#include <iostream>
#include <cmath>
using namespace std;
//Степень базового полинома:
const int n=5;
//Базовый класс:
class Polynom1{
public:
//Коэффициенты полинома:
double a[n+1];
//Перегрузка оператора []:
virtual double &operator[](int k){
return a[k];}
//Перегрузка оператора ():
virtual double operator()(double x){
int i;
double s=0;
for(i=0;i<=n;i++)
   s+=a[i]*pow(x,i);
return s;}
//Метод для отображения коэффициентов:
virtual void show(){
int i;
for(i=0;i<=n;i++)
   cout<<a[i]<<" ";
cout<<endl;}
}P1,P2,P3;
//Производный класс:
class Polynom2:public Polynom1{
public:
//"Дополнительные" коэффициенты:
double b[n];
//Переопределение оператора []:
double &operator[](int k){
if(k<=n) return a[k];
else return b[k-n-1];}
//Переопределение оператора ():
double operator()(double x){
int i;
double s=a[0];
for(i=1;i<=n;i++)
   s+=(a[i]*pow(x,i)+b[i-1]*pow(x,n+i));
return s;}
//Переопределение метода для отображения коэффициентов:
void show(){
int i;
for(i=0;i<=n;i++)
   cout<<a[i]<<" ";
for(i=0;i<n;i++)
   cout<<b[i]<<" ";
cout<<endl;}
}Q;
//Внешняя функция для вычисления произведения полиномов:
Polynom2 operator*(Polynom1 obj1,Polynom1 obj2){
Polynom2 tmp;
int i,j;
for(i=0;i<=n;i++){
   tmp[i]=0;
   for(j=0;j<=i;j++)
      tmp[i]=tmp[i]+obj1[j]*obj2[i-j];
}
for(i=n+1;i<=2*n;i++){
   tmp[i]=0;
   for(j=i-n;j<=n;j++)
      tmp[i]=tmp[i]+obj1[j]*obj2[i-j];
}
return tmp;}
int main(){
int i;
//Инициализация полиномов:
P1[0]=0;
P2[0]=1;
for(i=1;i<=n;i++){
   P1[i]=(double)(2*(i%2)-1)/i;
   P2[i]=(i+1)%2;
}
//Произведение полиномов:
Q=P1*P2;
//Ряд Тейлора:
P3=P1*P2;
P1.show();
P2.show();
Q.show();
P3.show();
//Проверка значений:
cout<<"P1: "<<P1(1)<<endl;
cout<<"P2: "<<P2(1)<<endl;
cout<<"P3: "<<P3(1)<<endl;
cout<<"Q:  "<<Q(1)<<endl;
cout<<"P1*P2: "<<P1(1)*P2(1)<<endl;
return 0;}