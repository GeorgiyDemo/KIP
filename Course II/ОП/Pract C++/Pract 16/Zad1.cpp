#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

int sum, i, j, n, m, **a;

void initarray(int **a, int n, int m){
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

void outarray(int **a, int n, int m){

 cout<<"\nМатрица:            Сум. отр. \n";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m+1;j++)
        cout<<setw(5)<<a[i][j];
 }
}

void sort(int **a, int n, int m){
  int buf, l;
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

int main(){

    srand(time(0));
    setlocale(LC_ALL,"rus");

    cout<<"n =>"; cin>>n;
    cout<<"m =>"; cin>>m;

    a = new int *[n];
    for(i=0;i<m;i++)
        a[i]=new int[m+1];
   initarray(a,n,m);
   outarray(a,n,m);
   //sort(a,n,m);
   cout<<"\nПосле сортировки:\n-----------------------";
   outarray(a,n,m);
   cout<<"\n";

return 0;
}