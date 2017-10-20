#include <iostream>
using namespace std;
class MyClass{
public:
double x;
};
//Передача аргумента по значению:
double f1(MyClass obj){
obj.x*=10;
return obj.x;
}
//Передача аргумента по ссылке:
double f2(MyClass &obj){
obj.x*=10;
return obj.x;
}
int main(){
MyClass obj;
obj.x=5;
cout<<"x = "<<f1(obj)<<endl;
cout<<"x = "<<obj.x<<endl;
cout<<"x = "<<f2(obj)<<endl;
cout<<"x = "<<obj.x<<endl;
return 0;
}