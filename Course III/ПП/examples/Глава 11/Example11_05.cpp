#include <iostream>
using namespace std;
class A{
public:
int n;
int f(){return 2*n;}
void show(){cout<<"show(): "<<f()<<endl;}
};
class B: public A{
public:
int f(){return n/2;}
};
int main(){
A a;
a.n=3;
B b;
b.n=10;
a.show();
b.show();
cout<<"a.f(): "<<a.f()<<endl;
cout<<"b.f(): "<<b.f()<<endl;
return 0;}