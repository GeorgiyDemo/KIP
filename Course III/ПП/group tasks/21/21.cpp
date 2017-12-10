#include <iostream>
#include <cmath>
#include <math.h>
using namespace std;

class MyLog {
public:
    double x;
    int N;
    double Ln()
    {
        double ln1 = x, lnotv = x;
        int i;

        for (int i = 2; i <= N; i++) {

            ln1 = pow(x, i) / i;
            if (i % 2 == 1) {
                cout << lnotv << "+(" << pow(x, i) << "/" << i;
                lnotv += ln1;
                cout << ")= " << lnotv << endl;
            }
            else {
                cout << lnotv << "-(" << pow(x, i) << "/" << i;
                lnotv -= ln1;
                cout << ")= " << lnotv << endl;
            }
        }
        return lnotv;
    }
};

int main()
{
    setlocale(LC_ALL, "rus");
    MyLog a;
    cout << "Введите число для получения логарифма = ";
    cin >> a.x;
    cout << "Введите диапазон = ";
    cin >> a.N;
    cout << "ln ( " << 1 + a.x << ") = " << a.Ln() << endl;
    cout << "ln ( " << 1 + a.x << ") = " << log(1 + a.x) << endl;
    system("pause");
}
