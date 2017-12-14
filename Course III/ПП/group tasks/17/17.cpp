#include "stdafx.h"
#include <iostream>
using namespace std;
double h;
class Tochka {
private:
    double x, y;
public:
    void get() {
        this->x = x;
        this->y = y;
    }

    int point(int x, int y) {
        cout << "x = " << x << endl;
        cout << "y = " << y << endl;
        h = sqrt(x*x + y*y);
        return h;
    }

    double point(double x, double y) {
        cout << "x = " << x << endl;
        cout << "y = " << y << endl;
        h = sqrt(x*x + y*y);
        return h;
    }
};

int main()
{   setlocale(LC_ALL, "rus");
    Tochka obj1;
    obj1.point(2,3);
    if (h > 5) { cout << "Точка не принадлежит кругу с радиусом 5"; }
    else { cout << "Точка принадлежит кругу с радиусом 5"; }
    cout << "\nТочка = " << h << endl<<endl;
    Tochka obj2;
    obj2.point(3.2,3.1);
    if (h > 5) { cout << "Точка не принадлежит кругу с радиусом 5"; }
    else { cout << "Точка принадлежит кругу с радиусом 5"; }
    cout << "\nТочка = " << h << endl<<endl;
    Tochka obj3;
    obj3.point(4,5);
    if (h > 5) { cout << "Точка не принадлежит кругу с радиусом 5"; }
    else { cout << "Точка принадлежит кругу с радиусом 5"; }
    cout << "\nТочка = " << h << endl<<endl;
    Tochka obj4;
    obj4.point(4.4,3.2);
    if (h > 5) { cout << "Точка не принадлежит кругу с радиусом 5"; }
    else { cout << "Точка принадлежит кругу с радиусом 5"; }
    cout << "\nТочка = " << h << endl<<endl;
    system("pause");
    return 0;
}
