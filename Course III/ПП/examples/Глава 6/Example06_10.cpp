#include <iostream>
using namespace std;
int main(){
typedef int* IntPointer;
int n=100;
IntPointer p;
p=&n;
(*p)++;
cout<<"n = "<<n<<endl;
return 0;
}