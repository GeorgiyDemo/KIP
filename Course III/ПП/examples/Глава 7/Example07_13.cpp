#include <iostream>
#include <cmath>
using namespace std;
const double g=9.8;
const double pi=3.1415;
class Body{
double T(){
return 2*V0*sin(alpha)/g;}
public:
double V0;
double alpha;
double x(double t){
if(t<=T()) return V0*cos(alpha)*t;
else return V0*cos(alpha)*T();}
double y(double t){
if(t<=T()) return V0*sin(alpha)*t-g*t*t/2;
else return 0;}
double Vx(double t){
if(t<=T()) return V0*cos(alpha);
else return 0;}
double Vy(double t){
if(t<=T()) return V0*sin(alpha)-g*t;
else return 0;}
void show(double t){
printf("%s%f%s%9f%s%9f%s%9f%s%9f%s","t=",t,":  x=",x(t),"  y=",y(t),"  Vx=",Vx(t), "  Vy=",Vy(t),"\n");}
};
int main(){
int i;
Body obj;
obj.V0=10;
obj.alpha=pi/3;
for(i=0;i<10;i++) obj.show(0.2*i);
return 0;}