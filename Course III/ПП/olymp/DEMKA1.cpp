#include <iostream>
#include <algorithm>
#include <vector>  

using namespace std;

bool IsPalindrome(long num){

	double digit, rev;
	do
    {
        digit = num % 10;
        rev = (rev * 10) + digit;
        num = num / 10;
    } while (num != 0);

     cout << " The reverse of the number is: " << rev << endl;

     if (num == rev)
         return true;
     return false;
}

int KOTCheckerPalindrome(int n)
{
   if (n <= 10 || n >= 10000)
   		cout<<"Значение не соответствует условию";
   else{ 
	   long x = n;
	   int i = 0;

	   for (i=0;i<100;i++)
	   {
	      if (IsPalindrome(x))
	         break;
	      x += reverse(x);
	   }
	   return i < 100? i : -1;
	}
}

int main(){

	int input_int;

	cout<<"Введите исходное значение:";
	cin>>input_int;
	cout<<KOTCheckerPalindrome(input_int);

	cout<<"\n";
	return 0;
};