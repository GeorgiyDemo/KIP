#include <iostream>
using namespace std;

int main()
{
	int n;
	int &copy=n;
	copy=100;
	n++;
	cout<<n<<"\n";    //101
	cout<<copy<<"\n"; //101

return 0;
}