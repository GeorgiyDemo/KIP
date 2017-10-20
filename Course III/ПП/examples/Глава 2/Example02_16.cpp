#include <iostream>
using namespace std;
//Граница ряда:
const int N = 100;
int main()
{
    //Аргумент функции и "рабочие" переменные:
    double x, q, s = 0;
    //Индексная переменная:
    int n;
    cout << "Enter x = ";
    cin >> x;
    q = x;
    //Вычисление синуса:
    for (n = 1; n <= N; n++) {
        s += q;
        q *= (-1) * x * x / (2 * n) / (2 * n + 1);
    }
    //Результат:
    cout << "sin(" << x << ") = " << s << endl;
    return 0;
}