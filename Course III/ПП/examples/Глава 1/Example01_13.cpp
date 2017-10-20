#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Частота колебаний:
    double omega = 0.2;
    //Параметры задачи:
    double A1, t1, k;
    //Амплитуда и начальная фаза:
    double A, phi0;
    //Ввод параметров:
    cout << "Enter t1 = ";
    cin >> t1;
    cout << "Enter A1 = ";
    cin >> A1;
    cout << "Enter k = ";
    cin >> k;
    phi0 = asin(1 / k);
    A = A1 / sin(omega * t1 + phi0);
    cout << "Amplitude A = " << A << "\n";
    return 0;
}