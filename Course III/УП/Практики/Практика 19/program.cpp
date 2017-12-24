/*
4.	Написать программу с обобщенным  классом,
	у которого есть поле -  массив.
	Перегрузить оператор инкремента так, чтобы все
	столбцы в массиве циклически сдвигались на одну позицию.

 */

#include <iostream>
#include <string>
using namespace std;

template<class KOT, int n> class KomukClass
{
protected:
    KOT main_arr[n];
public:
    KOT operator[](int k)
    {
        return main_arr[k % n];
    }

    KomukClass operator++(int m)
    {
        KOT tmp_obj;
        tmp_obj = main_arr[n - 1];
        for (int i = n - 1; i > 0; i--)
            main_arr[i] = main_arr[i - 1];
        main_arr[0] = tmp_obj;
        return *this;
    }

    KomukClass()
    {
        for (int i = 0; i < n; i++)
            main_arr[i] = (KOT)(rand() % 99);
    }

    KomukClass(string str)
    {
        for (int i = 0; i < n; i++)
            main_arr[i] = str[i];
    }

    void OutArray()
    {
        cout<<"[";
        for (int i = 0; i < n; i++)
            cout << main_arr[i] << " ";
        cout<<"]";
    }
};

int main()
{
    srand(time(NULL));

    KomukClass<int, 10> obj;
    cout << "\nМассив чисел до сдвига:\n";
    obj.OutArray();
    obj++;
    cout << "\nМассив чисел после сдвига:\n";
    obj.OutArray();

    KomukClass<string, 4> obj1("KOT_MEOW_MEOW");
    cout << "\n\nМассив строк до сдвига:\n";
    obj1.OutArray();
    obj1++;
    cout << "\nМассив строк после сдвига:\n";
    obj1.OutArray();

    cout<<"\n";
    return 0;
}
