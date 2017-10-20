#include <iostream>
using namespace std;
//Обобщенный класс:
template <class X = int>
class MyClass {
    X value;

public:
    MyClass(X m)
    {
        value = m;
    }
    void set(X m) { value = m; }
    void get()
    {
        cout << "value = " << value << endl;
    }
};
int main()
{
    //Создание объекта с int-полем:
    MyClass<> a(5);
    a.get();
    a.set(3);
    a.get();
    //Создание объекта с char-полем:
    MyClass<char> b('x');
    b.get();
    b.set('z');
    b.get();
    return 0;
}