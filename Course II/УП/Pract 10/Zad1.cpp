#include <iostream>
#include <ctime>
using namespace std;

int *a, i, j, n, k;

void initarray(){

    srand(time(0));
    srand((unsigned)time(0));
    n=15;
    a = new int [n];
  for(i=0;i<n;i++)
        a[i]=-10+rand()%20;
}

void bubblesort(){

  int buf;
  for (i=0;i<n-1;i++){
    for (j=0;j<(n-i-1);j++){
        if (abs(a[j]) > abs(a[j+1])){
            buf=a[j];
            a[j]=a[j+1];
            a[j+1]=buf;
        }
    }
  }
}

void chosesort(){

  int min, buf;
  for (i=0;i<n-1;i++){
    min=i;
    for (j=i+1;j<n;j++){
        if (abs(a[j]) < abs(a[min]))
            min=j;
    }
    buf=a[i];
    a[i]=a[min];
    a[min]=buf;
  }

}

void insertsort(){

  int buf, item;
  for (i=1;i<n;i++){
    buf=a[i];
    item=i-1;
    while((item >= 0) && (abs(a[item]) > abs(buf))){
      a[item+1]=a[item];
      a[item]=buf;
      item--;
    }
  }
}

void outarray(){

  cout<<"\nИсходный массив:\n[";
  for(i=0;i<n;i++)
        cout<<" "<<a[i];
  cout<<"]";
}

int main(){

  do
  {
    cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Сортировка пузырьком\n4. Сортировка выбором\n5. Сортировка вставкой\n0. Выход из программы\n=> ";
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
        bubblesort();
        break;

      case 4:  
        chosesort();
        break;

      case 5:  
        insertsort();
        break; 

    }    

  }
  while (k!=0);

cout<<"\n";
return 0;
}