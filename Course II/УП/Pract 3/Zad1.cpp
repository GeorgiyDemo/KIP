#include <iostream>

using namespace std;
 
int main(){

    int n,i;
    double s;
    cout<<"Введите сумму вклада (руб) => "; cin>>s;
    cout<<"На сколько лет делаем вклад? => "; cin>>n;
    
    for (i=0;i<n;i++){
        s=s+s/100*2;
    }

    cout<<"\nВаша сумма будет = "<<s<<" руб. через "<<n<<" лет\n";
return 0;
}