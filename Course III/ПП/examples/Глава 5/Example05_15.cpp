#include <iostream>
using namespace std;
int main(){
int **p;
int n,m,i,j;
cout<<"Enter 1-st size: ";
cin>>n;
cout<<"Enter 2-nd size: ";
cin>>m;
p=new int*[n];
for(i=0;i<n;i++){
   p[i]=new int[m];
   for(j=0;j<m;j++){
      p[i][j]=(i*m+j)%10;
      cout<<p[i][j]<<" ";
   }
cout<<endl;
}
for(i=0;i<n;i++)
   delete [] p[i];
delete [] p;
return 0;
}