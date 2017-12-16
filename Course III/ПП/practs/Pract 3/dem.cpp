#include <iostream>
using namespace std;
int global_counter = 0;

struct DemkaTreeStruct {

    DemkaTreeStruct* p1;
    DemkaTreeStruct* p2;
    DemkaTreeStruct* p3;
    DemkaTreeStruct* p4;
    int n;

};

DemkaTreeStruct* MakeNewDemkaTree(int _n);

int main(){

    DemkaTreeStruct* first;
    first = MakeNewDemkaTree(3);
    cout << "Элементов в дереве: " << global_counter <<"\n"<<first->n<<" ["<<&first->n<<"]\n";
    cout << first->p1->n<<" ["<<&first->p1->n<<"]\n";
    cout << first->p1->p3->p2->n<<" ["<<&first->p1->p3->p2->n<<"]\n";
    cout << first->p2->p4->p1->n<<" ["<<&first->p2->p4->p1->n<<"]\n";
    return 0;
}

DemkaTreeStruct* MakeNewDemkaTree(int _n)
{

    DemkaTreeStruct* p;
    p = new DemkaTreeStruct;
    global_counter++;
    p->n = global_counter;
    if (_n > 1){

        p->p1 = MakeNewDemkaTree(_n - 1);
        p->p2 = MakeNewDemkaTree(_n - 1);
        p->p1->p3 = MakeNewDemkaTree(_n - 1);
        p->p2->p4 = MakeNewDemkaTree(_n - 1);
    }

    return p;

}
