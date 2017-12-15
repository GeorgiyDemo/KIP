/*
Разместить в памяти компьютера массив из N целых беззнаковых чисел.
Написать программу, позволяющую уменьшить на единицу элементы массива с четными индексами.
Вывести на экран измененный массив.
Ввод массива необходимо осуществлять двумя способами (предусмотреть наличие меню):
вручную с клавиатуры, а также с помощью ГСЧ.
*/
#include "stdafx.h"
#include <iostream>
#include <time.h>
using namespace std;

int main(void) {
	setlocale(LC_ALL, "rus");
	unsigned int *a;
	int i, n = 0, k = 0, buf_n;
	do {
		cout << "*1* Случайный ввод\n*2* Ручной ввод\n*0* Выход \n=> ";
		srand(time(NULL));
		cin >> k;
		if (k == 0)
			break;
		cout << "n =>";
		cin >> n;

		a = new unsigned int[n];
		if (k == 1)
		{
			cout << "Исходный массив: " << endl;
			for (i = 0; i < n; i++)
			{
				a[i] = rand() % 50;
				cout << a[i] << " ";
			}
		}
		if (k == 2)
		{
			cout << "Введите элементы: " << endl;
			for (i = 0; i < n; i++)
			{
				cout << "a[" << i << "]= ";
				cin >> a[i];
			}
		}

		_asm {
			mov esi, a
			mov eax, [esi]
			mov ecx, n
			mov eax, 0

			l1 :
			test esi, 4
				jnbe m2
				sub[esi], 1
				add esi, 4; следующий индекс

				m2 :
			inc esi
				loop l1;

		}

		cout << "\nПреобразованный массив: " << endl;
		for (i = 0; i < n; i++)
			cout << a[i] << " ";

		system("pause");
	} while (k != 0);
}
