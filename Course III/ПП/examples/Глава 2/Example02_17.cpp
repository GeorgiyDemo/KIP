#include <iostream>
using namespace std;
int main()
{
    //Граница произведения:
    int N;
    //Индексная переменная:
    int n;
    //Переменная для записи произведения:
    double s = 1;
    //Ввод границы произведения:
    cout << "Enter N = ";
    cin >> N;
    //Вычисление произведения:
    for (n = 2; n <= N; n++)
        s *= (1 - (double)2 / (n * (n + 1)));
    //Результат:
    cout << "Product is " << s << endl;
    return 0;
}