#include <iostream>
#include <string>

using namespace std;

class Node {
public:
    Node();
    ~Node();
    int number_of_node;
    Node* Parent;
    Node* Neighbor;
    Node* Child;

private:
};

Node::Node()
{
}

Node::~Node(){};

void Edit(int number_of_node, Node*& aNode, Node& Neighbor)
{
    if (number_of_node > 0) {
        Node* _Neighbor = &Neighbor;
        aNode->Neighbor = _Neighbor;
    }
}

void Add(int number_of_node, Node*& aNode, Node& Parents, Node*& aNode1,
    Node& Parents1)
{
    Node* Parent = &Parents;

    if (!aNode && !aNode1) {

        aNode = new Node;
        aNode->number_of_node = number_of_node;
        aNode->Neighbor = 0;
        aNode->Child = 0;
        aNode->Parent = Parent;

        /////////////////////////////////////////
        aNode1 = new Node;
        aNode1->number_of_node = number_of_node;
        aNode1->Neighbor = 0;
        aNode1->Child = 0;
        aNode1->Parent = Parent;
        if (number_of_node & 1) {
            Edit(number_of_node, aNode, *aNode1);
            Edit(number_of_node, aNode1, *aNode);
        }
        else {
        }
        return;
    }
    else {

        Add(number_of_node, aNode->Child, *aNode, aNode1->Child,
            *aNode1);

        return;
    }
    return;
}

void FreeTree(Node*& aNode)
{
    if (!aNode)
        return;
    FreeTree(aNode->Child);
    delete aNode;
    return;
}

void print(Node*& aNode)
{
    if (!aNode)
        return;

    cout << "#-" << aNode->number_of_node << "Addres- " << aNode << "Parent- " << aNode->Parent << "Neighbor- " << aNode->Neighbor << "\n";

    print(aNode->Child);

    return;
}

int main()
{
    Node* Left_Root = 0;
    Node* Right_Root = 0;
    int n = 4;
    for (int i = 0; i <= n; i++) {
        Add(i, Left_Root, *Left_Root, Right_Root, *Right_Root);
    }

    print(Left_Root);
    print(Right_Root);
    FreeTree(Left_Root);
    FreeTree(Right_Root);

    return 0;
}
