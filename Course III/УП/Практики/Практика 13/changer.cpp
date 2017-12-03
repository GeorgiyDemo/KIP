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
    cout << "Введите кол-во строк в файле" << endl;
    cin >> n;
    char buff[50]; // буфер промежуточного хранения считываемого из файла
    ifstream fin("txt.txt");
    cout << "Исходные данные\n";

    for (i = 0; i < n; i++) {
        fin.getline(buff, 50); // считали строку из файла
        cout << buff << "\n"; // напечатали эту строку
        int count = strlen(buff);
        if (strlen(buff)==2){

           for (int j=0;j<2;j++){
            if(isdigit(buff[j])!=0){
               tmp_counter++;
            }
           }
           if (tmp_counter==2){
            tmp_counter=0;
            cout<<"ДВУХЗНАЧНОЕ ЧИСЛО\n";
            }
         }
        cout << "Кол-во символов= " << count << endl;
    }
    fin.close(); // закрываем файл
    return 0;
}
