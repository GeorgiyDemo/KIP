#include <iostream>
//#include<math.h>
#include <cmath>
using namespace std;
bool sys = false;
class treygl {

public:
    double s[3];
};

class standart : public treygl {

public:
    standart(double s1, double s2, double s3)
    {
        s[0] = s1;
        s[1] = s2;
        s[2] = s3;
    }
    int sychestv()
    {
        if ((s[0] + s[1] > s[2]) && (s[0] + s[2] > s[1]) && (s[1] + s[2] 
> s[0])) {
            return 1;
        }
        else {
            return 0;
        }
    }
    double perimetr()
    {
        cout << "Периметр равен " << s[0] + s[1] + s[2] << endl;
        return s[0] + s[1] + s[2];
    }
    double ploschad()
    {
        double p = (s[0] + s[1] + s[2]) / 2;
        cout << "Площадь равна" << pow((p * (p - s[0]) * (p - s[1]) * (p 
- s[2])), 0.5) << endl;
        return pow((p * (p - s[0]) * (p - s[1]) * (p - s[2])), 0.5);
    }
    double ygl()
    {
        double a = (acos(((s[1] * s[1]) + (s[2] * s[2]) - (s[0] * s[0])) 
/ (2 * s[1] * s[2])) * 180 / 3.14159);
        double b = (acos((pow(s[0], 2) + pow(s[2], 2) - pow(s[1], 2)) / 
(2 * s[0] * s[2])) * 180 / 3.14159);
        double c = 180 - (a + b);
        cout << "Углы треугольника " << a << " " << b << " " << c << 
endl;
        double ufd[3];
        ufd[0] = a;
        ufd[1] = b;
        ufd[2] = c;
        return ufd[3];
    }
};

class pramtregl : public treygl {
public:
    pramtregl(double s11, double s21, double s31)
    {
        s[0] = s11;
        s[1] = s21;
        s[2] = s31;
    }
    int sychestv()
    {
        double d1, d2, d3;
        d1 = s[0] * s[0];
        d2 = s[1] * s[1];
        d3 = s[2] * s[2];
        if ((d1 == d2 + d3) || (d2 == d1 + d3) || (d3 == d1 + d2)) {
            return 1;
        }

        else {
            return 0;
        }
    }
};

int main()
{
    setlocale(LC_ALL, "rus");
    int n, m, o;
    cout << "n= ";
    cin >> n;
    cout << "m= ";
    cin >> m;
    bool k = false, k1 = false;
    double *a, *b, *c, *pl, *a1, *b1, *c1, *gyp;
    a = new double[n];
    b = new double[n];
    c = new double[n];
    pl = new double[n];
    a1 = new double[m];
    b1 = new double[m];
    c1 = new double[m];
    gyp = new double[m];

    cout << "Введите длины сторон треугольника для простых треугольников 
через пробел " << endl;
    for (int i = 0; i < n; i++) {
        cout << "i[" << i << "]= ";
        cin >> a[i]
            >> b[i]
            >> c[i];
    }

    for (int i = 0; i < n; i++) {
        standart ob1(a[i], b[i], c[i]);
        if (ob1.sychestv() == 1) {
            cout << "Треугольник со сторонами " << a[i] << " " << b[i] 
<< " " << c[i] << " существует" << endl;
            ob1.perimetr();
            ob1.ploschad();
            ob1.ygl();
            pl[i] = ob1.ploschad();
            k1 = true;
        }
        else {
            cout << "Треугольник со сторонами " << a[i] << " " << b[i] 
<< " " << c[i] << " не существует" << endl;
            pl[i] = 0;
        }
    }

    cout << "Введите длины сторон треугольника для прямоугольных 
треугольников через пробел " << endl;
    for (int i = 0; i < m; i++) {
        cout << "i[" << i << "]= ";
        cin >> a1[i]
            >> b1[i]
            >> c1[i];
    }

    for (int i = 0; i < m; i++) {
        pramtregl ob1(a1[i], b1[i], c1[i]);
        if (ob1.sychestv() == 1) {
            cout << "Треугольник со сторонами " << a1[i] << " " << b1[i] 
<< " " << c1[i] << " прямоугольный" << endl;
            k = true;
            gyp[i] = a1[1];
        }
        else {
            cout << "Треугольник со сторонами " << a1[i] << " " << b1[i] 
<< " " << c1[i] << " не прямоугольный" << endl;
            gyp[i] = -1000;
        }
    }
    double maxpl = pl[0];
    int ind = 0;
    for (int i = 0; i < n; i++) {
        if (pl[i] > maxpl) {
            maxpl = pl[i];
            ind = i;
        }
    }
    double mingyp = gyp[0];
    int ind1 = 0;
    for (int i = 0; i < m; i++) {
        if (gyp[i] < mingyp && gyp[i] != -1000) {
            ind1 = i;
            mingyp = gyp[i];
        }
    }
    if (k1 == true) {
        cout << "Максимальная площадь равна" << maxpl << " при длине 
сторон " << a[ind] << " " << b[ind] << " " << c[ind] << endl;
    }
    else
        cout << "Нет ни одного треугодьника" << endl;
    if (k == true) {
        cout << "Минимальная гипотенуза" << mingyp << " при длине сторон 
" << a1[ind1] << " " << b1[ind1] << " " << c1[ind1] << endl;
    }
    else
        cout << "Нет ни одного треугодьника" << endl;
    system("pause");
}
