#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>

using namespace std;

int i,j,n,k1,menu,k2, input_len;
string s, s1, strbuf;
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

  cout<<"Введите размерность строки: ";
  cin>>n;

  fstream fi;
  fi.open("input.txt");
  for (i=0;i<n;i++)
      fi>>s[i];
  fi.close();

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

    for (i=0;i<s.length();i++){
        if (s[i]!=' '){
            strbuf += s[i];
        } 
        else{
          if (input_len == strbuf.length())
            cout << strbuf;
            strbuf.clear();
        }
    }
    ///
}

//Процедура вывода в файл
//void file_out(){
//
//  outfile=fopen("out.txt","w+");
//  fprintf(outfile,"Матрица А:\n");
//  for (i=0;i<n;i++){
//    for (j=0;j<m;j++)
//      fprintf(outfile,"%4d",a[i][j]);
//    fprintf(outfile,"\n");
//  }
//  
//  for (i=0;i<n;i++){
//    if ((a[i][0]<(a[i][1]+a[i][2])) && (a[i][1]<(a[i][0]+a[i][2])) && (a[i][2]<(a[i][1]+a[i][0]))){
//      
//      p=a[i][0]+a[i][1]+a[i][2];
//      s1=(double)p/2;
//      s=sqrt(s1*(s1-a[i][0])*(s1-a[i][1])*(s1-a[i][2]));
//      
//     fprintf(outfile,"\n----Треугольник №%d----\nСтороны: %d, %d,%d\nПериметр: %f\nПлощадь: %f",i+1,a[i][0],a[i][1],a[i][2],p,s);
//    }
//    
//    else {
//      fprintf(outfile,"\n\nНесуществующий %d-й треугольник\nЗавершаем цикл..",i+1);
//      break;
//    }
//  
//  }
//  
//  fprintf(outfile,"\n");
//  fclose(outfile);

//}

//Меню выбора вывода
void outarray(){

  cout<<"\n\n1. Вывод матрицы A на экран\n2. Вывод матрицы А и результатов вычислений в файл\n=> ";
    cin>>k2;
    switch (k2)
    {
      case 1:
        monitor_out();
        break;

      case 2:
          cout<<"Пилю";
        //file_out();
        break;
    }

}

int main(){

  do
  {
    cout<<"\n\n1. Ввод Строки\n2. Вывод матрицы\n3.Вывод слов заданной длинны\n0. Выход из программы\n=> ";
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
