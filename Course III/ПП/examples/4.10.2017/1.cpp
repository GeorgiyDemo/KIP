#include <iostream>
using namespace std;

int msum (int n)
{
	int s=0;
	for (int i=1;i<=n;i++)
		s++;
return s;
}

int main()
{
	int n;
	cout<<"Введите n =>"; cin>>n;
	cout<<"Сумма: "<<msum(n)<<"\n";
	return 0;
}

