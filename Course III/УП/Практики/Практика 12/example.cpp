
// Простой пример наследования
#include <iostream>
using namespace std;
// Определение базового класса
class В {
	int i;
public:
	void set_i(int n) {
		i = n;
	};
	int get_i ( ) ;
};
// Определение производного класса
class D: public В {
	int j;
public:
	void set_j (int n) ;
	int mul ( ) ;
};
// Задание значения i в базовом классе
// Возвращение значения i в базовом классе
int В::get_i ()
{return i;}
// Задание значения j в производном классе
void D::set_j (int n)
{	j = n;}
// Возвращение значения i базового класса и j — производного
int D::mul ()
	// производный класс может вызывать функции-члены базового класса
{ return j * get_i();
}
int main ( )
{
	D ob;
	ob.set_i (10) ; // загрузка i в базовый класс
	ob.set_j(4); // загрузка j в производный класс
	cout << ob.mul(); // вывод числа 40
	return 0;
}

