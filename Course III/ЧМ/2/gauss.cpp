#include <iostream>
#include <iomanip>

using namespace std;

int i, j, n, k, sum, input;
double *x, *b, **a;

//Процедура рандома для массивов
void initarray(double **a, int n){
 srand((unsigned)time(0)); 
 for(i=0;i<n;i++){
    for(j=0;j<n;j++)
        a[i][j]=rand()%10-5;
    b[i]=rand()%10-5;
    x[i]=rand()%10-5;
  }
}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем матрицу А>\n";
  for (i=0;i<n;i++)
    for (j=0;j<n;j++){
      cout<<"Введите элемент ["<<i<<"]["<<j<<"]: ";
      cin>>a[i][j];
    }

  cout<<"<Заполняем столбец свободных членов B>\n";
  for (i=0;i<n;i++){
      cout<<"Введите элемент №"<<i<<": ";
      cin>>b[i];
      x[i]=rand()%10-5;
    }

}

//Процедура вывода всех массивов на экран
void outarray(double **a, int n){
 cout<<"\nИсходная матрица:\n";
 for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<n;j++)
        cout<<setw(5)<<a[i][j];
    cout<<setw(3)<<"|"<<setw(3)<<b[i];
 }
}

//Процедура вычислений по Гауссу
void gauss(double **a, double *b, double *x, int n){
  
  for(k=0;k<=n-2;k++)
    for(i=k+1;i<=n-1;i++){
        double t=a[i][k]/a[k][k];
        b[i]=b[i]-t*b[k];
        
        for(j=k+1;j<=n-1;j++)
          a[i][j]=a[i][j]-t*a[k][j];
    }

    for(k=n-1;k>=0;k--){

      sum=0;
      for(j=k+1;j<n;j++)
        sum=sum+a[k][j]*x[j];

      x[k]=(b[k]-sum)/a[k][k];
    }

  cout<<"\n\nРезультаты вычислений:\n\n";
  for(i=0;i<n;i++)
    cout<<i+1<<". "<<x[i]<<"\n";
}

int main()
{
    cout<<"Введите кол-во неизвестных в системе => "; cin>>n;

    x = new double [n];
    b = new double [n];
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
    gauss(a,b,x,n);

cout<<"\n";
return 0;
}