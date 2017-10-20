#include <iostream>
using namespace std;
int main()
{
    int *q, n, *p;
    n = 100;
    p = &n;
    q = p;
    (*p)++;
    cout << *q << "\n";
    cout << n << "\n";
    cout << p << "\n";
    return 0;
}