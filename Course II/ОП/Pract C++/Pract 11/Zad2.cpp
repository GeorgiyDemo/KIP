#include <stdio.h>
#include <iostream>
using namespace std;
int main(){

  int x,y,sum,raz,proiz;
    float fix;
    float chast;
    printf("x="); scanf("%d",&x);
  printf("y="); scanf("%d",&y);
	
  sum=x+y;
  raz=x-y;
  proiz=x*y;
  chast=x/y;

  printf("Результат:\nСумма => %d\nРазность => %d\nПроизведение => %d\nЧастное => %fl",sum,raz,proiz,chast);
	 
}