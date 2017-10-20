#include <iostream>
using namespace std;
class A{
int m;
public:
A(int i){m=i;}
void getm(){
cout<<"m = "<<m<<endl;}
};
class B:public A{
public:
int n;
B(int i,int j):A(i){n=j;}
void getnm(){
getm();
cout<<"n = "<<n<<endl;}
};
int main(){
B obj(10,20);
obj.getnm();
return 0;}