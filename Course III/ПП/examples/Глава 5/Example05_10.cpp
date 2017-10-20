#include <iostream>
using namespace std;
int main(){
char *p,*q;
p="Hello, World!";
q="Hello, World!"+7;
cout<<p<<endl;
cout<<q<<endl;
cout<<*p<<endl;
p++;
cout<<*p<<endl;
return 0;
}