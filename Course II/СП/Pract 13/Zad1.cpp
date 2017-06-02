#include <iostream>
#include <iomanip>
#include <conio.h>

unsigned short a = -107;
unsigned short b, c;

void main() {

	setlocale(LC_ALL, "rus"); 

	_asm {

		mov ax, a
		mov bx, 0
		mov cx, 8

		ONE:
			sar ax, 1
			jnc TWO
			inc bx

		TWO :
			loop ONE
			mov b, bx

	}
	printf("\nОтвет = %d ", b);
	getch();
}

