/*

  Вариант 4
  Написать программу, которая считывает текст из 
  файла и выводит на экран только строки,
  не содержащие двузначных чисел.
  
*/

#include <fstream>
#include <iostream>
using namespace std;

class StringStreamClass
{

   protected:
       char buff[50];

   public:
       void readstream();
};

void StringStreamClass::readstream(){

   int n, tmp_counter = 0;
   char* a;
   
   cout << "Введите кол-во строк в файле => ";
   cin >> n;
   ifstream fin("txt.txt");
   cout << "Вывод строк, согласно условию:\n";

    for (int i = 0; i < n; i++) {
        fin.getline(buff, 50);
        if (strlen(buff)==2){
           for (int j=0;j<2;j++){
            if(isdigit(buff[j])!=0){
               tmp_counter++;
            }
           }
           if (tmp_counter!=2)
            cout << buff << "\n";
         tmp_counter=0;
            
         }
         else
            cout << buff << "\n"; 
    }
    fin.close();
}

int main()
{
   StringStreamClass* mainobj;
   mainobj = new StringStreamClass;
   mainobj->readstream();
   return 0;
}
