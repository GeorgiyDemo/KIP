#include "stdafx.h"
#include <ctime>
#include <locale.h>
#include <iomanip>
#include <iostream>

using namespace std;
int main() {
    setlocale(LC_ALL, "rus");
    const int n = 1000;
    int arr[n] = { 0 };
    int i, sum;
    printf("Исходный массив:\n");
    for (i = 0; i <n; i++)
    {
        arr[i] = rand() % 4 + 2;
        printf("%3d", arr[i]);
    }

    unsigned int start_time = clock();
    _asm {
            mov eax, 0; начальное значение суммы
            mov ecx, 1000; счетчик цикла
            mov esi, 0; начальное значение индекса
            l : add eax, arr[esi]; eax = eax + arr[i]
            add esi, 4; следующий индекс
            loop l; цикл  n раз
            mov sum, eax
    }
    unsigned int end_time = clock();
    unsigned int search_time = end_time - start_time; // искомое время
    printf("\n sum= %d", sum);
    cout << " time= " << clock() / 1000.0; //микросекунды
    getchar();
}
