#include <iostream>
#include <cmath>
using namespace std;
//Верхний предел суммы по умолчанию:
const int N = 100;
//Функция с одним аргументом:
double sh(double z)
{
    int n;
    double s = z, q = z;
    for (n = 1; n <= N; n++) {
        q *= z * z / (2 * n) / (2 * n + 1);
        s += q;
    }
    return s;
}
//Функция с двумя аргументами:
double sh(double z, int m)
{
    int n;
    double s = z, q = z;
    for (n = 1; n <= m; n++) {
        q *= z * z / (2 * n) / (2 * n + 1);
        s += q;
    }
    return s;
}
int main()
{
    //Аргумент для функции:
    double x;
    //Индексная переменная и предел для суммы:
    int i, m = 9;
    //Ввод аргумента:
    cout << "Enter x = ";
    cin >> x;
    //Значения ряда для разного числа слагаемых:
    for (i = 1; i <= m; i++) {
        cout << i << "  : sh(" << x << ") = " << sh(x, i) << endl;
    }
    cout << "--------------------\n";
    //Верхняя граница индексной переменной ряда равна N:
    cout << N << ": sh(" << x << ") = " << sh(x) << endl;
    //Вызов встроенной функции:
    cout << "Test value: " << sinh(x) << endl;
    return 0;
}