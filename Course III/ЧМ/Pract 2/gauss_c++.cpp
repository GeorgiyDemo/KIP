#include <iostream>
#include <iomanip>

using namespace std;

int i, j, n, m, k, sum, input;
double kot, *x, **a;

//Процедура рандома для массивов
void initarray(double **a, int n){
 srand((unsigned)time(0)); 
 for(i=0;i<n;i++){
    for(j=0;j<m;j++)
        a[i][j]=rand()%10-5;
    x[i]=rand()%10-5;
  }
}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем матрицу А>\n";
  for (i=0;i<n;i++)
    for (j=0;j<m;j++){
      cout<<"Введите элемент ["<<i+1<<"]["<<j+1<<"]: ";
      cin>>a[i][j];
    }

}

//Процедура вывода всех массивов на экран
void outarray(double **a, int n){
 cout<<"\nИсходная матрица:\n";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(5)<<a[i][j];
 }
}

//Процедура вычислений по Гауссу
void gauss(double **a, double *x, int n){
  
  for(i=0;i<n;i++){
    kot=a[i][i];
    for(j=n;j>=i;j--)
      a[i][j]/=kot;
    for(j=i+1;j<n;j++){
      kot=a[j][i];
      for(k=n;k>=i;k--)
        a[j][k]-=kot*a[i][k];
    }
  }

  x[n-1]=a[n-1][n];
  for (i=n-2;i >= 0;i--){
    x[i]=a[i][n];
    for(j=i+1;j<n;j++)
      x[i] -= a[i][j] * x[j];
  }

  cout<<"\n\nОтвет:";
  for(i=0;i<n;i++){
    cout<<"\n"<<x[i];
  }
}

int main()
{
    cout<<"Введите n => "; cin>>n;
    cout<<"Введите m => "; cin>>m;

    x = new double [m];
    a = new double *[n];
    for(i=0;i<n;i++)
        a[i]=new double[n];
  
 
    cout<<"\nКак вы хотите ввести матрицу?\n1. Ручной ввод исходной матрицы\n2. Рандомный ввод исходной матрицы\n=> ";
    cin>>input;

    switch (input)
    {
      case 1:
        enter();
        break;

      case 2:
        initarray(a,n);
        break;
    }

    outarray(a,n);
    gauss(a,x,n);

cout<<"\n";
return 0;
}