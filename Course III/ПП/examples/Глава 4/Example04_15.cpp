#include <iostream>
using namespace std;
int main(int size, char* str[])
{
    int i;
    for (i = 0; i < size; i++)
        cout << i + 1 << "-th argument is: " << str[i] << endl;
    return 0;
}