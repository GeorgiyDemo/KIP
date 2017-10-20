#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    int n, m;
    n = rand() % 100 + 1;
    cout << "Enter number m=";
    cin >> m;
    cout << "n=" << n << ": ";
    if (m > n)
        cout << "your number is greater!\n";
    else if (n > m)
        cout << "your number is less!\n";
    else
        cout << "you have guessed right!\n";
    return 0;
}