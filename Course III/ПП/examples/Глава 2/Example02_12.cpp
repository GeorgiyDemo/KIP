#include <iostream>
using namespace std;
int main()
{
    int i, j;
    for (i = 10, j = 90; i < j; i += 5, j -= 10)
        cout << i << " " << j << "\n";
    return 0;
}