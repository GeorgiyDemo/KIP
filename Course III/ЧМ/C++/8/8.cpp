#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <locale.h>
#include <iostream>
using namespace std;

double F(double x) { return (log(x)*log(x))*sqrt(x+1); }
double RightRectangleMethod(double a, int n, double h)
{
    double s = 0;
    for (int i = 1; i <= n; i++)
        s += F(a + i * h) * h;
    cout << "Погрешность метода правых прямоугольников = " << h / 2 * (F(a + h * n) - F(a));
    return s - h / 2 * (F(a + h * n) - F(a));
}

int main()
{
    setlocale(LC_ALL, "RUS");

    int n;
    double a, b, h;
    cout << "Численное интегрирование\n\nИнтервал от ";
    cin >> a;
    system("cls");
    cout << "Численное интегрирование\n\nИнтервал от " << a << " до ";
    cin >> b;
    cout << "Шагов ";
    cin >> n;

    h = (b - a) / n;

    cout << "\nМетод правых прямоугольников: " << RightRectangleMethod(a, n, h)<<endl;

    system("pause");
    return 0;
