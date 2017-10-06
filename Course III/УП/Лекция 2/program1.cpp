#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class myclass{

		int a;
	public:
		myclass();
		//Деструктор
		~myclass();
		//Методы
		void set(int x){
			a=x;
		}

		void show();
};

myclass::myclass(){
	cout<<"Конструктор\n";
	a=0;
}

myclass::~myclass(){
	cout<<"Деструктор\n";
}

void myclass::show(){
	cout<<a<<"\n";
}

int main(){

	myclass* p;
	int* i;
	p = new myclass; //тут уже исполняется конструктор
	p->show();
	i = new int[10];
	delete p;

cout<<"\n";
return 0;
}