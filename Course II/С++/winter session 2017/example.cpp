//Сортировка строк матрицы: четные строки по возрастанию, а нечетные по убыванию

#include <iostream>
#include <iomanip>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main(){
	int **a,i,j,n,m,buf,k;
	cout<<"n="; cin>>n;
	cout<<"\nm="; cin>>m;
	srand(time(NULL));
	a = new int *[n];
	for (i=0;i<n;i++){
		cout<<"\n";
		a[i] = new int[m];
		for (j=0;j<n;j++){
			a[i][j]=rand()%100-7;
			cout<<setw(6)<<a[i][j];
		}
	}
	cout<<"\n\n";
	for (i=0;i<n;i++)
		if(i%2==0){
			for (j=0;j<m-1;j++)
				for (k=j+1;k<m;k++)
					if (a[i][j]>a[i][k]){
						buf=a[i][j];
						a[i][j]=a[i][k];
						a[i][k]=buf;
					}
				
		}
		else
			for(j=0;j<m-1;j++)
				for(k=j+1;k<m;k++)
					if(a[i][j]<a[i][k]){
						buf=a[i][j];
						a[i][j]=a[i][k];
						a[i][k]=buf;
					}
					for (i=0;i<n;i++){
						cout<<"\n";
						for (j=0;j<m;j++)
							cout<<setw(6)<<a[i][j];
					}
	cout<<"\n";
	return 0;
}