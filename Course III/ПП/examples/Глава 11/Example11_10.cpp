#include <iostream>
using namespace std;
class Base{
public:
int n;
Base(int i){n=i;}
};
class Derivative:public Base{
public:
int m;
Derivative(int i,int j):Base(i){m=j;}
};
int main(){
Base obj1(1);
Derivative obj2(2,3);
cout<<"obj1.n = "<<obj1.n<<endl;
cout<<"obj2.n = "<<obj2.n<<endl;
cout<<"obj2.m = "<<obj2.m<<endl;
return 0;
}