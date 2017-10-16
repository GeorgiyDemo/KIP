#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class papkaclass{

	string name;
	double size;
	bool password;

	public:
		//Конструктор с полями по умолчанию
		papkaclass(string n="Новая папка", double s=0, bool p=false);
		//Деструктор
		~papkaclass();
		//Методы
		void info();
		void rename(string n, double s, bool p);
};

papkaclass::papkaclass(string n, double s, bool p){
	cout<<"Конструктор работает\n";
	name=n;
	size=s;
	password=p;
}

void papkaclass::rename(string n, double s, bool p){
	cout<<"\n\nПереименовали папку "<<name<<" на "<<n; name=n;
	cout<<"\nИзменили размер с "<<size<<" на "<<s; size=s;
	cout<<"\nИзменили пароль с "<<password<<" на "<<p; password=p;
}

void papkaclass::info(){
	cout<<"\n\nИнформация по объекту:";
	cout<<"\nИмя: "<<name;
	cout<<"\nРазмер:"<<size;
	cout<<"\nПароль:"<<password;

}

papkaclass::~papkaclass(){
	cout<<"\nУдалили папку '"<<name<<"'";
}

int main(){
	papkaclass p1, p2;
	
	papkaclass* p3;
	p3= new papkaclass;

	p1.rename("MEOW",1234,true);
	p3->rename("КОТЫ",481,false);

	p1.info();
	p2.info();
	p3->info();

	delete p3;
cout<<"\n";
return 0;
}