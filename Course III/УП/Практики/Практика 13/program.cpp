/*

  Вариант 4
  Написать программу, которая считывает текст из 
  файла и выводит на экран только строки,
  не содержащие двузначных чисел.
  
*/

#include <cctype>
#include <iostream>
#include <string.h>
using namespace std;

class StringClass
{

	protected:
	    FILE* buf_file;
	    char str[256];

	public:
	    void checker();
};

void StringClass::checker()
{
    char cset[] = "1234567890";
    buf_file = fopen("txt.txt", "r");

    while (!feof(buf_file)) {
        fgets(str, 256, buf_file);
        char* symbol = str;
        while (!isdigit(*symbol))
            symbol++;
        int i = strspn(symbol, cset);
        if (i != 2)
            puts(str);
    }
}

int main()
{
  StringClass* obj;
  obj = new StringClass;
  obj->checker();
  return 0;
}