#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class truck;
class car {
    int passengers;
    int speed;

public:
    car(int p, int s)
    {
        passengers = p;
        speed = s;
    }
    string sravnenie(truck t1);
};

class truck {
    int weight;
    int speed;

public:
    truck(int w, int s)
    {
        weight = w;
        speed = s;
    }

    friend string car::sravnenie(truck t1);
};
string car::sravnenie(truck t1)
{
    if (speed > t1.speed)
        return "Скорость машины быстрее";
    return "Скорость грузовика быстрее";
};

int main()
{

    car obj1(100, 25);
    truck obj2(2, 100);
    cout << obj1.sravnenie(obj2);

    cout << "\n";
    return 0;
}