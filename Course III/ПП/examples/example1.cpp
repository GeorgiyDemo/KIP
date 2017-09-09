#include <iostream>
using namespace std;

int main()
{
	int n, *p, **q;

	p=&n;
	q=&p;
	n=100;
	(*p)+=5;
	(**q)--;

	cout<<n<<"\n";    //104
	cout<<*p<<"\n";   //104
	cout<<**q<<"\n";  //104
	cout<<p<<"\n";    //адрес1
	cout<<q<<"\n";    //адрес2

return 0;
}