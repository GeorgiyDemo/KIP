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

		coord operator+(coord ob){
			coord temp;
			temp.x = x + ob.x;
			temp.y = y+ ob.y;
			return temp;
		}

		coord operator-(coord ob){
			coord temp;
			temp.x = x - ob.x;
			temp.y = y - ob.y;
			return temp;
		}

		coord operator/(coord ob){
			coord temp;
			if (ob.x !=0)
				temp.x = x/ob.x;
			else
				cout<<"Деление на 0 по y!";

			if (ob.y !=0)
				temp.y = y/ob.y;
			else
				cout<<"Деление на 0 по y!";

			return temp;
		}

		coord operator*(coord ob){
			coord temp;
			temp.x = x * ob.x;
			temp.y = y * ob.y;
			return temp;
		}

		coord operator--(){
			x--;
			y--;
			return *this;
		}
};

	coord operator++(coord &ob){
		ob.x++;
		ob.y++;
		return ob;
	}

int main(){

	coord ob(3,5),ob1(1,5),ob2;
	ob2 = ob+ob1;
	cout<<ob2.x<<","<<ob2.y<<"\n";
	ob2=ob-ob1;
	cout<<ob2.x<<","<<ob2.y<<"\n";
	ob2=ob/ob1;
	cout<<ob2.x<<","<<ob2.y<<"\n";
	ob2.x=0;
	ob2.y=0;
	//ob2++;
	cout<<ob2.x<<","<<ob2.y<<"\n";

cout<<"\n";
return 0;
}