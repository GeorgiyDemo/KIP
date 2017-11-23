#include <string>
#include <iostream>
#include <list>
#include <algorithm>
#include <iterator>
#include <sstream> 
 
using namespace std;

string elementinlist(list<string> number_list, string check){
	bool buf_bool;
	buf_bool = (std::find(number_list.begin(), number_list.end(), check) != number_list.end());
	if (buf_bool == true )
		return "Элемент есть в списке";
	return "Элемента нет в списке";
}


void getter(list<string> lines, int n){

	int i;
	string s1;
	stringstream ss;
	
	for (i=0;i<n;i++){
      ss << i;
      s1 = ss.str();
      lines.push_back(s1); 
      ss.str("");
   }
   //
   lines.sort();
   copy(lines.begin(), lines.end(), ostream_iterator<string>(cout, "\n"));

}
int main()
{

   int n;
   string main_checker;
   list<string> lines;

   cout<<"Введите N => ";
   cin>>n;
   cout<<"Введите число для проверки => ";
   cin>>main_checker;

   getter(lines,n);
   cout<<elementinlist(lines,main_checker);


return 0; 
}