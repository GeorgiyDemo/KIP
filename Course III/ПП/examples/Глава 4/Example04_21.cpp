#include <iostream>
using namespace std;
//Первый вариант функции:
void showArgs(double x)
{
    cout << "Double-number " << x << endl;
}
//Второй вариант функции:
void showArgs(double x, double y)
{
    cout << "Double-numbers " << x << " and " << y << endl;
}
//Третий вариант функции:
void showArgs(char s)
{
    cout << "Symbol " << s << endl;
}
//Четвертый вариант функции:
int showArgs(int n)
{
    return n;
}
int main()
{
    int n = 3;
    double x = 2.5, y = 5.1;
    char s = 'w';
    //Первый вариант функции:
    showArgs(x);
    //Второй вариант функции:
    showArgs(x, y);
    //Третий вариант функции:
    showArgs(s);
    //Четвертый вариант функции:
    cout << "Int-number " << showArgs(n) << endl;
    return 0;
}