#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
#include <cmath>
using namespace std;
 
int main(){
	int a,b,c;
	double result;
	cout<<"\n";
	cout<<"Введите число А => "; cin>>a;
	cout<<"Введите число B => "; cin>>b;
	cout<<"Введите число C => "; cin>>c;

	if ((a==b) && (b==c) && (c==a)){
		cout<<"Все числа равны!\n";
		result=a*a+b*b+c*c;
		cout<<"Сумма квадратов всех чисел: "<<result;
	}
	else if ((a>b) && (b>c)){
		b=a;
		c=a;
		cout<<"\na="<<a<<"\nb="<<b<<"\nc="<<c;
	}
	else if ((b>a) && (c<b)){
		a=b;
		c=b;
		cout<<"\na="<<a<<"\nb="<<b<<"\nc="<<c;
	}
	else if ((c>a) && (c>b)){
		a=c;
		b=c;
		cout<<"\na="<<a<<"\nb="<<b<<"\nc="<<c;
	}

cout<<"\n";
return 0;

}                                                 