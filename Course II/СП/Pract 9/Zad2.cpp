#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h>
#include <locale.h>
using namespace std;

int e;
char n = 2;
char c = 0;
unsigned short a = 10;
unsigned short  x, y;

int main()
{
	setlocale(LC_ALL, "RUS");
	_asm {
			mov ax, a
			mov bx, a
			mov cl, n
			dec cl
			round :
			mul bx
			jc mover
			dec cl
			cmp cl, 0
			jne round
			jmp outer
			mover :
			mov c, cl
			outer :
			mov x, dx
			mov y, ax
			shl edx, 16
			mov dx, ax
			mov e, edx
	}

	printf("Исходные данные:\na = %i\n", a);
	printf("n = %i\n", n);

	if (c == 1)
		printf("\nE = 10^%i\n", (n - c) + 1);

	printf("DX = %i (%x)\n", x, x);
	printf("AX = %i (%x)\n", y, y);
	printf("EDX = %i (%x)\n", e, e);

	system("pause");
	return 0;
}