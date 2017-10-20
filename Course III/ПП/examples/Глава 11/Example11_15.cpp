#include <iostream>
using namespace std;
//Базовый класс:
class Compl1{
public:
//Действительная и мнимая часть:
double Re,Im;
//Перегрузка оператора сложения:
Compl1 operator+(Compl1 obj){
Compl1 tmp;
tmp.Re=Re+obj.Re;
tmp.Im=Im+obj.Im;
return tmp;}
//Конструктор с двумя аргументами:
Compl1(double x,double y){
Re=x;
Im=y;}
//Конструктор без аргументов:
Compl1(){
Re=0;
Im=0;}
}a1(1,2),a2,a3(3,4);
//Производный класс:
class Compl2:public Compl1{
public:
//Перегрузка оператора умножения:
Compl2 operator*(Compl2 obj){
Compl2 tmp;
tmp.Re=Re*obj.Re-Im*obj.Im;
tmp.Im=Re*obj.Im+Im*obj.Re;
return tmp;}
//Конструктор с аргументами:
Compl2(double x,double y):Compl1(x,y){}
//Конструктор без аргументов:
Compl2():Compl1(){}
}b1(10,20),b2(30,40),b3;
//Внешняя операторная функция:
Compl2 operator-(Compl1 x,Compl1 y){
Compl2 tmp;
tmp.Re=x.Re-y.Re;
tmp.Im=x.Im-y.Im;
return tmp;}
//Внешний метод для отображения полей объекта:
void show(Compl1 obj){
cout<<"Re: "<<obj.Re<<endl;
cout<<"Im: "<<obj.Im<<endl;}
int main(){
//Сумма объектов:
a2=a1+b1;
show(a2);
a2=b1+a1;
show(a2);
a2=b1+b2;
show(a2);
//Произведение объектов:
b3=b1*b2;
show(b3);
//Разность объектов:
a2=a1-a3;
show(a2);
b3=b1-b2;
show(b3);
return 0;}