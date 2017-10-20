#include <iostream>
using namespace std;
//ќбъ€вление класса:
class MyClass{
public:
double x;
};
int main(){
//ќбъект класса:
MyClass obj;
//—сылка на объект:
MyClass &ref=obj;
//ќбращение к объекту по имени и через ссылку:
obj.x=10;
cout<<"x = "<<ref.x<<endl;
ref.x=100;
cout<<"x = "<<obj.x<<endl;
return 0;
}