#include <iostream>
#include <cmath>
 
using namespace std;

int x, n;

int pow(int a,int n){
  return (!n)?1:a*pow(a,n-1);
}

int counter(int x,int a){
    if (a <= 0)
        return 0;
    else if (a)
        return pow(x,a) + counter(x,a-1);
}

int main()
{   
	cout<<"Введите x => "; cin>>x;
	cout<<"Введите n => "; cin>>n;
	cout<<"S = "<<counter(x,n)<<"\n";
    return 0;
}