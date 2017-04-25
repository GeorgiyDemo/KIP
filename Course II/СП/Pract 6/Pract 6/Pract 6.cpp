#include "stdafx.h" 
#include <iostream> 

using namespace std;

char a = 70;
char x = 70;
char k;

int main() {

	setlocale(LC_ALL, "rus");
	printf("Введите k =>");
	scanf_s("%c", &k);

	//Задание 2
	_asm {
		mov al, a
		mov cl, k
		mov dl, 0
		retur: cmp dl, cl
			   je fin
			   shr al, 1
			   add dl, 1
			   jmp retur
			   fin : mov x, al
	}

	//Задание 1 
	_asm {
		mov dl, a
		or dl, 85
		mov a, dl
	}
	printf("\nРезультаты выполнения задания 1:\n");
	printf("Число а после изменения: %i\n", a);
	printf("Результаты выполнения задания 2:\n");
	printf("x=%i", x);

	system("pause");
}