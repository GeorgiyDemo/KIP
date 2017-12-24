/*
	Шаблон - определяет набор операций, который будет применятся к разным типам данных
	Это такие классы функций, для которых определены все алгоритмы, но фактические типы обрабатываемых данных будут сообщены позднее либо при создании каких-либо объектов класса либо при создании функции. Здесь есть особенности написания. 
*/

#include <iomanip>
#include <iostream>
using namespace std;

template <class type1, class type2> void myfunc(type1 x, type2 y){
	cout<<x<<" "<<y<<"\n";	
}

void myfunc(int i, double j){
	cout<<"Это версия приоритетная!"<<"\n";	
}


template <class x>void swapargs(x&a, x&b){
	x temp;
	temp=a;
	a=b;
	b=temp;
}

int main(){
	int i=10;
	int j=20;
	float x=10.1, y=23.3;
	cout<<"Исходные данные i и j "<<i<<","<<j<<"\n";
	cout<<"Исходные данные x и y "<<x<<" "<<y<<"\n";
	swapargs(i,j);
	swapargs(x,y);
	cout<<"Исходные данные i и j "<<i<<","<<j<<"\n";
	cout<<"Исходные данные x и y "<<x<<" "<<y<<"\n";
}