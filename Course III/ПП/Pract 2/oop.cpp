/*Вопросы:
1) Каким образом в C++ реализуются текстовые строки
2) Как текстовая строка реализуется в виде символьного массива
3) Как динамически выделяется память для массива

*/
#include <iomanip>
#include <iostream>
#include <string>
#include <math.h>
using namespace std;
//Счетчик элементов дерева:
int Count = 0;
//Структура-элемент дерева:

class tree {

public:
    //Поля-указатели:
    tree* p1;
    tree* p2;
    tree* p3;
    tree* p4;
    //Целочисленное поле:
    int n;

    //Функция создания бинарного дерева:
    tree* MakeTree(int N)
    {
        //Указатель на создаваемый элемент:
        tree* p;
        p = new tree;
        //Создание дерева:
        Count++;
        p->n = Count;
        if (N > 1) {

            p->p1 = MakeTree(N - 1);
            p->p2 = MakeTree(N - 1);
            p->p1->p3 = MakeTree(N - 1);
            p->p2->p4 = MakeTree(N - 1);
        }
        //Результат-указатель на созданный элемент:
        return p;
    }
};

//Функция создания бинарного дерева:
tree* MakeTree(int N)
{
    //Указатель на создаваемый элемент:
    tree* p;
    p = new tree;
    //Создание дерева:
    Count++;
    p->n = Count;
    if (N > 1) {

        p->p1 = MakeTree(N - 1);
        p->p2 = MakeTree(N - 1);
        p->p1->p3 = MakeTree(N - 1);
        p->p2->p4 = MakeTree(N - 1);
    }
    //Результат-указатель на созданный элемент:
    return p;
}
int main()
{
    //Указатель на нулевой (начальный) элемент:
    tree q;
    //Создание 4-х уровневого бинарного дерева:
    cout << q.MakeTree(3);
    //Проверка результата. Количество элементов:
    //cout << "Elements in tree: " << Count << endl;
    //Элемент №1:
    cout <<"\n" << q.n << endl;
    /*//Элемент №2:
    cout << q->p1->n << endl;
    //Элемент №3:
    cout << q->p1->p3->p2->n << endl;
    //Элемент №4:
    cout << q->p2->p4->p1->n << endl;
    return 0;
    */
}
