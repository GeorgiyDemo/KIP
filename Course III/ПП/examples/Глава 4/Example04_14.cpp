#include <iostream>
using namespace std;
int length(char* str)
{
    for (int s = 0; *str; s++, str++)
        ;
    return s;
}
int main()
{
    char str[20] = "This is a string";
    cout << "Length is " << length(str) << endl;
    return 0;
}