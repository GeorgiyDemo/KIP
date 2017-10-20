#include <iostream>
using namespace std;
//Объявление класса:
class MyClass {
public:
    double x;
};
int main()
{
    //Объект класса:
    MyClass obj;
    //Ссылка на объект:
    MyClass& ref = obj;
    //Обращение к объекту по имени и через ссылку:
    obj.x = 10;
    cout << "x = " << ref.x << endl;
    ref.x = 100;
    cout << "x = " << obj.x << endl;
    return 0;
}