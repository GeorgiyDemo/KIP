#include <iostream>
using namespace std;
const int N = 20;
//Функция для полинома:
double F(double x)
{
    return x * x - 9 * x + 14;
}
//Функция поиска корня (метод Ньютона):
double FindRoot(double (*f)(double), double x0)
{
    double x = x0, df, h = 0.00001;
    df = (f(x + h) - f(x)) / h;
    for (int i = 1; i <= N; i++)
        x = x - f(x) / df;
    return x;
}
//Функция поиска корня (метод хорд):
double FindRoot(double (*f)(double), double a, double b)
{
    double c;
    for (int i = 1; i <= N; i++) {
        c = (f(b) * a - f(a) * b) / (f(b) - f(a));
        if ((f(a) * f(c)) > 0)
            a = c;
        else
            b = c;
    }
    return c;
}
int main()
{
    //Начальное приближение, интервал и корни уравнения:
    double x0, a, b, x1, x2;
    cout << "initial x0 = ";
    cin >> x0;
    cout << "interval: ";
    cin >> a;
    cin >> b;
    //Поиск решения:
    x1 = FindRoot(F, x0);
    x2 = FindRoot(F, a, b);
    cout << "Newton method: x = " << x1 << endl;
    cout << "Chord  method: x = " << x2 << endl;
    return 0;
}