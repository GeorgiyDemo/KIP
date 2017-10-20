#include <iostream>
//Заголовок для включения класса string в программу:
#include <string>
using namespace std;
int main(){
//Символьная строка:
char str[30]="Alex";
//Пустая строка – объект класса string:
string s1;
//Строка с явно указанным значением:
string s2("What is your name?");
//Строка создана на основе символьного массива:
string s3(str);
//Вывод строки на экран:
cout<<s2<<endl;
//Считывание строки с консоли:
cin>>s1;
//Сравнение и объединение строк:
if(s1==s3) cout<<"Hello, "+s3<<endl;
else cout<<"You are not "+s3+"!"<<endl;
return 0;}