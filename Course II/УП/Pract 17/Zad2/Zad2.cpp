#include <iostream>
#include <iomanip>
#include <fstream>
using namespace std;

int const n = 25;

int i, j, k1, k2, menu, *a, *b, *c;
FILE *outfile;

//Генерация массивов
void generate(){

  srand((unsigned)time(0));
  for (i=0;i<n;i++){
      a[i]=rand()%20;
      b[i]=rand()%20;
      c[i]=rand()%20;
  }

}

//Ручный ввод массивов
void enter(){

  cout<<"<Заполняем матрицу А>\n";
  for (i=0;i<n;i++){

      cout<<"Введите элементы строки №"<<i<<": ";
      cin>>a[i];
      cin>>b[i];
      cin>>c[i];
    
  }

}

//Ввод массивов из файла
void file_in(){

  fstream fi;

  fi.open("inputA.txt");
  for (i=0;i<n;i++)
      fi>>a[i];
  fi.close();

  fi.open("inputB.txt");
  for (i=0;i<n;i++)
      fi>>b[i];
  fi.close();

  fi.open("inputC.txt");
  for (i=0;i<n;i++)
      fi>>c[i];
  fi.close();

}

//Вывод массивов на экран
void monitor_out(){

  cout<<"\nМатрица А:\n";
  for (i=0;i<n;i++){
    printf("%4d%4d%4d\n",a[i],b[i],c[i]);
  }
}

//Меню выбора ввода
void initarray(){

  a = new int [n];
  b = new int [n];
  c = new int [n];

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

//Процедура проверки на пренадлежность элементов к сторонам треугольника
void counter(){
  
 for (i=0;i<n;i++){
    if ((a[i]<(b[i]+c[i])) && (b[i]<(a[i]+c[i])) && (c[i]<(b[i]+a[i])))
        printf("\n✅  Строка №%d: треугольник существует [%d, %d, %d]",i+1,a[i],b[i],c[i]);
    else
        printf("\n❌  Строка №%d: треугольник не существует [%d, %d, %d]",i+1,a[i],b[i],c[i]);
 }

}

//Процедура вывода в файл
void file_out(){

  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Матрица А:\n");
  for (i=0;i<n;i++){
    fprintf(outfile,"%4d%4d%4d",a[i],b[i],c[i]);
    fprintf(outfile,"\n");
  }

  for (i=0;i<n;i++){
    if ((a[i]<(b[i]+c[i])) && (b[i]<(a[i]+c[i])) && (c[i]<(b[i]+a[i])))
          fprintf(outfile,"\n✅  Строка №%d: треугольник существует [%d, %d, %d]",i+1,a[i],b[i],c[i]);
     else
          fprintf(outfile,"\n❌  Строка №%d: треугольник не существует [%d, %d, %d]",i+1,a[i],b[i],c[i]);
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

//Основная процедура
int main(){

  do
  {
    cout<<"\n\n*Алгоритм №2*\n1. Ввод матрицы\n2. Вывод матрицы\n3. Проверка на существование треугольников\n0. Выход из программы\n=> ";
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
