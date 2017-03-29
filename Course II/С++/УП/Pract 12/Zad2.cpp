#include <iostream>
#include <ctime>
using namespace std;

int n, i;

void recursion(int n){
    int k = 1;
    int k2 = 0;
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

    cout<<"Введите n => "; cin>>n;
    cout<<"Первые "<<n<<" элементов последовательности:\n";
    recursion(n);

cout<<"\n";
return 0;
}
