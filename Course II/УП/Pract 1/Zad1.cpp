#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
using namespace std;

int main(){
 
float x,y,x1,y1,procent;

cout<<"Введите цены на товар №1 => "; cin>>x;
cout<<"Введите цены на товар №2 => "; cin>>y;
cout<<"Введите кол-во процентов P =>"; cin>>procent;

cout<<"\n-Старая цена-\nТовар №1: "<<x<<"\nТовар №2: "<<y<<"\n";

x1=x*(100.0+procent)/100.0;
y1=y*(100.0+procent)/100.0;

cout<<"\n-Новая цена-\nТовар №1: "<<x1<<"\nТовар №2: "<<y1<<"\n";

return 0;
}