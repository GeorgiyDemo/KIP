#include <iostream>
using namespace std;
int main()
{
    int n;
    cout << "Enter number from 0 to 10: ";
    cin >> n;
    switch (n) {
    case 0:
        cout << "The number is zero!\n";
        break;
    case 1:
    case 2:
    case 3:
    case 5:
    case 8:
        cout << "This is Fibonacci number!\n";
        break;
    default:
        cout << "This is integer number!\n";
    }
    return 0;
}