#include <iostream>
#include <cmath>
using namespace std;
class MyLog{
public:
double x;
int N;
double Ln(){
double s=0,q=x;
int i;
for(i=1;i<=N;i++){
   s+=q/i;
   q*=-x;}
return s;
}
};
int main(){
MyLog a;
cout<<"Enter x = ";
cin>>a.x;
cout<<"Enter N = ";
cin>>a.N;
cout<<"ln("<<1+a.x<<") = "<<a.Ln()<<endl;
cout<<"ln("<<1+a.x<<") = "<<log(1+a.x)<<endl;
return 0;}