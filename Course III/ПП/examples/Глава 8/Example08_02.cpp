#include <iostream>
using namespace std;
class ClassA{
public:
double x;
double y;
}objA;
class ClassB{
public:
int a;
int b;
}objB;
ClassA sumAB(ClassA obj1,ClassB obj2){
ClassA tmp;
tmp.x=obj1.x+obj2.a;
tmp.y=obj1.y+obj2.b;
return tmp;
}
int main(){
ClassA obj;
objA.x=2.5;
objA.y=3.6;
objB.a=2;
objB.b=5;
//Результатом функции является объект:
obj=sumAB(objA,objB);
cout<<"x = "<<obj.x<<endl;
cout<<"y = "<<obj.y<<endl;
return 0;
}