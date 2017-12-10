#include "stdafx.h"
#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "RUS");
    unsigned short a, a1, b1, c;
    cout << "Введите a число a => ";
    cin >> a;
    //Задание 1;
    _asm {
		mov dx, a
		not dx
		and dx, 85
		mov b1, dx
    }
    cout << "\n*Результат выполнения задания №1*";
    cout << "\n--> Число a после изменения: " << b1 << "\n";
    //Задание 2
    _asm
    {
		mov ax, a
		mov dx, a
		ror ax, 5
		rcr dx, 5
		mov a1, ax
		mov c, dx
    }
    cout << "\n*Результат выполнения задания №2*";
    cout << "\n--> Число a после изменения: " << a1;
    cout << "\n--> Число a после изменения: " << c << "\n";
    system("pause");
}
