#include <iostream>
using namespace std;
struct BitFields{
unsigned int state:1;
int n:2;
int m;
} str;
int main(){
cout<<"Enter a number: ";
cin>>str.m;
str.state=str.m%2;
str.n=str.m%4-2;
cout<<"state = "<<str.state<<endl;
cout<<"n ="<<str.n<<endl;
return 0;
}