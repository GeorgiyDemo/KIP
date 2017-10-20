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
//Операторная функция для вычитания двух объектов:
MComp operator-(MComp x, MComp y)
{
    MComp z;
    z.Re = x.Re - y.Re;
    z.Im = x.Im - y.Im;
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
//Операторная функция для сложения объекта и числа:
MComp operator+(MComp y, double x)
{
    MComp z;
    z.Re = x + y.Re;
    z.Im = y.Im;
    return z;
}
//Операторная функция для вычитания из числа объекта:
MComp operator-(double x, MComp y)
{
    MComp z;
    z.Re = x - y.Re;
    z.Im = -y.Im;
    return z;
}
//Операторная функция для вычитания из объекта числа:
MComp operator-(MComp y, double x)
{
    MComp z;
    z.Re = y.Re - x;
    z.Im = y.Im;
    return z;
}
//Операторная функция для префиксной формы инкремента:
MComp operator++(MComp& x)
{
    x.Re++;
    return x;
}
//Операторная функция для постфиксной формы инкремента:
MComp operator++(MComp& x, int unused)
{
    x.Im++;
    return x;
}
//Операторная функция для префиксной формы декремента:
MComp operator--(MComp& x)
{
    x.Re--;
    return x;
}
//Операторная функция для постфиксной формы декремента:
MComp operator--(MComp& x, int unused)
{
    x.Im--;
    return x;
}
//Операторная функция для вычисления комплексно-спряженного:
MComp operator!(MComp & x)
{
    x.Im *= -1;
    return x;
}
int main()
{
    MComp a, b, c;
    double x = 1.5, y = 2.5;
    a.Re = 1;
    a.Im = 2;
    b.Re = 2;
    b.Im = 3;
    cout << "******************";
    cout << "\na.Re = " << a.Re << "\na.Im = " << a.Im << "\n";
    cout << "******************";
    cout << "\nb.Re = " << b.Re << "\nb.Im = " << b.Im << "\n";
    cout << "******************";
    cout << "\nx = " << x << "\ny = " << y << "\n";
    cout << "******************";
    //Сложение объектов:
    c = a + b;
    cout << "\nc=a+b: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Сложение числа и объекта:
    c = x + c;
    cout << "\nc=x+c: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Сложение объекта и числа:
    c = c + y;
    cout << "\nc=c+y: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Инкремент в префиксной форме:
    ++c;
    cout << "\n++c: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Инкремент в постфиксной форме:
    c++;
    cout << "\nc++: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Вычитание объектов:
    c = a - b;
    cout << "\nc=a-b: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Вычитание из числа объекта:
    c = x - c;
    cout << "\nc=x-c: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Вычитание из объекта числа:
    c = c - y;
    cout << "\nc=c-y: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Декремент в префиксной форме:
    --c;
    cout << "\n--c: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Декремент в постфиксной форме:
    c--;
    cout << "\nc--: \n";
    cout << "c.Re = " << c.Re << "\nc.Im = " << c.Im << "\n";
    cout << "******************";
    //Комплексно-сопряженное:
    !a;
    cout << "\n!a: \n";
    cout << "a.Re = " << a.Re << "\na.Im = " << a.Im << "\n";
    cout << "******************\n";
    return 0;
}