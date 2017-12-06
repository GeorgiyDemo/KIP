#include <iostream>
using namespace std;
class B2 {
    int e;

public:
    B2(int x, int y){};
    B2(int x) { 
        e = x; }
    void show_B2() { cout << "B2=  " << e << "\n"; }
};

class B1 {
    int a;

public:
    B1(int x, int y, int i, int j){};
    B1(int x) { a = x; }
    void show_B1() { cout << "B1=  " << a << "\n"; }
};

class D1 : private B2, public B1 {
    int b;

public:
    D1(int x, int y,int i,int u) : B2(x), B1(i) { b = x; };

    void show_D1()
    {
        cout << "D1=  " << b << "\n";
        show_B1();
        show_B2();
    }
};

class D2 : public D1 {
	int c;
public:
	D2(int x, int y,int i,int u) :  D1(x, y, i,u) { c = i; }
	void show_D2() { cout << "D2=  " << c << "\n";  show_D1(); }
};


class D3 : public D2 {
	int d;
public:
	D3(int x, int y,int i,int u) :  D2(x, y, i,u) { d = i; }
	void show_D3() { cout << "D3=  " << d << "\n";  show_D2(); }
};

int main()
{
    setlocale(LC_ALL, "rus");

    D3 temp(100, 200, 300, 400);
    cout << "\nПолученная иерархия: \n";
    temp.show_D3();

    return 0;
}
