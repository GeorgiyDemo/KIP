/*
Создать массив объектов  [4] с int полем в диапазоне от 0 до номера варианта,
используя конструктором с параметрами и метод show().
Вывести на экран значения объектов  и их адреса.
*/

#include <iostream>
using namespace std;

const int n = 4;

class MainClass {
    int obj[4];

public:
    MainClass(int i, int j, int k, int l)
    {
        obj[0] = i;
        obj[1] = j;
        obj[2] = k;
        obj[3] = l;

    }
    int& operator[](int i);
    void show();
};
// проверка диапазона для atype.
int& MainClass::operator[](int i)
{
    if ((i>0) && (i<5)) {
        cout << "Ошибка!\n";
        //exit(1);
    }
    return obj[i];
}

void MainClass::show(){
	for (int i=0;i<n;i++){
		cout<<"Адрес: "<<&obj[i]<<", значение: "<<obj[i]<<"\n";
	}
}

int main()
{
    MainClass main_obj(1, 2, 3, 4);
    main_obj.show();

    //main_obj[1] = -2;
    main_obj[2] = 5;
    //main_obj[3] = 6;
    
    return 0;
}
