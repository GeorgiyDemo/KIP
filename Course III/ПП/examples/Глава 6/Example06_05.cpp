#include <iostream>
using namespace std;
//У структуры два поля: целое число и
//указатель на переменную структуры:
struct DList{
int m;
DList *p;
};
//Функция получения доступа к элементу динамического списка:
void getm(int k,DList *q){
int i;
DList *t,*t1;
t=q;
for(i=1;i<k;i++){
   t1=t->p;
   t=t1;}
cout<<"Value is "<<t->m<<endl;}
int main(){
int i,n,k;
DList *q0,*q1,*q2;
//Создание начального элемента списка:
q0=new DList;
q1=q0;
//Определение количества элементов списка:
cout<<"Enter n= ";
cin>>n;
//Создание динамического списка:
for(i=1;i<n;i++){
   cout<<"Value m= ";
   cin>>q1->m;
   q2=new DList;
   q1->p=q2;
   q1=q2;
}
cout<<"Value m= ";
cin>>q1->m;
//Последний элемент списка ссылается на начальный элемент:
q1->p=q0;
//Вывод значений целочисленных полей элементов списка:
do{
   cout<<"Value for index k= ";
   cin>>k;
   //Для завершения программы нужно ввести 0:
   if(!k){
      for(i=1;i<=n;i++){
         q1=q2->p;
         delete q2;
         q2=q1;
         }
   return 0;
   }
   getm(k,q0);
}while(true);
}