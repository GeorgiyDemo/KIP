#include <iostream>
using namespace std;
int main()
{
    int n, *p, *q;
    int& copy = n;
    p = &n;
    copy = 100;
    (*p) /= 10;
    q = &copy;
    n++;
    cout << n << "\n";
    cout << copy << "\n";
    cout << *p << "\n";
    cout << *q << "\n";
    cout << p << "\n";
    cout << q << "\n";
    return 0;
}