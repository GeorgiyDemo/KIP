#include <iostream>
using namespace std;
//Функция возведения в квадрат:
double sqr(double x)
{
    return x * x;
}
//Функция возведения в куб:
double cube(double x)
{
    return x * x * x;
}
//Функция со вторым аргументом-указателем на функцию:
void myfunc(double x, double (*f)(double))
{
    cout << f(x) << endl;
}
int main()
{
    double z;
    //Указатель на функцию:
    double (*p)(double);
    cout << "z = ";
    cin >> z;
    //Указателю присваивается значение:
    p = cube;
    //Использование указателя и имени функции:
    myfunc(z, sqr);
    myfunc(z, p);
    cout << p(z) << endl;
    //Адрес функции:
    cout << sqr << endl;
    cout << cube << endl;
    cout << p << endl;
    return 0;
}