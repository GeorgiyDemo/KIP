#include <math.h> 
#include <iostream> 
#include <iomanip>
#include <locale>

#define pi 3.1415
#define e 0.00001
#define doublepi 9.8696

using namespace std;

int main (){    
    setlocale(LC_ALL, "rus");

    double x,c,sum,y;
  int n,q; 
  sum=0;
  n=1;
  
  initx:  
      cout<<"x => ";cin>>x;
  
  if ((x*x)>(doublepi/4)){
      cout<<"\nПовторите ввод\n";
      goto initx;
  } 
  
  c=sin(x)*sin(x); 
  sum=c; 
  y=log(cos(x));
  
  cout<<"Значение ln cos(x) = "<<setprecision(5)<<y; 
  cout<<"N слагаемое S(x)"; 
  
  do{ 
      cout<<"\n"<<n; 
      c=c*(n*sin(x)*sin(x))/(n+1);
      sum+=c; 
      cout<<setw(12)<<setprecision(5)<<c; 
      cout<<setw(12)<<setprecision(5)<<-0.5*sum; 
      n++;
  } 
  while ((fabs(c)>=e)&&(n<1000)); 
  cout<<"\n\nЗаданная точность достигается за "<<n-1<<" шага"; 
  cout<<"\nСумма ряда: "<<setprecision(5)<<-0.5*sum; 

cout<<"\n";
return 0;
}