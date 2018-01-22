#include <iostream>
#include<math.h>
using namespace std;
double func(double x)
{
	return (x*x*x + 0.4*x*x + 0.6*x - 1.6);
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
	if (func(a) > 0)
	{
		x[0] = b;
		cout << "\nx[0] = " << x[0] << endl;
		do
		{
			n++;
			x[n] = x[n - 1] - (func(x[n - 1]) / (func(x[n - 1]) - func(a)))*(x[n - 1] - a);
			cout << "x[" << n << "] = " << x[n] << endl;
		} while (abs(x[n] - x[n - 1]) > e);
	}
	else
	{
		x[0] = a;
		cout << "\nx[0] = " << x[0] << endl;
		do
		{
			n++;
			x[n] = x[n - 1] - (func(x[n - 1]) / (func(b) - func(x[n - 1])))*(b - x[n - 1]);
			cout << "x[" << n << "] = " << x[n] << endl;
		} while (abs(x[n] - x[n - 1]) > e);
	}
	cout << "\nОтвет: " << x[n] << endl;
}

void main()
{
	double a, b, e;
	setlocale(LC_ALL, "rus");
	cout << "Введите погрешность вычисления, е = ";
	cin >> e;
	for (int i = 0; i < 2; i++) {
		cout << "\nВведите интервал:\n";
		do
		{
			cout << "a = "; cin >> a;
			cout << "b = "; cin >> b;
			if (proverka(a, b) == 0) cout << "\nf(a)*f(b)>0\nВведите интервал еще раз:\n";
		} while (proverka(a, b) != 1);
		znachenie(a, b, e);
	}
	
	system("pause");
}
