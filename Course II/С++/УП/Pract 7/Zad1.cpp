#include <iostream>
#include <iomanip>

using namespace std;

int com, k, sum, i, j, n, m, **a;

void initarray(int **a, int n, int m){
 int kot;
 sum=0;k=0;kot=0;com=1;
 for(i=0;i<n;i++)
    for(j=0;j<m;j++){
        cout<<"Введите элемент ["<<i<<"]["<<j<<"] => "; cin>>kot;
        a[i][j]=kot;
        if (a[i][j]<0){
          com*=a[i][j];
          sum+=a[i][j];
          k++;
        }
    }
}

void outarray(int **a, int n, int m){

 cout<<"\nИсходная матрица:";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(5)<<a[i][j];
 }
 cout<<"\n\nКол-во отриц. элементов: "<<k<<"\nСумма отриц. элементов: "<<sum<<"\nПроизведение отриц. элементов: "<<com;
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

   cout<<"\n";

return 0;
}