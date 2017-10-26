#include <iostream>
#include <string>
#include <time.h>
#include <Windows.h>

using namespace std;
void sleep1(int a);
void sleep1(string a);

int _tmain(int argc, _TCHAR* argv[])
{
	sleep1("350");
	sleep1(350);
	cout << "\n\n";
	return 0;
}

void sleep1(int a){
	cout << "\nСпим " << a << " милсек (int)";
	Sleep(a);
	cout << "\nПоспали";
}

void sleep1(string a){
	cout << "\nСпим " << a << " милсек (string)";
	Sleep(stoi(a));
	cout << "\nПоспали";
}