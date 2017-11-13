/*
 Создать класс  велосипедист -  bicycler, с закрытыми  полями скорость, 
 время в пути и статическим поле s - путь, пройденный велосипедистом, и открытые  методы,
 которые устанавливают поля скорость, вычисляют время  в пути и выводят на все это экран. 
 Создать 5 различных объектов этих велосипедистов и вывести на печать наибольшее и 
 наименьшее время в пути. Метод скорость сделать перегруженным для целых или вещественных 
 чисел. 
*/

#include <iostream>
using namespace std;

	class Bicycler
		{	static double s;
	
		double speed;
		double time;
	public:void set (double v)
		{speed= v; 	}
        void set (int v)
        {speed= v; 	}
		double vremja()
		{time=s/speed;
		return (time);	}
		void print()
		{cout << "Путь= "<<s<<endl;
		cout<< "скорость= "<< speed<<endl;
		cout <<"время = "<<time<<endl;
		}
	} a,b,c,d,f;
	double  Bicycler::s=50;
	
	int main (){
		setlocale (LC_ALL,"rus");
		double max = 0;
		a.set (20);
		a.vremja ();
		a.print();

		b.set (21.5);
		b.vremja ();
		b.print();

		c.set (30.5);
		c.vremja ();
		c.print();

		d.set (40);
		d.vremja ();
		d.print();

		f.set (28.5);
		f.vremja ();
		f.print();
		double vremja[5]={
			a.vremja(),b.vremja(),c.vremja(),d.vremja(),f.vremja()
		};
		double min = vremja[0];
		for (int i=0; i<5; i++)
		
		{if (vremja[i] > max)
			max = vremja[i];
		if (vremja[i] < min)
			min =vremja[i];	}
		cout << "max ="<<max<<endl;
		cout << "min ="<<min<<endl;
return 0;
}

