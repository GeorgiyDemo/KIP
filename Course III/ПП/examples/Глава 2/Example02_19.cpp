#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Корень уравнения:
    double x;
    //Количество итераций и индексная переменная:
    int n = 100, i;
    //Вычисление корня x=2:
    x = 0;
    for (i = 1; i <= n; i++)
        x = (x * x + 6) / 5;
    cout << "x = " << x << endl;
    //Вычисление корня x=3:
    x = 5;
    for (i = 1; i <= n; i++)
        x = sqrt(5 * x - 6);
    cout << "x = " << x << endl;
    return 0;
}