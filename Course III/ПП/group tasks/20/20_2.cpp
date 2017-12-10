#include <iostream>
using namespace std;
// базовый абстрактный класс т.к есть чистая вирт. функция
class Figure {
public: // чистая виртуальная функция
    virtual void goo(double a, double b, double c) = 0 {}
};
// площадь параллелепипеда 2(ab+bc+ac)
class Parall : public Figure { //наследуем от базового класса Figure
public: // переопределяем функцию
    void goo(double a, double b, double c)
    {
        cout << "Площадь параллелепипеда=" << 2 * (a * b + b * c + a * c) << endl;
    }
};
// площадь шара 4Пr^2
class Orb : public Figure {
public:
    void goo(double r, double p, double c)
    {
        cout << "Площадь шара:" << c * p * (r * r) << endl;
    }
};
int main()
{
    setlocale(LC_ALL, "Russian");
    Figure* Fig;
    // выделяем память для классов
    Parall* par = new Parall;
    Orb* shar = new Orb;
    double p = 3.1415; //число пи для площади шара
    const double c = 4; // число 4 для площади шара
    Fig = par;
    Fig->goo(1, 2, 3);
    Fig->goo(3, 4, 5);
    Fig->goo(5, 6, 7);

    Fig = shar;
    Fig->goo(2, p, c);
    Fig->goo(3, p, c);

    system("pause");
    return 0;
}
