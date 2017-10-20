#include <iostream>
#include <cmath>
using namespace std;
const double pi=3.1415;
class Figure{
public:
double R;
Figure(){R=1;}
virtual double area()=0;
};
class Circle:public Figure{
public:
double area(){
return pi*R*R;}
};
class Square:public Figure{
public:
double area(){
return R*R;}
};
class Triangle:public Figure{
public:
double area(){
return sqrt(3)*R*R/4;}
};
int main(){
Circle A;
Square B;
Triangle C;
cout<<"Circle: "<<A.area()<<endl;
cout<<"Square: "<<B.area()<<endl;
cout<<"Triangle: "<<C.area()<<endl;
return 0;}