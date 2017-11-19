/*
4. Напишите программу, которая содержит метод formatter класса FormatClass с
 использованием флагов для вывода числа в восьмеричной системе счисления
 большими символами.
*/

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

class FormatClass {

	int main_int;

public:
	FormatClass(int input_int);
	void formatter();
};

FormatClass::FormatClass(int input_int = 10)
{
	main_int = input_int;
}
void FormatClass::formatter()
{
	cout << "Исходное число:      А это с форматированием\n" << main_int;
	cout.flags(ios::right | ios::hex | ios::showbase | ios::uppercase);
	cout.width(25);
	cout.precision(15);
	cout << main_int << "\n";
};

int main()
{
	int buf_int;
	setlocale(LC_ALL, "RUS");

	cout << "Введите исходное число => ";
	cin >> buf_int;
	FormatClass obj(buf_int);
	obj.formatter();

	system("pause");
	return 0;
}
