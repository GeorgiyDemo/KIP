#include <iostream>
#include <fstream>
#include <algorithm>
#include <iterator>
#include <string> 
using namespace std;
 
bool check(const string& _str){
    return _str.size()<=4;
}

int main(){

    int k=0;
    ifstream inFile("example.txt", ios::in); 
    k = count_if(istream_iterator<string>(inFile), istream_iterator<string>(), check);
    cout<<"Кол-во слов: "<<k<<"\n";
 
return 0;
}