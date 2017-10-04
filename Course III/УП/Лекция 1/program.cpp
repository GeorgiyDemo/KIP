#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

class a{

	public:
		string x;
		string y;
		
		void hello(){
			cout<<x<<y;
		}


};

int main(){
	a ob2("Hello", "FFF");
	ob2.hello();



cout<<"\n";
return 0;
}