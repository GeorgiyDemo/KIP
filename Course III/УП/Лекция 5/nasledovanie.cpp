#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class fruit {
	
	protected:
		string forma;
		char colour;
		int weight;
	public:
		void show(){
			cout<<forma<<" "<<colour<<" "<<weight<<"\n";
		}
};

class Apple: public fruit{
	int kol_vo;
public:
	void set_apple(string form="шар", char c ='g', int w=350, int k=10){
		forma=form;
		colour=c;
		weight=w;
		kol_vo=k;
	}
	void show_apple(){
		cout<<kol_vo;
		show();
	}
};

int main(){
	Apple apple1, apple2, apple3;
	
	apple1.set_apple();
	apple2.set_apple("квадрат",'r',700, 15);
	apple3.set_apple("шар",  'o',  150, 5);
	
	apple1.show_apple();
	apple2.show_apple();
	apple3.show_apple();


cout<<"\n";
return 0;
}