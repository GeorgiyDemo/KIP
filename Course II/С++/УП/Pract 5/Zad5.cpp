#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

int *a, one, two, sum, num, i, j, n, m;

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

void finder(int *a, int n, int num){
	int index1=0;

	for(i=0;i<n;i++)
	    if (a[i]==num){
	    	cout<<"\n\nЭлемент B найден!\n";
	    	index1=i;
	    	cout<<"№"<<i+1<<". B="<<a[i]<<"\n";
	    	break;
	    }

	for(i=n-1;i>=0;--i)
		if (a[i]==num){
			if (index1!=i){
				cout<<"Элемент C найден!\n";
				cout<<"№"<<i+1<<". C="<<a[i];
			}
			else
				cout<<"Элементы C и B совпадают :c";
		break;
		}
}

int main(){

	srand(time(0));
    setlocale(LC_ALL,"rus");

    cout<<"\nВведите n => "; cin>>n;
	a = new int [n];
	initarray(a,n);
	cout<<"Исходный массив:";
	outarray(a,n);
	cout<<"Введите число A => "; cin>>num;
	finder(a,n,num);

cout<<"\n";
return 0;

}