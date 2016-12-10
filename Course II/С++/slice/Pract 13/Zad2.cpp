#include <iostream>
using namespace std;

int nod(int a, int b,int n){
    if (a%b==0){
      n=b;
    }
    else{
      int r=b;
      b=a%b;
      a=r;
      n=b;
    }
  return n;
}

int main(){
    int c1, c2;
    cout<<"Введите два числа для нахождения НОД =>" << endl;
    cin>>c1;
    cin>>c2;
    int n=0;
    if (c1 < c2){
      int p=c2; c2=c1; c1=p;}
    do{
      n = nod(c1,c2,n);
    } while (c1%c2!=0);

    if (n!=1){
      cout << "НОД => " << n << endl;
    }
    else{
      cout << "Числа не имеют НОД" << endl;
    }
}
