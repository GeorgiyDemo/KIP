#include <iostream>
using namespace std;
class MyClass {
    int m, n;

public:
    MyClass() //это конструктор без аргументов:
    {
        m = 30;
        n = 40;
        cout << "\nКонструктор сработал! "
             << "объект  " << this << "  создан";
    }
    //Конструктор класса с аргументами:
    MyClass(int m, int n)
    {
        this->m = m;
        this->n = n;
        cout << "\nКонструктор сработал! "
             << " объект  " << this << "  создан" << endl;
    }
    //Деструктор класса
    ~MyClass()
    {
        cout << "\n Деструктор сработал! "
             << " объект  " << this << "  удален";
    }
    void show()
    {
        cout << "m = " << m << endl;
        cout << "n = " << n << endl;
    }
} obj, obj2;
int main()
{
    setlocale(LC_ALL, "rus");
    //При создании объекта указываются значения полей:
    MyClass obj1;
    MyClass obj2(4, 7);
    //Отображение значения полей объекта:
    obj.show();
    obj1.show();
    obj2.show();
    return 0;
}
