#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;
const int n = 10;

double F(double x, double y) {
	return pow(cos(1.5*y + x), 2) + 1.4;
}

int main() {
	double a = 1; double b = 2; double h = 0.1;
	double X[n]; double Y[n];
	X[0] = a; Y[0] = 0.9;
	for (int i = 1; i <= n; i++) {
		X[i] = a + i*h;
		Y[i] = Y[i - 1] + h*F(X[i - 1], Y[i - 1]);
	}
	for (int i = 0; i <= n; i++) {
		cout << "X[" << i << "]=" << X[i] << " " << endl;
	}
	cout << endl;
	for (int i = 0; i <= n; i++) {
		cout << "Y[" << i << "]=" << Y[i] << " " << endl;
	}
	system("pause");
	return 0;
}
