#include <iostream>
#include <cstdio>
#include <cstring>
using namespace std;
void getWord(char *s1,char *s2,int n){
int i=0,j=0;
int s=1;
while(s<n){
   if(s1[i]==' '){
      s++;}
   i++;
}
for(;(s1[i]!='\0')&&(s1[i]!=' ')&&(s1[i]!=',')&&(s1[i]!='.')&&(s1[i]!='!')&&(s1[i]!='?');i++,j++)
   s2[j]=s1[i];
s2[j]='\0';
}
//Подсчет слов в строке s:
int countWords(char *s){
int i,res=1;
for(i=0;s[i];i++) if(s[i]==' ') res++;
return res;
}
//Позиция слова s2 в строке s1:
int findWord(char *s1,char *s2){
int i,n;
char s[30];
n=countWords(s1);
for(i=1;i<=n;i++){
   getWord(s1,s,i);
   if(strcmp(s2,s)==0) return i;
}
return 0;
}
//Кодирование строки s2 на основе текста s1:
void encoding(char s1[4][100],char *s2,int *p,int n){
int pos;
char s[50];
int i,j;
for(i=1;i<=n/2;i++){
   getWord(s2,s,i);
   for(j=0;j<4;j++){
      pos=findWord(s1[j],s);
      if(pos){
         p[2*i-2]=j+1;
         p[2*i-1]=pos;
         break;
         }
   }
}
}
int main(){
int n,i;
int *p;
char s1[4][100]={"Зачем копить добро в пустыне бытия?",
"Кто вечно жил средь нас? Таких не видел я!",
"Ведь жизнь нам в долг дана, и то на срок не долгий,",
"А то, что в долг дано- не собственность твоя!"};
char s2[50]="Кто видел жизнь и жил в пустыне?";
n=2*countWords(s2);
p=new int[n];
encoding(s1,s2,p,n);
for(i=0;i<n;i++)
   cout<<p[i]<<" ";
cout<<endl;
delete [] p;
return 0;
}