#include <iostream>
using namespace std;
//Класс и два объекта:
class MyClass {
public:
    double x;
    void show()
    {
        cout << "x = " << x << endl;
    }
} a, b;
//Результатом функции является ссылка:
MyClass& f(bool arg)
{
    if (arg)
        return a;
    else
        return b;
}
int main()
{
    //Обращение к объектам через функцию-ссылку:
    f(true).x = 5;
    f(true).show();
    //Проверка результата:
    cout << "x = " << a.x << endl;
    //Обращение к объектам через функцию-ссылку:
    f(false).x = 10;
    f(false).show();
    //Проверка результата:
    cout << "x = " << b.x << endl;
    return 0;
}