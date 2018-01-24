#include <iostream>
#include <math.h>
#include <windows.h>
using namespace std;
double fDichotomy(double x)
{
	return (sqrt(x) - 2 / (x - 3) + 1);
}

int Dichotomy(double a, double b, double * c, double eps)
{
	int k = 0;
	do
	{
		*c = (a + b) / 2;
		if (fDichotomy(*c) * fDichotomy(a) <0) b = *c;
		else a = *c;
		k++;
	} while (fabs(a - b) >= eps);
	return k;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double A=-100, B=-90, X=0, P=0;
	double ep = 0.001; 
	int K;

	cout << "Решение уравнения sqrt(x) - 2/(x-3) + 1 =0. " << endl;
	cout << "Метод половинного деления:" << endl;
	cout << "На промежутке от -100 до -90" << endl;
	A = -100, B = -90;
	K = Dichotomy(A, B, &X, ep);
	cout << "Найденное решение x=" << X;
	cout << ", количество итераций k=" << K << endl << endl;
	system("pause");
}
