#include <stdlib.h>
#include <iostream>
using namespace std;

struct Node     
{
	int x;    
	Node *Next, *Prev; 
};

class List  
{
	Node *Head, *Tail; 
public:
	List() :Head(NULL), Tail(NULL) {}; 
	~List(); 
	void Show(); 
	void Add(int x); 
};

List::~List() 
{
	while (Head) 
	{
		Tail = Head->Next; 
		delete Head; 
		Head = Tail; 
	}
}

void List::Add(int x)
{
	Node *temp = new Node; 
	temp->Next = NULL;  
	temp->x = x;

	if (Head != NULL)
	{
		temp->Prev = Tail; 
		Tail->Next = temp; 
		Tail = temp; 
	}
	else 
	{
		temp->Prev = NULL; 
		Head = Tail = temp; 
	}
}

void List::Show()
{   
	
	Node *temp = Head;
	int max;
	max = (temp->x);
	while (temp != NULL) 
	{
		if ((temp->x) > max) max = (temp->x);
		temp = temp->Next; 
	}
	temp = Head;
	while (temp != NULL) 
	{
		if ((temp->x) < max)
		{
			cout << temp->x << " ";
		} 
		temp = temp->Next; 
	}
	cout << max << " ";
	cout << "\n";
}

int main()
{
	setlocale(0, "");
	int i, n, z;
	List lst; 
	cout << "Введите количество элементов списка: ";
	cin >> n;
	for (i = 0; i < n; i++)
	{cin >> z;
	lst.Add(z);
}

	lst.Show(); 
}