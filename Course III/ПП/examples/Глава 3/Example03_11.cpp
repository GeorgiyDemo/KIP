#include <iostream>
using namespace std;
int main()
{
    //Индексная переменная:
    int i;
    //Первый массив:
    double a[3];
    //Второй массив:
    double b[3];
    //Переменная для записи результата:
    double res = 0;
    //Ввод элементов первого массива:
    cout << "a = ";
    for (i = 0; i < 3; i++)
        cin >> a[i];
    //Ввод элементов второго массива:
    cout << "b = ";
    for (i = 0; i < 3; i++)
        cin >> b[i];
    //Вычисление скалярного произведения:
    for (i = 0; i < 3; i++)
        res += a[i] * b[i];
    //Отображение результата:
    cout << "a.b = " << res << endl;
    return 0;
}