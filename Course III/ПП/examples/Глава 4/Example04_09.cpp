#include <iostream>
using namespace std;
void test(int* n)
{
    cout << "Address: " << &n << "\n";
}
int main()
{
    int n = 1;
    int* p;
    p = &n;
    test(p);
    cout << "Address: " << &p << "\n";
    return 0;
}