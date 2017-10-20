#include <iostream>
#include <cstdlib>
#include <cstring>
using namespace std;
int main()
{
    char s1[20], s2[20];
    strcpy(s1, "My name is ");
    strcpy(s2, "Alex");
    for (int i = 0; s2[i]; s2[i] = toupper(s2[i]), i++)
        ;
    strcat(s1, s2);
    cout << s1 << endl;
    return 0;
}