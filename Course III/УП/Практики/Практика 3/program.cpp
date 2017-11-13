/*
Вариант 4
1. Создать перегруженный класс vt, который вычисляет 
   сумму и частное из двух полей типа int или double.

2. 
Функция f1 должна взять инкремент x^2 и y/2 и сложить их значения
*/

#include <iostream>
using namespace std;
class vt {

public:
    int a, x, y;
    double b;

    vt(int f = 0, double g = 0, int h = 0, int j = 0) //это конструктор без аргументов:
    {
        a = f;
        b = g;
        x = h;
        y = j;

        cout << "\n\n\nЗадание №1\na = " << a << "\n";
        cout << "b = " << b << "\n";
        cout << "\na+b = " << (a + b) << "\n";
        cout << "a/b = " << (a / b) << "\n";
    }
    
    vt operator+()
    {
        b = a + b;
        return *this;
    }

    friend vt f1(vt ob1)
    {
        ob1.x = (ob1.x * ob1.x);
        cout << "\n\n\nЗадание 2\nx^2 = " << ob1.x << "\n";
        ob1.x++;
        cout << "x^2++ = " << ob1.x << "\n";

        cout << "y = " << ob1.y << "\n";
        ob1.y = (ob1.y / 2);
        cout << "y/2 = " << ob1.y << "\n-----------\nx = " << ob1.x << "\ny = " << ob1.y << "\n";
        cout << "x+y = " << (ob1.x + ob1.y) << "\n";
        return 0;
    }
};

int main()
{
    vt f(7, 4.43, 5, 4);
    f1(f);
    return 0;
}
