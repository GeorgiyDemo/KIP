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
    //Третий массив (результат):
    double c[3];
    //Ввод элементов первого массива:
    cout << "a = ";
    for (i = 0; i < 3; i++)
        cin >> a[i];
    //Ввод элементов второго массива:
    cout << "b = ";
    for (i = 0; i < 3; i++)
        cin >> b[i];
    //Вычисление результата:
    for (i = 0; i < 3; i++)
        c[i] = a[(i + 1) % 3] * b[(i + 2) % 3] - a[(i + 2) % 3] * b[(i + 1) % 3];
    //Отображение результата:
    cout << "[a.b] =";
    for (i = 0; i < 3; i++)
        cout << " " << c[i];
    cout << endl;
    return 0;
}