#include<iostream>
#include<cmath>
using namespace std;
const int N=4;// вариант 4
const double eps=0.001;//погрешность
double f(double x)
{
    return((cos(0.07*N+0.5*x)/(0.4+pow(x*x+N,0.5))));
}
//для Симсона , задание 2
double f2(double x)
{
    return(1/(sqrt(x*x+N)));
}
double LeftPram(double a,double b,int n){
	double h,XB,s,x;
	h=(b-a)/n;
	s=0;
	XB=a;
	for(int i=0;i<n-1;i++){
		x=XB+i*h;
		s=s+f(x)*h;
	}
	return s;
}
double RightPram(double a,double b,int n){
	double h,XB,s,x;
	h=(b-a)/n;
	s=0;
	XB=a;
	for(int i=1;i<=n;i++){
		x=XB+i*h;
		s=s+f(x)*h;
	}
	return s;
}
double Trapesia(double a,double b,int n){
	double h,XB,s,x,n1,n2;
	h=(b-a)/n;
	s=0;
	XB=a;
	for(int i=1;i<n-1;i++){
		x=XB+i*h;
		s=s+f(x)*h;
	}
	x=XB;
	n1=f(x)*h;//первый
	x=XB+n*h;
	n2=f(x)*h;// последний
	s=s+n1+n2;
	return s;
}

double Simson(double a,double b,int n){
	double h,s,x,F;
	int i=1;
	h=(b-a)/n;
	x=a;
	F=f2(x);
	s=F;
	while(i<=n){
		x=x+h;
		F=f2(x);
		s=s+4*F;
		i=i+2;
		x=x+h;
		F=f2(x);
		s=s+2*F;
	}
	x=b;
	F=f2(x);
	s=(s+F)*(h/3);
	return s;
	
}

int main()
{
      setlocale(LC_ALL, "Russian");
	double  y;
	double raz1,y1, R;
	cout<<"Задание 1."<<endl;
	y=LeftPram(0.4,1.2,30);
	cout<<"Метод левых:"<<y<<endl;

	y=RightPram(0.4,1.2,30);
	cout<<"Метод правых:"<<y<<endl;
	y=Trapesia(0.4,1.2,30);
	cout<<"Метод трапеции, средних:"<<y<<"\n"<<endl;
	y1=Trapesia(0.4,1.2,29);
	raz1=abs( y-y1);
	cout<<"точность:"<<raz1<<"\n"<<endl;
	cout<<"Задание 2. Метод Симсона"<<endl;
	y=Simson(1.2,2.1,220);
	cout<<"Метод Симсона:"<<y<<"\n"<<endl;
	y1=Simson(1.2,2.1,219);
	raz1=abs( y-y1);
	cout<<"точность:"<<raz1<<"\n"<<endl;
	//R=-h^4\180 *(f(4))
	// погрешность f(4) = 3/((x^2+8)^(5/2))*(35*x^4/((x^2+8)^2)-30*x^2/(x^2+8)+3) 
	return 0;
}
