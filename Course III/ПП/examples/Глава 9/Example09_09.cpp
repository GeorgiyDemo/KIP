#include <iostream>
using namespace std;
class MyExp {
public:
    int n;
    double* p;
    MyExp(int i, double x)
    {
        n = i;
        p = new double[n + 1];
        p[0] = 1;
        for (int k = 1; k <= n; k++)
            p[k] = p[k - 1] * x / k;
    }
    ~MyExp() { delete[] p; }
};
int main()
{
    int n, i;
    double x, s = 0;
    cout << "enter n= ";
    cin >> n;
    cout << "enter x= ";
    cin >> x;
    MyExp obj(n, x);
    for (i = 0; i <= n; i++)
        s += obj.p[i];
    cout << "exp(" << x << ")= " << s << endl;
    return 0;
}