#include <iostream>
using namespace std;
// Объявление класса SimpleClass:
class SimpleClass {
public:
    // Целочисленное поле класса:
    int number;
};
int main()
{
    // Создание объекта MyObj класса SimpleClass:
    SimpleClass MyObj;
    // Полю объекта присваивается значение:
    MyObj.number = 5;
    cout << "Object field value is " << MyObj.number << "\n";
    return 0;
}