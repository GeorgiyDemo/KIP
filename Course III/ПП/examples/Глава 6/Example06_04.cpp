#include <iostream>
using namespace std;
struct Numbers{
int integer;
double real;
char symbol;
};
void show(Numbers x){
cout<<"Integer: "<<x.integer<<endl;
cout<<"Real: "<<x.real<<endl;
cout<<"Symbol: "<<x.symbol<<endl;
}
int main(){
Numbers a,b;
Numbers *p,*q;
p=&a;
q=&b;
p->integer=1;
p->real=2.5;
p->symbol='a';
(*q).integer=2;
(*q).real=5.1;
(*q).symbol='b';
show(a);
show(*q);
return 0;
}