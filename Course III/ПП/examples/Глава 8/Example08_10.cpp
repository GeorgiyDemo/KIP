#include <iostream>
using namespace std;
class MyClass {
public:
    double x;
    void show()
    {
        cout << "x = " << x << endl;
    }
    MyClass(double z)
    {
        x = z;
    }
};
int main()
{
    int i;
    MyClass objs[] = { MyClass(1), MyClass(3), MyClass(5) };
    for (i = 0; i < 3; i++) {
        cout << i + 1 << ": ";
        objs[i].show();
    }
    return 0;
}