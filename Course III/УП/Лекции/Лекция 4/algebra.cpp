#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class algebra{

	double x;
	double y;

	public:
		//Методы
		void sum(double x, double y);
		void minus(double x, double y);
		void proiz(double x, double y);
		void raznost(double x, double y);
};

void algebra::sum(double x, double y){
	cout<<"\nСумма "<<x<<" и "<<y<<" = "<<x+y;
}

void algebra::minus(double x, double y){
	cout<<"\nРазность "<<x<<" и "<<y<<" = "<<x-y;
}

void algebra::proiz(double x, double y){
	cout<<"\nПроизведение "<<x<<" и "<<y<<" = "<<x*y;
}

void algebra::raznost(double x, double y){
	if (y==0)
		cout<<"\nДеление на 0, так делать нельзя!";
	else
		cout<<"\nРазность "<<x<<" и "<<y<<" = "<<(double) (x/y);
}

int main(){

	double x1, y1;
	algebra obj;

	cout<<"Введите x =>"; cin>>x1;
	cout<<"Введите y =>"; cin>>y1;

	obj.sum(x1,y1);
	obj.minus(x1,y1);
	obj.proiz(x1,y1);
	obj.raznost(x1,y1);

cout<<"\n";
return 0;
}