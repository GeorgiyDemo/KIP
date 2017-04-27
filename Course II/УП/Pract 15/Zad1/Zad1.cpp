#include <iostream>
#include <iomanip>
#include <fstream>

using namespace std;

int i, j, t, s, m, b, k, k1, k2, menu, *c, **a;
double p, q, n, v, *x;
bool xarray = false;
FILE *outfile;

//Генерация матрицы
void generate(){

  srand((unsigned)time(0));
  for (i=0;i<m;i++)
    for (j=0;j<m;j++)
      a[i][j]=-10+rand()%20;

  for (i=0;i<m;i++)
    c[i]=-10+rand()%20;

}

void enter(){
/////
  cout<<"<Заполняем матрицу А>\n";
  for(i=0;i<m;i++)
    for(j=0;j<m;j++){
      cout<<"Введите элемент ["<<i<<"]["<<j<<"]: ";
      cin>>a[i][j];
    }

  cout<<"\n\n<Заполняем массив С>\n";
  for(i=0;i<m;i++){
    cout<<"Введите элемент ["<<i<<"]: ";
    cin>>c[i];
  }

}

//Ввод матрицы из файла
void file_in(){

  fstream fi;
  fi.open("inputA.txt");
  for (i=0;i<m;i++)
    for (j=0;j<m;j++)
      fi>>a[i][j];
  fi.close();


  fi.open("inputC.txt");
  for (i=0;i<m;i++)
      fi>>c[i];
  fi.close();

}

void monitor_out(){

  cout<<"\nИсходная матрица А:";
  for (i=0;i<m;i++){
    cout<<"\n";
    for (j=0;j<m;j++)
      cout<<setw(5)<<a[i][j];
  }

  cout << "\n\nМассив С: ";
  for (i=0;i<m;i++)
    cout<<c[i]<<" ";
}

//Меню выбора ввода
void initarray(){

  cout<<"Введите m =>"; cin>>m;

  c = new int[m];
  x = new double[m];
  a = new int *[m];
  for(i=0;i<m;i++)
    a[i]=new int[m+1];


  cout<<"\n\n1. Генерация матрицы А и массива С\n2. Ручной ввод матрицы А и массива С\n3. Чтение матрицы А и массива С из файла\n=> ";
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

void counter(){

  cout << "Введите переменную b =>";
  cin >> b;

  for (i = 0; i<m; i++)
    for (j = 0; j<m; j++)
      if (i == j)
        s += a[i][j];

  cout << "\nМассив x на выходе:\n";

  for (i=0;i<m;i++){
    if (i == 0)
      p = 1;
    else
      p = x[i - 1];
    n = (s / (p*c[i]));
    for (k = 0; k<m; k++){
      v = (double)((a[k][i]+c[k])/(k*k+b));
      q += v;
    }

    x[i] = n + q;
    n = 0;
    v = 0;
    q = 0;
    cout<<i<<". "<< x[i] << "\n";
  }

  xarray=true;

}

//Процедура вывода в файл
void file_out(){

  outfile=fopen("out.txt","w+");
  fprintf(outfile,"Матрица А:\n");
  for (i=0;i<m;i++){
    for (j=0;j<m;j++)
      fprintf(outfile,"%4d",a[i][j]);
    fprintf(outfile,"\n");
  }
  
  fprintf(outfile,"\nМассив C:\n");
  for (i=0;i<m;i++)
    fprintf(outfile,"%4d",c[i]);
  fprintf(outfile,"\n");

  if (xarray==true){
    fprintf(outfile,"\nСформированный массив x:\n");
    for (i=0;i<m;i++)
      fprintf(outfile,"%d. %4f\n",i, x[i]);
  }
  else
    fprintf(outfile,"\nМассив x не сформирован\n");
  
  fclose(outfile);

}

//Меню выбора вывода
void outarray(){

  cout<<"\n\n1. Вывод массивов на экран\n2. Вывод массивов и результатов вычислений в файл\n=> ";
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

int main() {

  do
  {
    cout<<"\n\n1. Ввод массивов\n2. Вывод массивов\n3. Формирование массива x\n0. Выход из программы\n=> ";
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
