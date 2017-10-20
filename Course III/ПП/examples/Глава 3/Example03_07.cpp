#include <iostream>
using namespace std;
int main()
{
    int n[10];
    for (int i = 0; i < 10; i++) {
        *(n + i) = 10 - i;
        cout << n[i] << "\n";
    }
    return 0;
}