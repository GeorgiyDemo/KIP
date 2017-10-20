#include <iostream>
#include <cmath>
using namespace std;
struct Point{
double x;
double y;
double z;
};
double dist(Point A,Point B){
double s;
s=sqrt(pow(A.x-B.x,2)+ pow(A.y-B.y,2)+ pow(A.z-B.z,2));
return s;}
int main(){
Point A,B;
A.x=1; A.y=1; A.z=1;
B.x=3; B.y=2; B.z=-1;
cout<<"Distance is "<<dist(A,B)<<endl;
return 0;}