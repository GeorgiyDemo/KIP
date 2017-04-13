// sub2.cpp: определяет точку входа для консольного приложения.
//Для заданной матрицы размером 8 на 8 найти такие k, 
//что k-я строка матрицы совпадает с k-м столбцом.
//Найти сумму элементов в тех строках, которые содержат хотя бы один отрицательный элемент. 

#include <iostream>
#include <locale>
#include <iomanip>
#include <math.h>
using namespace std;
 
int _tmain()
{
    setlocale(LC_ALL, "Russian");
 
    int const n = 3;
    int m[n][n];
 
    cout << "Введите матрицу: \n";
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout << "Введите элемент[" << i+1 << "][" << j+1 << "]: ";
            cin >> m[i][j];
        }
    }
 
    cout << "\n";
 
    cout << "Исходная матрица: \n";
    for(int i = 0; i < n; i++)
    {
        cout << "\n" << "\t";
        for(int j = 0; j < n; j++)
        {
            cout << setw(3) << setiosflags(ios::left) << m[i][j] << " ";
        }
    }
 
    cout << "\n\n";
 
    /*Для заданной матрицы размером 8 на 8 найти такие k, 
    что k-я строка матрицы совпадает с k-м столбцом.*/
 
    bool flag = false;
    int sum_od, index_str, index_stb, k;
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            sum_od = 0;
            for(k = 0; k < n; ++k)
            {
                if(m[i][k] == m[k][j])
                {
                    sum_od++;
                    if(sum_od == n)
                    {
                        index_str = i;
                        index_stb = j;
                        flag = true;
                    }
                }
            }
        }
    }
 
    if(flag == true)
    {
        cout << "Индекс одинаковой строки: " << index_str
        << "\nИндекс одинакового столбца: " << index_stb << "\n\n";
    }
    else
        cout << "Одинаковых строк и столбцов нет!\n\n";
 
 
    /*Найти сумму элементов в тех строках,
    которые содержат хотя бы один отрицательный элемент.*/
 
    int sum, str_bez = 0;
    bool flags;
    for(int i = 0; i < n; i++)
    {
        flags = false;
        for(int j = 0; j < n; j++)
        {
            if(m[i][j] < 0)
            {
                sum = 0;
                for(int k = 0; k < n; k++)
                {
                    flags = true;
                    sum += m[i][k];
                }
            }
            else
                str_bez++;
        }
 
        if(flags == true)
            cout << "Сумма в строках с отрицательными элементами[" << i+1 << "]: " << sum << "\n";
    }
 
    int res = pow((double)n, 2);
    if(str_bez == res)
        cout << "Отрицательных элементов нет!\n\n";
 
    cout << "\n\n";
}