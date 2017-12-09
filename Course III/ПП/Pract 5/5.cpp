/*
1.  Создайте функцию swap (), меняет местами числа типа целые (int),
	вещественное(double), символьное (char).
 	С помощью перегруженных функций (без классов)
 	С помощью перегруженных конструкторов или методов класса
*/

#include <sstream>
#include <iostream>
#include <string>
using namespace std;

class MyClass {
	int a;
	double b;
	char* c;
	int buf;


public:
	void swap(int a, double b) {
		double c1;
		c1 = b;
		this->b = (double)a;
		this->buf = a;
		this->a = (int)c1;
	}
	void swap(char *c) {
		double temp = strtod(c, NULL);
		this->b = temp;

		//В c (char) надо записать a (double)
		stringstream s;
		double aDoubleValue = this->buf;
		s << aDoubleValue;
		string output = s.str();
		this->c=  strdup(output.c_str());
	}
	void Show() {
		cout << "a = " << this->a << endl;
		cout << "b = " << this->b << endl;
		cout << "c = " << this->c << endl;
	}
};
int main() {
	setlocale(LC_ALL, "rus");
	int a;
	double b;
	char *c = "3";
	MyClass  obj;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = " << c;
	obj.swap(a, b);
	obj.swap(c);
	obj.Show();
}