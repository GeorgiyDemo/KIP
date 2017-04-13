#include <stdio.h>
#include <iostream>
using namespace std;

bool validation(int s1, int s2, int s3) {
    return (s1==s2) || (s1==s3) || (s2==s3) ? true : false;
}

int main(){

  int a,b,c;
  bool trigger;

  printf("a="); scanf("%d",&a);
  printf("b="); scanf("%d",&b);
  printf("c="); scanf("%d",&c);
  trigger = validation(a,b,c);
  printf("\nРезультат: ");
    (trigger == 1) ? cout<<"True" : cout<<"False";
	 
}