#include <stdlib.h> 
#include <stdio.h> 

int main() { 

unsigned short a[6]; 

unsigned short sum = 0; 

for (short i = 0; i < 6; i++) a[i] = i; 

_asm { 
mov cx, 5 
mov ebx, 0 
mov ax, 0 
cycle: 
add ebx,2 
add ax, a[ebx] 
loop cycle 
mov sum,ax 
} 

printf("%i", sum); 
system("pause"); 

}
