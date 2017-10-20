#include <iostream>
#include <cstdio>
using namespace std;
int main()
{
    const int n = 3;
    int i;
    char s[n][50];
    for (i = 0; i < n; i++) {
        cout << "Enter a string: ";
        gets(s[i]);
    }
    for (i = 0; i < n; i++)
        cout << s[i] << endl;
    return 0;
}