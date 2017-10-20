#include <iostream>
#include <cstdio>
using namespace std;
//Функция для вычисления длины строки:
int length(char* str)
{
    int i = 0;
    while (str[i]) {
        i++;
    }
    return i;
}
//Проверка работы функции length():
int main()
{
    char str[80];
    cout << "Enter a string: ";
    gets(str);
    cout << "String length is " << length(str) << endl;
    return 0;
}