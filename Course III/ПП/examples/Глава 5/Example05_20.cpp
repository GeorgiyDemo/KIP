#include <iostream>
#include <cmath>
using namespace std;
//Функция, определяющая уравнение:
double phi(double x){
return sqrt(1+x);}
//Функция для отображения значений массива:
void show(double *x,int n){
int i;
for(i=0;i<n;i++)
   cout<<"x"<<i<<" = "<<x[i]<<endl;
}
int main(){
//Индексная переменная и число итераций:
int i,n;
//Массив приближений для корня:
double *x;
cout<<"Enter n = ";
cin>>n;
//Создание массива:
x=new double[n+1];
//Начальное приближение:
cout<<"Enter x0 = ";
cin>>x[0];
//Вычисление корня:
for(i=1;i<=n;i++) x[i]=phi(x[i-1]);
//Отображение результата:
show(x,n+1);
return 0;
}