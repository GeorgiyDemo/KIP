#include <iostream>
#include <math.h>
#include "numbers/pract11.cpp"
using namespace std;

int main(){

    int maink=0;
    int k=0;

    cout<<"Практические C++ по ОП\n";
    cout<<"Введите номер практической [11-18] => "; cin>>maink;

    switch (maink){

        case 11:{
            cout<<"Введите задание [1-3] => "; cin>>k;
            switch (k){  
                 case 1:{
                    n11_1();
                    break;
                 }  
                 case 2:{
                    n11_2();
                    break;
                 }
                 case 3:{
                    n11_3();
                    break;
                 } 
                 default:{  
                    cout<<"Такого задания нет!";
                 }
              }  
            break;
        }

        case 12:{
            cout<<"Введите задание [1-2] => "; cin>>k;
            switch (k){  
                 case 1:{
                    n12_1();
                    break;
                 }  
                 case 2:{
                    n12_2();
                    break;
                 } 
                 default:{  
                    cout<<"Такого задания нет!";
                 }
              }  
            break;
        }

        case 13:{
            cout<<"Введите задание [1-2] => "; cin>>k;
            switch (k){  
                 case 1:{
                    n13_1();
                    break;
                 }  
                 case 2:{
                    n13_2();
                    break;
                 } 
                 default:{  
                    cout<<"Такого задания нет!";
                 }
              }  
            break;
        }

        default:{
            cout<<"Такого задания нет!";
            break;
        }

    }

    return 0;
}
