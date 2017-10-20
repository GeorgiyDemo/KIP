#include <iostream>
using namespace std;
union nums{
unsigned short int n;
short int m;
};
void show(nums a){
cout<<"n = "<<a.n<<endl;
cout<<"m = "<<a.m<<endl;
cout<<endl;
};
int main(){
nums un;
un.m=1;
show(un);
un.m=32767;
show(un);
un.m=65535;
show(un);
un.m=-1;
show(un);
un.m=-65536;
show(un);
return 0;
}