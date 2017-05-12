#include <iostream>
#include <conio.h>

unsigned short a = 32000;
unsigned short n = 0;
unsigned int b = 2000000000;
unsigned int s;

void main() {

	setlocale(LC_ALL, "rus");

	_asm {

		mov ebx, b
		mov cx, n

	FIRST:
		mov ax, a
		mul cx
		shl edx, 16

		mov dx, ax
		inc cx
		cmp edx, ebx

		jae FATAL
		jmp FIRST

	FATAL:

		mov s, edx
		mov n, cx

	}

	printf("%i\n", n);
	printf("%i\n", s);
	system("pause");
}
