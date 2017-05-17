#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

int const n = 75;
int i, j, k, k1, k2, menu, *a;
FILE *outfile;

//Генерация массивов
void generate(){
  srand((unsigned)time(0));
  for (i=0;i<n;i++){
      a[i]=rand()%20;
  }

}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем матрицу А>\n";
  for (i=0;i<n;i++){

      cout<<"Введите элемент №"<<i<<": ";
      cin>>a[i];
    
  }

}

//Ввод массивов из файла
void file_in(){

  fstream fi;

  fi.open("input.txt");
  for (i=0;i<n;i++)
      fi>>a[i];
  fi.close();

}

//Вывод массивов на экран
void monitor_out(){

  cout<<"\nМатрица А:\n\n";

  for (i=0;i<n;i+=3){
     for (j=0;j<3;j++)
        printf("%4d",a[i+j]);
    printf("\n");
  }

}

//Меню выбора ввода
void initarray(){

  a = new int [n];

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
  k=1;
  for (i=0;i<n;i+=3){
        if ((a[i]<(a[i+1]+a[i+2])) && (a[i+1]<(a[i]+a[i+2])) && (a[i+2]<(a[i+1]+a[i])))
          printf("\n✅  Строка №%d: треугольник существует [%d, %d, %d]",k,a[i],a[i+1],a[i+2]);
        else
          printf("\n❌  Строка №%d: треугольник не существует [%d, %d, %d]",k,a[i],a[i+1],a[i+2]);
    k++;
  }

}

//Процедура вывода в файл
void file_out(){
  
  k=1;
  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Матрица А:\n");
  for (i=0;i<n;i+=3){
     for (j=0;j<3;j++)
        fprintf(outfile,"%4d",a[i+j]);
    fprintf(outfile,"\n");
  }

  for (i=0;i<n;i+=3){
        if ((a[i]<(a[i+1]+a[i+2])) && (a[i+1]<(a[i]+a[i+2])) && (a[i+2]<(a[i+1]+a[i])))
          fprintf(outfile,"\n✅  Строка №%d: треугольник существует [%d, %d, %d]",k,a[i],a[i+1],a[i+2]);
        else
          fprintf(outfile,"\n❌  Строка №%d: треугольник не существует [%d, %d, %d]",k,a[i],a[i+1],a[i+2]);
    k++;
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
