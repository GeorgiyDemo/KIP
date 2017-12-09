/*
	Найти время работы программы, вычисляющей сумму элементов 
	одномерного массива  размерностью n =100, n =1000,
		1.	Методами C++
		2.	С использованием  ассемблерной вставки
*/

#include <iostream>
#include <ctime>
using namespace std;

const int n = 1000;

class ArrayClass
{

	protected:
	    int *a;
	    unsigned int start_time;
	    unsigned int end_time;

	public:
	    void initarray();
	    void outarray();
	    int sum();
	    int timer();
};

void ArrayClass::initarray(){
	start_time = clock();
	srand(time(0));
 	srand((unsigned)time(0));
	a = new int [n];
	for(int i=0;i<n;i++)
	    a[i]=rand()%4+2;

}

void ArrayClass::outarray(){

	cout<<"Исходный массив:\n[";
	for(int i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

int ArrayClass::sum(){
	int buf_sum = 0;
	for(int i=0;i<n;i++)
		buf_sum+=a[i];
	end_time = clock(); 
	return buf_sum;
}

int ArrayClass::timer(){
	return end_time - start_time; 
}

int main(){

	ArrayClass* arr_obj;
  	arr_obj = new ArrayClass;
  	arr_obj->initarray();
  	arr_obj->outarray();
	cout<<"Сумма: "<<arr_obj->sum();
	cout<<"\nВремя: "<<arr_obj->timer()<<" мс.\n";
	
return 0;
}