#include <iostream>
using namespace std;
//Количество членов ряда:
const int N=100;
//Класс для реализации матриц:
class Matrix{
public:
double a[2][2];
//Метод для умножения матриц:
Matrix mult(Matrix obj){
Matrix T;
int i,j,k;
for(i=0;i<2;i++)
   for(j=0;j<2;j++){
      T.a[i][j]=0;
      for(k=0;k<2;k++)
      T.a[i][j]+=a[i][k]*obj.a[k][j];
   }
return T;}
//Метод для суммирования матриц:
Matrix mSum(Matrix obj){
Matrix T;
int i,j;
for(i=0;i<2;i++)
   for(j=0;j<2;j++)
      T.a[i][j]=a[i][j]+obj.a[i][j];
return T;}
//Деление матрицы на число:
Matrix div(double x){
int i,j;
for(i=0;i<2;i++)
   for(j=0;j<2;j++)
      a[i][j]/=x;
return *this;}
//Отображение матрицы:
void mShow(){
printf("%8f%s%8f%s",a[0][0],"  ",a[0][1],"\n");
printf("%8f%s%8f%s",a[1][0],"  ",a[1][1],"\n");
}};
//Матричная экспонента:
Matrix mExp(Matrix obj){
int i;
Matrix E,T;
E.a[0][0]=1;
E.a[1][1]=1;
E.a[0][1]=0;
E.a[1][0]=0;
T=E;
for(i=1;i<=N;i++){
   T=T.mult(obj);
   T=T.div(i);
   E=E.mSum(T);}
return E;}
int main(){
Matrix A;
A.a[0][0]=1;
A.a[0][1]=-1;
A.a[1][0]=2;
A.a[1][1]=1;
A.mShow();
cout<<endl;
mExp(A).mShow();
return 0;}