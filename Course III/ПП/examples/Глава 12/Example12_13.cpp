#include <iostream>
using namespace std;
const int n = 20;
template <class X>
class Elements {
public:
    X array[n];
    X operator[](int k)
    {
        return array[k];
    }
    Elements()
    {
        for (int i = 0; i < n; i++) {
            array[i] = (X)(rand() % 20 + 100);
            cout << array[i] << " ";
        }
        cout << endl;
    }
};
template <class X>
void FindElement(X s, Elements<X> obj)
{
    int count = 0, i;
    for (i = 0; i < n; i++)
        if (s == obj[i])
            count++;
    cout << "result is " << count << endl;
}
int main()
{
    Elements<int> a;
    FindElement(101, a);
    Elements<char> b;
    FindElement('f', b);
    return 0;
}