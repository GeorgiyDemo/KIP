#include <iostream>
using namespace std;
//Обобщенная функция:
template <class X> X MySum(X a,X b){
return a+b;}
//Перегрузка обобщенной функции:
template <class X> X MySum(X a){
return a+1;}
int main(){
int n=2,m=4;
double x=4.2,y=3.4;
char s='a';
//Вызов обобщенной функции:
cout<<MySum(n,m)<<endl;//Результат: 6
cout<<MySum(x,y)<<endl;//Результат: 7.6
cout<<MySum(s)<<endl;//Результат: b
return 0;}