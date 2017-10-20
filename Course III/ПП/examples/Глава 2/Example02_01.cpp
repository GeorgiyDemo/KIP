#include <iostream>
using namespace std;
int main()
{
    double x, y;
    cout << "x=";
    cin >> x;
    cout << "y=";
    cin >> y;
    if (y != 0)
        cout << "x/y =" << x / y << "\n";
    else
        cout << "Division by zero!\n";
    return 0;
}