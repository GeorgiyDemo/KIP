#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

int *a, one, two, sum, i, j, n, m;

void initarray(int *a, int n){
 	srand((unsigned)time(0));
	for(i=2;i<n;i++)
	    a[i]=rand()%100;

}

void outarray(int *a, int n){

	cout<<"[";
	for(i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

void changer(int *a, int n){
	for(i=2;i<n;i++)
	    if ((a[i]%2==1) && (i%2==0))
	    	a[i]=0;

}

int main(){

	srand(time(0));
    setlocale(LC_ALL,"rus");

    cout<<"\nВведите n => "; cin>>n;

	a = new int [n];
	initarray(a,n);
	cout<<"Исходный массив:";
	outarray(a,n);
	changer(a,n);
	cout<<"Измененный массив:";
	outarray(a,n);

return 0;

}