/*
    Создайте массив mas размерностью 30 элементов и заполните его случайным образом
    числами от 1 до 99 в десятичном формате. 
    После этого выведите все числа на экран в несколько форматированных столбцов 
    в восьмеричной системе счисления. 
    Создайте новый массив mas1, разделив элементы массива mas на {1,0,2} соответственно.
    Обработайте исключения
*/

#include <iostream>
#include <iomanip>

using namespace std;
int decToOct(int x)
{
    int i = 1;
    int oct = 0;
    while (x > 0) {
        oct += (x % 8) * i;
        i *= 10;
        x = x / 8;
    }
    return oct;
}

int main()
{
    int mas[30], mas1[30];
    int i, n, oct, n1, z1, z2;

    srand(100);
    n = 30;
    for (i = 0; i < n; i++)
        mas[i] = (int)((((double)rand()) / ((double)RAND_MAX)) * 99) + 1;
    printf("Massiv mas v 8:\n");
    for (i = 0; i < n; i++) {
        oct = decToOct(mas[i]);
        printf("%8d %8d", mas[i], oct);
        //printf("%8d", oct);
        if ((i + 1) % 3 == 0)
            printf("\n");
    }

    n1 = 0;
    for (i = 0; i < n; i++) {
        z1 = mas[i] / 10;
        z2 = mas[i] % 10;
        if ((z1 > 0 && z1 < 3) || (z2 >= 0 && z2 < 3))
            mas1[n1++] = mas[i];
    }

    printf("\n");
    printf("Massiv mas1:\n");
    for (i = 0; i < n1; i++) {
        printf("%3d", mas1[i]);
    }

cout<<"\n";
return 0;
}