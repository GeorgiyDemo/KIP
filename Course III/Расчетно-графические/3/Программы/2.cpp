#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;

const int N = 4;
double SimpsonFunction(double x);
double MainSimpson(double a, double b, int n);

int main()
{
    setlocale(LC_ALL, "RUS");
    double y;
    double raz1, y1;
    cout << "*Задание №2*\nМетод Симсона:\n";
    y = MainSimpson(1.2, 2.1, 220);
    cout << y << "\n";
    y1 = MainSimpson(1.2, 2.1, 219);
    raz1 = abs(y - y1);
    cout << "Точность:\n" << raz1 << "\n";
    system("pause");
    return 0;
}

double SimpsonFunction(double x)
{
    return (1 / (sqrt(x * x + N)));
}

double MainSimpson(double a, double b, int n)
{
    double h, s, x, f;
    int i = 1;
    h = (b - a) / n;
    x = a;
    f = SimpsonFunction(x);
    s = f;
    while (i <= n) {
        x = x + h;
        f = SimpsonFunction(x);
        s = s + 4 * f;
        i = i + 2;
        x = x + h;
        f = SimpsonFunction(x);
        s = s + 2 * f;
    }
    x = b;
    f = SimpsonFunction(x);
    s = (s + f) * (h / 3);
    return s;
}
