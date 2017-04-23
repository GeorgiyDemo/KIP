#include <iostream>
#include <iomanip>
#include <fstream>
#include <cmath>

using namespace std;

int i, j, n, m, k, k1, k2, mymax, sum;
double **a;
bool out;
FILE *outfile;

//Простая функция сравнения
int compare(int a, int b){
  if (a<b) return a;
  return b;
  }

//Генерация матрицы
void generate(){

  srand((unsigned)time(0));
   for(i=0;i<n;i++)
    for(j=0;j<m;j++)
        a[i][j]=-20+rand()%20;
}

//Ручной ввод матрицы
void enter(){

   for(i=0;i<n;i++)
    for(j=0;j<m;j++){
        cout<<"Введите элемент ["<<i<<"]["<<j<<"]";
        cin>>a[i][j];
    }

}

//Ввод матрицы из файла
void file_in(){

  fstream fi;
  fi.open("input.txt");
  for (i=0;i<n;i++)
    for (j=0;j<m;j++)
      fi>>a[i][j];
  fi.close();

}


//Меню выбора ввода
void initarray(){

  cout<<"Введите n =>"; cin>>n;
  cout<<"Введите m =>"; cin>>m;

  a = new double *[n];
  for(i=0;i<n;i++)
    a[i]=new double[m+1];

  cout<<"\n\n1. Генерация матрицы\n2. Ручной ввод матрицы\n3. Чтение матрицы из файла\n=> ";
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

//Сортировка матрицы
void sort(bool outer){

  sum=0;
  mymax=abs(a[0][0]);
  for(i=0;i<n;i++)
    for(j=0;j<m;j++){
      if (fabs(a[i][j])>mymax)
        mymax=fabs(a[i][j]);
      if ((a[i][j]<0) && (i==j))
          sum++;
    }

  if (sum==compare(n,m)){
    out = true;
    if (outer == true)
      cout<<"Все элементы диагонали отрицательны, макс. элемент: "<<mymax;
    for(i=0;i<n;i++)
      for(j=0;j<m;j++)
        a[i][j]= (double)a[i][j]/mymax;
  }
  else
    out = false;
    if (outer == true)
      cout<<"Отрицательны не все элементы диагонали, завершаем работу";
  }

//Процедура вывода на экран
void monitor_out(){

  cout<<"\nИсходная матрица:";
  for(i=0;i<n;i++){
    cout<<"\n";
    for(j=0;j<m;j++)
      cout<<setw(8)<<a[i][j];
  }

}

//Процедура вывода в файл
  void file_out(){

    outfile=fopen("out.txt","w+");
    fprintf(outfile,"Исходная матрица:\n");

    for (i=0;i<n;i++){
      for (j=0;j<m;j++)
          fprintf(outfile,"%15f",a[i][j]);
      fprintf(outfile,"\n");
    }
    sort(false);
    if (out == true)
      fprintf(outfile,"\nВсе элементы диагонали отрицательны, макс. элемент: %d\n",mymax);
    else
      fprintf(outfile,"\nОтрицательны не все элементы диагонали, завершаем работу\n");
  fclose(outfile);

}

//Меню выбора вывода
void outarray(){

  cout<<"\n\n1. Вывод матрицы на экран\n2. Вывод матрицы и результатов вычислений в файл\n=> ";
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
    cout<<"\n\n1. Генерация массива\n2. Вывод массива\n3. Сортировка\n0. Выход из программы\n=> ";
    cin>>k;
    switch (k)
    {
      case 1:
        initarray();
        break;

      case 2:
        outarray();
        break;

      case 3:
        sort(true);
        break;

    }

  }
  while (k!=0);

cout<<"\n";
return 0;
}
