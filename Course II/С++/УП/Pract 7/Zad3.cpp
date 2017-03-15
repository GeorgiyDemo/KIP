#include <iostream>
#include <iomanip>
#include <stdio.h>
#include <ctime>
using namespace std;
int main()
{int n,m,j,i,k;
	int a[20][20];
	int min[20];
srand(time(0));
	cout<<"\n n= ";cin>>n;
	cout<<"\n m= ";cin>>m;
    cout<<"Исходная матрица"<<endl;
	cout<<"\n";
	for(i=0;i<n;i++)
	{
		for(j=0;j<m;j++)
		{
			a[i][j]=rand()%20;
			cout<<" "<<setw(6)<<a[i][j];
		}
		cout<<"\n";
	}
	cout<<"\n Массив минимув"<<endl;
	cout<<"\n";
	for(i=0;i<n;i++)
	{
		min[i]=a[i][1];
		for (j=1;j<m;j++)
		if (a[i][j]<min[i])
		
			min[i]=a[i][j];
			cout<<" "<<min[i]<<"\n";

		

		
	}

}
