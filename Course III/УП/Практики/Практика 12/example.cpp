#include <iostream>
using namespace std;

class B{
 int a;
public:
 B() { };
 B(int x) { a=x; }
 void show_B() { cout <<"B=   "<< a << "\n"; }
};

class D1: public B {
 int b;
public:
 D1(int x, int y) : B(y) { b=x;};
 void show_D1() { cout <<"D1=  "<< b << "\n"; show_B();}
};

class D2: private B{
 int c;
public:
 D2(int x, int y) : B(y) { c=x;};
 void show_D2() { cout <<"D2=  "<< c << "\n"; show_B();}
};

class D3: private D1, public D2 {
 int d;
public:
 D3(int x, int y, int z, int i, int j) : D1(y,z), D2(i,j) { d=x;}
 void show_D3() { cout << "D3=  "<<d << "\n"; show_D1(); show_D2();}
};

class D4: public D2, private D1 {
 int e;
public:
 D4(int x, int y, int z, int i, int j) : D1(y,z), D2(i,j) { e=x;}
 void show_D4() { cout <<"D4=  "<< e << "\n"; show_D1(); show_D2();}
};

int main() {
D3 temp(100,200,300,400,500);
D4 temp1(1,2,3,4,5);
cout << "D3 temp(100,200,300,400,500);\n";
cout << "D4 temp1(1,2,3,4,5);\n";
cout<< "\nСледуя иерархии класса D3: \n";
temp.show_D3();
cout<< "\nСледуя иерархии класса D4\n";
temp1.show_D4();
return 0;
}