#include <iostream>
using namespace std;
//Обобщенная функция:
template <class X> void show(X arg){
cout<<"Value is "<<arg<<endl;}
int main(){
int n=5;
double x=3.6;
char s='a';
//Вызов обобщенной функции:
show(n);
show(x);
show(s);
return 0;}