#include <iostream>
#include <cstring>
#include <iomanip>
#include <stdlib.h>
#include <stdio.h>
#include <cmath>
using namespace std;

void RussianMostWanted(int a, int b, int c){

	if ((a>b) && (a>c))
		cout<<"Кол-во чисел, кратных 5 больше";
	else if ((b>a) && (b>c))
		cout<<"Кол-во чисел, кратных 7 больше";
	else
		cout<<"Кол-во чисел, кратных 9 больше";

}

int main(){

	int i, max=100;
    int five=0, seven=0, nine=0;
    double proc5=0, proc7=0, proc9=0;

    for (i=0;i<max+1;i++){

    	if (i%5==0)
    		five++;
    	if (i%7==0)
    		seven++;
    	if (i%9==0)
    		nine++;

    }

proc5=(double)five/(double)max*100;
proc7=(double)seven/(double)max*100;
proc9=(double)nine/(double)max*100;

cout<<"\nКол-во чисел, кратных 5: "<<five<<" ("<<proc5<<"%)";
cout<<"\nКол-во чисел, кратных 7: "<<seven<<" ("<<proc7<<"%)";
cout<<"\nКол-во чисел, кратных 9: "<<nine<<" ("<<proc9<<"%)\n\n";

RussianMostWanted(five,seven,nine);

cout<<"\n";
return 0;
}