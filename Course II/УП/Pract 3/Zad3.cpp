#include <iostream>
#include <cmath>

using namespace std;

int main(){

	int i=0;
    double e, a;

    cout<<"Введите число e => "; cin>>e;

    do{

        i++;
        a=1-1/sin(i);
        cout<<i<<". "<<a<<" "<<"\n";

    }

    while (fabs(a)<e);

cout<<"Заданное условие достигается за "<<i<<" шаг(а) 🐱\n";
return 0;
}