/*
Написать программу с обобщенным  классом,  у которого есть поле -  массив.
Перегрузить оператор инкремента так, чтобы все строки в массиве циклически сдвигались на одну позицию.
*/
 
#include <iostream>
#include <string>
#include <cstdlib>
 
using namespace std;
 
template<class X, int n> class Abc
{
public:
    X x[n];
 
    X operator[](int k)
    {
        return x[k % n];
    }
 
    Abc operator++(int m)
    {
        X tmp;
        tmp = x[n - 1];
 
        for (int i = n - 1; i > 0; i--)
            x[i] = x[i - 1];
 
        x[0] = tmp;
        return *this;
    }
 
    Abc()
    {
        srand(1);
        for (int i = 0; i < n; i++)
        {
            x[i] = (X)(100 + rand() % 10);
        }
    }
 
    Abc(string str)
    {
        for (int i = 0; i < n; i++)
        {
            x[i] = str[i];
        }
    }
 
    void ShowValue()
    {
        for (int i = 0; i < n; i++)
        {
            cout << x[i] << "\n";
        }
    }
};
 
int main()
{
    Abc<int, 10> abc;
    cout << "INT Start:\n";
    abc.ShowValue();
    abc++;
    cout << "\nFinal:\n";
    abc.ShowValue();
 
    Abc<string, 5> abc2("qwert");
    cout << "\n\nSTRING Start:\n";
    abc2.ShowValue();
    abc2++;
    cout << "\nFinal:\n";
    abc2.ShowValue();
 
    return 0;
}