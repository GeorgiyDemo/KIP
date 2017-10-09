#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class myclass{

		int a;
		int b;
	public:
		myclass(int n=100, int k=50);
		//Деструктор
		~myclass();
		//Методы
		void set(int x){
			a=x;
		}

		void show(int m=10);
};

myclass::myclass(int n, int k){
	cout<<"Конструктор\n";
	a=n;
	b=k;
}

myclass::~myclass(){
	cout<<"Деструктор\n";
}

void myclass::show(int m){
	cout<<"a = "<<a<<"\nm="<<m<<"\n";
}

int main(){

	//Обязательная процедура для динамического выделения памяти под объекты 
	myclass ob1, ob2(15), ob3(12,8), ob4(100,45);
	myclass ob[4];

	for (int i=0; i<4; i++){
		ob[i].show();
	}

	//ob1=ob3;
	//ob2=ob4;

	//ob1.show();
	//ob2.show();
	//ob3.show();
	//ob4.show();

cout<<"\n";
return 0;
}