#include <iostream>
using namespace std;
//Счетчик элементов дерева:
int Count=0;
//Структура-элемент дерева:
struct BinTree{
//Поля-указатели:
BinTree *p1;
BinTree *p2;
//Целочисленное поле:
int n;
};
//Функция создания бинарного дерева:
BinTree *MakeTree(int N){
//Указатель на создаваемый элемент:
BinTree *p;
p=new BinTree;
//Создание дерева:
Count++;
p->n=Count;
if(N>1){
p->p1=MakeTree(N-1);
p->p2=MakeTree(N-1);}
//Результат-указатель на созданный элемент:
return p;
}
int main(){
//Указатель на нулевой (начальный) элемент:
BinTree *q;
//Создание 4-х уровневого бинарного дерева:
q=MakeTree(4);
//Проверка результата. Количество элементов:
cout<<"Elements in tree: "<<Count<<endl;
//Элемент №1:
cout<<q->n<<endl;
//Элемент №2:
cout<<q->p1->n<<endl;
//Элемент №4:
cout<<q->p1->p1->p1->n<<endl;
//Элемент №7:
cout<<q->p1->p2->p1->n<<endl;
//Элемент №9:
cout<<q->p2->n<<endl;
//Элемент №10:
cout<<q->p2->p1->n<<endl;
//Элемент №15:
cout<<q->p2->p2->p2->n<<endl;
return 0;
}