#include "stdafx.h"
#include "iostream"
using namespace std;

unsigned short x, y, z;

int main() {
	setlocale(LC_ALL, "rus");
	cout << "¬ведите x =>"; cin >> x;
	cout << "¬ведите y =>"; cin >> y;
	cout << "¬ведите z =>"; cin >> z;
	_asm {

		mov ax, x
		mov bx, y
		mov cx, z
		add bx, ax
		add ax, ax
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
			add dx, cx
			mov z, dx
	}

	printf("–езультат: %i\n\n", z);
	system("pause");
	
return 0;
}