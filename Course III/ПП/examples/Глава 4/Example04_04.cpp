#include <iostream>
using namespace std;
//Прототип функции InvFunc():
void InvFunc(double z);
//Функция InvFunc() использована в программе:
int main()
{
    double s;
    cout << " Enter number: ";
    cin >> s;
    InvFunc(s);
    return 0;
}
//Объявление функции InvFunc():
void InvFunc(double z)
{
    if (z == 0) {
        cout << "Division by zero!" << endl;
        return;
    }
    double x;
    x = 1 / z;
    cout << "1/z =" << x << endl;
}