#include <iostream>
using namespace std;

int input;
void InfFunc(double z)
{
	if (z==0){
		cout<<"Деление на 0 :c\n";
		return;	
	}	

	double x;
	x=1/z;
	cout<<"1/z = "<<x<<"\n";
}

int main()
{
	cout<<"Введите число => "; cin>>input;
	InfFunc(input);
	return 0;
}

