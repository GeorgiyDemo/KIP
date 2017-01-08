#include <stdio.h>
#include <stdlib.h>

using namespace std;

int main(){
	int a[10][10],i,j,l,n,m,k[10],buf;
	rand();
	printf("Введите n=>"); scanf("%d",&n);
	printf("Введите m=>"); scanf("%d",&m);
	for (i=0;i<n;i++){
		k[i]=0;
		printf("\n");
		for (j=0;j<m;j++){
			a[i][j]=(rand()%10);
			printf("%5d",a[i][j]);
			if (a[i][j]==0)
				k[i]+=1;
		}
	}
	for (i=0;i<n-1;i++)
		for(l=i;l<n;l++)
			if (k[i]>k[l]){
				for (j=0;j<m;j++){
					buf=a[i][j];
					a[i][j]=a[l][j];
					a[l][j]=buf;
				}
				buf=k[i];
				k[i]=k[l];
				k[l]=buf;
			}
			printf("\nОтсортированная матрица");
			for (i=0;i<n;i++){
				printf("\n");
				for (j=0;j<m;j++)
					printf("%5d",a[i][j]);
			}
	printf("\n");
	return 0;
}