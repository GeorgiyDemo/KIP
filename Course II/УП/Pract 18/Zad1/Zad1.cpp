#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

int i, k1, k2, menu, input_len;
string s, s1, strbuf, allbuf;
bool cflag = false;
FILE *outfile;

//Ручный ввод строки
void enter(){
  
  //Мегакостыль
  cout << "Введите строку: ";
  cin>>s1;
  getline(cin,s);
  s=s1+s;
}

//Ввод строки из файла
void file_in(){
  cout<<"\nСчитали следующую строку:\n'";
  ifstream file("input.txt");
  while(getline(file,s)){
    cout<< s;
  }
  cout<<"'";
  file.close();

}

//Вывод строки на экран
void monitor_out(){

  cout<<"\nТекущая строка:\n'";
  cout << s << "'";

}

//Меню выбора ввода
void initarray(){

  cout<<"\n\n1. Ручной ввод строки\n2. Чтение строки из файла\n=> ";
    cin>>k1;
    switch (k1)
    {
      case 1:
        enter();
        break;

      case 2:
        file_in();
        break;
    }

}

//Процедура формирования массива x по образцу
void counter(){

    cout<<"Введите длинну слова => ";
    cin>>input_len;
    cout<<"\nСлова, длинной в "<<input_len<<" символ(ов):\n";
    for (i=0;i<s.length();i++){
        if (s[i]!=' '){
            strbuf += s[i];
        }
        else {
          if (input_len == strbuf.length()){
            allbuf += strbuf+' ';
            cout << strbuf<<"\n";
          }
            strbuf.clear();
        }
    }
  cflag=true;
}

//Процедура вывода в файл
void file_out(){

  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Исходная строка:\n");
  fprintf(outfile,"'%s'\n",s.c_str());
  
  if (cflag==true){

    fprintf(outfile,"\nСлова с длинной в %d символ(ов):\n",input_len);
    fprintf(outfile,"%s",allbuf.c_str());
  }
  else
    fprintf(outfile,"\n*Не вызывали процедуру нахождения слов заданной длинны*");

  fprintf(outfile,"\n");
  fclose(outfile);

}

//Меню выбора вывода
void outarray(){

  cout<<"\n\n1. Вывод строки на экран\n2. Вывод строки и результатов в файл\n=> ";
    cin>>k2;
    switch (k2)
    {
      case 1:
        monitor_out();
        break;

      case 2:
        file_out();
        break;
    }

}

int main(){

  do
  {
    cout<<"\n\n1. Ввод строки\n2. Вывод строки\n3. Вывод слов заданной длинны\n0. Выход из программы\n=> ";
    cin>>menu;
    switch (menu)
    {
      case 1:
        initarray();
        break;

      case 2:
        outarray();
        break;

      case 3:
        counter();
        break;

    }

  }
  while (menu!=0);

cout<<"\n";
return 0;
}
