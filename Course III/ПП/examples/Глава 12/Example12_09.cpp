#include <iostream>
#include <cstdlib>
using namespace std;
//Обобщенный класс:
template <class X, class Y, int n>
class MyClass {
public:
    //Поля класса – массивы:
    X xarray[n];
    Y yarray[n];
    //Конструктор класса:
    MyClass()
    {
        //Инициализация генератора случайных чисел:
        srand(1);
        //Заполнение массивов случайными значениями:
        for (int i = 0; i < n; i++) {
            xarray[i] = (X)(100 + rand() % 10);
            yarray[i] = (Y)(100 + rand() % 10);
        }
    }
    //Методы для отображения массивов:
    void getx()
    {
        for (int i = 0; i < n; i++)
            cout << xarray[i] << " ";
        cout << endl;
    }
    void gety()
    {
        for (int i = 0; i < n; i++)
            cout << yarray[i] << " ";
        cout << endl;
    }
};
int main()
{
    //Размеры массивов-полей класса:
    const int n = 3, m = 5;
    //Создание объектов:
    MyClass<int, char, n> a;
    MyClass<char, double, m> b;
    //Проверка значений полей объектов:
    a.getx();
    a.gety();
    b.getx();
    b.gety();
    return 0;
}