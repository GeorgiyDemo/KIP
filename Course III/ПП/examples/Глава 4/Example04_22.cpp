#include <iostream>
using namespace std;
void ndiv(double x, double y)
{
    cout << "x/y= " << x / y << endl;
}
int main()
{
    double x = 10, y = 3;
    int n = 10, m = 3;
    ndiv(x, y);
    ndiv(n, m);
    return 0;
}