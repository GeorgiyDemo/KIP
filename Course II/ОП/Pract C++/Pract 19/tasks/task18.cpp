#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
using namespace std;

const int number = 7;

struct AEROFLOT{
 char punct_naz[50],number[10],type[30];
} a18[100], ae;

int n18(){
 
 int i, j, buf;
 bool flag=false;
 char aerotype[30];

 for (i=0;i<number;i++){
     cout<<"Пункт назначения => ";
     cin>>a18[i].punct_naz;
     cout<<"Номер рейса => ";
     cin>>a18[i].number;
     cout<<"Тип самолета => ";
     cin>>a18[i].type;
 }

 cout<<"\nСортировка по алфавиту пунктов назначения:";
 for (i=0;i<number;i++)
    for (j=i+1;j<number;j++)
        if (strcmp(a18[i].punct_naz,a18[j].punct_naz)>0){
            ae=a18[i];
            a18[i]=a18[j];
            a18[j]=ae;
        }
 for (i=0;i<number;i++)
    cout<<"\n№"<<a18[i].number<<" тип: "<<a18[i].type<<" назначение: "<<a18[i].punct_naz;

 cout<<"\n\nВведите тип самолета => "; cin>>aerotype;
 for (i=0;i<number;i++)
    if (strcmp(a18[i].type,aerotype)==0){
        cout<<"№"<<a18[i].number<<" назначение: "<<a18[i].punct_naz<<"\n";
        flag=true;
    }
    if (flag==false)
        cout<<"Рейсов с таким типом самолета не существует :c\n";

return 0;
}