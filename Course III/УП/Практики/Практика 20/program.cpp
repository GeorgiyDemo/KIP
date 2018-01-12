#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
const int K = 19;

int main()
{

    setlocale(LC_ALL, "RUS");
    int middle_numbers, ender, i, sum, marks[K];
    double answer;
    string FIO, Localstring;

    ifstream fs("INPUT.txt");
    if (!fs)
        return 1;

    i = 0;
    while (getline(fs, Localstring)) {
        int buf = atoi(Localstring.c_str());
        if (buf == 0)
            FIO = Localstring.c_str();
        else {
            marks[i] = atoi(Localstring.c_str());
            i++;
        }
    }
    fs.close();

    sum = 0;
    for (i = 0; i < K; i++)
        sum += marks[i];

    _asm {
		mov eax, 0; начальное значение суммы
		mov ecx, K; счетчик цикла
		mov esi, 0; начальное значение индекса
		l : add eax, marks[esi]; eax = eax + marks[i]
			add esi, 4; следующий индекс
			loop l; цикл  n раз
			mov edx, 0
			mov ebx, K
			div ebx
			mov middle_numbers, eax
			mov ender, edx
    }

    answer = ender;
    answer = answer / K + middle_numbers;

    cout << FIO << "\nТекущие оценки: \n";
    for (i = 0; i < K; i++)
        cout << marks[i] << " ";
    cout << "\nСумма оценок: " << sum;
    cout << "\nКол-во оценок: " << K;
    cout << "\nСредний балл: " << answer << "\n";

    system("pause");
    return 0;
}
