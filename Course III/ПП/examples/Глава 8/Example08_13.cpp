#include <iostream>
using namespace std;
//Анонс класса:
class B;
//Класс с закрытым полем:
class A{
double x;
public:
A(double z){x=z;}
//Дружественная функция с двумя аргументами:
friend double summa(A a,B b);
}a(3.5);
//Класс с закрытым полем:
class B{
double y;
public:
B(double z){y=z;}
//Дружественная функция с двумя аргументами:
friend double summa(A a,B b);
}b(2.3);
double summa(A a,B b){
return a.x+b.y;
}
int main(){
//Вызов дружественной функции:
cout<<"Total is "<<summa(a,b)<<endl;
return 0;
}