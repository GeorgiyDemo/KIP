#include <iostream>
using namespace std;
int main()
{
    int n, i, s = 0;
    cout << "Enter number n=";
    cin >> n;
    for (i = 1; i <= n; i++) {
        s += i;
    }
    cout << "Sum of natural numbers is: " << s << "\n";
    return 0;
}