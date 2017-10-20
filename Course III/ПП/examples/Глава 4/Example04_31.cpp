#include <iostream>
using namespace std;
void ShowStr(char* str)
{
    if (*str != 'i' && *str)
        ShowStr(str + 1);
    else if (*str == 'i')
        return;
    else {
        cout << "I didn't find any 'i'!\n";
        exit(0);
    }
    cout << *str;
}
int main()
{
    char s[80];
    cout << "Enter text here: ";
    gets(s);
    ShowStr(s);
    cout << endl;
    return 0;
}