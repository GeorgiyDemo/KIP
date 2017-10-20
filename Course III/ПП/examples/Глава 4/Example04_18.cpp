#include <iostream>
using namespace std;
int& mpoint(int& n, int& m)
{
    if (n > m)
        return n;
    else
        return m;
}
int main()
{
    int n = 3, m = 5;
    int p;
    mpoint(n, m) = 2;
    p = mpoint(n, m);
    cout << "n =" << n << endl;
    cout << "m =" << m << endl;
    cout << "p =" << p << endl;
    return 0;
}