#include <iostream>
#include <stdlib.h>
#include <string>
#include <time.h>

using namespace std;

int i, n, *a;

void input(int *a, int n){
    srand((unsigned)time(0)); 
    for(int i=0; i<n; i++)
        a[i] = (rand()%5)-1;
}

void outarr(int *a, int n){

    cout<<"------------------\nИсходный массив:\n";
    for (i=0;i<n;i++)
        cout<<a[i]<<" ";
    cout<<"\n";
}

void proiz(int *a, int n){
    int index1, index2, proz;
    bool flag = false;
    index1=index2=0;
    proz = 1;

     for (i=0;i<n;i++)
        if (a[i] == 0){
            index1 = i;
            flag = true;
            break;
        }
    for (i=0;i<n;i++)
        if ((a[i] == 0) && (i != index1)){
            index2 = i;
            flag = true;
            break;
        }
    for (i=index1+1;i<index2;i++){
        proz=proz*a[i];
    }
    (flag==false)?cout<<"Нет нулевых элементов":cout<<"Proiz => "<<proz;
}

void sred(int *a, int n){
    int nechet, chet, kol1, kol2;
    double rez1, rez2;
    chet=nechet=kol1=kol2=0;
    
    for (i=0;i<n;i++){
        //четное
        if (a[i]%2==0){
            chet+=a[i];
            kol2++;
        }
        //нечетное
        if (a[i]%2==1){
            nechet+=a[i];
            kol1++;
        }
    }
    rez1 = (double) nechet/(double) kol1;
    rez2 = (double) chet/(double) kol2;

    cout<<"\n------------------\nСреднее арифметическое\nЧетные элементы: "<<rez2<<"\nНечетные элементы: "<<rez1;
    (rez1>rez2)?cout<<"\nСреднее арифметическое нечетных элементов больше":cout<<"\nСреднее арифметическое четных элементов больше";
    cout<<"\n------------------";
} 

void sort(int *a, int n){
  int *b,k, j;
  b = new int[n];
  j=k=0;
  for(i=0;i<n;i++){
    if (i%2==0){
      b[j]=a[i];
      j++;
      k++;
      a[i]=0;
    }
  }

  for(i=0;i<n;i++){
    if (a[i]!=0){
      b[k]=a[i]; 
      k++;
    }
  }

  cout<<"\nПосле сортировки:\n";
  for(i=0;i<n;i++)
    cout<<b[i]<<" ";
  cout<<"\n";
}

int n14()
{
  setlocale( LC_ALL,"Russian" );
  cout<<"n => ";
  cin>>n;

  a=new int[n];
  
  input(a,n);
  outarr(a,n);
  proiz(a,n);
  sred(a,n);
  sort(a,n);
  
  delete [] a;

return 0;
}