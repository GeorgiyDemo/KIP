#include <iostream>
#include <ctime>
using namespace std;

int *a, i, n, k, num;

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

void finder(){
	int index1=0;
	cout<<"Введите число A => "; cin>>num;
	for(i=0;i<n;i++)
	    if (a[i]==num){
	    	cout<<"\n\nЭлемент B найден!\n";
	    	index1=i;
	    	cout<<"№"<<i+1<<". B="<<a[i]<<"\n";
	    	break;
	    }

	for(i=n-1;i>=0;--i)
		if (a[i]==num){
			if (index1!=i){
				cout<<"Элемент C найден!\n";
				cout<<"№"<<i+1<<". C="<<a[i];
			}
			else
				cout<<"Элементы C и B совпадают :c";
		break;
		}
}

int main(){

	setlocale(LC_ALL,"rus");

	do
    {
     cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Поиск элементов массива\n0. Выход из программы\n=> ";
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
            finder();
            break;

      }    

    } while (k!=0);

cout<<"\n";
return 0;

}