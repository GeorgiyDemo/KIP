//Создать базовый класс кошки и производные классы московская и сибирская
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class CatClass {
	
	protected:
		string name;
		string colour;
		double weight;

	public:
		void ShowCat(){
			cout<<"\nИнформация о коте:";
			cout<<"\nИмя: "<<name;
			cout<<"\nЦвет: "<<colour;
			cout<<"\nВес: "<<weight<<" кг.";
		}
};

class SiberianCatClass: public CatClass{
	double sherst;
public:
	void SetSiberianCat(string n="Кот без имени (сибирский)", string c="Обычный, но сибирский", double w=2.0, double s=30){
		name=n;
		colour=c;
		weight=w;
		sherst=s;
	}
	void ShowSiberianCat(){
		cout<<"\n<Сибирская кошка>";
		ShowCat();
		cout<<"\nШерсть: "<<sherst<<" см.\n";
	}
};


class MoscowCatClass: public CatClass{
	double sherst;

public:
	void SetMoscowCat(string n="Кот без имени (Московский)", string c="Обычный, но столичный", double w=2.5, double s=10.5){
		name=n;
		colour=c;
		weight=w;
		sherst=s;
	}
	void ShowMoscowCat(){
		cout<<"\n<Московская кошка>";
		ShowCat();
		cout<<"\nШерсть: "<<sherst<<" см.\n";
	}
};

int main(){
	
	SiberianCatClass SiberianCat_obj1,SiberianCat_obj2;

	SiberianCat_obj1.SetSiberianCat();
	SiberianCat_obj1.ShowSiberianCat();
	SiberianCat_obj2.SetSiberianCat("Мурка-мяуколка","Рыжий",3.0,20);
	SiberianCat_obj2.ShowSiberianCat();

	MoscowCatClass MoscowCat_obj1, MoscowCat_obj2;
	MoscowCat_obj1.SetMoscowCat();
	MoscowCat_obj1.ShowMoscowCat();
	MoscowCat_obj2.SetMoscowCat("Московский котик","Черный",2.5,15);
	MoscowCat_obj2.ShowMoscowCat();
	

cout<<"\n";
return 0;
}