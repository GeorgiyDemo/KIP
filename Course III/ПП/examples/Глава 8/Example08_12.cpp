#include <iostream>
using namespace std;
//Класс с закрытым полем:
class MyClass{
double x;
public:
MyClass(double z){x=z;}
//Дружественная функция:
friend void show(MyClass obj);
};
//Описание дружественной функции:
void show(MyClass obj){
cout<<"x = "<<obj.x<<endl;}
int main(){
MyClass a(10);
//Дружественная функция имеет доступ к закрытым членам:
show(a);
return 0;
}