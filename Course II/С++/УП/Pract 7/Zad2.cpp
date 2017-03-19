#include <iostream>
#include <iomanip>

using namespace std;

int i, j, n, k, **a;

void initarray() {

    cout<<"Введите n =>"; cin>>n;

    a = new int *[n];
    for(i=0;i<n;i++)
      a[i]= new int[n+1];

	for(i=0;i<n;i++)
	    for(j=0;j<n;j++)
	    	a[i][j]=i+j;
	
	for(i=0;i<n;i++){
		a[i][n-1]=n;
    }

	for(j=0;j<n;j++)
		a[n-1][j]=n;
	    
}

void outarray() {

	cout<<"\nИсходная матрица:";
	for(i=0;i<n;i++){
	    cout<<"\n";
	    for(j=0;j<n;j++)
	        cout<<setw(5)<<a[i][j];
    }
}

int main() {

    do
    {

        cout<<"\n\n1. Генерация массива по образцу\n2. Вывод массива\n0. Выход из программы\n=> ";
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