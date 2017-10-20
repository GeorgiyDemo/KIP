#include <iostream>
#include <cmath>
using namespace std;
struct Line {
    double a;
    double b;
    double c;
};
void cross(Line A, Line B)
{
    double x0, y0;
    if (A.a * B.b == A.b * B.a) {
        if (A.a * B.c != A.c * B.a)
            cout << "Parallel lines!\n";
        else
            cout << "Lines coincide!\n";
    }
    else {
        x0 = (A.b * B.c - B.b * A.c) / (A.a * B.b - A.b * B.a);
        y0 = (A.a * B.c - A.c * B.a) / (A.b * B.a - B.b * A.a);
        cout << "x0 = " << x0 << "   y0 = " << y0 << endl;
    }
}
int main()
{
    Line L1, L2, L3, L4;
    L1.a = 2;
    L1.b = -1;
    L1.c = 0;
    L2.a = 6;
    L2.b = -3;
    L2.c = 6;
    L3.a = 10;
    L3.b = -5;
    L3.c = 0;
    L4.a = 2;
    L4.b = 0;
    L4.c = -8;
    cross(L1, L2);
    cross(L1, L3);
    cross(L1, L4);
    return 0;
}