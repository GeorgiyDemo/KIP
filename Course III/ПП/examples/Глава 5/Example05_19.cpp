#include <iostream>
#include <cstdlib>
using namespace std;
int main()
{
    //Индексные переменные и размер массивов:
    int i, j, n;
    //Двумерные массивы:
    int **A, **B, **C;
    //Ввод размера массивов (ранга матриц):
    cout << "Enter n = ";
    cin >> n;
    //Динамическое выделение памяти под одномерные массивы:
    A = new int*[n];
    B = new int*[n];
    C = new int*[n];
    //Динамическое выделение памяти для создания двумерных массивов:
    for (i = 0; i < n; i++) {
        A[i] = new int[n];
        B[i] = new int[n];
        C[i] = new int[n];
    }
    //Заполнение массивов:
    for (i = 0; i < n; i++)
        for (j = 0; j < n; j++) {
            A[i][j] = rand() % 5;
            B[i][j] = rand() % 5;
            C[i][j] = A[i][j] + B[i][j];
        }
    //Вывод результата (построчный). Верхние строки:
    for (i = 0; i < n / 2; i++) {
        for (j = 0; j < n; j++)
            cout << A[i][j] << " ";
        cout << "  ";
        for (j = 0; j < n; j++)
            cout << B[i][j] << " ";
        cout << "  ";
        for (j = 0; j < n; j++)
            cout << C[i][j] << " ";
        cout << endl;
    }
    //Вывод строки со знаками операций:
    for (j = 0; j < n; j++)
        cout << A[n / 2][j] << " ";
    cout << "+ ";
    for (j = 0; j < n; j++)
        cout << B[n / 2][j] << " ";
    cout << "= ";
    for (j = 0; j < n; j++)
        cout << C[n / 2][j] << " ";
    cout << endl;
    //Вывод (построчный) нижних строк результата:
    for (i = n / 2 + 1; i < n; i++) {
        for (j = 0; j < n; j++)
            cout << A[i][j] << " ";
        cout << "  ";
        for (j = 0; j < n; j++)
            cout << B[i][j] << " ";
        cout << "  ";
        for (j = 0; j < n; j++)
            cout << C[i][j] << " ";
        cout << endl;
    }
    return 0;
}