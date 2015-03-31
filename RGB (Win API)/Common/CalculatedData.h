#pragma once

#include <vector>
using std::vector;

// Класс CCalculatedData содержит значения функции в некотором диапазоне.
// Именно эти данные передаются по сети.
class CCalculatedData
{
private:
	// Значения функции в диапазоне.
	vector<double> values;
	// Начало диапазона вычислений (с какого X начинались вычисления значений функции).
	double start;
	// Конец диапазона (на каком X закончились вычисления значений функции).
	double finish;
public:
	// Создаёт новый объект и запоминает диапазон.
	CCalculatedData(double start, double finish);
	// Создаёт новый объект из его сериализованного представления.
	CCalculatedData(const char* serialized);
	// Возвращает вектор значений функции.
	vector<double>& GetValues() { return values; }
	// Возвращает начало диапазона вычислений.
	double GetStart() { return start; }
	// Возвращает конец диапазона вычислений.
	double GetFinish() { return finish; }
	// Сериализует объект.
	vector<char> Serialize();
};