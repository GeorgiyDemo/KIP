#include <iostream>
#include <cmath>
using namespace std;
const double pi = 3.1415;
class MyFunc {
    double f[3];
    double t;
    double f1(double z)
    {
        return 3 * sin(6 * pi * z) * cos(2 * pi * z);
    }
    double f2(double z)
    {
        return 5 * sin(6 * pi * z) * sin(2 * pi * z);
    }
    double f3(double z)
    {
        return 4 * cos(6 * pi * z);
    }
    void set()
    {
        f[0] = f1(t);
        f[1] = f2(t);
        f[2] = f3(t);
    }

public:
    double* operator()(double z)
    {
        t = z;
        set();
        return f;
    }
    double operator[](int k)
    {
        if (!(k % 4))
            return t;
        else
            return f[(k - 1) % 4];
    }
    MyFunc()
    {
        t = 0;
        set();
    }
};
int main()
{
    MyFunc F;
    double time = 0.125;
    int i;
    for (i = 0; i < 3; i++)
        cout << F(time)[i] << " ";
    cout << endl;
    for (i = 1; i <= 4; i++)
        cout << F[i] << " ";
    cout << endl;
    return 0;
}