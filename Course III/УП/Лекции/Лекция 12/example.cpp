#include <iostream>
#include <math.h>

using namespace std;
class MyClass{
public:
double x,y;
}; 
//Передача аргумента по значению: 
double f1(MyClass obj){obj.x++;
obj.x*=10+obj.y; 
return obj.x;
}
//Передача аргумента по ссылке:
double f2(MyClass &obj){{obj.x++;
obj.x*=10+obj.y; 
return obj.x;}
}
int main(){
	MyClass obj;
	obj.x=5;
	obj.y=2;
	cout<<"x = "<<f1(obj)<<endl;
	cout<<"x = "<<obj.x<<endl;
	cout<<"x = "<<f2(obj)<<endl;
	cout<<"x = "<<obj.x<<endl;
	return 0;}
