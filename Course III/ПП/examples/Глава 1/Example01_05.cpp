#include <iostream>
using namespace std;
int main()
{
    int n, m, i = 3, j = 3;
    cout << "At the beginning:\n";
    cout << "i = " << i << "\n";
    cout << "j = " << j << "\n";
    cout << "After command n=i++ :\n";
    n = i++; // Теперь n=3, а i=4
    cout << "n = " << n << "\n";
    cout << "i = " << i << "\n";
    cout << " After command m=++j :\n";
    m = ++j; // Значение переменных m=4 и j=4
    cout << "m = " << m << "\n";
    cout << "j = " << j << "\n";
    cout << " After command n=(--i)*(i--) :\n";
    n = (--i) * (i--); // Теперь n=9, а i=2
    cout << "n = " << n << "\n";
    cout << "i = " << i << "\n";
    cout << " After command m=(--j)*(--j) :\n";
    m = (--j) * (--j); // Теперь m=4, а j=2
    cout << "m = " << m << "\n";
    cout << "j = " << j << "\n";
    cout << " After command n=(--i)*(i++) :\n";
    n = (--i) * (i++); // Теперь n=1, а i=2
    cout << "n = " << n << "\n";
    cout << "i = " << i << "\n";
    cout << " After command m=(j--)*(++j) :\n";
    m = (j--) * (++j); // Теперь m=9, а j=2
    cout << "m = " << m << "\n";
    cout << "j = " << j << "\n";
    cout << " After command n=(--i)*(++i) :\n";
    n = (--i) * (++i); // Теперь n=4, а i=2
    cout << "n = " << n << "\n";
    cout << "i = " << i << "\n";
    return 0;
}