#include <iostream>
#include <iomanip>
#include <conio.h>

char  k = 15;
char result;

void main() {

	setlocale(LC_ALL, "rus");
	printf("Входные данные       Выходные данные");

	for (k = 1; k < 19; k++) {
		result = 0;
		_asm {

			mov al, 0
			mov cx, 9
			mov dh, 1

		null:
			mov bx, cx
			mov cx, 10
			mov dl, 0
		one :
			mov ah, dh
			add ah, dl
			cmp ah, k
			jne two
			inc al

		two :
			inc dl
			loop one
			mov cx, bx
			inc dh
			loop null
			mov result, al
		
		}
		printf("\nk = %d                result = %d", k, result);
	}
	_getch();
}
