#include "stdafx.h"
#include <stdlib.h>
#include <locale.h>
#include <stdio.h>

char a = 28;
char n = 2;
char flag, c;
int main()
{
	setlocale(LC_ALL, "RUS");
	_asm {

		mov cl, n
		mov bl, a
		mov al, a

		dec cl

		repeat :
		mul bl
			jc error
			dec cl
			cmp cl, 0
			jne repeat
			jmp ok
			error :
		mov flag, 1
			jmp end
			ok :
		mov c, al
			end :
	}
	if (flag == 1) {
		printf("Исходные данные:\nа = %i\n", a);
		printf("n = %i\n", n);
		printf("\nОшибка переполнения\nПри n=%i следует работать со словом\n", n);
	}
	else {
		printf("Исходные данные:\nа = %i\n", a);
		printf("n = %i\n", n);
		printf("\nОтвет:\nДесятичная с/с: %i\n", c);
		printf("Шестнадцатеричная с/с: %x\n", c);
	}
	system("pause");
	return 0;
}