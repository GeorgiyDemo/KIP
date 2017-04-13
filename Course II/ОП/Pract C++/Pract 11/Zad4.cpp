#include <stdio.h>
#include <iostream>
using namespace std;

bool tochka(int t1, int t2){
    return ((t1 <= -2) && (t1 >= -6) && (t2 >2) &&(t2 < 7)) || ((t1 <= -4) &&(t1 >= -6)&&(t2 >= -3)&&(t2 <= 2)) ? true : false
;}

int main(){

  int x,y;
    bool trigger;

  printf("x => "); scanf("%d",&x);
  printf("y => "); scanf("%d",&y);

  trigger = tochka(x,y);
    (trigger == 1) ? cout<<"True" : cout<<"False";

return 0;
}