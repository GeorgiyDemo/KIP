#include <iostream>
#include <cmath>
using namespace std;
//Количество слагаемых ряда:
const int n=100;
const double pi=3.1415;
//Класс для косинус-преобразования:
class FourierCos{
protected:
//Раскладываемая в ряд функция:
double (*f)(double);
//Коэффициенты разложения:
double a[n+1];
//Интеграл для косинус-преобразования:
double IntCos(int k,bool state=false){
int N=10000,i;
double s=0,h=(1+state)*pi/N,x=-pi*state;
for(i=0;i<N;i++){
   s+=(f(x)*cos(x*k)+f(x+h)*cos((x+h)*k))/2;
   x+=h;}
s*=h*(2-state);
return s;}
public:
//Метод для вычисления коэффициентов ряда:
void make(bool state=false){
int i;
for(i=0;i<=n;i++){
   a[i]=IntCos(i,state)/pi;}
   a[0]/=2;}
//Перегрузка оператора ():
double operator()(double x){
double s=0;
for(int i=0;i<=n;i++)
   s+=a[i]*cos(x*i);
return s;}
void operator()(double (*f)(double)){
this->f=f;}
}F1;
//Класс для синус-преобразования:
class FourierSin{
protected:
//Раскладываемая в ряд функция:
double (*f)(double);
//Коэффициенты разложения:
double b[n+1];
//Интеграл для синус-преобразования:
double IntSin(int k,bool state=false){
int N=10000,i;
double s=0,h=(1+state)*pi/N,x=-pi*state;
for(i=0;i<N;i++){
   s+=(f(x)*sin(x*k)+f(x+h)*sin((x+h)*k))/2;
   x+=h;}
s*=h*(2-state);
return s;}
public:
//Метод для вычисления коэффициентов ряда:
void make(bool state=false){
int i;
for(i=1;i<=n;i++){
   b[i]=IntSin(i,state)/pi;}
b[0]=0;}
//Перегрузка оператора ():
double operator()(double x){
double s=0;
for(int i=1;i<=n;i++)
   s+=b[i]*sin(x*i);
return s;}
void operator()(double (*f)(double)){
this->f=f;}
}F2;
//Класс для преобразования Фурье:
class Fourier:public FourierCos,public FourierSin{
public:
//Переопределение метода для вычисления коэффициентов ряда:
void make(bool state=false){
FourierCos::make(true);
FourierSin::make(true);}
//Переопределение оператора ():
double operator()(double x){
return FourierCos::operator()(x)+FourierSin::operator()(x);}
void operator()(double (*f)(double)){
this->FourierCos::f=f;
this->FourierSin::f=f;}
}F;
//Функции для преобразования Фурье:
double f1(double x){
return x*x;}
double f2(double x){
return x;}
double f(double x){
return f1(x)+f2(x);}
int main(){
F1(f1);
F1.make();
F2(f2);
F2.make();
F(f);
F.make();
cout<<F1(1)<<endl;
cout<<F2(2)<<endl;
cout<<F(-3)<<endl;
return 0;}