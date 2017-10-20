#include <iostream>
using namespace std;
class MyClass{
public:
int m,n;
//Конструктор класса:
MyClass(){
m=0;
n=0;}
void show(){
cout<<"m = "<<m<<endl;
cout<<"n = "<<n<<endl;}
};
int main(){
//При создании класса поля получают значения:
MyClass obj;
//Отображение полей объекта:
obj.show();
return 0;
}