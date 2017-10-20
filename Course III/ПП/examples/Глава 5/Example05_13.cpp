#include <iostream>
using namespace std;
int main(){
int *p;
double *q;
p=new int;
q=new double(3.6);
cout<<"Enter int-number: ";
cin>>*p;
cout<<"Address: "<<p<<endl;
cout<<"Value: "<<*p<<endl;
cout<<"Address: "<<q<<endl;
cout<<"Value: "<<*q<<endl;
delete p;
delete q;
return 0;
}