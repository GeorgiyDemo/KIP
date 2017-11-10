/*
Перегрузить оператор "+" чтобы он был как бинарным,
так и унарным
*/
#include <iomanip>
#include <iostream>
#include <string>
using namespace std;

class coord {
	public:
	int x,y;
		coord(int a=0, int b=0){
			x=a;
			y=b;
		}

		coord operator-(coord a){
			coord temp;
			temp.x=x-a.y;
			temp.y=y-a.y;
			return temp;
		}

		//Бинарный
		coord operator-(){
			x=-x;
			y=-y;
			return *this;
		}

		//Унарный
		coord operator-(int a){
			coord temp;
			temp.x = x-a;
			temp.y = y-a;
			return temp;
		}
		
};

int main(){

	coord a(3,5), b(1,5),c;
	c=b-a;
	cout<<"c = ["<<c.x<<","<<c.y<<"]\n";
	-c;
	cout<<"-c = ["<<c.x<<","<<c.y<<"]\n";
	c=b-2;
	cout<<"c = ["<<c.x<<","<<c.y<<"]\n";

cout<<"\n";
return 0;
}