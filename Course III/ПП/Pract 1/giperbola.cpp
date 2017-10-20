#include <iostream>
#include <math.h>
using namespace std;

long fact(long n){

	long p=1;
	for(int i=1;i<=n;i++)
		p*=i;
return p;
}
 
int main(){

	double x, f=0.0, e, buf=1.0;
	int n=1;
	cin>>x>>e;
	
	while(buf>e){
		f+=buf;
		buf=pow(x,2*n)/double(fact(2*n));
		n++;
	}
	 
	printf("%f",f);
	
return 0;
}