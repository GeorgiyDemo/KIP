#include <iostream>
using namespace std;
int main()
{
    int n;
    int& copy = n;
    copy = 100;
    n++;
    cout << n << "\n";
    cout << copy << "\n";
    return 0;
}