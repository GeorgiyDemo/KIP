#include <iostream>
using namespace std;
//Класс с закрытым полем, конструктором и деструктором:
class Demo{
int n;
public:
Demo(int m){
n=m;
cout<<"Constructor: "<<this<<endl;}
void setn(int m){n=m;}
void getn(){
cout<<"n = "<<n<<endl;
cout<<"Object: "<<this<<endl;
}
~Demo(){
cout<<"Destructor: "<<this<<endl;}
};
int main(){
//Создание объекта:
Demo a(1);
//Создание объекта с явным вызовом конструктора:
Demo b=Demo(2);
//Проверка значений:
a.getn();
b.getn();
//Изменение значения поля с помощью метода класса:
a.setn(-1);
//Проверка значений:
a.getn();
//Копирование объектов:
a=b;
//Проверка результата копирования:
a.getn();
//Изменение значения поля с помощью конструктора:
a=Demo(0);
//Проверка результата:
a.getn();
return 0;
}