#include <iostream>
#include <iomanip>
using namespace std;

int *a, i, k, n;

void initarray(){
    
    int one, two;
	cout<<"\nВведите n => "; cin>>n;
	a = new int [n];

    cout<<"Введите 1-й элемент массива => "; cin>>one;
    cout<<"Введите 2-й элемент массива => "; cin>>two;

	a[0]=one;
	a[1]=two;
	for(i=2;i<n;i++)
	    a[i]=(a[i-1]+a[i-2])*i;

}

void outarray(){

	cout<<"\nПреобразованный массив:\n[";
	for(i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

int main(){

    setlocale(LC_ALL,"rus");

    do
    {
     cout<<"\n\n1. Генерация массива\n2. Вывод массива\n0. Выход из программы\n=> ";
     cin>>k;
     switch (k)  
      {  
         case 1:  
            initarray();
            break;
          
         case 2:  
            outarray();
            break;

      }    

    } while (k!=0);

cout<<"\n";
return 0;

}