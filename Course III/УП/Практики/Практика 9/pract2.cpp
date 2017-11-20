/*
Создать класс  Pole и в нем конструктор, с помощью которого 
при создании элемента массива-поля соотвествующего объекта
заполняются случайными числами в диапазоне от 0 табельного номера. 

Создать два объекта класса Pole с полями массивами
размерностью = 4 и сложить их. 
Для этого необходимо использовать перегрузку операторов [] и +.
*/

#include <iostream>
using namespace std;

const int n = 4;

class Pole {
    int obj[4];

public:
    Pole()
    {
        srand((unsigned)time(0));
        for (int i=0;i<n;i++)
            obj[i]=rand()%5;

    }
    /*friend Pole operator+(coord a){
            Pole tmp_obj;
            for (int i=0;i<n;i++){
                tmp_obj.[i]
            }
            tmp_obj.x=a.x++;
            return tmp_obj;
        }

    friend Pole operator+(int _obj1, int _obj2){
        for (int i=0;i<n;i++){
            _obj1[i]=*_obj1[i]+*_obj1[i];
        } 

        return obj[i];
    };
    */
    void show();
};
// проверка диапазона для atype.
/*int& Pole::operator[](int &_obj1[4], _obj2)
{
    if ((i>0) && (i<5)) {
        cout << "Ошибка!\n";
        //exit(1);
    }
    return obj[i];
}
*/

void Pole::show(){
	for (int i=0;i<n;i++){
		cout<<"Адрес: "<<&obj[i]<<", значение: "<<obj[i]<<"\n";
	}
}

int main()
{
    int meow[4];
    Pole obj1;
    Pole obj2;
    obj1.show();
    cout<<"\n";
    obj2.show();
    //cout<<(obj1[4]+obj2[4]);
    
    return 0;
}
