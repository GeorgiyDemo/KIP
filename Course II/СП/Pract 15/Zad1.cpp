#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h>
#include <locale.h>
using namespace std;

int i;
unsigned char z, o, s, c;
void input(unsigned short a, unsigned short b)
{
	c = o = s = z = 0;
	
	_asm {

		mov bx, b
		mov ax, a
		cmp ax, bx

		jb CARRY
		ODIN :
			jo OVER
		DVA :
			js SIGN
		TRI :
			jz ZERO
			jmp END
		CARRY :
			mov c, 1
			jmp ODIN
		OVER :
			mov o, 1
			jmp DVA
		SIGN :
			mov s, 1
			jmp TRI
		ZERO :
			mov z, 1
		END :
	}
	printf("C(carry) = %i, O(overflow) = %i, S(sign) = %i, Z(zero) = %i\n", c, o, s, z);
}
int main()
{
	setlocale(LC_ALL, "RUS");
	for (i = 0; i < 100; i++) {
		printf("___________________________\nИсходные данные:\na = %d\nb = 
80\nФлаги:\n", i);
		input(i, 80);
	}
	system("pause");
	return 0;
}
