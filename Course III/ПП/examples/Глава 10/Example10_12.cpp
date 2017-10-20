#include <iostream>
using namespace std;
//Класс для реализации векторов:
class Vector {
    //Координаты вектора – закрытый массив-член класса:
    double coords[3];

public:
    //Перегрузка оператора [] для индексации объектов:
    double& operator[](int i)
    {
        int k = i % 3;
        return coords[k];
    }
    //Перегрузка оператора () для присваивания координатам значений:
    Vector operator()(double x, double y, double z)
    {
        coords[0] = x;
        coords[1] = y;
        coords[2] = z;
        return *this;
    }
    //Перегрузка оператора () для вычисления векторного произведения:
    Vector operator()(Vector a, Vector b)
    {
        for (int i = 0; i < 3; i++)
            coords[i] = a[i + 1] * b[i + 2] - a[i + 2] * b[i + 1];
        return *this;
    }
    //Перегрузка оператора * для вычисления скалярного произведения:
    double operator*(Vector obj)
    {
        double res = 0;
        for (int i = 0; i < 3; i++)
            res += coords[i] * obj[i];
        return res;
    }
    //Конструктор с тремя аргументами:
    Vector(double x, double y, double z)
    {
        coords[0] = x;
        coords[1] = y;
        coords[2] = z;
    }
    //Метод для отображения координат вектора:
    void show()
    {
        cout << "(" << coords[0] << ", " << coords[1] << ", " << coords[2] << ")\n";
    }
    //Конструктор без аргументов:
    Vector()
    {
        for (int i = 0; i < 3; i++)
            coords[i] = 0;
    }
};
int main()
{
    //Объявление трех векторов:
    Vector a, b(2, 1, 3), c;
    //Определение координат вектора:
    a(1, -3, 4);
    //Отображение координат векторов:
    a.show();
    b.show();
    //Скалярное произведение:
    cout << "a*b=" << a * b << endl;
    //Векторное произведение:
    c(a, b);
    cout << "[ab]=";
    c.show();
    return 0;
}