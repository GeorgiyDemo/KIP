/*
Создать класс  Pole и в нем конструктор, с помощью которого 
при создании элемента массива-поля соотвествующего объекта
заполняются случайными числами в диапазоне от 0 табельного номера. 

Создать два объекта класса Pole с полями массивами
размерностью = 4 и сложить их. 
Для этого необходимо использовать перегрузку операторов [] и +.
*/

#include <ctime>
#include <iostream>
using namespace std;

const int n = 4;

class Pole {

public:
    int a[4];

    Pole()
    {
        for (int i = 0; i < n; i++) {
            a[i] = rand() % 5;
        }
    }

    int operator[](int i) { return a[i]; }

    friend Pole operator+(Pole& obj1, Pole& obj2)
    {
        int tmp_obj;
        for (int i = 0; i < n; i++) {
            tmp_obj = obj1.a[i] + obj2.a[i];
        }
        return obj1;
    }

    void show();
};

void Pole::show()
{
    for (int i = 0; i < n; i++)
        cout << "Адрес: " << &a[i] << ", значение: " << a[i] << "\n";
}

int main()
{
    srand(time(0));

    Pole obj1;
    Pole obj2;

    obj1.show();
    obj2.show();

    cout << "\n";
    for (int item = 0; item < n; item++)
        cout << "Сумма при " << obj1.a[item] << " и " << obj2.a[item] << " = " << obj1.a[item] + obj2.a[item] << "\n";
    cout << "\n";

    return 0;
}
