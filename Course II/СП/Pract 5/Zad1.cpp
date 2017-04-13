#include <iostream>
using namespace std;

int sum, i, n=10;
int a[10]={1,2,1,3,2,1,5,3,1,4};

void outarray(int *a, int n){

	cout<<"[";
	for(i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

int summ(int *a, int n){
	int sum=0;

	for(i=0;i<n;i++)
		sum+=a[i];

return sum;
}

int main(){

	srand(time(0));
    setlocale(LC_ALL,"rus");

	cout<<"Исходный массив:";
	outarray(a,n);

	cout<<"Сумма элементов: "<<summ(a,n);

cout<<"\n";
return 0;
}