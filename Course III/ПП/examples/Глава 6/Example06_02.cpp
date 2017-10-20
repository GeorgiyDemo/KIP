#include <iostream>
#include <cstdio>
#include <cstring>
#include <cstdlib>
using namespace std;
struct Marks{
char name[80];
int phys;
int chem;
int maths;
};
int main(){
const int n=3;
bool state;
char s[80];
Marks students[n];
for(int i=0;i<n;i++){
   cout<<("Student name: ");
   gets(students[i].name);
   students[i].phys=3+rand()%3;
   students[i].chem=3+rand()%3;
   students[i].maths=3+rand()%3;
}
do{
   cout<<"What is the student name? ";
   gets(s);
   if(!strcmp(s,"exit")) return 0;
   state=true;
   for(int i=0;i<n;i++){
      if(!strcmp(students[i].name,s)){
         state=false;
         cout<<"Physiscs: "<<students[i].phys<<endl;
         cout<<"Chemistry: "<<students[i].chem<<endl;
         cout<<"Mathematics: "<<students[i].maths<<endl;
         break;
         }
   }
   if(state) cout<<"There is no student with such name\n";
}while(true);
}