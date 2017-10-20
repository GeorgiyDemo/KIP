#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Ускорение свободного падения и число pi:
    const double g = 9.8, pi = 3.1415;
    //Шаг дискретности по времени:
    double dt = 0.0001;
    //Рабочие переменные:
    double V, alpha, t, v, u, x = 0, y = 0;
    int n = 0;
    //Ввод параметров задачи:
    cout << "Enter V = ";
    cin >> V;
    cout << "Enter alpha = ";
    cin >> alpha;
    //Перевод градусов в радианы:
    alpha = alpha * pi / 180;
    cout << "Enter t = ";
    cin >> t;
    //Начальная скорость (проекции):
    v = V * cos(alpha);
    u = V * sin(alpha);
    //Вычисление координат тела:
    do {
        n++;
        y += u * dt;
        x += v * dt;
        u -= g * dt;
    } while ((y > 0) && (n * dt < t));
    //Вывод результатов с учетом конечности времени полета:
    cout << "y = " << y << " : ";
    cout << (t < sqrt(2 * V * sin(alpha) / g) ? V * sin(alpha) * t - g * t * t / 2 : 0) << endl;
    cout << "x = " << x << " : ";
    cout << (t < sqrt(2 * V * sin(alpha) / g) ? V * cos(alpha) * t : V * V * sin(2 * alpha) / g) << endl;
    return 0;
}