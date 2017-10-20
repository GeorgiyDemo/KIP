#include <iostream>
using namespace std;
int main(){
int a,b;
cout<<"Enter a = ";
cin>>a;
cout<<"Enter b = ";
cin>>b;
if(b==0) cout<<"Division by zero!\n";
else cout<<"a/b = "<<(double)a/b<<endl;
return 0;}