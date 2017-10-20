#include <iostream>
using namespace std;
int main()
{
    //Матрица:
    double A[2][2];
    //Определитель матрицы:
    double det;
    //Индексные переменные:
    int i, j;
    //Ввод (построчный) элементов матрицы:
    cout << "Matrix A:\n";
    for (i = 0; i < 2; i++)
        for (j = 0; j < 2; j++)
            cin >> A[i][j];
    //Вычисление определителя матрицы:
    det = A[0][0] * A[1][1] - A[0][1] * A[1][0];
    //Вывод значения определителя на экран:
    cout << "det(A) = " << det << endl;
    return 0;
}