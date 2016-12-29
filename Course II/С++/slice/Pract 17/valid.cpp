#include <string>
#include <sstream>
#include <fstream>
#include <iostream>
using namespace std;
int main()
{
    char buf[50];
    setlocale(LC_ALL, "rus");
    char text[50];
    string word, *array;
    ifstream fin("example.txt");
    fin.getline(text, 50);
    stringstream ss(text);//Инициализация строкового потока
    int nCount = 0;
    while(ss>>word)
        nCount++;
    ss.clear();//Сбросили флаг EOF
    ss.seekg(0,ios::beg);//Вернули поток вначало
    array = new string[nCount];//Память под массив
    int i = 0;//Счётчик
    while(ss>>word)
        array[i++] = word;
    for(i = 0; i < nCount; i++){
        strcpy(buf,array[i]);
        if (strlen(buf)<=4)
            cout<<"word # "<<i + 1<<" : "<<array[i]<<endl;
    }
    fin.close();
    return 0;
}