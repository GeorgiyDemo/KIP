/*

*/
#include <iostream>
using namespace std;

struct Item {
    int info;
    Item* next;
};

int main()
{
    setlocale(LC_ALL, "rus");
    Item* first = 0;
    Item* p;

    int m;
    // Создать список
    for (;;) {
        // Вводить числа, пока не введем 0
        cout << " Введи число " << endl;
        cin >> m;
        if (!m)
            break;

        // Создать новый элемент списка
        p = new Item;
        p->info = m;
        cout << "адрес " << m << "  " << p << "  " << endl;

        // Присоединить новый элемент к началу списка
        p->next = first;
        first = p;
    }
    // Пройти список и вывести элементы
    p = first;
    while (p) {
        cout << p->info << "  ";
        p = p->next;
    }
    // Пройти список и удалить элементы
    while (first) {
        p = first;
        first = first->next;
        delete p;
    }
return 0;
}

