/*
	1. Описать структуру с именем AEROFLOT, содержащую следующие поля:
	• название пункта назначения рейса;
	• номер рейса;
	• тип самолета.
	. 	Написать программу, выполняющую следующие действия:
	• из файла данных в массив, состоящий из двух элементов типа
	AEROFLOT; 
	Вывод на экран  и в файл данных обо  всех рейсах.
	• вывод на экран пунктов назначения и номеров рейсов, обслуживаемых самолетом, тип которого введен с клавиатуры;
	• если таких рейсов нет, выдать на дисплей соответствующее сообщение

*/

#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
#include <fstream>
using namespace std;

const int number = 3;
int i, k1, k2, menu, input_len;
FILE* outfile;
FILE* inputfile;

void file_out();
void file_in();

struct AEROFLOT {
    char punct_naz[50], number[10], type[30];
} a[100], inputarr[2];

int main()
{

    int i, j, buf;
    bool flag = false;
    char aerotype[30];

    file_in();

    for (i = 0; i < number; i++) {
        cout << "Пункт назначения => ";
        cin >> a[i].punct_naz;
        cout << "Номер рейса => ";
        cin >> a[i].number;
        cout << "Тип самолета => ";
        cin >> a[i].type;
    }

    for (i = 0; i < number; i++)
        cout << "\n№" << a[i].number << " тип: " << a[i].type << " назначение: " << a[i].punct_naz;
    file_out();

    cout << "\n\nВведите тип самолета => ";
    cin >> aerotype;
    for (i = 0; i < number; i++)
        if (strcmp(a[i].type, aerotype) == 0) {
            cout << "№" << a[i].number << " назначение: " << a[i].punct_naz << "\n";
            flag = true;
        }
    if (flag == false)
        cout << "Рейсов с таким типом самолета не существует :c\n";

    return 0;
}

void file_in(){

  fstream fi;
  fi.open("input.txt");
  
  for(int i=0;i<=1;i++){
    fi>>inputarr[i].number;
    fi>>inputarr[i].type;
    fi>>inputarr[i].punct_naz;	
  }

  cout<<"*Чтение из файла*";
  for (int i=0;i<2;i++){
  	cout << "\n№" << inputarr[i].number << " тип: " << inputarr[i].type << " назначение: " << inputarr[i].punct_naz;
  }
  fi.close();

  cout<<"\n";

}

void file_out()
{

    outfile = fopen("out.txt", "w+");
    fprintf(outfile, "Список всех рейсов:");

    for (i = 0; i < number; i++)
        fprintf(outfile, "\n№%s тип: %s назначение: %s", a[i].number, a[i].type, a[i].punct_naz);

    cout << "\n*Успешная запись данных в файл*\n";
    fprintf(outfile, "\n");
    fclose(outfile);
}