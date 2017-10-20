#include <iostream>
using namespace std;
int main()
{
    int n[4][5], *p;
    for (int i = 0; i < 4; i++) {
        p = n[i];
        for (int j = 0; j < 5; j++) {
            *(p + j) = 5 * i + j + 1;
            printf("%4d", n[i][j]);
        }
        printf("\n");
    }
    return 0;
}