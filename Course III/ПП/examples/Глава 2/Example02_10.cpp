#include <iostream>
using namespace std;
int main()
{
    for (char x = 'a'; x != 'z';) {
        cout << "Guess a symbol: ";
        cin >> x;
    }
    cout << "Correct!\n";
    return 0;
}