#include <iostream>
using namespace std;
//Анонс класса:
class B;
//Класс с закрытым полем и методом:
class A{
double x;
public:
A(double z){x=z;}
double summa(B b);
}a(3.5);
//Класс с закрытым полем и дружественным методом:
class B{
double y;
public:
B(double z){y=z;}
//Дружественный метод:
friend double A::summa(B b);
}b(2.3);
int main(){
//Вызов дружественного метода:
cout<<"Total is "<<a.summa(b)<<endl;
return 0;
}
double A::summa(B b){
return x+b.y;}