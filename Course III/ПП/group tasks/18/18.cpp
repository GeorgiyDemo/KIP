/*
    Создайте функцию add () которая   к аргументу прибавляет 1, где аргументы целый (int), вещественный (double), символьный  (char) тип.
	a)	С помощью перегруженных функций(без классов);
	b)	С помощью перегруженных конструкторов или методов класса.
*/

#include <iostream>
using namespace std;
class Myclass {
public:
    Myclass(double x)
    {
        x++;
        cout << "x=" << x << endl;
    }
    Myclass(int x)
    {
        x++;
        cout << "x=" << x << endl;
    }
    Myclass(char x)
    {
        x++;
        cout << "x=" << x << endl;
    }
};
void Add(double x)
{
    x++;
    cout << "x=" << x << endl;
}
void Add(int x)
{
    x++;
    cout << "x=" << x << endl;
}
void Add(char x)
{
    x++;
    cout << "x=" << x << endl;
}

int main()
{
    cout << "A:\n";
    Myclass a(1), b(3.2), c('c');
    cout << "B:\n";
    Add(1);
    Add(3.2);
    Add('c');
    return 0;
}
