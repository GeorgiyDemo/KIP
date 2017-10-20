#include <iostream>
#include <cmath>
using namespace std;
//Класс для реализации комплексных чисел:
class Complex {
public:
    double Re, Im;
    //Метод для отображения комплексного числа:
    void show()
    {
        cout << Re;
        if (Im > 0)
            cout << "+" << Im << "i" << endl;
        if (Im < 0)
            cout << "-" << -Im << "i" << endl;
    }
};
//Экспонента от комплексного числа:
Complex cExp(Complex z)
{
    Complex tmp;
    tmp.Re = exp(z.Re) * cos(z.Im);
    tmp.Im = exp(z.Re) * sin(z.Im);
    return tmp;
}
int main()
{
    Complex z;
    cout << "Re: ";
    cin >> z.Re;
    cout << "Im: ";
    cin >> z.Im;
    cout << "z=";
    z.show();
    cout << "exp(z)=";
    cExp(z).show();
    return 0;
}