#include "stdafx.h"
#include "iostream"
using namespace std;

unsigned short x = 3;
unsigned short y = 4;
unsigned short z = 14;
unsigned short result, s1, s2, s3;

int main() {

	setlocale(LC_ALL, "rus");

	_asm {

		mov ax, x
		mov bx, y
		mov cx, z
		add bx, ax
		mov s1, bx
		cmp ax, bx
		jb DOWN
		ja UP
		je RAVNO

		DOWN :
			mov dx, bx
			jmp KON

		UP :
			mov dx, ax
			jmp KON

		RAVNO :
			mov dx, bx
			jmp KON

		KON :
			mov ax, y
			add ax, y
			add ax, y
			mov bx, z
			cmp ax, bx
			jb DOWN1
			ja UP1
			je RAVNO1

		DOWN1 :
			mov cx, ax
			jmp KON1

		UP1 :
			mov cx, bx
			jmp KON1

		RAVNO1 :
			mov cx, ax
			jmp KON1

		KON1 :
			mov s2, dx
			mov s3, cx
			add dx, cx
			mov result, dx
	}

	printf("x = %i", x);
	printf("\ny = %i", y);
	printf("\nz = %i", z);
	printf("\n\nBX = %i", s1);
	printf("\nDX (1-я часть) = %i", s2);
	printf("\nCX (2-я часть) = %i", s3);
	printf("\n\nРезультат = %i\n", result);
	system("pause");

return 0;
}