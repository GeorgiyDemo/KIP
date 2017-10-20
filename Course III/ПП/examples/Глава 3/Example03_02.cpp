#include <iostream>
using namespace std;
int main()
{
    int n, *p, **q;
    p = &n;
    q = &p;
    n = 100;
    (*p) += 5;
    (**q)--;
    cout << n << "\n";
    cout << *p << "\n";
    cout << **q << "\n";
    cout << p << "\n";
    cout << q << "\n";
    return 0;
}