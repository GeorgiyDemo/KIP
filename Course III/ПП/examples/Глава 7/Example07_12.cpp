#include <iostream>
#include <cmath>
using namespace std;
class Eqns{
public:
double x0;
int n;
double phi(double x){
return 0.8*cos(x);}
double root(){
double s=x0;
int i;
for(i=1;i<=n;i++) s=phi(s);
return s;}
};
int main(){
Eqns obj;
obj.x0=0;
obj.n=100;
cout<<"x = "<<obj.root()<<endl;
return 0;}