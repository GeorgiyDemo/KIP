#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class cord3d{

		int x;
		int y;
		int z;
	public:
		cord3d(int x1=0, int y1=0, int z1=0);
		//Деструктор
		//Методы
		void set(int x1, int y1, int z1){
			x=x1;
			y=y1;
			z=z1;
		}

		void show();
};

cord3d::cord3d(int x1, int y1, int z1){
	cout<<"Конструктор\n";
	x=x1;
	y=y1;
	z=z1;
}

void cord3d::show(){
	cout<<"x="<<x<<"\n";
	cout<<"y="<<y<<"\n";
	cout<<"z="<<z<<"\n";


}

int main(){

	//Обязательная процедура для динамического выделения памяти под объекты 
	cord3d ob1;

	ob1.set(4,2,3);
	ob1.show();

	//ob1=ob3;
	//ob2=ob4;

	//ob1.show();
	//ob2.show();
	//ob3.show();
	//ob4.show();

cout<<"\n";
return 0;
}