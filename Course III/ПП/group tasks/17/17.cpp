/*
Создать класс точка – point с закрытыми координатами x y и конструктор,
которые устанавливают значения координат, также методы,
которые выводят их на экран. Создавать различные объекты этих точек и определять,
лежат ли они внутри окружности с радиусом 5 в центре координат или нет.
Методы сделать перегруженными для координат, представленными целыми или
вещественными числами.
*/

#include "stdafx.h"
#include <cmath>
#include <iostream>

using namespace std;
double h;
class Tochka {
private:
    double x, y;

public:
    void get()
    {
        this->x = x;
        this->y = y;
    }

    int point(int x, int y)
    {
        cout << "x = " << x << endl;
        cout << "y = " << y << endl;
        h = sqrt(x * x + y * y);
        return h;
    }

    double point(double x, double y)
    {
        cout << "x = " << x << endl;
        cout << "y = " << y << endl;
        h = sqrt(x * x + y * y);
        return h;
    }
};

int main()
{
    setlocale(LC_ALL, "RUS");
    Tochka obj1;
    obj1.point(2, 3);
    if (h > 5) {
        cout << "Точка не принадлежит кругу с радиусом 5";
    }
    else {
        cout << "Точка принадлежит кругу с радиусом 5";
    }

    cout << "\nТочка = " << h << "\n\n";
    Tochka obj2;
    obj2.point(3.2, 3.1);
    if (h > 5) {
        cout << "Точка не принадлежит кругу с радиусом 5";
    }
    else {
        cout << "Точка принадлежит кругу с радиусом 5";
    }
    cout << "\nТочка = " << h << "\n\n";
    Tochka obj3;
    obj3.point(4, 5);
    if (h > 5) {
        cout << "Точка не принадлежит кругу с радиусом 5";
    }
    else {
        cout << "Точка принадлежит кругу с радиусом 5";
    }
    cout << "\nТочка = " << h << "\n\n";
    Tochka obj4;
    obj4.point(4.4, 3.2);
    if (h > 5) {
        cout << "Точка не принадлежит кругу с радиусом 5";
    }
    else {
        cout << "Точка принадлежит кругу с радиусом 5";
    }
    cout << "\nТочка = " << h << "\n\n";

    system("pause");
    return 0;
}
