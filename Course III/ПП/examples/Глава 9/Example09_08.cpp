#include <iostream>
using namespace std;
class BinTree {
public:
    static int Count;
    int m;
    BinTree* p1;
    BinTree* p2;
    BinTree(int n)
    {
        if (n == 1) {
            p1 = NULL;
            p2 = NULL;
        }
        else {
            p1 = new BinTree(n - 1);
            p2 = new BinTree(n - 1);
        }
        m = ++Count;
        cout << "Object created: " << this << " : " << m;
        cout << " -> Number of objects: " << Count << endl;
    }
    ~BinTree()
    {
        delete p1;
        delete p2;
        Count--;
        cout << "Object deleted: " << this << " : " << m;
        cout << " -> Number of objects: " << Count << endl;
    }
};
int BinTree::Count;
int main()
{
    BinTree::Count = 0;
    BinTree obj1(3);
    BinTree* p;
    p = new BinTree(2);
    delete p;
    return 0;
}