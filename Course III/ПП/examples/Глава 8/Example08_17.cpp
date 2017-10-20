#include <iostream>
using namespace std;
//Класс для объектов-элементов списка:
class Numbers{
public:
int n;
Numbers *p;
};
//Функция для создания списка:
Numbers *make(int N){
Numbers *p1,*p2;
int i;
p1=new Numbers;
p1->n=1;
p1->p=NULL;
for(i=2;i<=N;i++){
   p2=new Numbers;
   p2->n=i;
   p2->p=p1;
   p1=p2;}
return p1;}
//Функция для отображения элементов списка:
void showAll(Numbers *q){
do{
   cout<<q->n<<" : "<<q<<endl;
   q=q->p;
}while(q!=NULL);
}
//Функция для удаления списка из памяти:
void deleteAll(Numbers *q){
Numbers *q1;
do{
   q1=q;
   cout<<"deleted: "<<q<<endl;
   q=q1->p;
   delete q1;
}while(q!=NULL);
}
int main(){
int n;
Numbers *q;
cout<<"Enter n = ";
cin>>n;
q=make(n);
showAll(q);
deleteAll(q);
return 0;}