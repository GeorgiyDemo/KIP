/*
  Вариант 4
  Написать программу, которая считывает текст из 
  файла и выводит на экран только строки,
  не содержащие двузначных чисел.
  
*/
#include <fstream>
#include <iostream>
using namespace std;

int i, n, tmp_counter = 0;
char* a;
char q, w, e;

int main()
{
   char buff[50];
   cout << "Введите кол-во строк в файле => ";
   cin >> n;
   ifstream fin("txt.txt");
   cout << "Исходные данные\n";

    for (i = 0; i < n; i++) {
        fin.getline(buff, 50);
        if (strlen(buff)==2){

           for (int j=0;j<2;j++){
            if(isdigit(buff[j])!=0){
               tmp_counter++;
            }
           }
           if (tmp_counter==2){
            tmp_counter=0;
            }
            else{
               tmp_counter=0;
               cout << buff << "\n"; 
            }
         }
         else
            cout << buff << "\n"; 
    }
    fin.close();
    return 0;
}
