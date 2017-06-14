#include <iostream>
#include <iomanip>
using namespace std;

int const n=10;
bool flag=false;
int i, k1, menu, sum, *a;

//Генерация массивов
void generate(){

  srand((unsigned)time(0));
  for (i=0;i<n;i++)
    a[i]=rand()%20-10;

}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем массив А>\n";
  for (i=0;i<n;i++){
     cout<<"Введите элемент ["<<i<<"]: ";
      cin>>a[i];
    }
}


//Вывод массивов на экран
void monitor_out(){

  cout<<"\nМассив А:\n[";
  for (i=0;i<n;i++){
    cout<<a[i]<<" ";
  }
  cout<<"]";
}

//Функция элементов массива
void counter(){

	monitor_out();
  sum=0;
	for (i=0;i<n;i++)
    sum+=a[i];
  cout<<"\nСумма элементов массива А: "<<sum;
}

//Меню выбора ввода
void initarray(){

  a = new int [n];

  cout<<"\n\n1. Генерация массива А\n2. Ручной ввод массива А\n=> ";
    cin>>k1;
    switch (k1)
    {
      case 1:
        generate();
        break;

      case 2:
        enter();
        break;
    }

}

//Главное меню
int main(){

  do
  {
    cout<<"\n\n1. Ввод массива\n2. Вывод массива\n3. Сумма элементов массива\n0. Выход из программы\n=> ";
    cin>>menu;
    switch (menu)
    {
      case 1:
        initarray();
        break;

      case 2:
        monitor_out();
        break;

      case 3:
        counter();
        break;

    }

  }
  while (menu!=0);

cout<<"\n";
return 0;

}
