#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
#include <cmath>
using namespace std;
 
int main(){

    double x,check;
    cout<<"Введите чило для проверки => "; cin>>x;
    check = sqrt(x);
    cout<<"\nКвадрат числа: "<<check;

    //Проверка на остаток числа 
    check-=floor(check);

    if (check == 0)
        cout<<"\nДанное чило является квадратом";
    else 
        cout<<"\nДанное чило не является квадратом";

cout<<"\n";
return 0;
}