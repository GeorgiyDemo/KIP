#include <iostream>
using namespace std;
//При объявлении массива размер не указан:
void show(int n[])
{
    for (int i = 0; i < 5; i++)
        cout << "n[" << i << "]=" << n[i] << endl;
}
int main()
{
    int n[5] = { 1, 2, 3, 4, 5 };
    show(n);
    return 0;
}