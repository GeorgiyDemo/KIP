/*
    Создать абстрактный базовый класс Figure с виртуальной функцией – площадь поверхности.
    Создать производные классы параллелепипед и шар, в 
    которых данная функция переопределена. Продемонстрировать на 5 объектах.
*/

#include <iostream>
#include <cmath>
# define pi   3.14159265358979323846 
using namespace std;
class figure
{
public:
    virtual double ploshad() const = 0;
    virtual double show()const = 0;

};

class shar : public figure
{
public:
    double r;
    shar(float x1)
    {
        r = x1;
    }
    virtual double show()
        const
    {
        cout <<"шара с радиусом равным "<< r;
        return 0;
    }
    virtual double ploshad()
        const
    {
        return 4 * pi*r*r;
    }

};
class paralelip : public figure
{
    double a, b, c;
public:
    paralelip(double x1, double x2, double x3)
    {
        a = x1;
        b = x2;
        c = x3;
    }

    virtual double show()
        const
    {
        cout << "паралепипеда со стороной a= " << a << " b= "<<b<<" c= "<<c;
        return 0;
    } 

    virtual double ploshad()
        const
    {
        return 2 * (a*b + b*c + a*c);
    }
};

int main() {
    setlocale(LC_ALL, "rus");
    int r;

    figure *mas[4];
    mas[0] = new shar(5);
    mas[1] = new paralelip(3, 5, 25);
    mas[2] = new paralelip(7, 8, 11);
    mas[3] = new shar(15);
    mas[4] = new paralelip(5, 10, 15);
    for (int i = 0; i < 4; i++) {
        cout << "У ";
        mas[i]->show();
        cout <<". Площадь равна " << mas[i]->ploshad()<<endl;
    }
        for (int i = 0; i != 4; ++i) {
        delete mas[i];
    }
    return 0;
}
