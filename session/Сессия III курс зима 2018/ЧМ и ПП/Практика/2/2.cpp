#include "stdafx.h"
#include <iostream>
#include<cmath>

using namespace std;

double func(double x)
{
	return pow(x, 3) + (0.2 * pow(x, 2)) + 0.5 * x - 1.2;
}


double proizvodn1(double x)
{
	return 3 * pow(x, 2) + 0.4*x + 0.5;
}


double proizvodn2(double x)
{
	return 6 * x + 0.4;
}


bool proverka(double a, double b)
{
	bool k = 0;
	if (func(a)*func(b) > 0) k = 0;
	else k = 1;
	return k;
}


void znachenie(double a, double b, double e)
{
	double x[1000];
	int n = 0;
	if (func(a)*proizvodn2(a) < 0) x[0] = b;
	else x[0] = a;
	cout << "\nx[0] = " << x[0] << endl;
	do
	{
		n++;
		x[n] = x[n - 1] - func(x[n - 1]) / proizvodn1(x[n - 1]);
		cout << "x[" << n << "] = " << x[n] << endl;
	} while (abs(x[n] - x[n - 1]) > e);
	cout << "\nОТВЕТ: " << x[n] << endl;
}


void main()
{
	double a, b, e;
	setlocale(LC_ALL, "rus");
	cout << "Введите погрешность вычисления, е = ";
	cin >> e;
	cout << "\nВведите интервал:\n";
	do
	{
		cout << "a = "; cin >> a;
		cout << "b = "; cin >> b;
		if (proverka(a, b) == 0) cout << "\nf(a)*f(b)>0\nВведите интервал еще раз:\n";
	} while (proverka(a, b) != 1);
	znachenie(a, b, e);
	system("pause");
}