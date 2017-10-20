#include<iostream>
using namespace std;
class SimpleClass{
public:
int m;
int n;
//ќбъ€вление метода в классе (прототип метода):
void show();
};
int main(){
SimpleClass obj;
obj.m=1;
obj.n=2;
obj.show();
return 0;}
//ќписание метода класса:
void SimpleClass::show(){
cout<<"m = "<<m<<endl;
cout<<"n = "<<n<<endl;}