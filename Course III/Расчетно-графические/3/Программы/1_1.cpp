#include "stdafx.h"
#include <iostream>;
using namespace std;

double *X, *Y;
int n = 0;

double decider(double *X, double * Y, double t) {
	double result, n1, n2;
	result = 0;
	for (int j = 0; j<n; j++) {
		n1 = 1; n2 = 1;
		for (int i = 0; i<n; i++) {
			if (i == j) {
				n1 = n1 * 1; n2 = n2 * 1;
			}
			else {
				n1 = n1 * (t - X[i]);
				n2 = n2 * (X[j] - X[i]);
			}
		}
		result = result + Y[j] * n1 / n2;
	}
	return result;
}

int main() {
	setlocale(LC_ALL, "RUS");
	cout << "---Вычисление интерполяционного многочлена лагранжа---\n\n";
	cout << "*Ввод данных*\n";
	cout << "Введите количество узлов => "; cin >> n;
	X = new double[n];
	Y = new double[n];

	cout << "Значение X\n";
	for (int i = 0; i<n; i++) {
		cout << "Введите X[" << i << "]: ";
		cin >> X[i];
	}

	cout << "Значение Y\n";
	for (int i = 0; i < n; i++) {
		cout << "Введите Y[" << i << "]: ";
		cin >> Y[i];
	}

	cout << "Введите точку для поиска => ";
	double t = 0;
	cin >> t;

	cout << "\n*Результат*\n";
	cout << "Ln (" << t << ") = " << decider(X, Y, t) << "\n";
	system("pause");
}
