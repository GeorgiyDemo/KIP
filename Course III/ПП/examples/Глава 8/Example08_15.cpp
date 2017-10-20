#include <iostream>
using namespace std;
class B;
class A {
    double x;

public:
    A(double z) { x = z; }
    double summa(B b);
    double product(B b);
} a(3.5);
class B {
    double y;

public:
    B(double z) { y = z; }
    friend class A;
} b(2.3);
int main()
{
    cout << "Total is " << a.summa(b) << endl;
    cout << "Product is " << a.product(b) << endl;
    return 0;
}
double A::summa(B b)
{
    return x + b.y;
}
double A::product(B b)
{
    return x * b.y;
}