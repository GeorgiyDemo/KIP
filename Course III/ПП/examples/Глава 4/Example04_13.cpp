#include <iostream>
using namespace std;
void show2(int n[][3], int size)
{
    int i, j;
    for (i = 0; i < size; i++) {
        for (j = 0; j < 3; j++) {
            cout << n[i][j] << " ";
        }
        cout << "\n";
    }
}
int main()
{
    int n[][3] = { { 1, 2, 3 },
        { 4, 5, 6 } };
    show2(n, 2);
    return 0;
}