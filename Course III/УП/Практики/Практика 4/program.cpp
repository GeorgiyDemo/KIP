//Вариант 9 -> f1 должна взять инкремент x, возвести в квадрат  и сложить с  y  
#include <iostream>
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
            *p++;
            *p=*p*(*p);
            x=x+y;
            return *this;
        }
} ;

int main(){
    MainClass a(3,4);
    MainClass *u = &a;
    u->f1();
    cout<<"Ответ: "<<u->x;

cout<<"\n";
return 0;

};