#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

int sum, i, j, n, m, **a;

void initarray(int **a, int n, int m){
 srand((unsigned)time(0));
 for(i=0;i<n;i++)
    for(j=0;j<m;j++)
        a[i][j]=rand()%10-5;
}

void outarray(int **a, int n, int m){

  cout<<"\nИсходная матрица:";
  for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
      cout<<setw(5)<<a[i][j];
  }
}

void changer(int **a, int n, int m){
  int buf, l;
  //
  for (j=0;j<m;j++){
    int p=1;
    for(i=0;i<n;i++)
      p=p*a[i][j];
    a[m+1][j]=a[m][j];
    a[m][j]=p;
  }
}

int main(){

    srand(time(0));
    setlocale(LC_ALL,"rus");

    cout<<"Введите n =>"; cin>>n;
    cout<<"Введите m =>"; cin>>m;

    a = new int *[n];
    for(i=0;i<m;i++)
      a[i]=new int[m+1];

   initarray(a,n,m);
   outarray(a,n,m);
   changer(a,n,m);
   outarray(a,n,m);
   

cout<<"\n";
return 0;
}