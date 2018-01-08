/*
Создайте функцию add () которая   к аргументу прибавляет 1, где аргументы целый (int), вещественный (double), символьный  (char) тип.
a)  С помощью перегруженных функций(без классов);
b)  С помощью перегруженных конструкторов или методов класса.
*/

#include "stdafx.h"
#include <iostream>

using namespace std;
class Myclass {
public:
    Myclass(double x)
    {
        x++;
        cout << "x=" << x << "\n";
    }
    Myclass(int x)
    {
        x++;
        cout << "x=" << x << "\n";
    }
    Myclass(char x)
    {
        x++;
        cout << "x=" << x << "\n";
    }
};
void add(double x)
{
    x++;
    cout << "x=" << x << "\n";
}
void add(int x)
{
    x++;
    cout << "x=" << x << "\n";
}
void add(char x)
{
    x++;
    cout << "x=" << x << "\n";
}

int main()
{
    cout << "A:\n";
    Myclass a(1), b(3.2), c('c');
    cout << "B:\n";
    add(1);
    add(3.2);
    add('c');

    system("pause");
    return 0;
}
