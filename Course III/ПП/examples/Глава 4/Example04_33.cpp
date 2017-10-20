#include <iostream>
#include <cstdlib>
using namespace std;
//Размер матриц:
const N = 3;
//Транспонирование матрицы (результат-второй аргумент):
void trans(double A[N][N], double B[N][N])
{
    int i, j;
    for (i = 0; i < N; i++)
        for (j = 0; j < N; j++)
            B[i][j] = A[j][i];
}
//Транспонирование матрицы (результат записывается в аргумент):
void trans(double A[N][N])
{
    int i, j;
    double s;
    for (i = 0; i < N; i++)
        for (j = i + 1; j < N; j++) {
            s = A[i][j];
            A[i][j] = A[j][i];
            A[j][i] = s;
        }
}
//Заполнение матрицы случайными числами:
void fill(double A[N][N])
{
    int i, j;
    for (i = 0; i < N; i++)
        for (j = 0; j < N; j++)
            A[i][j] = rand() % 10;
}
//Вывод матрицы на экран:
void show(double A[N][N])
{
    int i, j;
    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++)
            cout << A[i][j] << " ";
        cout << endl;
    }
}
int main()
{
    //Двумерные массивы:
    double A[N][N], B[N][N];
    cout << "Initial matrix:\n";
    //Заполнение массива:
    fill(A);
    //Отображение массива:
    show(A);
    cout << "After transform:\n";
    //Транспонирование:
    trans(A, B);
    //Результат:
    show(B);
    cout << "Initial matrix:\n";
    //Заполнение массива:
    fill(A);
    //Результат:
    show(A);
    cout << "After transform:\n";
    trans(A);
    show(A);
    return 0;
}