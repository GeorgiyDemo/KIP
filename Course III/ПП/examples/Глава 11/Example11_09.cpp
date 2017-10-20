#include <iostream>
using namespace std;
//Базовый класс:
class A{
public:
int n;
};
//Первый производный класс (виртуальное наследование):
class B: virtual public A{
public:
void show(){
cout<<"n = "<<n<<endl;}
};
//Второй производный класс (виртуальное наследование):
class C: virtual public A{
public:
void get(){
cout<<"n = "<<n<<endl;}
};
//Производный класс на основе двух базовых:
class D: public B, public C{
public:
void showAll(){
show();
get();}
};
int main(){
D obj;
obj.n=10;
obj.showAll();
return 0;}