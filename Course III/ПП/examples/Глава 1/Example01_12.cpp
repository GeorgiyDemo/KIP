#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Гравитационная постоянная:
    const double G = 6.672E-11;
    //Масса Земли:
    const double M = 5.96E24;
    //Радиус Земли:
    const double R = 6.37E6;
    //Число pi:
    const double pi = 3.1415;
    //Период и высота орбиты:
    double T, h;
    //Ввод периода (в часах):
    cout << "Enter T = ";
    cin >> T;
    //Перевод часов в секунды:
    T = T * 3600;
    //Определение высоты:
    h = pow(G * M * T * T / 4 / pi / pi, (double)1 / 3) - R;
    //Перевод в километры:
    h = h / 1000;
    cout << "Height h =" << h << " km\n";
    return 0;
}