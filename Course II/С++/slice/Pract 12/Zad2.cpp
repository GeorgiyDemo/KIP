#include <stdio.h>
#include <math.h>

int main(){

  int n,m,st,k;
  double x,y,eps,p,a,drob;

  p = 1;

  for (n=34, m=3, st=2; n>10; n-=4, m+=4, st++){
    p=(1 + pow(sin(n), st))/m;
  }

  printf("P = %lf", p); //Выводим З
  
  do{
    printf("\nEnter x "); scanf("%lf", &x);}
  while (x*x>=1);

  printf("\nEnter eps "); scanf("%lf", &eps);//Вводим эпсилу, че?
  y = pow(1+x, -0.5);
  
  printf("Y = %lf", y);
  k = 0;
  a = 1;
  p = 1;

  while (fabs(y-a) > eps){
    k = k+1;
    double drob=(double)(k+k-1)/(k+k);
    
    p = p*pow(-x, k)*drob;
    a = a+p;
    printf("\na[%d] = %lf, error: %lf", k, a, y-a);// Вывод чего-то
    if (k>30) //если k>30, то стопаем
        break;
  }
}
