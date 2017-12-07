#include "stdafx.h"
#include "iostream"
using namespace std;
void main()
{
	setlocale(LC_ALL, "rus");
	int a, b, res;
	printf("\Введите a ");
	scanf_s("%i", &a);
	printf("\Введите b ");
	scanf_s("%i", &b);

	_asm
	{  	
		mov eax, a
		mov ebx, b

		cmp eax, 2
		jge m1
		
		imul ebx,ebx
		mov res, ebx
		jmp m
		
		m1 : add eax, 10
		mov res, eax

		m : 
	}

	printf("\n %d %d  %d \n", a, b, res);
	system("pause");
}

