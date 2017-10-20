#include <iostream>
using namespace std;
//Базовый класс A:
class A{
public:
int n;
virtual void set(int i){
n=i;}
virtual void get(){
cout<<"n = "<<n<<endl;}
};
//Производный класс B:
class B: public A{
public:
int m;
void set(int i){
n=i;
m=i;}
};
//Производный класс C:
class C: public B{
public:
void get(){
cout<<"n-value is "<<n<<endl;
cout<<"m-value is "<<m<<endl;}
};
//Производный класс D:
class D: public C{
public:
int k;
};
int main(){
A a;
B b;
C c;
D d;
a.set(1);
b.set(2);
c.set(3);
d.set(4);
a.get();
b.get();
c.get();
d.get();
return 0;}