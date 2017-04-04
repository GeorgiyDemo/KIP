#include <iostream>
#include <cmath>
 
using namespace std;

int x;
 
int RSum(int N)
{
    if(N==0) return 0;
    cout<<N<<"\n";
    return pow(x,N)+RSum(pow(x,N)-1);
}

int main()
{   
	x=2;
    RSum(2);
    return 0;
}