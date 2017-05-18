#include <iostream>
#include <iomanip>
#include <conio.h>

unsigned short a = 32000;
unsigned int b = 2000000000;
unsigned short n = 0;
unsigned int s, s1, s2;

void main() {

	setlocale(LC_ALL, "RUS");

	_asm {

		mov ebx, b
		mov cx, n

		BEGINER :
			mov ax, a
			mul cx
			mov s1, edx
			shl edx, 16
				
			mov dx, ax
			inc cx
			cmp edx, ebx

			jae KOT
			jmp BEGINER

		KOT :

			mov s, edx
			mov n, cx

	}

	printf("Ответ: CX = %i\n", n);
	printf("EDX перед смещением на 16 %i (%x)", s1, s1);
	printf("\nEDX после смещения на 16 %i (%x)\n\n", s, s);
	system("pause");
}
