#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
using namespace std;

unsigned char x;
//unsigned char x = 135;

int main()
{	
	setlocale(LC_ALL, "Russian");
	cout << "Введите x => "; cin >> x;
	_asm {

		mov al, x
		xor ah, ah
		shl ax, 1
		or al, ah
		mov bl, 8
		mul bl
		mov x, al
		
	}

	printf("Результат x = %i\n\n", x);
	system("pause");
    return 0;
}
