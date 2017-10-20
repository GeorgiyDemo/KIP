#include <iostream>
using namespace std;
class MyClass{
public:
int n;
int m;
void show(){
cout<<"m = "<<this->m<<endl;
cout<<"n = "<<this->n<<endl;}
void setmn(int m,int n){
this->m=m;
this->n=n;}
MyClass change(){
int k;
k=m;
m=n;
n=k;
return *this;}
};
int main(){
MyClass a,b;
a.setmn(10,20);
b=a.change();
a.show();
b.show();
return 0;
}