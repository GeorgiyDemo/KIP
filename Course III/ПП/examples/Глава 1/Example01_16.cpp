#include <iostream>
using namespace std;
int main()
{
    //Число, показатель степени и результат:
    int number, n, result;
    //Ввод пользователем числа:
    cout << "Enter number = ";
    cin >> number;
    //Ввод пользователем показателя степени:
    cout << "Enter n = ";
    cin >> n;
    //Результат умножения:
    result = number << n;
    cout << "result = " << result << endl;
    return 0;
}