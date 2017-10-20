#include <iostream>
using namespace std;
int main()
{
    // Скорость тела – объявление переменной
    double v;
    // Время полета
    double t = 1.2;
    // Ускорение свободного падения
    double g = 9.8;
    // Скорость – инициализация переменной
    v = 12.3;
    // Высота – динамическая инициализация переменной
    double s = v * t - g * t * t / 2;
    cout << "Height level is " << s << "\n";
    return 0;
}