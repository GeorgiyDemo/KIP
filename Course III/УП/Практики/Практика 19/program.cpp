/*

4.	Написать программу с обобщенным  классом,
	у которого есть поле -  массив.
	Перегрузить оператор инкремента так, чтобы все
	столбцы в массиве циклически сдвигались на одну позицию.

*/

#include <iostream>
using namespace std;
//Размер поля-массива:
const int n = 10;
template <class X>
class MyClass {
public:
    //Поле-массив:
    X array[n];
    //Перегрузка оператора []:
    X operator[](int k)
    {
        return array[k % n];
    }
    //Перегрузка оператора ++:
    MyClass operator++()
    {
        X tmp;
        int i;
        tmp = array[n - 1];
        for (i = n - 1; i > 0; i--)
            array[i] = array[i - 1];
        array[0] = tmp;
        return *this;
    }
    //Метод для отображения массива:
    void show()
    {
        for (int i = 0; i < n; i++)
            cout << array[i] << " ";
        cout << endl;
    }

    //Конструктор класса:
    MyClass()
    {
        for (int i = 0; i < n; i++)
            array[i] = (X)(rand() % 25 + 100);
    }
};

int main()
{
    MyClass<int> obj1;
    obj1.show();
    for (int i = n; i < 2 * n; i++)
        cout << obj1[i] << " ";
    cout << endl;
    MyClass<char> obj2;
    obj2.show();
    ++obj2;
    obj2.show();
    return 0;
}
