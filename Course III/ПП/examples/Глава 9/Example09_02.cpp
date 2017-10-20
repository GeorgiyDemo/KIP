#include <iostream>
using namespace std;
class MyClass{
public:
int m,n;
//Конструктор класса с аргументами:
MyClass(int a,int b){
m=a;
n=b;}
void show(){
cout<<"m = "<<m<<endl;
cout<<"n = "<<n<<endl;}
};
int main(){
//При создании объекта указываются значения полей:
MyClass obj(1,2);
//Отображение значения полей объекта:
obj.show();
return 0;
}