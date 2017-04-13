#include <iostream>
#include <ctime>

using namespace std;

int *a, i, k, n;

void initarray(){

	srand(time(0));
 	srand((unsigned)time(0));
 	cout<<"\nВведите n => "; cin>>n;
 	a = new int [n];
	for(i=0;i<n;i++)
	    a[i]=rand()%100;

}

void outarray(){

	cout<<"[";
	for(i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

void changer(){
	for(i=0;i<n;i++)
	    if ((a[i]%2==1) && (i%2==0))
	    	a[i]=0;

}

int main(){

    setlocale(LC_ALL,"rus");

    do
    {
     cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Замена элементов массива\n0. Выход из программы\n=> ";
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
            changer();
            break;

      }    

    } while (k!=0);

cout<<"\n";
return 0;

}