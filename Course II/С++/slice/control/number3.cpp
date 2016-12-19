#include <stdio.h>
#include <stdlib.h>

using namespace std;

int main()
{
	int i,j,a[10][10],n,sum[10],num[10],chet;
	chet=0;

	scanf("%d",&n);
	rand();
	for (i=0;i<n;i++){
		printf("\n");
		for (j=0;j<n;j++){
			a[i][j]=(rand()%10);
			printf("%5d",a[i][j]);
			if (a[i][j]%2==0)
				chet+=1;

		}
	}
	printf("\nchet = %d",chet);
	for (i=0;i<n;i++){
		num[i]=0;
		sum[i]=0;
		for (j=0;j<n;j++)
			if (a[i][j]<0)
				num[i]++;
			if (num[i]==0)
				for (j=0;j<n;j++)
					sum[i]+=a[i][j];
	}
	for (i=0;i<n;i++)
		if(num[i]==0)
			printf("\nВ строке %d сумма = %d",i+1,sum[i]);
	printf("\n");
	return 0;
}
