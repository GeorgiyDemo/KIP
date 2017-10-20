#include <iostream>
using namespace std;
void hello()
{
    cout << "Hello, my friend!\n";
}
void hello(char str[], char name[] = "Alex")
{
    cout << str << ", " << name << "!" << endl;
}
int main()
{
    hello();
    hello("Hello", "Peter");
    hello("Hi");
    return 0;
}