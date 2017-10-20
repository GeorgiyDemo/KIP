#include <iostream>
using namespace std;
//Аргументом является указатель:
int incr(int* m)
{
    *m = *m + 1;
    return *m;
}
int main()
{
    int n = 5;
    cout << "n =" << incr(&n) << endl;
    cout << "n =" << n << endl;
    return 0;
}