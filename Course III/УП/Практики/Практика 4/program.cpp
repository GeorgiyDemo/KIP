/* Вариант 9 (4+5)
 Функция f1 должна взять инкремент x,
 возвести в квадрат и сложить с y  
*/

#include <iostream>
#include <cmath>
using namespace std;

class MainClass{

    public:

        int x,y;
        int *p = &x;
        int *c = &y;

        MainClass(int _x, int _y){
            *p=_x;
            *c=_y;
        }

        MainClass f1(){
            x++;
            //*p++;
            x = pow(x,2);
            x=x+y;
            return *this;
        }
} ;

int main(){
    int __x, __y;
    cout<<"Введите x =>";
    cin >> __x;
    cout<<"Введите y => ";
    cin >> __y;

    MainClass a(__y,__x);
    MainClass *KOTIK = &a;
    KOTIK->f1();
    cout<<"Ответ ((x++)^2+y=): "<<KOTIK->x;

cout<<"\n";
return 0;

};