/*
Общая постановка. Пользовательский класс String должен содержать необходимые элементы-данные, которые создаются в динамической области памяти.
•	Конструктор для создания строк: String (…);
•	Деструктор: ~String();
•	Метод ввода исходной строки: Set();
•	Метод печати: void print(…);

Код методов  – вне пространства определения класса. Программа иллюстрирует прямой и косвенный способы обращения к методам.
Ввести с клавиатуры строку  символов S1. Признак окончания ввода строки - нажатие клавиши "Ввод". Программа должна содержать перегруженную операцию «=», использование которой скопирует S1 в S2 .
Варианты заданий 

4.1.	Длина L кратна 3-м, то удаляются все числа, делящиеся на 3;
4.2.	Длина L делится на 5, то удаляется все символы кроме a-z 

*/

#define toDigit(c) (c-'0')
#define SIZE 255
#define LINE cout << "------------------------------------------------------\n"
#include <iostream>
#include <string>
#include <stdlib.h>
#include <istream>
using namespace std;

class StringClass {
    char* str;
    char* str_return;

public:
    StringClass();
    StringClass(char*);
    ~StringClass();
    char* number1(); //метод, выполняющий поставленную задачу.
    char* number2(); //метод, выполняющий поставленную задачу.
    void Set(char*);
    friend void print(StringClass&); //функция-друг печати
    friend ostream& operator<<(ostream&, StringClass&); //перегрузка оператора вывода
    friend istream& operator>>(istream&, StringClass&); //перегрузка оператора ввода
    friend char* number1(StringClass&); //функция-друг, выполняющий поставленную задачу.
    friend char* number2(StringClass&); //функция-друг, выполняющий поставленную задачу.
};
StringClass::StringClass()
{
    str = new char[SIZE];
    str[0] = '\0';
    str_return = new char[SIZE];
    str_return[0] = '\0';
};
StringClass::StringClass(char* s)
{
    str = new char[SIZE];
    strcpy(str, s);
    str_return = new char[SIZE];
    str_return[0] = '\0';
};
StringClass::~StringClass()
{
    delete[] str;
    cout << "*Деструктор работает*" << endl;
};
void StringClass::Set(char* s)
{
    unsigned int i;
    for (i = 0; i < strlen(s); i++)
        str[i] = s[i];
    str[i] = '\0';
};

//Если длина L кратна 3-м, то удаляются все числа, делящиеся на 3;
char* StringClass::number1()
{
	bool boolflag = false;
    int j = 0;
    if ((strlen(str) % 3) == 0){
    	cout<<"--> Длина строки кратна 3\n";
        for (unsigned int i = 0; i < strlen(str); i++){
            if ((toDigit(str[i]) % 3) != 0){
            	boolflag = true;
                str_return[j] = str[i];
                j++;
            }
        }
        str_return[j] = '\0';
   	(boolflag == true) ? cout<<"--> Есть цифры, кратные 3": cout<<"--> Нет цифр, кратных 3";
    }
    else {
        strcpy(str_return, str);
        cout<<"--> Длина строки не кратна 3\n";
    }
    cout<<"\n*Преобразованная строка*\n--> ";

    return str_return;
};

char* StringClass::number2()
{
	bool boolflag = false;
    int j = 0;
    if ((strlen(str) % 3) == 0){
    	cout<<"--> Длина строки кратна 3\n";
        for (unsigned int i = 0; i < strlen(str); i++){
            if ((toDigit(str[i]) % 3) != 0){
            	boolflag = true;
                str_return[j] = str[i];
                j++;
            }
        }
        str_return[j] = '\0';
   	(boolflag == true) ? cout<<"--> Есть цифры, кратные 3": cout<<"--> Нет цифр, кратных 3";
    }
    else {
        strcpy(str_return, str);
        cout<<"--> Длина строки не кратна 3\n";
    }
    cout<<"\n*Преобразованная строка*\n--> ";

    return str_return;
};

char* number1(StringClass& obj) {
	return obj.number1();
};

char* number2(StringClass& obj) {
	return obj.number2();
};

void print(StringClass& obj) {
	cout << obj.str << " " << obj.str_return;
};

ostream& operator<<(ostream& stream, StringClass& ob)
{
    stream << ob.str;
    return stream;
};
istream& operator>>(istream& stream, StringClass& ob)
{
    stream >> ob.str;
    return stream;
};
int main()
{
    char s[265];

    LINE;
    cout<<"|Пример с доступом к методам класса непосредственно через переменную|\nВведите строку и нажмите \"Enter\" => ";
    cin.getline(s, 256); //считываем полностью всю строку
    StringClass str(s); //доступ к методам класса непосредственно через переменную,
    cout<<"Вы ввели строку: ";
	print(str);
	cout<<"\n\n*Результат выполнения*"<<endl;
	cout<<number1(str)<<endl;
	
	///////////////////////////////////////////////////////
	LINE;
	cout << "|Пример с доступом к методам класса через указатель|\nВведите строку и нажмите \"Enter\" => ";
	cin.getline(s,256);
	StringClass *pstr;
	pstr=new StringClass();
	pstr->Set(s);
	cout<<"Вы ввели строку: ";
	print(*pstr);
	cout<<"\n\n*Результат выполнения*"<<endl;
	cout<<number1(*pstr)<<endl;
	delete pstr;
	return 0;
};
