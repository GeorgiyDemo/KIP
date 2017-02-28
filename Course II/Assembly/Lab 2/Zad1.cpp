#include <iostream>

using namespace std;

int main(){

	int i,x;
    float y;

    for (i=1;i<31;i++){
        x=i;
        if (x>=16)
            y=(x-11)*(x-11)-125;
        
        if (x<16)
            y= (float) (x*x+72*x-6400)/168;

        cout<<i<<". "<<y<<"\n";
    }

cout<<"\n";
return 0;
}
