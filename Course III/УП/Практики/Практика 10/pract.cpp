/*

    1. Дописать в программе необходимые команды вывода на экран, чтобы
    2. Вывести на экран адреса узлов и информацию в них.
    3. Определить содержимое узлов после удаления списка.
    4. Вывести адрес переменной  m и содержимое m до создания списка  и после удаления  списка
    5. Создать одномерный массив из 4  тех же  значений элементов и вывести на экран его с адресами элементов

*/

#include <iostream>
using namespace std;

struct Item {
    int info;
    Item* next;
};

int main()
{
    bool bool_checker = false;
    int remove_arr[4], i, input_number1, input_number2;
    Item* first = 0;
    Item* p;

    //Созднаие списка
    cout << "Начальное значение: " << input_number1 << " с адресом  [" << &input_number1 << "]\n";
    for (;;) {
        cout << "Введите значение:\n"; cin >> input_number1;
        if (!input_number1)
            break;

        p = new Item;
        p->info = input_number1;
        cout << "*Успешно ввели значение " << input_number1 << " с адресом [" << p << "]*\n";

        p->next = first;
        first = p;
    }

    //cout << "Текущий адрес списка " << input_number1 << ": [" << &input_number1 << "]\n";

    //Вывод всех элементов
    i = 0;
    p = first;
    cout<<"\n*Информация о списке*\n";
    while (p) {
        cout << "Значение " << p->info << " с адресом [" << p << "] указывает на адрес [" << p->next << "]\n";
        if (i < 4) {
            remove_arr[i] = p->info;
            i++;
        }
        p = p->next;
    }

    //Поиск в списке
    cout << "\nВведите значение элемента для поиска по списку: ";
    cin >> input_number2;
    p = first;
    while (p) {
        if ((p->info) == input_number2) {
            cout << "Искомый элемент есть в списке c адресом [" << p << "]\n";
            bool_checker = true;
        }
        p = p->next;
    }
    if (bool_checker == false)
        cout << "Искомого элемента нет в списке\n";
        
    //Удаление объекта p
    cout << "\n*Информация после удаления объекта*" << '\n';
    while (first) {
        p = first;
        first = first->next;
        delete p;
        cout << "Значение " << p->info << " с адресом [" << p << "] указывает на адрес [" << p->next << "]\n";
    }

    //Вывод массива
    cout << "\n*Вывод массива*\n";
    for (i = 0; i < 4; i++) {
        cout << "Значение: " << remove_arr[i] << " с адресом [" << &remove_arr[i] << "]\n";
    }

    return 0;
}
