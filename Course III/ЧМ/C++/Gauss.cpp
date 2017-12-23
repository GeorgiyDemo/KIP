#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

void change(double** nc, int i1, int i2, int n)
{
    int j;
    double* buf;

    buf = (double*)malloc((n + 1) * sizeof(double));
    for (j = 0; j < n + 1; j++) {
        buf[j] = nc[i1][j];
        nc[i1][j] = nc[i2][j];
        nc[i2][j] = buf[j];
    }
}

void main()
{
    double **data, k, help, *helper;
    int i, j, l, counter, hlp, n;
    setlocale(LC_ALL, "rus");
    printf("Введите порядок системы: ");
    scanf_s("%d", &n);
    data = (double**)malloc(n * sizeof(double*));
    for (i = 0; i < n; i++)
        data[i] = (double*)malloc((n + 1) * sizeof(double));
    printf("Вводите элементы расширенной матрицы: \n");
    for (i = 0; i < n; i++)
        for (j = 0; j < n + 1; j++) {
            printf("Введите элемент %d-%d: ", i + 1, j + 1);
            scanf_s("%lf", &data[i][j]);
        }
    printf("Ваша расширенная матрица: ");
    for (i = 0; i < n; i++) {
        printf("\n");
        for (j = 0; j < n + 1; j++)
            printf("%5.3lf ", data[i][j]);
    }
    for (i = 0; i < n - 1; i++) {
        hlp = 0;
        do {
            help = data[i][i];
            if (help == 0) {
                counter = 0;
                for (l = i + 1; l < n + 1; l++)
                    if (data[i][l] == 0)
                        counter++;
                //if (counter == n-i)
                change(data, i, n - hlp, n);
            }
            hlp++;
        } while ((help == 0) || (hlp > n - i));
        if (hlp > n - i) {
            printf("\nСистема несовместна, решений нет");
            exit(0);
        }
        for (j = i + 1; j < n; j++) {
            k = -data[j][i] / help;
            for (l = i; l < n + 1; l++)
                data[j][l] = data[i][l] * k + data[j][l];
        }
    }
    printf("\nРезультат прямого шага Гаусса:\n");
    for (l = 0; l < n; l++) {
        printf("\n");
        for (j = 0; j < n + 1; j++)
            printf("%5.3lf ", data[l][j]);
    }
    helper = (double*)malloc(n * sizeof(double));
    //Обратный шаг

    if ((data[n - 1][n] * data[n - 1][n - 1] == 0) && ((data[n - 1][n] != 0 || data[n - 1][n - 1] != 0))) {
        printf("\nСистема несовместна, решений нет");
        exit(0);
    }
    else {
        for (i = n - 1; i >= 0; i--) {
            for (j = 0; j < n; j++)
                if (j != i)
                    data[i][n] -= data[i][j];
            if ((data[i][n] == 0) && (data[i][i] == 0)) {
                printf("Cложный алгоритм, напишу потом может быть, а то уже полвторого");
            }
            helper[i] = data[i][n] / data[i][i];
            for (j = 0; j < i; j++)
                data[j][i] *= helper[i];
        }
        {
            printf("\nРешение уравнения: (");
            for (i = 0; i < n; i++)
                printf("%5.3lf ", helper[i]);
            printf(")");
        }
    }
    system("pause");
}
