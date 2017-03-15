#include <iostream>
#include <iomanip>
#include <stdio.h>
#include <ctime>
using namespace std;
int main()
{int n,m,j,i,k,max,min,mini,minj,maxi,maxj,buf;
	int a[20][20];
	srand(time(0));
	cout<<"\n n= ";cin>>n;
	cout<<"\n m= ";cin>>m;
	cout<<"\n Исходная матрица"<<endl;
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
max=a[1][1];
min=a[1][1];
for(i=0;i<n;i++)
	for(j=0;j<m;j++)
	{
		if (a[i][j]>max)
		{
			max=a[i][j];
			maxi=i;
			maxj=j;
		}
		if (a[i][j]<min)
		{
			min=a[i][j];
	 	    mini=i;
		    minj=j;
	}
}
	cout<<"\n max= "<<max;
	cout<<"\n min= "<<min;
	cout<<"\n Меняем"<<endl;
buf=max;
a[maxi][maxj]=a[mini][minj];
a[mini][minj]=buf;
    for(i=0;i<n;i++)
{cout<<"\n"<<endl;
for(j=0;j<m;j++)
	cout<<" "<<setw(6)<<a[i][j];
}
	cout<<"\n ";
}
