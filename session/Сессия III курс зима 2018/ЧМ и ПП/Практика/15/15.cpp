/*
Создать класс Oboi, который будет содержать поля с открытым
доступом: material,(бумажные, виниловые) dlina, size_w,
price и метод класса getData(). В главной функции объявить
пару объектов класса и внести данные в поля. Затем
отобразить их, вызвав метод getData().
*/
#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class OboiClass {
public:
    int dlina;
    int size_w;
    int price;
    string material;

    OboiClass(string material1, int dlina1, int size_w1, int price1);
    void GetData();
};

OboiClass::OboiClass(string material1, int dlina1, int size_w1, int price1)
{
    material = material1;
    dlina = dlina1;
    size_w = size_w1;
    price = price1;
}

void OboiClass::GetData()
{
    cout << material << " " << dlina << " " << size_w << " " << price << " рублей" << endl;
}

int main()
{
    setlocale(LC_ALL, "RUS");
    OboiClass v1("Бумажные", 5, 2, 1000);
    OboiClass v2("Виниловые", 12, 3, 1200);

    v1.GetData();
    v2.GetData();

    system("pause");
    return 0;
}
