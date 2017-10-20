#include <iostream>
using namespace std;
int main(){
int a,b;
double x,y;
try{
   cout<<"Enter a = ";
   cin>>a;
   cout<<"Enter b = ";
   cin>>b;
   if(b==0) throw b;
   x=(double)a/b;
   y=x-a/b;
   if(y==0) throw y;
   cout<<" a/b  = "<<x<<endl;
   cout<<"[a/b] = "<<a/b<<endl;
   cout<<"{a/b} = "<<y<<endl;}
catch(int e){
   cout<<"Division by "<<e<<" (zero)!\n";}
catch(double e){
   cout<<"a/b is integer! Rest is "<<e<<" (zero)!\n";}
return 0;}