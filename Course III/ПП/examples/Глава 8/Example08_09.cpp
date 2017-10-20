#include <iostream>
using namespace std;
class MyClass{
public:
double x;
void show(){
cout<<"x = "<<x<<endl;}
};
int main(){
const n=5;
int i;
MyClass objs[n];
for(i=0;i<n;i++){
   objs[i].x=2*i+1;
   cout<<i+1<<": ";
   objs[i].show();
}
return 0;
}