#include <iostream>
using namespace std;
int main()
{
    int **p, *m;
    int n, i, j;
    cout << "Enter rows number: ";
    cin >> n;
    m = new int[n];
    for (i = 0; i < n; i++) {
        cout << "Enter size of row " << i + 1 << ": ";
        cin >> m[i];
    }
    p = new int*[n];
    for (i = 0; i < n; i++) {
        p[i] = new int[m[i]];
        for (j = 0; j < m[i]; j++) {
            p[i][j] = j + 1;
            cout << p[i][j] << " ";
        }
        cout << endl;
    }
    for (i = 0; i < n; i++)
        delete[] p[i];
    delete[] p;
    return 0;
}