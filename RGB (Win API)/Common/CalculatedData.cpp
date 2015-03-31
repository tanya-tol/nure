#include "CalculatedData.h"
#include <algorithm>
using std::copy;

CCalculatedData::CCalculatedData(double start, double finish)
{
	this->start = start;
	this->finish = finish;
}

CCalculatedData::CCalculatedData(const char* serialized)
{
	// Порядок следования значений в сериализованном объекте CCalculatedData:
	// - начало диапазона (double),
	// - конец диапазона (double),
	// - количество вычисленных значений (unsigned int),
	// - собственно вычисленные значения (каждое - double).
	this->start = *(double*)serialized;
	serialized += sizeof(double);
	this->finish = *(double*)serialized;
	serialized += sizeof(double);
	unsigned int value_count = *(unsigned int*)serialized;
	serialized += sizeof(int);
	this->values.reserve(value_count);
	for (; value_count > 0; --value_count, serialized += sizeof(double))
	{
		this->values.push_back(*(double*)serialized);
	}
}

vector<char> CCalculatedData::Serialize()
{
	// Формат сериализации указан в конструкторе.

	unsigned int values_count = this->values.size();

	// Вектор байтов сериализованного представления.
	vector<char> ret(sizeof(double) * (3 + values_count) + sizeof(int));
	
	// Байтовый указатель на начало переменной.
#define START(x) ((char*)&x)
	// Байтовый указатель на конец переменной.
#define END(x)   ((char*)&x + sizeof(x) / sizeof(char))

	// Последовательно копируем информацию в ret с помощью std::copy().
	copy(START(this->start), END(this->start), ret.begin());
	copy(START(this->finish), END(this->finish), ret.begin() + sizeof(double));
	copy(START(values_count), END(values_count), ret.begin() + sizeof(double) * 2);
	copy((char*)&(*this->values.begin()),
		 (char*)&(*this->values.begin()) + sizeof(double) * this->values.size(),
		 ret.begin() + sizeof(double) * 2 + sizeof(int));
	return ret;
}