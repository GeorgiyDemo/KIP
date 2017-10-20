#include <iostream>
using namespace std;
int main(){
int a,b;
try{
   cout<<"Enter a = ";
   cin>>a;
   cout<<"Enter b = ";
   cin>>b;
   if(b==0) throw b;
   cout<<"a/b = "<<(double)a/b<<endl;
}catch(int e){
   cout<<"Division by zero!\n";}
return 0;}