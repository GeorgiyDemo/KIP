#include <iostream>
#include <iomanip>
#include <math.h>

const int n=4;
const int m=4;
using namespace std;

int i, j, n, m, k, sum, checker, iteration;
double **a, *b, *x, *xn;

void initarray(double **a, int n, int m){
 srand((unsigned)time(0)); 
 for(i=0;i<n;i++){
    for(j=0;j<m;j++)
        a[i][j]=rand()%10-5;
    b[i]=rand()%10-5;
  }
}

int main(){

    b = new double [m];
    x = new double [m];
    xn = new double [m];
    a = new double *[n];
    for(i=0;i<n;i++)
        a[i]=new double[m];

    a[0][0]=-19; a[0][1]=2;  a[0][2]=-1;  a[0][3]=-8;  // матрица 
    a[1][0]=2;   a[1][1]=14; a[1][2]=0;   a[1][3]=-4;
    a[2][0]=6;   a[2][1]=-5; a[2][2]=-20; a[2][3]=-6;
    a[3][0]=-6;  a[3][1]=4;  a[3][2]=-2;  a[3][3]=15;
    
    b[0]=38; b[1]=20; b[2]=52; b[3]=43;      // столбец свободных членов
    x[0]=0;  x[1]=0;  x[2]=0;  x[3]=0;          // начальное приближение
    double eps = 0.005;
    
    iteration=0;
    while (true){
        //cout<<"НИХЕРА, МЫ В ЦИКЛЕ";
        xn[0] = (b[0] - (a[0][1]*x[1] + a[0][2]*x[2] + a[0][3]*x[3]))/a[0][0]; 
        xn[1] = (b[1] - (a[1][0]*x[0] + a[1][2]*x[2] + a[1][3]*x[3]))/a[1][1];
        
        xn[2] = (b[2] - (a[2][0]*x[0] + a[2][1]*x[1] + a[2][3]*x[3]))/a[2][2];
        xn[3] = (b[3] - (a[3][0]*x[0] + a[3][1]*x[1] + a[3][2]*x[2]))/a[3][3];

        checker=0;
        for(i=0;i<4;i++)
            if(fabs(xn[i]-x[i])<eps)
                checker++;
        
        if (checker==4)
            break;

        for(int i=0;i<4;i++)
            x[i] = xn[i];
    cout << "\nИтерация №"<<iteration+1<<":\nx1 = "<<xn[0]  << "\nx2 = " << xn[1] << endl << "x3 = " << xn[2] << endl << "x4 = " << xn[3] << endl;   
    iteration++;
    }

    for(i=0;i<4;i++)
            x[i] = xn[i];  
   
    cout << "\n-------------------\nИтераций всего: " << iteration+1;
    for(i=0;i<4;i++)
        cout<<"\n"<<x[i];

cout<<"\n";
return 0;

}