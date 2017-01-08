#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
using namespace std;

const int number = 3;

struct AEROFLOT{
 char punct_naz[50],number[10],type[30];
} a[100], ae;

int main(){
 
 int i, j, buf;
 bool flag=false;
 char aerotype[30];

 for (i=0;i<number;i++){
     cout<<"Пункт назначения => ";
     cin>>a[i].punct_naz;
     cout<<"Номер рейса => ";
     cin>>a[i].number;
     cout<<"Тип самолета => ";
     cin>>a[i].type;
 }

 cout<<"\nСортировка по алфавиту пунктов назначения:";
 for (i=0;i<number;i++)
    for (j=i+1;j<number;j++)
        if (strcmp(a[i].punct_naz,a[j].punct_naz)>0){
            ae=a[i];
            a[i]=a[j];
            a[j]=ae;
        }
 for (i=0;i<number;i++)
    cout<<"\n№"<<a[i].number<<" тип: "<<a[i].type<<" назначение: "<<a[i].punct_naz;

 cout<<"\n\nВведите тип самолета => "; cin>>aerotype;
 for (i=0;i<number;i++)
    if (strcmp(a[i].type,aerotype)==0){
        cout<<"№"<<a[i].number<<" назначение: "<<a[i].punct_naz<<"\n";
        flag=true;
    }
    if (flag==false)
        cout<<"Рейсов с таким типом самолета не существует :c\n";

return 0;
}