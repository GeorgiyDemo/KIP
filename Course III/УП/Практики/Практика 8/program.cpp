/*
4. Перегрузите операцию << для класса Variant4,
который будет просить ввести строку, содержащую произвольные слова и 
цифры,
разделенные пробелами, а затем выведет её на экран, но без больших букв 
и цифр.
*/
#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

ostream& left10(ostream &stream)
{
	stream.setf(ios::right);
	stream << setw(10);
	return stream;
}
int main(void)
{
	setlocale(LC_ALL, "RUS");
	cout << "р    а    з" << left10 << "р   а   з     " << "р   а   
з" << "\n";
	return 0;
}


