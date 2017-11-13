#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class counter{

	int meow;

	public:

		counter(int start_int){
			meow=start_int;
			cout<<"Введите число => "; cin>>start_int;
		}

		int changer(int start_int){
			start_int++;
			return start_int;
			
		}

		void outer(int start_int){
			cout<<start_int;
			
		}
		
		counter(){
			cout<<"Деструктор живой";
		}

};

int main(){

	counter kot(5);
	cout<<kot.changer(6);
	kot.outer(6);

cout<<"\n";
return 0;
}