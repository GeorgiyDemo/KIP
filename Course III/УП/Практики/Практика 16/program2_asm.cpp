/*
	Разместить в памяти компьютера массив из N целых чисел со знаком.
	Написать программу, позволяющую увеличить на 10
	отрицательные элементы массива.
	Вывести на экран измененный массив, либо, если таких элементов в массиве нет,
	вывести на экран соответствующее сообщение.
	Ввод массива необходимо осуществлять двумя способами (предусмотреть наличие меню):
	вручную с клавиатуры, а также с помощью ГСЧ.

*/

#include <iostream>
#include <ctime>
using namespace std;

class ArrayClass{

	protected:
	    int *a;
	    int n;
	    unsigned int start_time;
	    unsigned int end_time;

	public:
		void outarray();
	    void initarray();
	    void enterarray();
	    void checker();
	    int timer();
};

void ArrayClass::outarray(){

	cout<<"Исходный массив:\n[";
	for(int i=0;i<n;i++)
    	cout<<a[i]<<" ";
	cout<<"]\n";

}

void ArrayClass::initarray(){

	cout<<"Введите n => "; cin>>n;
	srand(time(0));
 	srand((unsigned)time(0));
	a = new int [n];
	for(int i=0;i<n;i++)
	    a[i]=rand()%100-50;
	outarray();
}

void ArrayClass::enterarray(){
  
  cout<<"Введите n => "; cin>>n;
  a = new int [n];	
  cout<<"<Заполняем массив>\n";
  for (int i=0;i<n;i++){
      cout<<"Введите элемент №"<<i<<": ";
      cin>>a[i];
  }

}

void ArrayClass::checker(){
	start_time = clock();
	for(int i=0;i<n;i++)
		if (a[i]<0)
			a[i]+=10;

	end_time = clock(); 
}

int ArrayClass::timer(){
	return end_time - start_time; 
}

 int main(){
  	
  	int k;
  	ArrayClass* arr_obj;
  	arr_obj = new ArrayClass;

    cout<<"\n\n1. Генерация массива\n2. Ручной ввод массива\n=> ";
    cin>>k;
    switch (k)  
    {  
        case 1:
           	arr_obj->initarray();
           	break;
        case 2:
            arr_obj->enterarray();
            break;
    }    
    arr_obj->checker();
    arr_obj->outarray();

    cout<<"\nВремя: "<<arr_obj->timer()<<" мс.\n";
	return 0;

}