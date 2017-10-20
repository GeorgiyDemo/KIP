#include <iostream>
using namespace std;
//Базовый класс:
class A{
protected:
int x;
public:
virtual void set(int i){x=i;}
virtual void get(){
cout<<"x = "<<x<<endl;}
};
//Производный класс:
class B: public A{
private:
int y;
public:
//Переопределение метода:
void set(int i){
x=i;
y=i;}
//Перегрузка метода:
void set(int i,int j){
x=i;
y=j;}
//Переопределение метода:
void get(){
cout<<"x = "<<x<<endl;
cout<<"y = "<<y<<endl;}
};
int main(){
A a;
B b;
a.set(1);
a.get();
b.set(2);
b.get();
b.set(3,4);
b.get();
return 0;}