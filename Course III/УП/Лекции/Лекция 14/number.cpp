#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main(void)
{

	setlocale(LC_ALL, "RUS");
	long fl;
	fl = cout.flags();
	cout << "Исходное состояние флагов: " << fl << "\n";

	cout.setf(ios::showpos);
	cout.setf(ios::scientific);
	cout << 123 << " " << 1.2345678 << "\n";

	cout.setf(ios::hex | ios::showbase);
	cout.unsetf(ios::showpos);
	cout.width(20);
	cout.precision(10);
	cout << 123 << " " << 123.456 << " " << 1.2345678 << "\n";
	cout << "Новое состояние флагов: " << cout.flags() << "\n";
	cout.flags(fl);
	cout << "После востановления исходного состояния флагов: \n";
	cout << 123 << " " << 123.456 << 1.2345678 << "\n";
	system("pause");
	return 0;
}
