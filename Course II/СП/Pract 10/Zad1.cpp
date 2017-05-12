#include <iostream>

#include <conio.h>

unsigned char a = 10;
unsigned char c = 0;
unsigned char n;

void main() {

	setlocale(LC_ALL, "rus");

	_asm {

		mov al, a;
		mov bl, 0;


	m1: 
		inc bl
		mov al, a
		mul bl
		jc m2
		mov c,al
		jmp m1
	
	m2: 
		mov n, bl
	
	}

	printf("Произведение = %i\n", c);
	printf("При умножении %i будет переполнение!\n", n);
	system("pause");
}