/*
    Создать класс месяц- month с закрытым полем месяц
    в цифровом формате и конструктор, который устанавливает № месяца и метод,
    который выводит на экран номер месяца.
    Создать метод, который прибавляет несколько месяцев (<12) к заданному месяцу.
    Полученный месяц вывести на экран. Продемонстрировать на 5 объектах.
*/

#include <iostream>
#include <cmath>
 
using namespace std;
 
class Month
{
public:
    Month(int monthId);
    void Show();
    void Up(int id);
 
private:
    int monthId;
};
 
Month::Month(int monthId)
{
    if (monthId > 12) this->monthId = 12;
    if (monthId <= 0) this->monthId = 1;
 
    this->monthId = monthId;
}
 
void Month::Show()
{
    cout << "Month - " << monthId << "\n";
}
 
void Month::Up(int id)
{
    if (id >= 12)
        return;
 
    cout << monthId << " + " << id << "\n";
 
    for (int i = 1; i <= id; i++)
    {
        if (monthId != 12)
            monthId++;
        else
            monthId = 1;
    }
}
 
int main()
{
    cout << "1:\n";
    Month *month = new Month(11);
    month->Show();
    month->Up(5);
    month->Show();
    cout << "\n";
 
    cout << "2:\n";
    Month *month2 = new Month(12);
    month2->Show();
    month2->Up(4);
    month2->Show();
    cout << "\n";
 
    cout << "3:\n";
    Month *month3 = new Month(5);
    month3->Show();
    month3->Up(8);
    month3->Show();
    cout << "\n";
 
    cout << "4:\n";
    Month *month4 = new Month(3);
    month4->Show();
    month4->Up(9);
    month4->Show();
    cout << "\n";
 
    cout << "5:\n";
    Month *month5 = new Month(7);
    month5->Show();
    month5->Up(4);
    month5->Show();
    cout << "\n";
 
    return 0;
}