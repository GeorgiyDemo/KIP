#include <iostream>
const N=100;
using namespace std;
//Класс для реализации комплексных чисел:
class Complex{
public:
double Re,Im;
//Перегрузка оператора присваивания:
Complex operator=(double x){
Re=x;
Im=0;
return *this;}
//Перегрузка оператора умножения:
Complex operator*(Complex obj){
Complex tmp;
tmp.Re=Re*obj.Re-Im*obj.Im;
tmp.Im=Re*obj.Im+Im*obj.Re;
return tmp;}
//Перегрузка оператора сложения:
Complex operator+(Complex obj){
Complex tmp;
tmp.Re=Re+obj.Re;
tmp.Im=Im+obj.Im;
return tmp;}
//Перегрузка оператора деления:
Complex operator/(double x){
Complex tmp;
tmp.Re=Re/x;
tmp.Im=Im/x;
return tmp;}
};
//Шаблонная функция для определения экспоненты:
template <class X> X mExp(X t){
X s;
s=1;
X q=t;
int i;
for(i=1;i<=N;i++){
   s=s+q;
   q=q*t/(i+1);
}
return s;}
int main(){
Complex z;
z.Re=1;
z.Im=2;
cout<<"exp("<<z.Re<<"+"<<z.Im<<"i)="<<mExp(z).Re<<"+"<<mExp(z).Im<<"i"<<endl;
cout<<"exp(1.0)="<<mExp(1.0)<<endl;
cout<<"exp(1)="<<mExp(1)<<endl;
return 0;}