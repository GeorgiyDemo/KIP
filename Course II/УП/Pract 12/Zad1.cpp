#include <iostream>
#include <cmath>
 
using namespace std;

int x, n, k;

void init(){
	cout<<"Введите x => "; cin>>x;
	cout<<"Введите n => "; cin>>n;
}

int counter(int x,int a){
    if (a <= 0)
        return 0;
    else
        return pow(x,a) + counter(x,a-1);
}

int main(){
	do
	  {
	    cout<<"\n\n1. Ввод x и a\n2. Вывод суммы последовательности\n0. Выход из программы\n=> ";
	    cin>>k;
	    switch (k)  
	    {  
	      case 1:  
	        init();
	        break;
	        
	      case 2:  
	        cout<<"S = "<<counter(x,n)<<"\n";
	        break;
	    }    

	  }
	  while (k!=0);

cout<<"\n";
return 0;
}