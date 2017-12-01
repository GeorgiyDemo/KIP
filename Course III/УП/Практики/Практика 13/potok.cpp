/*
  Вариант 4
  Написать программу, которая считывает текст из 
  файла и выводит на экран только строки,
  не содержащие двузначных чисел.
  
  //Еще добавить потоковый ввод
*/

#include <cctype>
#include <iostream>
#include <string.h>
#include <fstream>
#include <sstream>

using namespace std;

class StringClass
{

	protected:

	    FILE* buf_file;
      stringstream ss;
	    char str[256];

	public:
      void input_file();
	    void checker();
};

void StringClass::input_file(){


   ifstream in ("txt.txt"); 
 
      if (! in) { 
         cout << "Невозможно открыть файл\n";
      }
      while (in){
         in >> str;
         ss << str<<"\n";
      } 
      in.close(); 
}

void StringClass::checker()
{
    char cset[] = "1234567890";

    const string& tmp = ss.str();   
    const char* cstr = tmp.c_str();

    cout<<cstr;

/*
    int down=0;
    int up=down;
    int symbol=up;

    for(int i=0;i<15;i++){
      up++;
      if (cstr[i] == "\n"){
         for(j=down;down<up+1;down++){
            if (isdigit(cstr[j])==true){
              symbol++;
            }
            if (symbol==2){
              cout<<"\n\n"
            }

            }
         } 
      } 

      cout<<cstr[i];
    }
*/


/*
        gets(str, 256, ss);
        char* symbol = str;
        while (!isdigit(*symbol))
            symbol++;
        int i = strspn(symbol, cset);
        if (i != 2)
            puts(str);
*/
    
}

int main()
{
    StringClass obj;
    obj.input_file();
    obj.checker();

    return 0;
}