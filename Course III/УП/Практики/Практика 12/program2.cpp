#include <iostream>
using namespace std;

class B1{
 int a;
public:
 B1() { };
 B1(int x) { a=x; }
 void show_B1() { cout <<"B1=   "<< a << "\n"; }
};

class B2{
 int a;
public:
 B2() { };
 B2(int x) { a=x; }
 void show_B2() { cout <<"B2=   "<< a << "\n"; }
};

class D1: private B2, public B1 {
 int d;
public:
 D1(int x, int y, int z, int i, int j) : B2(y,z), B1(i,j) { d=x;}
 void show_D1() { cout << "D1=  "<<d << "\n"; show_B2(); show_B1();}
};

class D2: private D1{
 int c;
public:
 D2(int x, int y) : D1(y) { c=x;};
 void show_D2() { cout <<"D2=  "<< c << "\n"; show_B();}
};

class D3: public D2{
 int c;
public:
 D3(int x, int y) : B(y) { c=x;};
 void show_D3() { cout <<"D3=  "<< c << "\n"; show_B();}
};

int main() {
D3 temp(100,200,300,400,500);
D4 temp1(1,2,3,4,5);
cout << "D1 temp(100,200,300,400,500);\n";
cout << "D4 temp1(1,2,3,4,5);\n";
cout<< "\nСледуя иерархии класса D1: \n";
temp.show_D2();
cout<< "\nСледуя иерархии класса D4\n";
temp1.show_D3();
return 0;
}