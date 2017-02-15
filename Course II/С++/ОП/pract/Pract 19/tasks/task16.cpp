#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

void initarray16(int **a, int n, int m){
 int i, j, sum;
 srand((unsigned)time(0));
 for(i=0;i<n;i++){
    for(j=0;j<m;j++){
        a[i][j]=rand()%10-5;
        if (a[i][j]<0)
          sum+=a[i][j];
    }
  a[i][m]=sum;
  sum=0;  
  }
}

void outarray16(int **a, int n, int m){
 int i, j;
 cout<<"\nМатрица:            Сум. отр. \n";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m+1;j++)
        cout<<setw(5)<<a[i][j];
 }
}

void sort16(int **a, int n, int m){
  int buf, l, i, j;
  for (i=0;i<n-1;i++)
    for (l=i+1;i<n;l++)
      if (a[i][m]<a[l][m]){
        for (j=0;j<m;j++){
            buf=a[i][j];
            a[i][j]=a[l][j];
            a[l][j]=buf;
        }
      }
}

int n16(){

    int sum, i, j, n, m, **a;

    srand(time(0));
    setlocale(LC_ALL,"rus");

    cout<<"n =>"; cin>>n;
    cout<<"m =>"; cin>>m;

    a = new int *[n];
    for(i=0;i<m;i++)
        a[i]=new int[m+1];
      
   initarray16(a,n,m);
   outarray16(a,n,m);
   sort16(a,n,m);
   cout<<"\nПосле сортировки:\n-----------------------";
   outarray16(a,n,m);
   cout<<"\n";

return 0;
}