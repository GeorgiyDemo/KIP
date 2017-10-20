#include <iostream>
using namespace std;
class Demo{
public:
int n;
int m;
Demo(int i,int j){
n=i;
m=j;}
Demo(Demo &obj){
n=2*obj.n;
m=obj.m+3;}
void show(){
cout<<"n = "<<n<<endl;
cout<<"m = "<<m<<endl;}
};
int main(){
int i;
Demo a(1,0);
Demo b=a;
a.show();
b.show();
for(i=1;i<=4;i++){
   a=Demo(a);}
   a.show();
   return 0;
}