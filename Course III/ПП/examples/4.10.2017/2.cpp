#include <iostream>
using namespace std;

void msum2()
{
	int n;
	cout<<"Введите n= "; cin>>n;
	int s=0;
	for (int i=1;i<=n;i++)
		s++;
	cout<<"Сумма: "<<s<<"\n";
}

int main()
{
	msum2();
	return 0;
}

