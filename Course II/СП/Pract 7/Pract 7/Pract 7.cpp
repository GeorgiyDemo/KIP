#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h>
#include <iostream>

unsigned char x = 128 + 7;

int main()
{	
	setlocale(LC_ALL, "Russian");
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
