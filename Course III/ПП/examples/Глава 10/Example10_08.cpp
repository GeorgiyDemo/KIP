#include <iostream>
using namespace std;
//Класс для реализации комплексных чисел:
class MComp {
public:
    double Re;
    double Im;
    //Переопределение оператора сложения методом класса:
    MComp operator+(MComp y)
    {
        MComp z;
        z.Re = Re + y.Re;
        z.Im = Im + y.Im;
        return z;
    }
};
int main()
{
    MComp a, b, c;
    a.Re = 1;
    a.Im = 2;
    b.Re = 2;
    b.Im = 3;
    //Сложение объектов:
    c = a + b;
    cout << "c.Re = " << c.Re << "\n";
    cout << "c.Im = " << c.Im << "\n";
    return 0;
}