#include <iostream>

using namespace std;

int main(){

	int i,x;
    float y;

    cout<<"Введите x => ";cin>>x;

        if ((11<=x) && (x<=30)){
        	y=(2*x*x+7)/x;
        	cout<<"Ветка №1\nРезультат: y="<<y<<"\n";
        }
        
        else if ((1<=x) && (x<11)){
        	y=((x+3)*(x+3))/x;
        	cout<<"Ветка №2\nРезультат: y="<<y<<"\n";
        }
        
        else
        	cout<<"Не входит в данное множество\n";

cout<<"\n";
return 0;

}