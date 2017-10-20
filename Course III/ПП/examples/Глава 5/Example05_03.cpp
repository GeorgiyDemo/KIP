#include <iostream>
#include <cstdio>
using namespace std;
int main(){
char str[30];
int n=26;
char s='a';
for(int i=0;i<n;i++,s++)
   str[i]=s;
str[n]='\0';
cout<<str<<endl;
return 0;
}