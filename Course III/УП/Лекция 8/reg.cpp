#include <iostream>
#include <string>
#include <regex>

using namespace std;
class MyClass {
public:
    string revizor(string str)
    {
	    regex r("[\\+|-]?((\\d+\\.?\\d*)|(\\.\\d+))([e|E][\\+|-]?\\d+)?"); // entire match will be 2 numbers
	    smatch m;
	    regex_search(str, m, r);
	    for(auto v: m) return v;
    }
};

using namespace std;
int main()
{
	string s;
	MyClass obj;
	cout<<"Введите строку => "; cin>>s;

	cout<<obj.revizor(s);

cout<<"\n";
return 0;
}