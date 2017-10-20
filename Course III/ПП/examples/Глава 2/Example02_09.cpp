#include <iostream>
using namespace std;
int main()
{
    int n;
    cout << "Enter number n=";
    cin >> n;
    for (int i = 1, s = 0; i <= n; s += i++)
        ;
    cout << "Sum of natural numbers is: " << s << "\n";
    return 0;
}