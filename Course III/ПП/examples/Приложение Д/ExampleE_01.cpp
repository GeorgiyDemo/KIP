#include <iostream>
using namespace std;
//Пространство имен myOun:
namespace myOun{
int n=10;
class MyClass{
public:
double x;
MyClass(){
x=n+1.5;}};
}
int main(){
int n=5;
//Ссылка на класс из пространства имен myOun:
myOun::MyClass obj;
cout<<"obj.x = "<<obj.x<<endl;
cout<<"n = "<<n<<endl;
//ССылка на переменную из пространства имен myOun:
cout<<"myOun::n = "<<myOun::n<<endl;
return 0;}