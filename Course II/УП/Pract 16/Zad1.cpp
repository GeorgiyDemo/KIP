#include <iostream>
#include <iomanip>
#include <fstream>
#include <cmath>
using namespace std;

int const n = 7;
int const m = 3;

int i, j, t, k, k1, k2, menu, *c, **a;
double p, s, s1, q, v;
FILE *outfile;

//Генерация массивов
void generate(){

  srand((unsigned)time(0));
  for (i=0;i<n;i++)
    for (j=0;j<m;j++)
      a[i][j]=rand()%20;

}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем матрицу А>\n";
  for(i=0;i<n;i++)
    for(j=0;j<m;j++){
      cout<<"Введите элемент ["<<i<<"]["<<j<<"]: ";
      cin>>a[i][j];
    }

}

//Ввод массивов из файла
void file_in(){

  fstream fi;
  fi.open("input.txt");
  for (i=0;i<n;i++)
    for (j=0;j<m;j++)
      fi>>a[i][j];
  fi.close();

}

//Вывод массивов на экран
void monitor_out(){

  cout<<"\nИсходная матрица А:";
  for (i=0;i<n;i++){
    cout<<"\n";
    for (j=0;j<m;j++)
      cout<<setw(5)<<a[i][j];
  }
}

//Меню выбора ввода
void initarray(){

  a = new int *[n];
  for(i=0;i<n;i++)
    a[i]=new int[m];

  cout<<"\n\n1. Генерация матрицы А\n2. Ручной ввод матрицы А\n3. Чтение матрицы А из файла\n=> ";
    cin>>k1;
    switch (k1)
    {
      case 1:
        generate();
        break;

      case 2:
        enter();
        break;

      case 3:
        file_in();
        break;
    }

}

//Процедура формирования массива x по образцу
void counter(){
  
 for (i=0;i<n;i++){
    if ((a[i][0]<(a[i][1]+a[i][2])) && (a[i][1]<(a[i][0]+a[i][2])) && (a[i][2]<(a[i][1]+a[i][0]))){
      
      p=a[i][0]+a[i][1]+a[i][2];
      s1=(double)p/2;
      s=sqrt(s1*(s1-a[i][0])*(s1-a[i][1])*(s1-a[i][2]));
      
      cout<<"\n----Треугольник №"<<i+1<<"----\nСтороны: "<<a[i][0]<<", "<<a[i][1]<<", "<<a[i][2]<<"\nПериметр: "<<p<<"\nПлощадь: "<<s;
    }
    else{
      cout<<"\nНесуществующий "<<i+1<<"-й треугольник\nЗавершаем цикл..";
      break;
    }
 }

}

//Процедура вывода в файл
void file_out(){

  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Матрица А:\n");
  for (i=0;i<n;i++){
    for (j=0;j<m;j++)
      fprintf(outfile,"%4d",a[i][j]);
    fprintf(outfile,"\n");
  }
  
  for (i=0;i<n;i++){
    if ((a[i][0]<(a[i][1]+a[i][2])) && (a[i][1]<(a[i][0]+a[i][2])) && (a[i][2]<(a[i][1]+a[i][0]))){
      
      p=a[i][0]+a[i][1]+a[i][2];
      s1=(double)p/2;
      s=sqrt(s1*(s1-a[i][0])*(s1-a[i][1])*(s1-a[i][2]));
      
      fprintf(outfile,"\n----Треугольник №%d----\nСтороны: %d, %d,%d\nПериметр: %f\nПлощадь: %f",i+1,a[i][0],a[i][1],a[i][2],p,s);
    }
    
    else {
      fprintf(outfile,"\n\nНесуществующий %d-й треугольник\nЗавершаем цикл..",i+1);
      break;
    }
  
  }
  
  fprintf(outfile,"\n");
  fclose(outfile);

}

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
        file_out();
        break;
    }

}

int main(){

  do
  {
    cout<<"\n\n1. Ввод матрицы\n2. Вывод матрицы\n3. Проверка на существование треугольников\n0. Выход из программы\n=> ";
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
