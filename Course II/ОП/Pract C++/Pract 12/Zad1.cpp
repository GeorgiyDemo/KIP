#include <stdio.h>
#include <locale.h>
#include <iostream>
#include <cmath>
using namespace std;

const double pi = 3.141;

int main(){
    setlocale(LC_ALL, "ru_RU.utf8");

    int k,a;
    long double result;
    cout<<"|1| Вычисление длинны окружности\n|2| Вычисление радиуса окружности\n|3| Вычисление диаметра окружности\n=> ";
    scanf("%d",&k);

  switch (k){
      case 1:
          cin>>a;
          result = sqrt(a)/(4 * pi);
          cout<<result;
          break;

      case 2:
          cin>>a;
          result = pi * sqrt(a);
          cout<<result;
          break;

      case 3:
          cin>>a;
          result = pi * sqrt(a / 2);
          cout<<result;
          break;

      default:
          cout<<"???";
          break;
      }

cout<<"\n";
return 0;
}