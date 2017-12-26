#include "stdafx.h"
#include <iostream>

using namespace std;

double** input(int n)
{
    int i, j, hl;
    double** arr;
    arr = new double*[n + 1];
    arr[0] = new double[n];
    arr[1] = new double[n];
    for (i = 0; i < n; i++) {
        cout << "Введите x[" << i << "]:";
        cin >> arr[0][i];
        cout << "Введите y[" << i << "]:";
        cin >> arr[1][i];
    }
    for (i = 2; i <= n; i++) {
        arr[i] = new double[n + 1 - i];
        cout << endl;
        for (j = 0; j < n + 1 - i; j++)
            arr[i][j] = (arr[i - 1][j + 1] - arr[i - 1][j]) / (arr[i - 2][j + 1] - arr[i - 2][j]);

    }
    cout << endl;
    return arr;
}

void output(double** arr, int n)
{
    int i, j;
    for (i = 0; i < 2; i++) {
        cout << endl;
        for (j = 0; j < n; j++) {
            cout << arr[i][j] << " ";
        }
    }
        for (i = 2; i <= n; i++) {
            cout << endl;

            for (j = 0; j < n + 1 - i; j++)
                cout << arr[i][j] << " ";

        }
}

double findanswer(double** arr, int n, double x) {
    int i, j, imin, hlp;
    double min, ans;
    min = fabs(x - arr[0][0]);
    imin = 0;
    for (i = 1; i < n; i++) {
        if (min > fabs(x - arr[0][i])) {
            min = fabs(x - arr[0][i]);
            imin = i;
        }
    }
    if ((arr[0][imin] == arr[0][0]) || (arr[0][imin] == arr[0][n]))
    {
        hlp = n;
    }
    else
        if (imin == n / 2)
        {
            hlp = n - 2;
        }
        else
            hlp = --n;
    if (imin <= n / 2) {
        min = 1;
        ans = 0;
        for (i = 1; i < hlp; i++)
        {
            if (i > 1)
                min *= x - arr[0][i - 1];
            ans += arr[i][imin];
        }

    }
    if (imin > n / 2) {
        min = 1;
        ans = 0;
        for (i = 1; i < hlp; i++)
        {
            if (i > 1)
                min *= x - arr[0][n+1-i];
            ans += arr[i][n-imin];
        }
    }
    return ans;
}
int main()
{
    int n;
    double** arr;
    double ans, x;
    setlocale(LC_ALL, "rus");
    cout << "Введите количество точек -> ";
    cin >> n;
    arr = input(n);
    output(arr, n);
    cout << "Введите x -> ";
    cin >> x;
    ans = findanswer(arr, n, x);
    cout << "Ans = " << ans;
    system("pause");
    return 0;
}
