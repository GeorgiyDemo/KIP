#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

int i, j, n, m, k, sum, input;
double kot, pkot, *x, **a, **p, *p1;

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
      cout<<"Введите погрешность для элемента ["<<i+1<<"]["<<j+1<<"]: ";
      cin>>p[i][j];
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
 cout<<"\nПогрешности элементов матрицы:\n";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(5)<<p[i][j];
 }
}

//Процедура вычислений по Гауссу + нахождение погрешности
void gauss(double **a, double *x, int n){
  
  for(i=0;i<n;i++){
    kot=a[i][i];
    pkot=p[i][i];
    for(j=n;j>=i;j--){
      //Формула №1 (чек)
      p[i][j]=(fabs(a[i][j])*pkot+fabs(kot)*p[i][j])/(kot*kot);
      a[i][j]/=kot;
    }
    for(j=i+1;j<n;j++){
      kot=a[j][i];
      pkot=p[j][i];
      for(k=n;k>=i;k--){
        //Формула №2 (чек)
        p[j][k]=fabs(a[i][k])*pkot+fabs(kot)*p[j][k];
        a[j][k]=a[j][k]-kot*a[i][k];
      }
    }
  }

  x[n-1]=a[n-1][n];
  for(i=n-2;i>=0;i--){
    x[i]=a[i][n];
    p1[i]=p[i][n];
    for(j=i+1;j<n;j++){
      x[i]=x[i]-a[i][j]*x[j];
      //Формула №3 (чек)
      p1[i]=p1[i]+(fabs(a[i][j])*p[i][n]+fabs(x[j])*p[i][j]);
    }
  }

  cout<<"\n\nОтвет:";
  for(i=0;i<n;i++){
    cout<<"\n"<<x[i];
  }
  cout<<"\n\nПогрешности:";
  for(i=0;i<n;i++){
    cout<<"\n"<<p1[i];
  }

}

int main()
{
    cout<<"Введите n => "; cin>>n;
    cout<<"Введите m => "; cin>>m;

    x = new double [m];
    p1 = new double [m];
    a = new double *[n];
    for(i=0;i<n;i++)
        a[i]=new double[n];
    p = new double *[n];
    for(i=0;i<n;i++)
        p[i]=new double[n];
  
 
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