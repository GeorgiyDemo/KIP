#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>
#include <math.h>

using namespace std;

int n, i, k, maink, qnum, good_answers, bad_answers;
string s, user_answer, input_pass;
string pass = "321";
FILE *outfile;

struct BDtester{
 string str, type, answer, q1, q2, q3 ,q4 ,q5;
} a[100];

void file_struct_out(){

  outfile=fopen("out.dat","w+");
  for (i=0;i<n;i++){

     fprintf(outfile,"%s,", a[i].str.c_str());
     fprintf(outfile,"%s,", a[i].type.c_str());
     fprintf(outfile,"%s,", a[i].answer.c_str());
     fprintf(outfile,"%s,", a[i].q1.c_str());
     fprintf(outfile,"%s,", a[i].q2.c_str());
     fprintf(outfile,"%s,", a[i].q3.c_str());
     fprintf(outfile,"%s,", a[i].q4.c_str());
     fprintf(outfile,"%s,\n", a[i].q5.c_str());

  }

  fprintf(outfile,"\n");
  fclose(outfile);

}

//Ввод структуры из файла
void file_struct_in(){

  string bufstring;
  int kot_biker;

  ifstream file("out.dat");
  i=0;
  kot_biker = 0;
  bufstring = "";

  while(getline(file,s)){

    for(k=0;k<s.length();k++){

      if (s[k]==','){
          kot_biker++;
          switch (kot_biker)
          {
          case 1:
            a[i].str=bufstring;
            break;
          case 2:
            a[i].type=bufstring;
            break;
          case 3:
            a[i].answer=bufstring;
            break;
          case 4:
            a[i].q1=bufstring;
            break;
          case 5:
            a[i].q2=bufstring;
            break;
          case 6:
            a[i].q3=bufstring;
            break;
          case 7:
            a[i].q4=bufstring;
            break;
          case 8:
            a[i].q5=bufstring;
            break;
          }

          bufstring="";
      }

      else 
        bufstring+=s[k];
    }

    kot_biker=0;
    n=i;
    qnum=n;
    i++;
  }

  file.close();
  cout<<"*Структура успешно загружена из файла*\n";
  
}

void input_struct(){
  string buf1, buf2;

  cout<<"Для изменения структуры требуется ввести пароль\n => ";
  cin>>input_pass;
  
  if (pass==input_pass){
    
    cout<<"✅  Доступ разрешен\nВведите кол-во вопросов в структуре: ";
    cin>>n;
    for (i=0;i<n;i++){
       cout<<"Введите вопрос => ";
       cin>>buf1;
       getline(cin,buf2);
       buf2=buf1+buf2;
       a[i].str=buf2;
       cout<<"Введите тип вопроса (check,multi,free) => ";
       getline(cin,a[i].type);

       //check - это один ответ
       //multi - это несколько ответов
       //free - свободный ответ

       cout<<"Введите правильный ответ => ";
       getline(cin,a[i].answer);

       if (a[i].type=="free"){
          a[i].q1="-";
          a[i].q5=a[i].q4=a[i].q3=a[i].q2=a[i].q1;
       }
       if (a[i].type=="check"){
          cout<<"Неправильный ответ ответ №1 => ";
          getline(cin, a[i].q1);
          cout<<"Неправильный ответ ответ №2 => ";
          getline(cin, a[i].q2);
          cout<<"Неправильный ответ ответ №3 => ";
          getline(cin, a[i].q3);
          cout<<"Неправильный ответ ответ №4 => ";
          getline(cin, a[i].q4);
          cout<<"Неправильный ответ ответ №5 => ";
          getline(cin, a[i].q5);
       }

   }
    file_struct_out();
  }
  else
    cout<<"❌  Доступ запрещен";
}

void show_struct(){
  for (i=0;i<n;i++){
     cout<<"\nВопрос: '"<<a[i].str<<"'\nТип:"<<a[i].type<<"\nПравильный ответ(ы): "<<a[i].answer;
     cout<<"\nНеправильные ответ(ы):\n1. "<<a[i].q1<<"\n2. "<<a[i].q2<<"\n3. "<<a[i].q3<<"\n4. "<<a[i].q4<<"\n5. "<<a[i].q5;   
  }
}

void changecounter(){
  cout<<"Введите кол-во вопросов для тестирования\n => ";
  cin>>qnum;
}

void beginer(){
  
  string buf;
  good_answers=0;
  good_answers=bad_answers;
  for (i=0;i<qnum;i++){

     cout<<"\n-------------------\nВопрос №"<<i+1<<":\n";
     cout<<"'"<<a[i].str<<"'";
     if (a[i].type == "check"){
        cout<<"\n*Вопрос с единственным ответом*\n";
            cout<<"Ответы:\n1. "<<a[i].q1<<"\n2. "<<a[i].q2<<"\n3. "<<a[i].q3<<"\n4. "<<a[i].q4<<"\n5. "<<a[i].q5<<"\n6. "<<a[i].answer;
            cout<<"\n=> "; cin>>user_answer;
            if (user_answer=="6"){
              cout<<"✅  Вы ответили правильно\n";
              good_answers++;
            }
            else{
              cout<<"❌  Вы ответили неправильно\n";
              bad_answers++;
            }
       }

       if (a[i].type == "multi"){
          cout<<"\n*Вопрос с несколькими ответами*";
          //
       }

       if (a[i].type == "free"){
          
          cout<<"\n*Вопрос со свободным ответом*";
          cout<<"\n=> "; cin>>user_answer;
            
            if (user_answer==a[i].answer){
              cout<<"✅  Вы ответили правильно\n";
              good_answers++;
            }
            else{
              cout<<"❌  Вы ответили неправильно\n";
              bad_answers++;
            }

       }
  }
  cout<<"\nВы ответили правильно на "<<good_answers<<" вопрос(ов) ✅";
  cout<<"\nВы ответили неправильно на "<<bad_answers<<" вопрос(ов) ❌";
}


int main(){

    //Красивое меню
    cout<<"---------------------------------------\n";
    cout<<"|      Тестирование на C++ по УП      |\n";
    cout<<"---------------------------------------\n";
    cout<<"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n";
    cout<<"░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░\n";
    cout<<"░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░\n";
    cout<<"░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░\n";
    cout<<"░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░\n";
    cout<<"░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░\n";
    cout<<"░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░\n";
    cout<<"░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░\n";
    cout<<"░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░\n";
    cout<<"░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░\n";
    cout<<"░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░\n";
    cout<<"░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░\n";
    cout<<"░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░\n";
    cout<<"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n";
    cout<<"---------------------------------------\n";
    file_struct_in();

    do
    {
      cout<<"\n\n1. Новая структура ответов\n2. Вывести всю структуру тестирования\n3. Изменить кол-во вопросов для тестирования\n4. Начать тестирование\n0. Выход из программы\n=> ";
      cin>>maink;
      switch (maink)
      {
        case 1:
          input_struct();
          break;

        case 2:
          show_struct();
          break;

        case 3:
          changecounter();
          break;

        case 4:
          beginer();
          break;

      }

    }
    while (maink!=0);
      

cout<<"\n";
return 0;
}
