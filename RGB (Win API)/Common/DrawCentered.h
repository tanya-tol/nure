#pragma once

#include <Windows.h>
#include <GdiPlus.h>

// Заливает контекст устройства hdc белым цветом, а затем рисует заданный текст
// посередине. hdc должен иметь ширину w и высоту h.
// Перед вызовом функции должен быть проинициализирован GDI+.
void DrawCentered(HDC hdc, HFONT font, int w, int h, const WCHAR* text);