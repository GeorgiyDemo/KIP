#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;

const int n=4;
const int m=4;

int i, j, k, checker, iteration, input;
double **a, *b, *x, *xn, eps;

//Рандомный ввод массивов
void initarray(){
    srand((unsigned)time(0)); 
    for(i=0;i<n;i++){
        for(j=0;j<m;j++)
            a[i][j]=rand()%10-5;
        b[i]=rand()%10-5;
        x[i]=0;
    }
}

//Ручный ввод массивов
void enter(){
    cout<<"<Заполняем коэффициенты>\n";
    for (i=0;i<n;i++)
        for (j=0;j<m;j++){
            cout<<"Введите элемент ["<<i+1<<"]["<<j+1<<"]: ";
            cin>>a[i][j];
    }

    cout<<"<Заполняем свободные члены>\n";
    for (i=0;i<n;i++){
        cout<<"Введите элемент ["<<i+1<<"]: ";
        cin>>b[i];
        x[i]=0; 
    }

}

//Вывод массивов на экран
void outarray(){
    cout<<"\nИсходная матрица:\n";
    for(i=0;i<n;i++){
        cout<<"\n";
        for(j=0;j<m;j++)
            cout<<setw(5)<<a[i][j];
        cout<<setw(5)<<b[i];
    }
}

//Функция метода простых итераций
void simple_iteration(){

    iteration=0;
    while (true){

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

}

int main(){

    cout<<"Введите точность (пример: 0.005) => "; cin>>eps;

    a = new double *[m];
    for(i=0;i<n;i++)
        a[i]=new double[n];
    b = new double [m];
    x = new double [m];
    xn = new double [m];
    
    cout<<"\nКак вы хотите ввести матрицу?\n1. Ручной ввод исходной матрицы\n2. Рандомный ввод исходной матрицы\n=> ";
    cin>>input;

    switch (input)
    {
      case 1:
        enter();
        break;

      case 2:
        initarray();
        break;
    }

    outarray();
    simple_iteration();

cout<<"\n";
return 0;

}