/*
1.  Создайте функцию swap (), меняет местами числа типа целые (int),
	вещественное(double), символьное (char).
 	С помощью перегруженных функций (без классов)
 	С помощью перегруженных конструкторов или методов класса
*/
#include <sstream>
#include <iostream>
using namespace std;
double swap(int a, double b);
char swap(char *c);
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
		stringstream s;
		double aDoubleValue = this->buf;
		s << aDoubleValue;
		string output = s.str();
		this->c = strdup(output.c_str());
	}
	void Show() {
		cout << "a = " << this->a << endl;
		cout << "b = " << this->b << endl;
		cout << "c = " << this->c << endl;
	}
};
int main() {
	int a;
	double b;
	char *c = "3";
	MyClass  obj;

	cout << "Задание А:" << endl;
	cout << "с помощью перегруженных функций" << endl;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	c = "3";
	cout << "c = " << c << endl;
	double y = swap(a, b);
	char z = swap(c);
	cout << "c = " << z << endl;

	cout << "Задание Б:" << endl;
	cout << "с помощью перегруженных методов класса" << endl;
	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = " << c << endl;
	obj.swap(a, b);
	obj.swap(c);
	obj.Show();

	cout << "\n";
}
double swap(int a, double b){
	int buf;
double c1;
c1 = b;
b = (double)a;
buf = a;
a = (int)c1;
cout << "a = " << a << endl;
return b;
}

char swap(char * c)
{
	double b,temp = strtod(c, NULL);
	int buf=1;
	b = temp;
	stringstream s;
	double aDoubleValue = buf;
	s << aDoubleValue;
	string output = s.str();
	c = strdup(output.c_str());
	cout << "b = " << b << endl;
	return *c;
}
