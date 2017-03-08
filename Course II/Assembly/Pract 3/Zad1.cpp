#include <iostream>
using namespace std;

int max, i, n=10;
int a[10]={-1,2,-2,3,-10,1,5,-15,1,4};

void outarray(int *a, int n)
{

    cout<<"[";
    for(i=0;i<n;i++)
        cout<<a[i]<<" ";
    cout<<"]\n";

}

int maximum(int *a, int n)
{
    int max=a[0];

    for(i=0;i<n;i++)
        if ((a[i]<0) && (a[i]>max))
            max=a[i];
return max;
}

int main()
{

    setlocale(LC_ALL,"rus");
    cout<<"Исходный массив:";
    outarray(a,n);
    cout<<"Максимальный элемент: "<<maximum(a,n);

cout<<"\n";
return 0;
}