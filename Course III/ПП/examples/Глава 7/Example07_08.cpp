#include <iostream>
using namespace std;
class MyClass {
    int a, b;

public:
    //Перегруженный метод:
    void setab(int i, int j)
    {
        a = i;
        b = j;
    }
    void setab(int i)
    {
        a = i;
        b = i;
    }
    void getab()
    {
        cout << "a = " << a << endl;
        cout << "b = " << b << endl;
    }
} obj1, obj2;
int main()
{
    obj1.setab(1, 2);
    obj2.setab(3);
    obj1.getab();
    obj2.getab();
    return 0;
}