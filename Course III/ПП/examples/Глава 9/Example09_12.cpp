#include <iostream>
using namespace std;
//Класс с закрытыми полями:
class MyExp{
double x;
double xexp;
//Закрытый метод для вычисления экспоненты:
double mexp(double z){
double s=1,q=z;
for(int i=1;i<=100;i++){
   s+=q;
   q*=z/(i+1);}
return s;}
public:
//Открытый метод для изменения значения полей:
void set(double z){
x=z;
xexp=mexp(x);}
//Конструктор с вызовом открытого метода:
MyExp(double z){
set(z);}
//Перегруженный метод для отображения полей:
double get(){
return x;}
double get(int k){
return xexp;}
};
int main(){
double x=1;
MyExp obj(x);
cout<<"x = "<<obj.get()<<endl;
cout<<"exp(x) = "<<obj.get(0)<<endl;
return 0;}