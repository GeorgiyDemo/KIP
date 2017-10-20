#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Действительная и мнимая часть:
    double x, y, X, Y;
    //Модуль и аргумент:
    double r, phi, R, Phi;
    //Показатель степени:
    int n;
    //Ввод параметров:
    cout << "Real part x = ";
    cin >> x;
    cout << "Imaginary part y = ";
    cin >> y;
    cout << "Power n = ";
    cin >> n;
    //Вычисление результата:
    phi = atan2(y, x);
    r = sqrt(x * x + y * y);
    R = pow(r, n);
    Phi = n * phi;
    X = R * cos(Phi);
    Y = R * sin(Phi);
    cout << "The result is:\n";
    cout << "Re-part " << X << "\n";
    cout << "Im-part " << Y << "\n";
    return 0;
}