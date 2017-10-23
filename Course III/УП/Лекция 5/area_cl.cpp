#include <iomanip>
#include <iostream>
#include <string>
using namespace std;

class area_cl{
	public:
	
		double height;
		double width;
};

class rectangle: public area_cl{
		
	public:

		rectangle(double h=10, double w=5){
			height=h;
			width=w;
		}

		void агеа(){
			cout<<"Площадь прямоугольника:\n";
			cout<<height*width<<"\n";
		}
};

class isosceles: public area_cl{
		
	public:

		isosceles(double h=5, double w=10){
			height=h;
			width=w;
		}

		void агеа(){
			cout<<"Площадь равнобедреного треугольника:\n";
			cout<<(height*width)/2<<"\n";
		}
};

int main(){
	
	rectangle obj1;
	isosceles obj2;

	obj1.агеа();
	obj2.агеа();

cout<<"\n";
return 0;
}