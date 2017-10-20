#include <iostream>
using namespace std;
//Функция для полинома:
double F(double x)
{
    return x * x - 9 * x + 14;
}
//Функция поиска корня:
double FindRoot(double (*f)(double), double a, double b, double eps)
{
    double c;
    while ((b - a) / 2 > eps) {
        c = (a + b) / 2;
        if ((f(a) * f(c)) > 0)
            a = c;
        else
            b = c;
    }
    return c;
}
int main()
{
    //Интервал, погрешность и корень:
    double a, b, eps, x;
    cout << "interval: ";
    cin >> a;
    cin >> b;
    //Проверка корректности интервала:
    if (F(a) * F(b) > 0) {
        cout << "Wrong interval!\n";
        return 0;
    }
    cout << "error: ";
    cin >> eps;
    //Поиск решения:
    x = FindRoot(F, a, b, eps);
    cout << "x = " << x << endl;
    return 0;
}