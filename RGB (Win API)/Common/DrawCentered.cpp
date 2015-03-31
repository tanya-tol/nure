#include <Windows.h>
#include <tchar.h>
#include <GdiPlus.h>

#pragma comment(lib, "Gdiplus.lib")

// Заливает контекст устройства hdc белым цветом, а затем рисует заданный текст
// посередине. hdc должен иметь ширину w и высоту h.
// Перед вызовом функции должен быть проинициализирован GDI+.
void DrawCentered(HDC hdc, HFONT font, int w, int h, const WCHAR* text)
{
	// Текст будет выводиться с помощью GDI+.
	// Зальём фон нужным цветом с помощью GDI+.
	// Главный класс для рисования в GDI+ - это Graphics.
	// Этот класс позволяет выводить на контекст устройства линии, кривые, геометрические
	// фигуры, изображения и текст. Всё, что для этого нужно - связать объект класса
	// Graphics с нужным контекстом устройства, и при вызове методов Graphics результат
	// их выполнения будет выводиться на этот контекст.
	Gdiplus::Graphics g(hdc);

	// Кисти (brush) в GDI+ определяют цвет и заливку рисуемых объектов.
	// Эта кисть будет использоваться для закраски hdc сплошным белым цветом.
	Gdiplus::SolidBrush background_brush(Gdiplus::Color::White);
	g.FillRectangle(&background_brush, 0, 0, w, h);

	// А эта - для вывода текста сплошным чёрным цветом.
	Gdiplus::SolidBrush text_brush(Gdiplus::Color::Black);
	// Определим прямоугольник расположения текста (layout rectangle).
	// Он будет занимать весь предоставленный размер, сам же текст будет выводиться
	// посередине этого прямоугольника.
	Gdiplus::RectF rect(0, 0, w, h);
	// Шрифт для вывода текста.
	Gdiplus::Font f(hdc, font);
	// Объект класса StringFormat определяет, как именно будет выведен текст относительно
	// прямоугольника расположения.
	Gdiplus::StringFormat format;
	// В нашем случае, текст будет выводиться по центру - как по горизонтали, так и по
	// вертикали.
	format.SetAlignment(Gdiplus::StringAlignmentCenter);
	format.SetLineAlignment(Gdiplus::StringAlignmentCenter);
	// Если же строка окажется шире прямоугольника расположения, будем делать перенос
	// по словам.
	format.SetTrimming(Gdiplus::StringTrimmingWord);
	// Рисуем строку.
	g.DrawString(text, -1, &f, rect, &format, &text_brush);
}