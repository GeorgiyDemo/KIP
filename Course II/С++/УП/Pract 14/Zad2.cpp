#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int i, j, n, m, k, mymax, sum;
double **a;

int compare(int a, int b){
  if (a<b) return a;
  return b;
  }

void initarray(){
    
    srand(time(0));
    srand((unsigned)time(0));
    cout<<"Введите n =>"; cin>>n;
    cout<<"Введите m =>"; cin>>m;

    a = new double *[n];
    for(i=0;i<n;i++)
      a[i]=new double[m+1];

  for(i=0;i<n;i++)
    for(j=0;j<m;j++)
        a[i][j]=-20+rand()%20;
}

void outarray(){

  cout<<"\nИсходная матрица:";
  for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(8)<<a[i][j];
  }
}

void sort(){

  sum=0;
  mymax=abs(a[0][0]);
  for(i=0;i<n;i++)
    for(j=0;j<m;j++){
      if (fabs(a[i][j])>mymax)
        mymax=fabs(a[i][j]);
      if ((a[i][j]<0) && (i==j))
          sum++;
    }

  if (sum==compare(n,m)){
    cout<<"Все элементы диагонали отрицательны, макс. элемент: "<<mymax;
    for(i=0;i<n;i++)
      for(j=0;j<m;j++)
        a[i][j]= (double)a[i][j]/mymax;
  }
  else
    cout<<"Отрицательны не все элементы диагонали, завершаем работу";
  }

int main(){

  do
  {
    cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Сортировка\n0. Выход из программы\n=> ";
    cin>>k;
    switch (k)  
    {  
      case 1:  
        initarray();
        break;
        
      case 2:  
        outarray();
        break;

      case 3:  
        sort();
        break;

    }    

  }
  while (k!=0);

cout<<"\n";
return 0;
}