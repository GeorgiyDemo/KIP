#include <iostream>

using namespace std;
int NOD(int a, int b,int nod){
    if (a%b==0) {nod=b;}
           else{
                int r=b;
                b=a%b;   
                a=r;
                nod=b;
           }
     return nod;
    }
    
int main(){
       int chislo1, chislo2;
       cout << "Введите два числа для нахождения НОД =>" << endl;
       cin >> chislo1;
       cin >> chislo2;
       int nod=0;
       if (chislo1 < chislo2){
           int p=chislo2; chislo2=chislo1; chislo1=p;}
       do{   
           nod = NOD(chislo1,chislo2,nod);
          } while (chislo1%chislo2!=0);
       if (nod!=1) {
                   cout << "НОД => " << nod << endl;
       }
       else {
                   cout << "Числа не имеют НОД" << endl;
       }  
}