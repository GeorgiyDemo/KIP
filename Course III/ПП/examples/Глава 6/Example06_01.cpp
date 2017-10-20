#include <iostream>
#include <cstring>
using namespace std;
struct Marks{
char name[80];
int phys;
int chem;
int maths;
}ivanov,petrov,sidorov;
struct Exams{
double phys;
double chem;
double maths;
};
int main(){
strcpy(ivanov.name,"Sergei Ivanov");
ivanov.phys=4;
ivanov.chem=3;
ivanov.maths=3;
strcpy(petrov.name,"Igor Petrov");
petrov.phys=5;
petrov.chem=4;
petrov.maths=4;
strcpy(sidorov.name,"Ivan Sidorov");
sidorov.phys=5;
sidorov.chem=4;
sidorov.maths=3;
Exams LastYear,ThisYear;
LastYear.chem=4.33333;
LastYear.phys=3.66667;
LastYear.maths=3.33333;
ThisYear.chem=(double)(ivanov.chem+petrov.chem+sidorov.chem)/3;
ThisYear.phys=(double)(ivanov.phys+petrov.phys+sidorov.phys)/3;
ThisYear.maths=(double)(ivanov.maths+petrov.maths+sidorov.maths)/3;
cout<<"Last year marks:"<<endl;
cout<<"Physics      "<<LastYear.phys<<endl;
cout<<"Chemistry    "<<LastYear.chem<<endl;
cout<<"Mathematics  "<<LastYear.maths<<endl;
cout<<endl;
cout<<"This year marks:"<<endl;
cout<<"Physics      "<<ThisYear.phys<<endl;
cout<<"Chemistry    "<<ThisYear.chem<<endl;
cout<<"Mathematics  "<<ThisYear.maths<<endl;
return 0;
}