#include <iostream>
#include <iomanip>

using namespace std;

int i, j, n, m, sum, com, k, **a;

void initarray(){
  int kot=0;

    cout<<"Введите n =>"; cin>>n;
    cout<<"Введите m =>"; cin>>m;

    a = new int *[n];
    for(i=0;i<n;i++)
      a[i]=new int[m+1];

  for(i=0;i<n;i++)
    for(j=0;j<m;j++){
        cout<<"Введите элемент ["<<i<<"]["<<j<<"] => "; cin>>kot;
        a[i][j]=kot;
    }
}

void counter(){

  sum=0;k=0;com=1;
  for(i=0;i<n;i++)
    for(j=0;j<m;j++)
      if (a[i][j]<0){
          com*=a[i][j];
          sum+=a[i][j];
          k++;
        }
  cout<<"\n\nКол-во отриц. элементов: "<<k<<"\nСумма отриц. элементов: "<<sum<<"\nПроизведение отриц. элементов: "<<com;
}

void outarray(){

  cout<<"\nИсходная матрица:";
  for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
        cout<<setw(5)<<a[i][j];
  }
}

int main(){

  do
  {
    cout<<"\n\n1. Ручной ввод массива\n2. Вывод массива\n3. Вычисление\n0. Выход из программы\n=> ";
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
        counter();
        break;

    }    

  }
  while (k!=0);

cout<<"\n";
return 0;
}