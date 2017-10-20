#include <iostream>
using namespace std;
int main()
{
    //Размер матриц:
    const int N = 3;
    //Индексные переменные:
    int i, j, k;
    //Первая матрица:
    double A[N][N];
    //Вторая матрица:
    double B[N][N];
    //Третья матрица (результат):
    double C[N][N];
    //Ввод (построчный) элементов первой матрицы:
    cout << "Matrix A:\n";
    for (i = 0; i < N; i++)
        for (j = 0; j < N; j++)
            cin >> A[i][j];
    //Ввод (построчный) элементов второй матрицы:
    cout << "Matrix B:\n";
    for (i = 0; i < N; i++)
        for (j = 0; j < N; j++)
            cin >> B[i][j];
    //Вычисление произведения матриц:
    cout << "Matrix C=AB:\n";
    for (i = 0; i < N; i++) {
        for (j = 0; j < N; j++) {
            C[i][j] = 0;
            for (k = 0; k < N; k++)
                C[i][j] += A[i][k] * B[k][j];
            //Вывод значения элемента на экран:
            cout << C[i][j] << " ";
        }
        cout << endl;
    }
    return 0;
}