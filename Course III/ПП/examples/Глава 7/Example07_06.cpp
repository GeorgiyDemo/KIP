#include<iostream>
using namespace std;
class SimpleClass{
public:
//Статическое поле:
static int m;
//Нестатическое поле:
int n;
void show();
}obj1,obj2;
//Повторное объявление переменной:
int SimpleClass::m;
int main(){
SimpleClass::m=10;
obj1.n=1;
obj2.n=2;
obj1.show();
obj2.show();
obj1.m=100;
obj2.show();
return 0;}
//Описание метода:
void SimpleClass::show(){
cout<<"Static field m = "<<m<<endl;
cout<<"Nonstatic field n = "<<n<<endl;}