#include <iostream>
#include <ctime>
using namespace std;

int n, i, k;

void init(){
    cout<<"Введите n => "; cin>>n;
}

void recursion(int n){
    int k = 1;
    int k2 = 0;
    cout<<"Первые "<<n<<" элементов последовательности:\n";
    for (i=0;i<n;i++){
        cout<<k<<' ';
        k2+=1;
        if (k2==k){
            k+=1;
            k2=0;
        }
    }
}


int main(){

    do
      {
        cout<<"\n\n1. Ввод кол-ва элементов последовательности\n2. Вывод элементов последовательности\n0. Выход из программы\n=> ";
        cin>>k;
        switch (k)  
        {  
          case 1:  
            init();
            break;
            
          case 2:  
            recursion(n);
            break;
        }    

      }
      while (k!=0);

cout<<"\n";
return 0;
}
