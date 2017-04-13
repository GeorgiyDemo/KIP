#include <iostream>
#include <string>
#include <curses.h>

using namespace std;
typedef int (*IntFunction) ();

/**
 *
 * Рисует шапку
 *
 */
void drawHeader(string title)
{
    printf("\n\n\n\n\n\n\n\n\n\n\n\n");

    printf("\n\n\n +--------------------------------------------------+\n");
        printf("       %s\n", title.c_str());
        printf(" +--------------------------------------------------+\n\n");


}

/**
 *
 * Выводит сообщение
 *
 */
void ShowIt(string str)
{

    printf("\n [ Output ]: %s", str.c_str());
}

/**
 *
 * Выводит сообщение->предупреждение
 *
 */
void Warning(string str)
{

    printf("\n [ WARNING! ]: %s", str.c_str());
}

/**
 *
 * Выводит пустую строку
 *
 */
void nullLine()
{
    printf("\n");
}

/**
 *
 * Выводит шапку с номером практической
 * и спрашивает задание
 *
 */
int getPractice(int n, int count)
{
    int step;

    drawHeader("Выбрана практическая №" + to_string(n));

    ShowIt("Введите номер подзадания 1.."+to_string(count)+": "); cin >> step;

    return step;
}

/**
 *
 * Создает новую практическую
 *
 */
int newPractical(int number, int count, IntFunction callback[])
{
    p1:
    int i = getPractice(number, count)-1;

    if(i > count-1) Warning("Задание с номером " + to_string(i+1) + " не найдено в практической " + to_string(number));
    else callback[i]();

    nullLine();
    nullLine();

    int n;

    ShowIt("Запустить еще раз? (0 - Да, 1 - Нет): "); cin>>n;

    if(n == 0) goto p1;
    return 1;
}



/**
 * Функция обрезания строки
 */
string cutStr(string a, int c)
{
    return a.substr(0, a.length()-c);
}



