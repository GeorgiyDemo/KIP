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
		double x,y;

		coord (double ox=0,double oy=0){
			x=ox; 
			y=oy;
		}

		friend coord operator*(coord &a){
			return a;
		}
		friend coord operator*(coord a,coord b){
			coord tmp_obj;
			tmp_obj.x=b.x*a.x;
			tmp_obj.y=b.y*a.y;
			return tmp_obj;
		}

		friend coord operator*(coord b, int a){
			coord tmp_obj;
			tmp_obj.x=b.x*a;
			tmp_obj.y=b.y*a;
			return tmp_obj;
		}
};

int main(){

	coord a(3,5), b(1,5),c;
	c=b*a;
	cout<<"c = ["<<c.x<<","<<c.y<<"]\n";
	*c;
	cout<<"*c = ["<<c.x<<","<<c.y<<"]\n";
	c=b*2;
	cout<<"c = ["<<c.x<<","<<c.y<<"]\n";

cout<<"\n";
return 0;
}