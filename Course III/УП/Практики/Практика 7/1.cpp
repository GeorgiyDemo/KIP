/*
1.	Составьте программу, которая спрашивает у пользователя число и 
выводит в цикле четные числа от 0 до заданного числа. Сделайте два 
варианта: с использованием оператора continue и без него.
*/
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class CounterClass {

    int n;

public:
    void inputer();
};

void CounterClass::inputer()
{

    cout << "Введите число:\n";
    cin >> n;
    cout << "Четные числа:\n";

    for (int i = 0; i < n; i++) {
        if ((i % 2) == 0)
            cout << i << "\n";
    }
}

int main()
{

    CounterClass obj;
    obj.inputer();

    cout << "\n";
    return 0;
}