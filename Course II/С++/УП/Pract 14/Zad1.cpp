#include <iostream>
#include <iomanip>

using namespace std;

int i, j, n, m, k, sum, **a;

void initarray(){
    
    srand(time(0));
    srand((unsigned)time(0));
    cout<<"Введите n =>"; cin>>n;
    cout<<"Введите m =>"; cin>>m;

    a = new int *[n];
    for(i=0;i<n;i++)
      a[i]=new int[m+1];

  for(i=0;i<n;i++)
    for(j=0;j<m;j++)
        a[i][j]=-10+rand()%20;
}

void summ(){

  sum=0;
  for(i=0;i<n;i++)
    for(j=0;j<m;j++)
      if (i==j)
          sum+=a[i][j];
  cout<<"Сумма элементов на главной диагонали:\n"<<sum;

}

void outarray(){

  cout<<"\nИсходная матрица:";
  for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(5)<<a[i][j];
  }
}

void changer(){

  for (i=0;i<n-1;i++)
    for (j=i+1;j<n;j++)
      if (a[i][j]<0){
        cout<<"Замена ["<<i<<"]["<<j<<"] "<<a[i][j]<<" на "<<abs(a[i][j])<<"\n";
        a[i][j]=abs(a[i][j]);
      }

}

int main(){

  do
  {
    cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Сумма элементов\n4. Замена отриц.элементов\n0. Выход из программы\n=> ";
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
        summ();
        break;

      case 4:  
        changer();
        break;

    }    

  }
  while (k!=0);

cout<<"\n";
return 0;
}