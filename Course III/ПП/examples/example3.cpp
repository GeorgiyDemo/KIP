#include <iostream>
using namespace std;

int main()
{
	int n, *p, *q;
	int &copy=n;

	p=&n;
	copy=100;
	(*p)/=10;
	q=&copy;
	n++;
	cout<<n<<"\n";    //11
	cout<<copy<<"\n"; //11
	cout<<*p<<"\n";   //11
	cout<<*q<<"\n";   //11
	cout<<p<<"\n";    //адрес1
	cout<<q<<"\n";    //адрес1
	
return 0;
}