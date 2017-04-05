#include <iostream>
#include <iomanip>

using namespace std;

int *x, *y, i, n, k;
double sr;

void initarray(){
    
    srand(time(0));
    srand((unsigned)time(0));
    cout<<"Введите размерность n => "; cin>>n;

    x = new int [n];
    cout<<"Массив x: ";
    for(i=0;i<n;i++){
      x[i]=-10+rand()%20;
      sr+=x[i];
      cout<<x[i]<<" ";
    } 

    sr=sr/n;

    cout<<"\nМассив y: ";
    y = new int [n];
    for(i=0;i<n;i++){
      y[i]=-10+rand()%20;
      cout<<y[i]<<" ";
    } 

    for (i=0;i<n;i++)
      if (x[i]==y[i])
        k++;
  
    cout<<"\n\nCреднее арифметическое массива х: "<<sr;
    cout<<"\nЧисло случаев равенства пар: "<<k;
  
}

int main(){

  do
  {
    cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Сред. арифметическое\n4. Число случаев равенства пар\n0. Выход из программы\n=> ";
    cin>>k;
    switch (k)  
    {  
      case 1:  
        initarray();
        break;

    }    

  }
  while (k!=0);

cout<<"\n";
return 0;
}