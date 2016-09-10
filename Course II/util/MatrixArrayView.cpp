#include <cmath>
#include <iostream>
using namespace std;




/**
 *
 * Выводит массив на экран (double)
 *
 */
void ShowArray(double a[], int n)
{
    cout << "\n [ Output ]: \n";

    for(int i = 0; i<n; i++)
    {
        cout << "\t " << cutStr(to_string(a[i]), 5);
    }

    cout << "\n";
}

/**
 *
 * Выводит массив на экран (int)
 *
 */
void ShowIntArray(int a[], int n)
{
    cout << "\n [ Output ]: \n";

    for(int i = 0; i<n; i++)
    {
        cout << "\t " << to_string(a[i]);
    }

    cout << "\n";
}

/**
 *
 * Создает новую матрицу с ограничениями
 *
 */
int ** CreateNewMatrix(int n, int m)
{
    if(n>=100)
    {
        Warning("Значение n больше 100. Присвоено значение 12");
        n = 12;
    }

    if(m>=100)
    {
        Warning("Значение m больше 100. Присвоено значение 12");
        m = 12;
    }

    //int matrix[100][100];

    int ** matrix;

    matrix = new int*[n];

    for (int i = 0; i < n; ++i)
        matrix[i] = new int[m];

    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
            matrix[i][j] = getRandomInt(10,70);

    return matrix;
}

/**
 *
 * Выводит матрицу
 *
 */
void showMatrix(int ** matrix, int n, int m)
{
    cout << "\n [ Output ]: \n";

    for(int i = 0; i < n; i++)
    {
        cout << "\n";
        for(int j = 0; j<m; j++)
        {
            cout << matrix[i][j] << "\t";
        }
    }
}