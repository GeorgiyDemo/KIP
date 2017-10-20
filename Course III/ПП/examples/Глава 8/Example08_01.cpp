#include <iostream>
using namespace std;
//Первый класс:
class ClassA{
public:
double x;
double y;
}objA;
//Второй класс:
class ClassB{
public:
int a;
int b;
//Методу объектом передается объект:
double f(ClassA obj){
return a*obj.x+b*obj.y;
}
}objB;
//Внешняя функция с аргументом-объектом:
void showB(ClassB obj){
cout<<"a = "<<obj.a<<endl;
cout<<"b = "<<obj.b<<endl;
}
int main(){
objA.x=2.5;
objA.y=3.6;
objB.a=2;
objB.b=5;
cout<<"Value is "<<objB.f(objA)<<endl;
showB(objB);
return 0;
}