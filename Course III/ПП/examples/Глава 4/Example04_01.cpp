#include <iostream>
using namespace std;
int msum(int n)
{
    int s = 0;
    for (int i = 1; i <= n; i++)
        s += i;
    return s;
}
int main()
{
    int n;
    cout << "Enter n = ";
    cin >> n;
    cout << "Sum is " << msum(n) << "\n";
    return 0;
}