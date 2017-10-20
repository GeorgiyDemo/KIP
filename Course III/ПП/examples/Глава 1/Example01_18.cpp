#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    //Параметры задачи:
    double p, p1, P, q;
    int n;
    //Ввод параметров задачи:
    cout << "p = ";
    cin >> p;
    //Проверка корректности значения p:
    (p < 0 || p > 1) ? (cout << "Wrong value!" << endl, exit(0)) : cout << "p1 = ";
    cin >> p1;
    //Проверка корректности значения p1:
    (p1 < 0 || p1 > 1) ? (cout << "Wrong value!" << endl, exit(0)) : cout << "n = ";
    cin >> n;
    //Поиск решения:
    q = (1 - p) * (1 - p1);
    P = p * p1 * (1 - pow(q, n)) / (1 - q);
    cout << "P = " << P << endl;
    return 0;
}