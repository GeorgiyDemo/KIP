#include <stdio.h>
#include <stdlib.h>
#include <math.h>

using namespace std;

int *a,n,i,j,k=0;

void input(int *a,int n){
	rand();
	for (i=0;i<n;i++){
		a[i]=(rand()%10);
		printf("%d ",a[i]);
	}
}

void prost(int *a,int n){
	int m;
	for (i=0;i<n;i++){
		m=0;
		for (j=2;j<abs(a[i]);j++)
			if (abs(a[i])%j!=0)
				m++;
			if (m==0)
				k++;
	}
	printf("\nВ массиве %d простых чисел",k);
}

void summa(int *a,int n){
	int suma=0;
	for (i=0;i<n;i++)
		if (a[i]>0)
			suma+=a[i];
		printf("\nСумма положительных = %d\n",suma);
}

int main(){
	printf("n => ");
	scanf("%d",&n);
	a = new int[n];
	input(a,n);
	prost(a,n);
	summa(a,n);

	delete []a;

	return 0;
}