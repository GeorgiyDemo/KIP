// увеличение указателя на объект
#include <iostream>
using namespace std;
class P_example {
    int num;

public:
    void set_num(int val) { num = val; }
    void show_num();
};
void P_example::show_num()
{
    cout << num << "\n";
}
int main()
{
    P_example ob[2], *p;
    ob[0].set_num(10); // прямой доступ к объекту
    ob[1].set_num(20);
    p = &ob[0]; // получение указателя на первый элемент
    p->show_num(); // вывод значения ob[0] с помощью указателя
    р++; // переход к следующему объекту
    p->show_num(); // вывод значения ob[1] с помощью указателя
    р--; // переход к предыдущему объекту
    p->show_num(); // вывод значения оb [0]
    return 0;
}
