#include <iostream>
using namespace std;
//Аргумент передается по ссылке:
int incr(int& m)
{
    m = m + 1;
    return m;
}
int main()
{
    int n = 5;
    cout << "n =" << incr(n) << endl;
    cout << "n =" << n << endl;
    return 0;
}