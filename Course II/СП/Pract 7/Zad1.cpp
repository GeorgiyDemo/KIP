#include "stdafx.h"
#include "iostream"
using namespace std;

unsigned short x, y, z, s1, s2, s3;

int main() {
	setlocale(LC_ALL, "rus");
	cout << "Введите x =>"; cin >> x;
	cout << "Введите y =>"; cin >> y;
	cout << "Введите z =>"; cin >> z;
	_asm {

		mov ax, x
		mov bx, y
		mov cx, z 
		add bx, ax
		mov s1, bx
		cmp ax, bx
		jb Down
		ja Up
		je Ravno
		
		Down :
			mov dx, bx
			jmp KON
		
		Up :
			mov dx, ax
			jmp KON
		
		Ravno :
			mov dx, bx
			jmp KON
		
		KON :
			mov ax, y
			add ax, y
			add ax, y
			mov bx, z
			cmp ax, bx
			jb Down1
			ja Up1
			je Ravno1
		
		Down1 :
			mov cx, ax
			jmp KON1
		
		Up1 :
			mov cx, bx
			jmp KON1
		
		Ravno1 :
			mov cx, ax
			jmp KON1
		
		KON1 :
			mov s2, dx
			mov s3, cx
			add dx, cx
			mov z, dx
	}

	printf("\nBX = %i", s1);
	printf("\nDX (1-я часть) = %i", s2);
	printf("\nCX (2-я часть) = =%i", s3);
	printf("\nРезультат: %i\n\n", z);
	system("pause");
	
return 0;
}
