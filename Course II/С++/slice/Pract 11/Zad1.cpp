#include <stdio.h>;
#include <iostream>;
#include <math.h>;
using namespace std;
int main(){

  int x,y;
  long double c;
  printf("x="); scanf("%d",&x);
  printf("y="); scanf("%d",&y);
  c=log10((y-sqrt(log10(x)))*(x-(y/(x+pow(x,2)/4))));
  printf("Result: => %d",c);
	 
}