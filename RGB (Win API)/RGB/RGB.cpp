// RGB.cpp: определяет точку входа для приложения.
//

#include "stdafx.h"
#include "RGB.h"
#include <time.h>
#include <shellapi.h>
#include <process.h>
// Заголовки библиотеки WinSock2.
#include <WinSock2.h>
#include <WS2tcpip.h>
// Заголовки GDI+.
#include <ObjIdl.h>
#include <Gdiplus.h>
#include <gdipluspen.h>
#include <Gdipluscolor.h>
#include <math.h>
#include <vector>

#include "../Common/DrawCentered.h"
#include "../Common/CalculatedData.h"

#define WM_ERROR       WM_USER
#define WM_CONNECTED   WM_USER + 1
#define WM_FINISHED    WM_USER + 2

// WinSock2 и GDI+.
#pragma comment(lib, "Ws2_32.lib")
#pragma comment(lib, "Gdiplus.lib")

static RECT rcBmp;       // rectangle that encloses bitmap  
static RECT rcTarget;    // rectangle to receive bitmap  
static RECT rcClient;    // client-area rectangle  

struct Color {
	int r;
	int b;
	int g;
};
vector<Color> colorus;

#define MAX_LOADSTRING 100
int preventCounts = 0, preventF1Counts = 0, preventF2Counts = 0;

int recv_all(SOCKET s, char* buf, int len);

// Глобальные переменные:
HINSTANCE hInst;								// текущий экземпляр
TCHAR szTitle[MAX_LOADSTRING];					// текст строки заголовка
TCHAR szWindowClass[MAX_LOADSTRING];			// имя класса главного окна

NOTIFYICONDATA		icon;

void InitRegistry();
bool SaveCountInRegistry();

HHOOK hhookMsg;

HFONT font = (HFONT)GetStockObject(DEFAULT_GUI_FONT);

// отправить объявление функций, включенных в этот модуль кода:
ATOM				MyRegisterClass(HINSTANCE hInstance);
BOOL				InitInstance(HINSTANCE, int);
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK	About(HWND, UINT, WPARAM, LPARAM);

//LRESULT             (_stdcall *pKeybHook)(int, WPARAM, LPARAM);
LRESULT(*pKeybHook)(int, WPARAM, LPARAM);
void(*TestFuncFromDll)();

void				SetTrayIcon(HWND hWnd);
void				DestroyTrayIcon();

const TCHAR* title = _T("Лабораторная работа 23");
ULONG_PTR gdi_token;
HHOOK hook;
HANDLE network_thread = 0;
char server_ip[80];
CCalculatedData *plot1 = NULL, *plot2 = NULL, *current_plot = NULL;
HWND window = 0, info_window = 0;

struct _RECT { LONG left = 200; LONG top = 49; LONG right = 1; LONG bottom = 100; };//x1 = 50, y1 = 50, x2 = 550, y2 = 50

int APIENTRY _tWinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPTSTR    lpCmdLine,
	int       nCmdShow)
{
	UNREFERENCED_PARAMETER(hPrevInstance);
	UNREFERENCED_PARAMETER(lpCmdLine);

	// TODO: разместите код здесь.
	MSG msg;
	HACCEL hAccelTable;


	// Инициализируем GDI+.
	Gdiplus::GdiplusStartupInput gdi_input;
	if (GdiplusStartup(&gdi_token, &gdi_input, NULL) != Gdiplus::Ok)
	{
		MessageBox(NULL,
			_T("Ошибка инициализации GDI+."),
			title,
			MB_ICONERROR | MB_OK);
		return 1;
	}

	HMODULE dll = LoadLibrary(_T("dllmain.dll"));
	if (dll)
	{

		TestFuncFromDll = (void(*) (void))GetProcAddress(dll, "Test");

		pKeybHook = (LRESULT(*)(int, WPARAM, LPARAM)) GetProcAddress(dll, "_KeyboardHook@12");

		hhookMsg = SetWindowsHookEx(WH_KEYBOARD, (HOOKPROC)(pKeybHook), dll, 0);

		//system("PAUSE");
		TestFuncFromDll();
	}

	// инициализация глобальных строк
	LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadString(hInstance, IDC_RGB, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

	// выполнить инициализацию приложений:
	if (!InitInstance(hInstance, nCmdShow))
	{
		return FALSE;
	}

	hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_RGB));

	// цикл основного сообщения:
	while (GetMessage(&msg, NULL, 0, 0))
	{
		if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}

	DestroyTrayIcon();
	UnhookWindowsHookEx(hhookMsg);		// принимаем ловушку
	FreeLibrary(dll);						// отключаем DLL
	return (int)msg.wParam;
}

//
//    Эта функция и ее использование необходимы только в случае, если нужно, чтобы данный код
//    был совместим с системами Win32, не имеющими функции RegisterClassEx'
//    которая была добавлена в Windows 95. Вызов этой функции важен для того,
//    чтобы приложение получило "качественные" мелкие значки и установило связь
//    с ними.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
	WNDCLASSEX wcex;

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = WndProc;
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.hInstance = hInstance;
	wcex.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_RGB));
	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.lpszMenuName = MAKEINTRESOURCE(IDC_RGB);
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

	return RegisterClassEx(&wcex);
}

BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
	HWND hWnd;

	hInst = hInstance; // сохранить дескриптор экземпляра в глобальной переменной

	hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
		200, 50, 400, 550, NULL, NULL, hInstance, NULL);//х1 - отступ слева, y1 - отступ сверху, x2 - ширина окна, у2 - высота окна


	if (!hWnd)
	{
		return FALSE;
	}

	SetTrayIcon(hWnd);

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	return TRUE;
}

//  WM_COMMAND	- обработка меню приложения
//  WM_PAINT	-раскрасить главное окно
//  WM_DESTROY	 - ввести сообщение о выходе и вернуться.
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent;
	PAINTSTRUCT ps;
	HDC hdc;

	switch (message)
	{
	case WM_COMMAND:
		wmId = LOWORD(wParam);
		wmEvent = HIWORD(wParam);

		switch (wmId)
		{
		case IDM_ABOUT:
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
			break;
		case IDM_EXIT:
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
		break;
		case WM_PAINT:
		{
					
						 Color current;
						 current.r = rand() % 255;
						 current.b = rand() % 255;
						 current.g = rand() % 255;
						 
					 time(NULL);
					 WCHAR text[100];
					 int avg = ((current.r + current.g + current.b) / 3);
					 int string_length = swprintf(text, 100,
						 L"R - %d\n, G - %d\n, B - %d, \n",
						 current.r, current.g, current.b);
					 colorus.push_back(current);


					HDC hdc = BeginPaint(hWnd, &ps);
					Gdiplus::Graphics graphics(hdc);

					Gdiplus::Pen myPen(Gdiplus::Color(current.r, current.g, current.b), 5);//5 - толщина в пикселях

					graphics.DrawLine(&myPen, 50, 70, 150, 70);//x1, y1, x2, y2
						 
					Gdiplus::Font f(hdc, font);
					Gdiplus::SolidBrush br(Gdiplus::Color::Black);
					graphics.DrawString(text, string_length, &f, Gdiplus::PointF(20, 20), &br);

					Sleep(120);

					InvalidateRect(hWnd, NULL, TRUE);//для перерисовки области
					UpdateWindow(hWnd);//обновление окна

					EndPaint(hWnd, &ps);
					break;
		}

	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
	}
	return 0;
}

// обработчик сообщений для окна "к программе".
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		HWND hWnd;
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		
		break;
	}
	return (INT_PTR)FALSE;
}

void SetTrayIcon(HWND hWnd) // установить значок в трей
{
	char* tip = " + ";
	icon.cbSize = sizeof(NOTIFYICONDATA);
	icon.hWnd = hWnd;
	icon.uID = IDC_MYICON;
	icon.uFlags = NIF_MESSAGE | NIF_ICON | NIF_TIP;
	icon.uCallbackMessage = WM_APP + 1;
	icon.hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_SMALL));
	memset(icon.szTip, 0, sizeof (icon.szTip));
	memcpy(icon.szTip, tip, strlen(tip));
	Shell_NotifyIcon(NIM_ADD, &icon);
}

void DestroyTrayIcon() // убрать значок из трей
{
	Shell_NotifyIcon(NIM_DELETE, &icon);
	DestroyIcon(icon.hIcon);
}
void SendError()
{
	SendMessage(window, WM_ERROR, 0, 0);
}

/*int ReceivingFailure(SOCKET socket_to_close)
{
	int res = WSAGetLastError();
	MessageBox(NULL, _T("Ошибка приёма данных."), title, MB_ICONERROR | MB_OK);
	shutdown(socket_to_close, SD_BOTH);
	closesocket(socket_to_close);
	WSACleanup();
	SendError();
	return res;
}

DWORD WINAPI NetworkThread(LPVOID)
{
	// Инициализируем WinSock.
	WSADATA wsaData;
	int result = WSAStartup(MAKEWORD(2, 2), &wsaData);
	if (result != 0)
	{
		MessageBox(NULL, _T("Ошибка инициализации WinSock."), title, MB_ICONERROR | MB_OK);
		SendError();
		return 1;
	}

	// Откроем клиентский сокет.
	struct addrinfo *res = NULL, *ptr = NULL, hints;
	// Заполним структуру hints, содержащую параметры клиентского сокета.
	ZeroMemory(&hints, sizeof(hints));
	// Адресная семья (для клиентского сокета можно не указывать).
	hints.ai_family = AF_INET;
	// Тип сокета.
	hints.ai_socktype = SOCK_STREAM;
	// Протокол сокета (IPPROTO_TCP для TCP, IPPROTO_UDP для UDP, IPPROTO_PGM для PGM).
	hints.ai_protocol = IPPROTO_TCP;

	// Преобразуем строковое название порта в структуру res.
	// Обратите внимание, что вне зависимости от настроек компиляции номер порта (9999)
	// и адрес сервера передаются однобайтовой строкой.
	result = getaddrinfo(server_ip, "9999", &hints, &res);
	if (result != 0)
	{
		MessageBox(NULL, _T("Ошибка преобразования порта."), title, MB_ICONERROR | MB_OK);
		WSACleanup();
		SendError();
		return 1;
	}
	// Создаём сокет.
	SOCKET client_socket = socket(res->ai_family, res->ai_socktype, res->ai_protocol);
	if (client_socket == INVALID_SOCKET)
	{
		MessageBox(NULL, _T("Ошибка создания сокета."), title, MB_ICONERROR | MB_OK);
		freeaddrinfo(res);
		WSACleanup();
		SendError();
		return 1;
	}

	// После создания клиентский сокет необходимо подключить (connect) к серверу.
	result = connect(client_socket, res->ai_addr, (int)res->ai_addrlen);
	if (result == SOCKET_ERROR || client_socket == INVALID_SOCKET)
	{
		MessageBox(NULL, _T("Невозможно подключиться к серверу."), title, MB_ICONERROR | MB_OK);
		freeaddrinfo(res);
		WSACleanup();
		SendError();
		return 1;
	}

	// После вызова connect() переменная res нам больше не нужна.
	freeaddrinfo(res);
	res = NULL;

	// Уведомляем окно о том, что подключение к серверу завершено.
	SendMessage(window, WM_CONNECTED, 0, 0);

	// Теперь мы можем передавать и принимать данные, используя клиентский сокет.

	// Информация от сервера будет приниматься клиентом в таком виде:
	// - количество байт в первом сериализованном CCalculatedData (unsigned int);
	// - первый сериализованный объект CCalculatedData;
	// - количество байт во втором сериализованном CCalculatedData (unsigned int);
	// - второй сериализованный объект CCalculatedData.
	// Для чтения информации из сокета используется функция recv(), которая при успешном
	// чтении возвращает, сколько байт записалось в буфер с прочитанными данными, а в случае
	// ошибки возвращает SOCKET_ERROR.
	// По умолчанию, recv() может прочитать не весь буфер, а только ту часть, которая уже
	// пришла клиенту, не дожидаясь заполнения оставшейся части буфера. Вообще, для
	// предотвращения такого поведения у recv() есть флаг MSG_WAITALL, но он не работает
	// с TCP-сокетами. Поэтому в этом коде есть обёртка для recv() - recv_all(), которая
	// осуществляет последовательные вызовы recv(), пока буфер не будет заполнен.
	unsigned int size1, size2;
	char *data1, *data2;
	if (recv_all(client_socket, (char*)&size1, sizeof(int)) != 0)
	{
		return ReceivingFailure(client_socket);
	}
	data1 = new char[size1];
	if (recv_all(client_socket, data1, size1) != 0)
	{
		return ReceivingFailure(client_socket);
	}

	if (recv_all(client_socket, (char*)&size2, sizeof(int)) != 0)
	{
		return ReceivingFailure(client_socket);
	}
	data2 = new char[size2];
	if (recv_all(client_socket, data2, size2) != 0)
	{
		return ReceivingFailure(client_socket);
	}

	delete data1;
	delete data2;

	// Отключаемся.
	result = shutdown(client_socket, SD_RECEIVE);
	if (result == SOCKET_ERROR)
	{
		MessageBox(NULL, _T("Ошибка выключения клиентского сокета."), title, MB_ICONERROR | MB_OK);
		closesocket(client_socket);
		WSACleanup();
		SendError();
		return 1;
	}
	result = closesocket(client_socket);
	if (result == SOCKET_ERROR)
	{
		MessageBox(NULL, _T("Ошибка закрытия клиентского сокета."), title, MB_ICONERROR | MB_OK);
		WSACleanup();
		SendError();
		return 1;
	}

	WSACleanup();

	SendMessage(window, WM_FINISHED, 0, 0);

	return 0;
}

int recv_all(SOCKET s, char* buf, int len)
{
	do
	{
		int read = recv(s, buf, len, 0);
		if (read == SOCKET_ERROR || read == 0)
			return SOCKET_ERROR;
		len -= read;
		buf += read;
	} while (len > 0);
	return 0;
}*/

void InitRegistry()
{
	HKEY key;
	DWORD dword_type = RRF_RT_REG_DWORD;
	DWORD binary_type = RRF_RT_REG_BINARY;
	DWORD dword_size = sizeof(DWORD);
	DWORD greal_size = sizeof(Gdiplus::REAL);
	LONG result = RegOpenKeyEx(HKEY_CURRENT_USER, _T("Software\\KNURE_LABS\\Lab23"), 0, KEY_ALL_ACCESS, &key);
	if (result == ERROR_SUCCESS)
	{
		DWORD ravg;
		result = RegQueryValueEx(key, _T("ravg"), NULL, &dword_type, (LPBYTE)&ravg, &dword_size);
		if (result == ERROR_FILE_NOT_FOUND)
		{
			SaveCountInRegistry();
		}
		else if (result == ERROR_SUCCESS)
		{
			if (ravg <= 10000)
			{
				preventCounts = ravg;
			}
		}
		else
		{
			MessageBox(NULL, _T("Ошибка при работе с реестром."), title, MB_ICONERROR | MB_OK);
			return;
		}

		DWORD gavg;
		result = RegQueryValueEx(key, _T("gavg"), NULL, &dword_type, (LPBYTE)&gavg, &dword_size);
		if (result == ERROR_FILE_NOT_FOUND)
		{
			SaveCountInRegistry();
		}
		else if (result == ERROR_SUCCESS)
		{
			if (gavg <= 10000)
			{
				preventF1Counts = gavg;
			}
		}
		else
		{
			MessageBox(NULL, _T("Ошибка при работе с реестром."), title, MB_ICONERROR | MB_OK);
			return;
		}

		DWORD bavg;
		result = RegQueryValueEx(key, _T("bavg"), NULL, &dword_type, (LPBYTE)&bavg, &dword_size);
		if (result == ERROR_FILE_NOT_FOUND)
		{
			SaveCountInRegistry();
		}
		else if (result == ERROR_SUCCESS)
		{
			if (bavg <= 10000)
			{
				preventF2Counts = bavg;
			}
		}
		else
		{
			MessageBox(NULL, _T("Ошибка при работе с реестром."), title, MB_ICONERROR | MB_OK);
			return;
		}
	}
	else if (result == ERROR_FILE_NOT_FOUND)
	{
		// Ключ не существует. Создадим и заполним его.
		MessageBox(NULL, _T("Параметры в реестре не найдены, они будут установлены."), title, MB_ICONWARNING | MB_OK);

		result = RegCreateKeyEx(HKEY_CURRENT_USER, _T("Software\\KNURE_LABS\\Lab23"), 0, NULL, REG_OPTION_NON_VOLATILE, KEY_ALL_ACCESS, NULL, &key, NULL);
		if (result != ERROR_SUCCESS)
		{
			// Неудача при работе с реестром не будет препятствием для работы приложения, так как все значения инициализируются по умолчанию в самом начале его работы.
			MessageBox(NULL, _T("Ошибка при создании ключа реестра."), title, MB_ICONERROR | MB_OK);
			return;
		}

		if (!SaveCountInRegistry()) return;
	}
	else {
		MessageBox(NULL, _T("Ошибка при обращении к ключу реестра."), title, MB_ICONERROR | MB_OK);
	}
}

bool SaveCountInRegistry()
{
	int size = colorus.size();
	int sumr = 0, sumg = 0, sumb = 0;
	for (int i = 0; i < size; ++i)
	{
		sumr += colorus[i].r;
		sumg += colorus[i].g;
		sumb += colorus[i].b;
	}
	DWORD ravg = (int)sumr/size;
	DWORD gavg = (int)sumg / size;
	DWORD bavg = (int)sumb / size;
	HKEY key;
	if (RegOpenKeyEx(HKEY_CURRENT_USER, _T("Software\\KNURE_LABS\\Lab23"), 0, KEY_ALL_ACCESS, &key) != ERROR_SUCCESS)
	{
		MessageBox(NULL, _T("Ошибка при открытии ключа."), title, MB_ICONERROR | MB_OK);
		RegCloseKey(key);
		return false;
	}
	else
	{
		MessageBox(NULL, _T("all is ok"), title, MB_OK);
	}
	if (RegSetValueEx(key, _T("r"), 0, RRF_RT_REG_DWORD, (BYTE*)&ravg, sizeof(DWORD)) != ERROR_SUCCESS)
	{
		MessageBox(NULL, _T("Ошибка при записи значения ravg."), title, MB_ICONERROR | MB_OK);
		RegCloseKey(key);
		return false;
	}
	if (RegSetValueEx(key, _T("g"), 0, RRF_RT_REG_DWORD, (BYTE*)&gavg, sizeof(DWORD)) != ERROR_SUCCESS)
	{
		MessageBox(NULL, _T("Ошибка при записи значения gavg."), title, MB_ICONERROR | MB_OK);
		RegCloseKey(key);
		return false;
	}
	if (RegSetValueEx(key, _T("b"), 0, RRF_RT_REG_DWORD, (BYTE*)&bavg, sizeof(DWORD)) != ERROR_SUCCESS)
	{
		MessageBox(NULL, _T("Ошибка при записи значения bavg."), title, MB_ICONERROR | MB_OK);
		RegCloseKey(key);
		return false;
	}
	RegCloseKey(key);
	return true;
}
