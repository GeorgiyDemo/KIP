#include <iostream>
#define SIZE 255 //длина строки по умолчанию
#include <string>
#include <stdlib.h>
#include <istream>
using namespace std;

class X {
    char* str;
    char* str_return;

public:
    X(); //конструктор по-умолчанию
    X(char*); //конструктор, которому можно передавать параметр
    ~X(); //деструктор
    char* Run(); //метод, выполняющий поставленную задачу.
    void Set(char*);
    friend void print(X&); //функция-друг печати
    friend ostream& operator<<(ostream&, X&); //перегрузка оператора вывода
    friend istream& operator>>(istream&, X&); //перегрузка оператора ввода
    friend char* Run(X&); //функция-друг, выполняющий поставленную задачу.
};
X::X()
{
    str = new char[SIZE];
    str[0] = '\0';
    str_return = new char[SIZE];
    str_return[0] = '\0';
};
X::X(char* s)
{
    str = new char[SIZE];
    strcpy(str, s);
    str_return = new char[SIZE];
    str_return[0] = '\0';
};
X::~X()
{
    delete[] str;
    cout << "...destructor has been called" << endl;
};
void X::Set(char* s)
{
    unsigned int i;
    for (i = 0; i < strlen(s); i++)
        str[i] = s[i];
    str[i] = '\0';
};
char* X::Run()
{ /*метод, решающий конкретную задачу, в данном случае - выделение из строки
              подстроки, не содержащей заглавных латинских букв, если длина исходной строки меньше 10*/
    int j = 0;
    if (strlen(str) < 10) {
        for (unsigned int i = 0; i < strlen(str); i++)
            if (((int)str[i] < 65) || ((int)str[i] > 90)) {
                str_return[j] = str[i];
                j++;
            };
        str_return[j] = '\0';
    }
    else
        strcpy(str_return, str);

    return str_return;
};
char* Run(X& obj) { return obj.Run(); };
void print(X& obj) { cout << obj.str << " " << obj.str_return << endl; };
ostream& operator<<(ostream& stream, X& ob)
{
    stream << ob.str;
    return stream;
};
istream& operator>>(istream& stream, X& ob)
{
    stream >> ob.str;
    return stream;
};
int main()
{
    char s[265];

    cout << "Type anything and press \"Enter\":" << endl;
    cin.getline(s, 256); //считываем полностью всю строку
    X str(s); //доступ к методам класса непосредственно через переменную,
    cout<<"You have type:"<<endl;
	print(str);
	cout<<"Output string:"<<endl;
	cout<<Run(str)<<endl; 
	cout<<"Type anything and press \"Enter\":"<<endl;
	cin.getline(s,256);
	X *pstr; //доступ к методам класса через указатель
	pstr=new X();
	pstr->Set(s);
	cout<<"You have type:"<<endl;
	print(*pstr);
	cout<<"Output string:"<<endl;
	cout<<Run(*pstr)<<endl;
	delete pstr;
	return 0;
};
