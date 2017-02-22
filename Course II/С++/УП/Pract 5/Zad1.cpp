#include <iostream>
#include <iomanip>
using namespace std;

int *a, one, two, sum, i, j, n, m;

void initarray(int *a, int n, int one, int two){

	a[0]=one;
	a[1]=two;
	for(i=2;i<n;i++)
	    a[i]=(a[i-1]+a[i-2])*i;

}

void outarray(int *a, int n){

	cout<<"\nПреобразованный массив:\n[";
	for(i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

int main(){

    setlocale(LC_ALL,"rus");

    cout<<"\nВведите n => "; cin>>n;
    cout<<"Введите 1-й элемент массива => "; cin>>one;
    cout<<"Введите 2-й элемент массива => "; cin>>two;

	a = new int [n];
	initarray(a,n,one,two);
	outarray(a,n);

return 0;

}