/*
2.	Написать программу, которая определяет максимальное число из 
введенной с клавиатуры последовательности положительных чисел (длина 
последовательности неограниченна). Ниже приведен рекомендуемый вид 
экрана во время выполнения программы (данные, введенные пользователем, 
выделены полужирным шрифтом). 
Определение максимального числа последовательности положительных чисел. 
Вводите после стрелки числа. Для завершения ввода введите ноль. 
-> 56 
-> 75 
-> 43 
-> О Максимальное число: 75
*/
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class CounterClass {

    double number;
    double max;

public:
    void inputer();
};

void CounterClass::inputer()
{
    max = 0;
    cout << "Введите числа:\n";
    do {

        cin >> number;
        if (number > max)
            max = number;
    } while (number != 0);
    cout << "Максимальное число: " << max;
}

int main()
{

    CounterClass obj;
    obj.inputer();

    cout << "\n";
    return 0;
}