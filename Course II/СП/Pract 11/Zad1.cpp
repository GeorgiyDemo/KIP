#include <iostream>
#include <iomanip>
#include <conio.h>


char kol=0,k = 18;

void main() {

	setlocale(LC_ALL, "rus");

	_asm {

		mov bh, k

		mov cx, 9
		m1: mov dx, cx
			mov cx, 9
			m2 : mov ax, dx
	
				 add ax, cx
				 cmp ax, bh
				 je e1
				 jmp e2
				 e1 : add kol,1
					  e2 : loop m2
						   mov cx, dx
						   jcxz m1
	}
	printf("%d", kol);
	_getch();
}
