#include <iostream>
#include <cstdio>
#include <cstring>
#include <cstdlib>

using namespace std;
   
   struct WORKER{
      char name[80], dolznost[80], year[80];
   };

   int main(){

      const int n=2;

      bool state;
      char s[80];
      WORKER workers[n];
     
      for(int i=0;i<n;i++){

         cout<<("Введите ФИО рабочего: ");
         gets(workers[i].name);
         cout<<("Введите должность рабочего: ");
         gets(workers[i].dolznost);
         cout<<("Введите год поступления на работу: ");
         gets(workers[i].year);
      }

      //Вывод
      for(int i=0;i<n;i++){
         cout<<"ФИО: "<<workers[i].name<<endl;
         cout<<"Должность: "<<workers[i].dolznost<<endl;
         cout<<"Год поступления на работу: "<<workers[i].year<<endl;
      }

         cout<<"*Поиск по рабочим*\nВведите имя рабочего\n=> ";
         gets(s);
         state=true;
         for(int i=0;i<n;i++){

            if(!strcmp(workers[i].name,s)){
               state=false;
               cout<<"ФИО: "<<workers[i].name<<endl;
               cout<<"Должность: "<<workers[i].dolznost<<endl;
               cout<<"Год поступления на работу: "<<workers[i].year<<endl;
               break;
               }
         }
         if(state) cout<<"Нет рабочего с таким именем!\n";
      };

