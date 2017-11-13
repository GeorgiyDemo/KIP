/*
 Вариант 4.
 Создать класс месяц- month  с закрытым  полем  месяц в цифровом формате и методы,
 который устанавливает № месяца и выводит на экран. Создать метод, который 
 прибавляет несколько месяцев (<12) к заданному месяцу.
 Полученный месяц вывести на экран.
 Продемонстрировать на 5 объектах.
 */

#include <iostream>
using namespace std;

	class MonthClass
		{	

		private:
			int month;
		
		public:
        	void set (int v)
        	{
        		if (v<13)
					month= v;
				else
					cout<<"Кол-во месяцев больше 12!\n";
			}

			void print()
			{
				cout <<"Месяц = "<<month<<endl;
			}

			void moremonth(int more)
			{
				if (more<13){
					month=month+more;
					if (month>12)
						month=month-12;
				}

				else
					cout<<"Кол-во месяцев больше 12!\n";
			}

		} a, b, c, d, e;
	
	int main (){

		a.set(10);
		a.print();
		a.moremonth(5);
		a.print();

		cout<<"\n";
		b.set(4);
		b.print();
		b.moremonth(2);
		b.print();

		cout<<"\n";
		c.set(11);
		c.print();
		c.moremonth(11);
		c.print();

		cout<<"\n";
		d.set(1);
		d.print();
		d.moremonth(2);
		d.print();

		cout<<"\n";
		e.set(1);
		e.print();
		e.moremonth(7);
		e.print();

return 0;
}

