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

	cout<<"\nВведите число А => "; cin>>a;
	cout<<"Введите число B => "; cin>>b;
	cout<<"Введите число C => "; cin>>c;

	if ((a==b) && (b==c) && (c==a)){
		cout<<"Все числа равны!\n";
		result=a*a+b*b+c*c;
		cout<<"Сумма квадратов всех чисел: "<<result<<"\n";
		exit(0);
	}
	else if ((a>b) && (b>c)){
		b=a;
		c=a;
	}
	else if ((b>a) && (c<b)){
		a=b;
		c=b;
	}
	else if ((c>a) && (c>b)){
		a=c;
		b=c;
	}

cout<<"\na="<<a<<"\nb="<<b<<"\nc="<<c<<"\n";
return 0;

}                                                 