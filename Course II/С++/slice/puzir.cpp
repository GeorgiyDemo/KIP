 
#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;
void bubbleSort(int *, int); // прототип функции сортировки пузырьком
int main(int argc, char* argv[])
{
    srand(time(NULL));
    setlocale(LC_ALL, "rus");
    cout << "Введите размер массива: ";
    int size_array; // длинна массива
    cin >> size_array;
 
    int *sorted_array = new int [size_array]; // одномерный динамический массив
    for (int counter = 0; counter < size_array; counter++)
    {
        sorted_array[counter] = rand() % 100; // заполняем массив случайными числами
        cout << setw(2) << sorted_array[counter] << "  "; // вывод массива на экран
    }
    cout << "\n\n";
    bubbleSort(sorted_array, size_array); // вызов функции сортировки пузырьком
    for (int counter = 0; counter < size_array; counter++)
    {
        cout << setw(2) << sorted_array[counter] << "  "; // печать отсортированного массива
    }
    cout << "\n";
 
    printf("Ready!\n");
    return 0;
}

void bubbleSort(int* arrayPtr, int length_array) // сортировка пузырьком
{
 int temp = 0; // временная переменная для хранения элемента массива
 bool exit = false; // болевая переменная для выхода из цикла, если массив отсортирован
 while (!exit) // пока массив не отсортирован
 {
  exit = true;
  for (int int_counter = 0; int_counter < (length_array - 1); int_counter++) // внутренний цикл
    if (arrayPtr[int_counter] > arrayPtr[int_counter + 1]) // сравниваем два соседних элемента
    {
     temp = arrayPtr[int_counter];
     arrayPtr[int_counter] = arrayPtr[int_counter + 1];
     arrayPtr[int_counter + 1] = temp;
     exit = false; // на очередной итерации была произведена перестановка элементов
    }
 }
}