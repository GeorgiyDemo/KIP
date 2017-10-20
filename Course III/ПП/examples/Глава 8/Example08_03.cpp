#include <iostream>
using namespace std;
class MyClass{
public:
int n;
void show(){
cout<<"n = "<<n<<endl;}
};
int main(){
MyClass a,b;
//Указатели на объект:
MyClass *p,*q;
//Значения указателей:
p=&a;
q=&b;
//Доступ к полям и методам через указатель:
p->n=10;
(*q).n=20;
p->show();
(*q).show();
return 0;
}