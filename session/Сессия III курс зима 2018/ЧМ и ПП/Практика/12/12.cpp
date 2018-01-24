#include "stdafx.h"
#include <iostream>;
using namespace std;

double *X, *Y;
int n = 0;
double LP(double* X, double* Y, double t);
int main()
{
    setlocale(LC_ALL, "RUS");
    cout << "Вычисление интерполяционного многочлена лагранжа\nВвод данных\nВведите количество узлов => ";
    cin >> n;
    X = new double[n];
    Y = new double[n];

    cout << "Значение X\n";
    for (int i = 0; i < n; i++) {
        cout << "Введите X[" << i << "]:";
        cin >> X[i];
    }
    cout << "Значение Y\n";
    for (int i = 0; i < n; i++) {
        cout << "Введите Y[" << i << "]:";
        cin >> Y[i];
    }

    cout << "Введите точку для поиска => ";
    double t = 0;
    cin >> t;
    cout << "\n   Результат\n";
    cout << "Ln(" << t << ") = " << LP(X, Y, t) << " " << endl;
    system("pause");
}

double LP(double* X, double* Y, double t)
{
    int size = n;
    double sum = 0;
    for (int i = 0; i < size; i++) {
        double mul = 1;
        for (int j = 0; j < size; j++) {
            if (i != j)
                mul *= (t - X[j]) / (X[i] - X[j]);
        }
        sum += Y[i] * mul;
    }
    return sum;
}