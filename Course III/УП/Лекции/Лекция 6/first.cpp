#include <iostream>
#include <string>
using namespace std;
char min(char a, char b);
int min(int a, int b);
double min(double a, double b);

int main()
{
	cout << "Example int: " << min(1, 2) << "\n";
	cout << "Example double: " << min(1.1, 2.2) << "\n";
	cout << "Example char: "<< min('1', '2')<<"\n";
	return 0;
}

char min(char a, char b){
	if (a < b)
		return a;
	return b;
}
int min(int a, int b){
	if (a < b)
		return a;
	return b;
}
double min(double a, double b){
	if (a < b)
		return a;
	return b;
}