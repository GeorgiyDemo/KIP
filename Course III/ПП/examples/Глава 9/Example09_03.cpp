#include <iostream>
using namespace std;
class MyClass {
public:
    int m, n;
    //Конструктор класса без аргументов:
    MyClass()
    {
        m = 0;
        n = 0;
    }
    //Конструктор класса с одним аргументом:
    MyClass(int a)
    {
        m = a;
        n = a;
    }
    //Конструктор класса с двумя аргументами:
    MyClass(int a, int b)
    {
        m = a;
        n = b;
    }
    void show()
    {
        cout << "m = " << m << endl;
        cout << "n = " << n << endl;
    }
};
int main()
{
    //Разные способы создания объектов:
    MyClass obj1;
    MyClass obj2(1);
    MyClass obj3(2, 3);
    //Отображение значения полей объектов:
    obj1.show();
    obj2.show();
    obj3.show();
    return 0;
}