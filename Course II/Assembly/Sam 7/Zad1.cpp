#include "stdafx.h"
#include "iostream"
using namespace std;

void main()
{	setlocale(LC_ALL,"rus");
	 unsigned  int  a= 12345678; 
	 int d;
 	 short e;
	 char b, c;
	_asm
	{
	mov eax,a;
	mov  b,al;
	mov c, ah;
	mov e,ax;
	mov d,eax;
	}
	printf ("a=%x\n",a);
	printf ("eax= %i  ax=  %i ah=  %i  al= %i", d,e, c,b);
		
}