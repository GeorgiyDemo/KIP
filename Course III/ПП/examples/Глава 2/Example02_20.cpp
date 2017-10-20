#include <iostream>
using namespace std;
int main()
{
    //Переменные для записи результата
    //вычислений и вводимого числа:
    double x, s;
    //Переменная для записи символа операции:
    char op;
    //Ввод первого числа:
    cout << ">> ";
    cin >> x;
    s = x;
    //Оператор цикла для вычисления результата:
    while (true) {
        //Считывание символа операции:
        cout << ">> ";
        cin >> op;
        //Команда выхода из оператора цикла:
        if (op == '=') {
            cout << "---> " << s << endl;
            exit(0);
        }
        //Ввод числа:
        cout << ">> ";
        cin >> x;
        //Обработка символа операции:
        switch (op) {
        case '+':
            s += x;
            break;
        case '-':
            s -= x;
            break;
        case '*':
            s *= x;
            break;
        case '/':
            s /= x;
        }
    }
    return 0;
}