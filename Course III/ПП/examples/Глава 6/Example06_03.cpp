#include <iostream>
#include <cstdio>
#include <cstring>
#include <cstdlib>
using namespace std;
struct Marks {
    char name[80];
    int phys;
    int chem;
    int maths;
};
void set_one(Marks& str)
{
    cout << ("Student name: ");
    gets(str.name);
    str.phys = 3 + rand() % 3;
    str.chem = 3 + rand() % 3;
    str.maths = 3 + rand() % 3;
}
void set_all(Marks* str, int m)
{
    for (int i = 0; i < m; i++)
        set_one(str[i]);
}
void get(Marks* str, int m)
{
    bool state;
    char s[80];
    do {
        cout << "What is the student name? ";
        gets(s);
        if (!strcmp(s, "exit"))
            return;
        state = true;
        for (int i = 0; i < m; i++) {
            if (!strcmp(str[i].name, s)) {
                state = false;
                cout << "Physiscs: " << str[i].phys << endl;
                cout << "Chemistry: " << str[i].chem << endl;
                cout << "Mathematics: " << str[i].maths << endl;
                break;
            }
        }
        if (state)
            cout << "There is no student with such name\n";
    } while (true);
}
int main()
{
    const int n = 3;
    Marks students[n];
    set_all(students, n);
    get(students, n);
    return 0;
}