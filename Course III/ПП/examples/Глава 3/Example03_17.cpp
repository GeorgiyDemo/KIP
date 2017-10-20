#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Порядок полинома:
    const int N = 3;
    //Индексные переменные и число итераций:
    int i, k, n = 10;
    //Аргумент, функция и производная:
    double x, f, df;
    //Массив коэффициентов полинома-функции:
    double a[N + 1];
    //Массив коэффициентов полинома-производной:
    double b[N];
    //Ввод коэффициентов функции-полинома:
    cout << "Function: ";
    cin >> a[0];
    for (i = 1; i < N + 1; i++) {
        cin >> a[i];
        //Вычисление коэффициентов для производной:
        b[i - 1] = i * a[i];
    }
    //Начальное приближение:
    cout << "Enter x0 = ";
    cin >> x;
    //Последовательные итерации:
    for (k = 1; k <= n; k++) {
        f = a[0];
        df = 0;
        for (i = 1; i < N + 1; i++) {
            f += a[i] * pow(x, i);
            df += b[i - 1] * pow(x, i - 1);
        }
        x -= f / df;
    }
    //Результат:
    cout << "x = " << x << endl;
    cout << "f(" << x << ") = " << f << endl;
    return 0;
}