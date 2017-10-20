#include <iostream>
using namespace std;
class MyClass {
public:
    int m, n;
    //Конструктор класса:
    MyClass(int a, int b)
    {
        m = a;
        n = b;
        cout << "Object " << this << " has been created" << endl;
        cout << "m = " << m << endl;
        cout << "n = " << n << endl;
    }
    //Деструктор класса:
    ~MyClass()
    {
        cout << "Object " << this << " has been deleted" << endl;
    }
};
//В функции создается объект:
MyClass MyFunc(int x, int y)
{
    MyClass tmp(x, y);
    return tmp;
}
int main()
{
    //Создание объекта:
    MyClass obj(1, 2);
    //Изменение объекта:
    obj = MyFunc(3, 4);
    return 0;
}