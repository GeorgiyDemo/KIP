#include <iostream>
#include <cmath>
using namespace std;
//Функция, для заполнения массива:
void set(double* a, int N, double x)
{
    int i;
    a[0] = 1;
    for (i = 1; i <= N; i++)
        a[i] = a[i - 1] * (-1) * x * x / (2 * i - 1) / (2 * i);
}
//Функция для отображения массива:
void show(double* a, int k)
{
    int i;
    for (i = 0; i <= k; i++)
        cout << a[i] << " ";
    cout << endl;
}
//Функция для вычисления косинуса:
double MyCos(double* a, int k)
{
    double s = 0;
    int i;
    for (i = 0; i <= k; i++)
        s += a[i];
    return s;
}
int main()
{
    int i, N;
    double x;
    double* a;
    //Ввод параметров:
    cout << "Enter x = ";
    cin >> x;
    cout << "Enter N = ";
    cin >> N;
    //Создание массива:
    a = new double[N + 1];
    //Заполнение массива:
    set(a, N, x);
    //Отображение массива:
    show(a, N);
    //Разные приближения для косинуса и погрешность (в %):
    for (i = 1; i <= 5; i++)
        cout << N * i / 5 << " : " << MyCos(a, N * i / 5) << " : " << (1 - MyCos(a, N * i / 5) / cos(x)) * 100 << "%\n";
    //Точное (вычисленное встроенной функцией) значение:
    cout << "cos(x) = " << cos(x) << endl;
    return 0;
}