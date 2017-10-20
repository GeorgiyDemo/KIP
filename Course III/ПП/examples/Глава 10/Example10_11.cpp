#include <iostream>
#include <cstdlib>
using namespace std;
//Размер полей-массивов:
const int n = 10;
//Класс с полем-массивом:
class RealNums {
public:
    //Поле-массив:
    int p[n];
    //Конструктор класса:
    RealNums()
    {
        int k;
        for (k = 0; k < n; k++)
            p[k] = rand() % n;
    }
    //Перегрузка оператора []:
    int& operator[](int i)
    {
        return p[i];
    }
    //Перегрузка оператора +:
    RealNums operator+(RealNums obj)
    {
        int i;
        RealNums tmp;
        for (i = 0; i < n; i++)
            tmp[i] = p[i] + obj[i];
        return tmp;
    }
    //Метод для вывода значений массива:
    void show()
    {
        int i;
        for (i = 0; i < n; i++)
            printf("%3d", p[i]);
        cout << endl;
    }
};
int main()
{
    RealNums a, b;
    a.show();
    b.show();
    (a + b).show();
    for (int i = 0; i < n; i++)
        a[i] = b[i] - a[i];
    a.show();
    return 0;
}