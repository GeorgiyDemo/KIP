#include <iostream>
using namespace std;
//Класс для реализации комплексных чисел:
class MComp {
public:
    double Re;
    double Im;
};
//Операторная функция для сложения двух объектов:
MComp operator+(MComp x, MComp y)
{
    MComp z;
    z.Re = x.Re + y.Re;
    z.Im = x.Im + y.Im;
    return z;
}
//Операторная функция для сложения числа и объекта:
MComp operator+(double x, MComp y)
{
    MComp z;
    z.Re = x + y.Re;
    z.Im = y.Im;
    return z;
}
int main()
{
    MComp a, b, c;
    double x = 1.5;
    a.Re = 1;
    a.Im = 2;
    b.Re = 2;
    b.Im = 3;
    //Сложение объектов:
    c = a + b;
    cout << "c.Re = " << c.Re << "\n";
    cout << "c.Im = " << c.Im << "\n";
    //Сложение числа и объекта:
    c = x + c;
    cout << "c.Re = " << c.Re << "\n";
    cout << "c.Im = " << c.Im << "\n";
    return 0;
}