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
		double x;

		coord (double ox=0){
			x=ox;
		}

		friend coord operator++(coord &a){
			return a;
		}
		friend coord operator++(coord a){
			coord tmp_obj;
			tmp_obj.x=a.x++;
			return tmp_obj;
		}

		//friend coord operator++(coord b){
		//	coord tmp_obj;
		//	tmp_obj.x=a.x++;
		//	return tmp_obj;
		//}
};

int main(){

	coord a(3),c;
	a++;
	cout<<"c = ["<<c.x<<"]\n";
	//*c;
	//cout<<"*c = ["<<c.x<<","<<c.y<<"]\n";
	//c=b*2;
	//cout<<"c = ["<<c.x<<","<<c.y<<"]\n";

cout<<"\n";
return 0;
}