/*

4.	Написать программу с обобщенным  классом,
	у которого есть поле -  массив.
	Перегрузить оператор инкремента так, чтобы все
	столбцы в массиве циклически сдвигались на одну позицию.

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
            x[i] = (X)(rand() % 100);
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
        cout<<"[";
        for (int i = 0; i < n; i++)
        {
            cout << x[i] << " ";
        }
        cout<<"]";
    }
};
 
int main()
{
    Abc<int, 10> abc;
    cout << "Массив чисел до сдвига:\n";
    abc.ShowValue();
    abc++;
    cout << "\nМассив чисел после сдвига:\n";
    abc.ShowValue();
 
    Abc<string, 13> abc2("KOT_MEOW_MEOW");
    cout << "\n\nМассив строк до сдвига:\n";
    abc2.ShowValue();
    abc2++;
    cout << "\nМассив строк после сдвига:\n";
    abc2.ShowValue();
 
    cout<<"\n";
    return 0;
}