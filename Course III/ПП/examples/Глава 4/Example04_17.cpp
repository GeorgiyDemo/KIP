#include <iostream>
using namespace std;
int* mpoint(int& n, int& m)
{
    if (n > m)
        return &n;
    else
        return &m;
}
int main()
{
    int n = 3, m = 5;
    int* p;
    p = mpoint(n, m);
    (*p)++;
    cout << "n =" << n << endl;
    cout << "m =" << m << endl;
    return 0;
}