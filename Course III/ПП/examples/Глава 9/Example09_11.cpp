#include <iostream>
using namespace std;
//Размер поля-массива:
const int n = 10;
//"Внутренний" класс:
class Inner {
public:
    int m;
    int number;
    //Метод для отображения полей:
    void show()
    {
        if (m != 1)
            (this - 1)->show();
        cout << number << " ";
    }
};
//"Внешний" класс:
class Outer {
public:
    //Поле-массив объектов:
    Inner obj[n];
    //Конструктор:
    Outer()
    {
        int i;
        obj[0].m = 1;
        obj[0].number = 1;
        obj[1].m = 2;
        obj[1].number = 1;
        for (i = 2; i < n; i++) {
            obj[i].m = i + 1;
            obj[i].number = obj[i - 1].number + obj[i - 2].number;
        }
    }
};
int main()
{
    Outer a;
    a.obj[n / 2].show();
    cout << endl;
    a.obj[n - 1].show();
    cout << endl;
    return 0;
}