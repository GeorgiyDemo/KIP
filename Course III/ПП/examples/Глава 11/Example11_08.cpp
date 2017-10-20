#include <iostream>
using namespace std;
//Первый базовый класс:
class A{
public:
int n;
void shown(){
cout<<"n = "<<n<<endl;}
};
//Второй базовый класс:
class B{
public:
int m;
void showm(){
cout<<"m = "<<m<<endl;}
};
//Производный класс на основе двух базовых:
class C: public A, public B{
public:
void show(){
shown();
showm();}
};
int main(){
C obj;
obj.n=3;
obj.m=5;
obj.show();
}