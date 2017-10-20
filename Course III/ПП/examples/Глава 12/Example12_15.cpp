#include <iostream>
using namespace std;
//Количество веток дерева:
const int n=2;
//Обобщенный класс:
template <class X> class MyTree{
public:
//Обобщенное поле:
X record;
//Массив указателей:
MyTree *pnt[n];
//Конструктор:
MyTree(int k){
int i;
if(k==1)
   for(i=0;i<n;i++) pnt[i]=NULL;
else
   for(i=0;i<n;i++) pnt[i]=new MyTree(k-1);
cout<<"created: "<<this<<endl;
for(i=0;i<n;i++)
   cout<<i<<": "<<pnt[i]<<endl;
cout<<endl;}
//Деструктор:
~MyTree(){
int i;
for(i=0;i<n;i++)
   delete pnt[i];
cout<<"deleted: "<<this<<endl;
}
};
int main(){
//Указатель на первый объект дерева:
MyTree<double> *input;
//Создание дерева:
input=new MyTree<double>(3);
//Обращение к полю record объекта дерева:
input->pnt[1]->record=3.1415;
cout<<endl;
cout<<input->pnt[1]<<": record=";
cout<<(*(*input).pnt[1]).record<<endl;
cout<<endl;
//Удаление дерева:
delete input;
return 0;}