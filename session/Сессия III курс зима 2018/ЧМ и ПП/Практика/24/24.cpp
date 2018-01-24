/*
Создать абстрактный базовый класс объектов на декартовой плоскости CShape (фигура).
Спроектировать и реализовать иерархию классов конкретных фигур: CPoint, CCircle.
При этом у всех объектов должен быть реализован метод с именем "ToString",
который возвращает информацию информацию в текстовом виде о данном экземпляре
(не менее трех характеристик; у точки есть имя и координаты, у окружности еще есть
радиус и площадь)
*/

#include "stdafx.h"
#include <cmath>
#include <iostream>
using namespace std;

const double pi = 3.14159;

class CShape {
public:
    double x, y;
    virtual void ToString() = 0;
};

class CPoint : public CShape {
public:
    CPoint(double xp = 0, double yp = 0)
    {
        x = xp;
        y = yp;
    }
    void ToString()
    {
        cout << "фигура: точка\nx= " << x << "\ny=" << y << endl;
    }
} a(5, 6);

class CCircle : public CShape {
public:
    double rad, sq;
    CCircle(double xp = 0, double yp = 0, double r = 0)
    {
        x = xp;
        y = yp;
        rad = r;
        sq = pow(r, 2) * pi;
    }
    void ToString()
    {
        cout << "фигура: круг\nx= " << x << "\ny=" << y << "\nрадиус= " << rad << "\nплощадь= " << sq << endl;
    }
} b(10, 10, 4);

int main()
{
    setlocale(LC_ALL, "RUS");
    a.ToString();
    b.ToString();
    system("pause");
    return 0;
}