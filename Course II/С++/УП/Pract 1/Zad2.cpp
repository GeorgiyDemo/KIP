#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
#include <cmath>
using namespace std;

int main(){

int sum, poroshok;
int K; //простынь
int P; //пододеяльник
int S; //скатерти 

cout<<"Введите кол-во простыней => "; cin>>K;
cout<<"Введите кол-во пододеяльников => "; cin>>P;
cout<<"Введите кол-во скатертей => "; cin>>S;

sum=K*500+P*650+S*600;   //общий весь белья
poroshok=ceil((ceil(sum/4)*250)/750);  //Кол-во порошка

cout<<"\nОбщий вес белья: "<<sum<<" г."<<"\nКол-во порошка: "<<poroshok<<"\n";
return 0;
}