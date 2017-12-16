/*
26. Создать абстрактный класс CVehicle.
	На его основе реализовать классы CPlane и ССаr.
	Классы должны иметь возможность задавать и получать координаты,
	параметры средств передвижения (цена, скорость, год выпуска).
	Для самолета должна быть определена высота, для автомобиля — количество пассажиров.
	Написать программу, создающую список объектов этих классов в динамической памяти.
*/

#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

//Класс летательных аппаратов
class CVehicle {
protected:
    int mass;
    string name;

public:
    CVehicle(int m = 0, string n = "")
        : mass(m),
          name(n)
    {
    }
    virtual void Print() const = 0;
    virtual ~CVehicle() {}
};

//Класс ракеты
class RocketClass : public CVehicle {
    int netto, amount;

public:
    void GetData(int m = 0, string _model = "", int n = 0, int a = 0)
    {
        mass = m;
        netto = n;
        amount = a;
        name = _model;
    }
    void Print() const
    {
        cout<<"\n*Класс ракеты*";
        cout << "\nМасса: "<< mass << "\nНазвание: " << name << "\nМасса полезной нагрузки: " << netto  << "\nКол-во ступеней: "<<amount << "\n";
    }
};

class HelicopterClass : public CVehicle {
    int units;

public:
    HelicopterClass(int m, string n, int u = 0)
        : CVehicle(m, n)
        , units(u)
    {
    }
    void Print() const
    {   
        cout<<"\n*Класс вертолета*\n";
        cout<<"Масса: "<<mass<<"\nНазвание: "<<name<<"\nКол-во человек в экипаже\n"<<units<<"\n";
    }
    bool operator<(const HelicopterClass& x) const
    { 
        return units < x.units;
    }
};

int main()
{
    RocketClass a;
    CVehicle* p = &a;
    a.GetData(48, "РАКЕТА №1", 20, 3);
    p->Print();

    //Вектор для пацанов
    vector<HelicopterClass> chop_array;
    chop_array.push_back(HelicopterClass(10, "Вертолет №1", 12));
    chop_array.push_back(HelicopterClass(4, "Вертолет №2", 5));
    chop_array.push_back(HelicopterClass(9, "Вертолет №3", 16));
    sort(chop_array.begin(), chop_array.end()); 
    for (unsigned i = 0; i < chop_array.size(); i++)
        chop_array[i].Print();
    return 0;
}

