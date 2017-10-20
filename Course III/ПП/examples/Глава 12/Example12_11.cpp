#include <iostream>
using namespace std;
class A{
public:
int k;
A operator+(A obj){
A tmp;
tmp.k=k+obj.k;
return tmp;}
void show(){
cout<<"k = "<<k<<endl;}
};
class B{
public:
double x,y;
B operator+(B obj){
B tmp;
tmp.x=x+obj.x;
tmp.y=y+obj.y;
return tmp;}
void show(){
cout<<"x = "<<x<<endl;
cout<<"y = "<<y<<endl;}
};
template <class X> class MyTempl{
public:
X res;
MyTempl operator+(MyTempl obj){
MyTempl tmp;
tmp.res=res+obj.res;
return tmp;}
void show(){
res.show();}
};
int main(){
MyTempl<A> a1,a2,a3;
MyTempl<B> b1,b2,b3;
a1.res.k=1;
a2.res.k=2;
b1.res.x=10.1;
b1.res.y=100.1;
b2.res.x=20.2;
b2.res.y=200.2;
a3=a1+a2;
b3=b1+b2;
a3.show();
b3.show();
return 0;}