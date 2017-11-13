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
        		month= v;
        	}

			void print()
			{
				cout <<"Месяц = "<<month<<endl;
			}

			void moremonth(int more)
			{
				if (more<12)
					month=month+more;
				else
					cout<<"Кол-во месяцев больше 12!";
			}

		} a, b, c, d, e;
	
	int main (){

		a.set(8);
		a.print();
		a.moremonth(3);
		a.print();

		cout<<"\n";
		b.set(6);
		b.print();
		b.moremonth(1);
		b.print();

		cout<<"\n";
		c.set(2);
		c.print();
		c.moremonth(10);
		c.print();

		cout<<"\n";
		d.set(2);
		d.print();
		d.moremonth(4);
		d.print();

		cout<<"\n";
		e.set(1);
		e.print();
		e.moremonth(1);
		e.print();

return 0;
}

