#include <iostream>
using namespace std;
int main()
{
    char str1[20] = "hello";
    char str2[20] = { 'h', 'e', 'l', 'l', 'o', '\0' };
    cout << str1 << "\n";
    cout << str2 << "\n";
    return 0;
}