#include <iostream>
#include <time.h>
 
using namespace std; 
 
 
int main()
{
    setlocale(0,"Rus");
        int mas[100][100], res[100];
        int n, max, min, col=0, row=0;
        cout<<"Введите N: ";
        cin>>n;
        srand(time(NULL));
 
 // Заполнение массива
        cout<<"Исходный массив:\n";
        for(int i=0; i<n; i++)
        {
                for(int j=0; j<n; j++)
                        cout<<(mas[i][j]=rand()%100)<<'\t';
                cout<<'\n';
        }
 
        min=max=mas[0][0];
        
 
 //Поиск наиб. и наим.
        for(int i=0; i<n; i++)
                for(int j=0; j<n; j++)
                {
                        if (mas[i][j]>max)
                        {
                                max=mas[i][j];
                                row=i;
                        }
                        if (mas[i][j]<min)
                        {
                                min=mas[i][j];
                                col=j;
                        }
                }
 
        cout<<"max = "<<max<<" min = "<<min<<'\n';
        cout<<"Строка= "<<row<<" Столб = "<<col<<'\n';
 
        // Умножение
        cout<<"Результат:\n";
        for(int i=0; i<n; i++)
        {
                cout<<(res[i]=mas[row][i]*mas[i][col])<<'\t';
 
        }
        cout<<endl;
}