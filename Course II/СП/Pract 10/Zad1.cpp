#include <iostream>
#include <iomanip>
#include <conio.h>

unsigned char a = 10;
unsigned char c = 0;
unsigned char n;

void main() {

	setlocale(LC_ALL, "rus");

	_asm {

		mov al, a;
		mov bl, 0;


		BEGINER :
			inc bl
			mov al, a
			mul bl
			jc KOT
			mov c, al
			jmp BEGINER 

		KOT :
			mov n, bl

	}

	printf("Переполнение при умножении %i\n", n);
	printf("Произведение: %i\n", c);
	system("pause");
}