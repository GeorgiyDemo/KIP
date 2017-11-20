#include <iostream>
using namespace std;
class cl {
    int i;

public:
    cl(int j) { i = j; } // конструктор
    int get_i() { return i; }
};
int main()
{
    cl ob[3] = { 1, 2, 3 }; // инициализаторы
    int i;
    for (i = 0; i < 5; i++)
        cout << ob[i].get_i() << "\n";
    return 0;
}
