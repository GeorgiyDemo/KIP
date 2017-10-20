#include <iostream>
using namespace std;
int main()
{
    int n[10];
    for (int i = 0; i < 10; i++) {
        n[i] = rand() % 10;
        cout << n[i] << " ";
    }
    cout << "\n";
    return 0;
}