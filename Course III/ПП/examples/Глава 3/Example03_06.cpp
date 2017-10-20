#include <iostream>
using namespace std;
int main()
{
    int n[10], *p;
    p = n;
    for (int i = 0; i < 10; i++) {
        p[i] = 10 - i;
        cout << *(p + i) << " ";
    }
    cout << "\n";
    return 0;
}