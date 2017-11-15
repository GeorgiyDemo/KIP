/*
Цилиндр  с аргументами: Радиус, высота.
*/

#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class RadiusCalss {

    double height;
    double radius;

public:
	//Конструкторы
    RadiusCalss(double height1 = 1.25, double radius1 = 3.42);
    RadiusCalss(const RadiusCalss& object);
    //Деструктор
    ~RadiusCalss();
    //Методы
    void show();
};

RadiusCalss::RadiusCalss(double height1, double radius1)
{
    cout << "Конструктор\n";
    height = height1;
    radius = radius1;
}

RadiusCalss::RadiusCalss(const RadiusCalss& object)
{
    cout << "Конструктор\n";
    height = object.height;
    radius = object.radius;
}

RadiusCalss::~RadiusCalss()
{
    cout << "\nДеструктор живой";
};

void RadiusCalss::show()
{
    cout << "Радиус: " << radius << "\n";
    cout << "Высота: " << height << "\n";
}

int main()
{

    //RadiusCalss ob1;
    RadiusCalss ob1(4.324, 2.42);
    RadiusCalss ob2(ob1);

    ob1.show();
    ob2.show();

    cout << "\n";
    return 0;
}