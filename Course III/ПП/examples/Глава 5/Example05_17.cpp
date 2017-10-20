#include <iostream>
#include <cstdio>
using namespace std;
void decoder(char* s, int* cstr, int n)
{
    char str[100];
    int i;
    for (i = 0; i < n; i++) {
        str[i] = s[cstr[i]];
    }
    str[n] = '\0';
    cout << str << endl;
}
int main()
{
    char s[] = "He would remember that honesty is the best policy!";
    int cstr[] = { 0, 10, 6, 45, 4, 49, 2, 0, 4, 3, 17, 20, 9, 1, 8, 29, 24, 5 };
    decoder(s, cstr, 18);
    return 0;
}