#include <iomanip>
#include <iostream>
#include <string>
#include <math.h>

using namespace std;

class faktorclass {

    // Основные поля
    double x, e;
    //Доп. поля для удобства вычислений
    double f, buf;
    int n;

public:
    //Конструктор с полями по умолчанию
    faktorclass(double f1 = 0.0, double buf1 = 1.0, int n1 = 1);
    //Методы
    void input(double x1, double e1);
    long fact(long n);
    void counter();
};

faktorclass::faktorclass(double f1, double buf1, int n1)
{
    cout << "Конструктор работает\n";
    f = f1;
    buf = buf1;
    n = n1;
}

void faktorclass::input(double x1, double e1)
{
    x = x1;
    e = e1;
}

long faktorclass::fact(long n)
{
    long p = 1;
    for (int i = 1; i <= n; i++)
        p *= i;
    return p;
}

void faktorclass::counter()
{
    while (buf > e) {
        f += buf;
        buf = pow(x, 2 * n) / double(faktorclass::fact(2 * n));
        n++;
    }
    printf("%f", f);
}

int main()
{

    double x, e;
    cout << "Введите аргумент x => ";
    cin >> x;
    cout << "Введите верхнюю границу ряда => ";
    cin >> e;
    faktorclass* obj;
    obj = new faktorclass;

    obj->input(x, e);
    obj->counter();

    cout << "\n";
    return 0;
}