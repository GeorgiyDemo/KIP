#include <iostream>
using namespace std;
class SimpleClass {
public:
    //Статическое поле:
    static int m;
    //Нестатическое поле:
    int n;
    void show();
    //Статический метод:
    static void msum(int k);
} obj1, obj2;
//Повторное объявление переменной:
int SimpleClass::m;
int main()
{
    //Вызов статического метода:
    SimpleClass::msum(10);
    obj1.n = 1;
    obj2.n = 2;
    obj1.show();
    obj2.show();
    //Вызов статического метода:
    obj1.msum(90);
    obj2.show();
    return 0;
}
//Описание нестатического метода:
void SimpleClass::show()
{
    cout << "Static field m = " << m << endl;
    cout << "Nonstatic field n = " << n << endl;
}
//Описание статического метода:
void SimpleClass::msum(int k)
{
    m += k;
}