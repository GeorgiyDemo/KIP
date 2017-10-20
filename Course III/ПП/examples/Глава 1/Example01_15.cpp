#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    const double g = 9.8;
    //Высота:
    double h = 78.4;
    //Полупериод, вводимое пользователем время и координата:
    double T, t, x;
    //Количество полупериодов:
    int n;
    //Ввод пользователем момента времени:
    cout << "Enter t = ";
    cin >> t;
    T = sqrt(2 * h / g);
    n = (int)t / T;
    t = n % 2 ? T - (t - n * T) : t - n * T;
    x = h - g * t * t / 2;
    cout << "x = " << x << " m" << endl;
    return 0;
}