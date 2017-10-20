#include <iostream>
#include <cmath>
using namespace std;
//Степень полинома:
const int n = 5;
class Polynom {
public:
    //Коэффициенты полинома:
    double a[n + 1];
    //Перегрузка оператора "скобки" (т.е. ()):
    double operator()(double z)
    {
        int i;
        double s = 0;
        for (i = 0; i <= n; i++)
            s += a[i] * pow(z, i);
        return s;
    }
    //Перегрузка оператора "запятая" (т.е. ,):
    Polynom operator, (int k)
    {
        int i;
        Polynom tmp;
        for (i = 0; i <= n; i++)
            tmp.a[i] = a[i];
        switch (k) {
        case 0:
            break;
        case 1:
            for (i = 0; i < n; i++)
                tmp.a[i] = tmp.a[i + 1] * (i + 1);
            tmp.a[n] = 0;
            break;
        default:
            //Рекурсия:
            tmp = (tmp, 1, k - 1);
        }
        return tmp;
    }
    //Перегрузка оператора сложения:
    Polynom operator+(Polynom obj)
    {
        Polynom tmp;
        for (int i = 0; i <= n; i++)
            tmp.a[i] = a[i] + obj.a[i];
        return tmp;
    }
    //Перегрузка оператора вычитания:
    Polynom operator-(Polynom obj)
    {
        Polynom tmp;
        for (int i = 0; i <= n; i++)
            tmp.a[i] = a[i] - obj.a[i];
        return tmp;
    }
    //Перегрузка оператора умножения:
    Polynom operator*(double b)
    {
        Polynom tmp;
        for (int i = 0; i <= n; i++)
            tmp.a[i] = a[i] * b;
        return tmp;
    }
    //Перегрузка оператора деления:
    Polynom operator/(double b)
    {
        Polynom tmp;
        for (int i = 0; i <= n; i++)
            tmp.a[i] = a[i] / b;
        return tmp;
    }
    //Конструктор класса:
    Polynom()
    {
        for (int i = 0; i <= n; i++)
            a[i] = i + 1;
    }
};
//Внешняя функция для отображения коэффициентов полинома:
void show(Polynom obj)
{
    for (int i = 0; i <= n; i++)
        cout << obj.a[i] << "  ";
    cout << endl;
}
int main()
{
    //Создание объектов:
    Polynom obj1, obj2;
    //Переменные для полиномов:
    double x = 1, y = -1;
    //Коэффициенты полинома:
    show(obj1);
    //Деление на число:
    obj1 = obj1 / 2;
    show(obj1);
    //Умножение на число:
    obj1 = obj1 * 2;
    show(obj1);
    //Значение полинома:
    cout << obj1(x) << endl;
    //Производные от полинома:
    for (int i = 0; i <= 3; i++) {
        obj2 = (obj1, i);
        show(obj2);
    }
    //Значение производной:
    cout << (obj1, 1)(y) << endl;
    //Значение суммы полиномов:
    cout << (obj1 + obj2)(x) << endl;
    //Значение разности полиномов:
    cout << (obj1 - (obj1, 1, 2))(y) << endl;
    return 0;
}