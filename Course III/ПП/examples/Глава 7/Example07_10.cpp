#include <iostream>
#include <cmath>
using namespace std;
class Compl{
public:
double Re;
double Im;
double modul(){
double r;
r=sqrt(Re*Re+Im*Im);
return r;}
double argument(){
double phi;
phi=atan2(Re,Im);
return phi;}
};
int main(){
Compl z;
z.Re=sqrt(3);
z.Im=-1;
cout<<"|z| = "<<z.modul()<<endl;
cout<<"phi = "<<z.argument()<<endl;
return 0;}