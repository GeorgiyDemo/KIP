#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

int i, j, k1, k2, menu, input_len, a_count, b_count;
bool cflag = false;
string str_a = "aeiouy";
string str_b = "bcdfghjklmnpqrstvwxz";
string s, s1;
FILE *outfile;

string checker(int a, int b){
	if (a>b)
		return "Гласных букв в строке больше";
	return "Согласных букв в строке больше";
}

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
    cout<<s;
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

//Счет гласных/согласных букв в строке, согласно условию
void counter(){

	for(i=0;i<s.length();i++)
    for(j=0;j<str_a.length();j++)
      if(s[i]==str_a[j])
        a_count++;
 
  for(i=0;i<s.length();i++)
    for(j=0;j<str_b.length();j++)
      if(s[i]==str_b[j])
        b_count++;
 	
 	cflag = true;
 	printf("\nКол-во гласных букв в строке: %d\nКол-во согласных букв в строке: %d", a_count, b_count);
 	printf("\n\n%s",checker(a_count,b_count).c_str());
    
}

//Процедура вывода в файл
void file_out(){

  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Исходная строка:\n");
  fprintf(outfile,"'%s'\n",s.c_str());
  
  if (cflag==true){
  	fprintf(outfile,"\nКол-во гласных букв в строке: %d\nКол-во согласных букв в строке: %d", a_count, b_count);
  	fprintf(outfile,"\n\n%s",checker(a_count,b_count).c_str());
  }
  else
    fprintf(outfile,"\n*Не вызывали процедуру счета гласных/согласных букв в строке*");

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
    cout<<"\n\n1. Ввод строки\n2. Вывод строки\n3. Кол-во гласных/согласных букв\n0. Выход из программы\n=> ";
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
