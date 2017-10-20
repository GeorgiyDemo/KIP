#include<iostream>
using namespace std;
//Объявление класса SimpleClass:
class SimpleClass{
public:
//Целочисленные поля класса:
int m;
int n;
//Метод для вычисления суммы полей:
int summa(){
int k=n+m;
return k;
}
//Метод для отображения значений полей:
void show(){
cout<<"m = "<<m<<endl;
cout<<"n = "<<n<<endl;
}
//Метод для умножения полей на число:
void mult(int k){
n*=k;
m*=k;
}
};
int main(){
//Создание объектов MyObj1 и MyObj2 класса SimpleClass:
SimpleClass MyObj1,MyObj2;
//Полям объектов присваиваются значения:
MyObj1.m=1;
MyObj1.n=2;
MyObj2.m=8;
MyObj2.n=9;
//Сумма полей для разных объектов:
cout<<"Total value for MyObj1 is "<<MyObj1.summa()<<endl;
cout<<"Total value for MyObj2 is "<<MyObj2.summa()<<endl;
//Умножение полей объектов на число:
MyObj1.mult(3);
MyObj2.mult(2);
//Отображение значений полей объектов:
MyObj1.show();
MyObj2.show();
return 0;
}