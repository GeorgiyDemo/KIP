#include <iostream>
#include <cmath>
using namespace std;
//Степень полинома:
const int n=4;
//Класс для реализации полинома:
class Polynom{
public:
//Коэффициенты полинома в точке:
double a[n+1];
//Значение полинома:
double P(double x){
double s=0;
int i;
for(i=0;i<=n;i++) s+=a[i]*pow(x,i);
return s;
}
//Производная:
Polynom Deriv(){
Polynom tmp;
int i;
tmp.a[n]=0;
for(i=n-1;i>=0;i--) tmp.a[i]=a[i+1]*(i+1);
return tmp;}
};
//Отображение таблицы значений:
void show(Polynom obj,double x1,double x2){
double h=(x2-x1)/5;
int i;
cout<<"x:    ";
for(i=0;i<=5;i++)
   printf("%12f",x1+i*h);
cout<<endl<<"P(x): ";
for(i=0;i<=5;i++)
   printf("%12f",obj.P(x1+i*h));
cout<<endl;
}
int main(){
//Полином и его производные:
Polynom Q1,Q2,Q3;
int i;
for(i=0;i<=n;i++) Q1.a[i]=1;
//Первая производная:
Q2=Q1.Deriv();
//Вторая производная:
Q3=Q2.Deriv();
show(Q1,0,1);
show(Q2,0,1);
show(Q3,0,1);
return 0;}