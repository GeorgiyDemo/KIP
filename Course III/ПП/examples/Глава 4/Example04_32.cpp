#include <iostream>
#include <cstdlib>
#include <cmath>
using namespace std;
//Среднее по всему массиву:
double avr(double* x, int n)
{
    int i;
    double s = 0;
    for (i = 0; i < n; i++)
        s += x[i];
    s /= n;
    return s;
}
//Среднее по части массива:
double avr(double* x, int n1, int n2)
{
    int i, n = n2 - n1 + 1;
    double s = 0;
    for (i = n1 - 1; i < n2; i++)
        s += x[i];
    s /= n;
    return s;
}
//Дисперсия по массиву:
double dev(double* x, int n)
{
    double x0, s = 0;
    int i;
    x0 = avr(x, n);
    for (i = 0; i < n; i++)
        s += x[i] * x[i];
    s /= n;
    return s - x0 * x0;
}
//Дисперсия по части массива:
double dev(double* x, int n1, int n2)
{
    double x0, s = 0;
    int i, n = n2 - n1 + 1;
    x0 = avr(x, n1, n2);
    for (i = n1 - 1; i < n2; i++)
        s += x[i] * x[i];
    s /= n;
    return s - x0 * x0;
}
//Отображение статистики для массива:
void ShowStat(double* x, int n)
{
    //Среднее:
    cout << "Average is " << avr(x, n) << endl;
    //Дисперсия:
    cout << "Dispersion is " << dev(x, n) << endl;
    //Стандартное отклонение:
    cout << "Deviation is " << sqrt(dev(x, n)) << endl;
}
//Отображение статистики для части массива:
void ShowStat(double* x, int n1, int n2)
{
    //Среднее:
    cout << "Average is " << avr(x, n1, n2) << endl;
    //Дисперсия:
    cout << "Dispersion is " << dev(x, n1, n2) << endl;
    //Стандартное отклонение:
    cout << "Deviation is " << sqrt(dev(x, n1, n2)) << endl;
}
//Функция для заполнения массива:
void fill(double* x, int n)
{
    for (int i = 0; i < n; i++)
        x[i] = rand() % 10;
}
//Функция для отображения значений массива:
void show(double* x, int n)
{
    for (int i = 0; i < n; i++)
        cout << x[i] << "  ";
    cout << endl;
}
int main()
{
    //Размер массива:
    const int N = 10;
    //Массив значений:
    double z[N];
    //Заполнение массива:
    fill(z, N);
    cout << "Base data:\n";
    //Отображение данных массива:
    show(z, N);
    cout << "Base statistics:\n";
    //Статистика по массиву:
    ShowStat(z, N);
    cout << "Small statistics:\n";
    //Статистика по части массива:
    ShowStat(z, 3, N - 2);
    return 0;
}