#define LINE cout << "----------------------\n"
#include <iostream>
using namespace std;

int global_counter = 0;

struct ExampleClass {
	int value_int;
    ExampleClass* object1;
    ExampleClass* object2;
};

ExampleClass* a = NULL;

void add_item(ExampleClass*& abstract_val, int transfer_int);
void struct_outer(ExampleClass*& abstract_val);

int main()
{
	int buf_inputer;
	cout<<"Введите кол-во значений для записи => ";
	cin>>buf_inputer;
    for (int i = 1; i <= buf_inputer; i++)
        add_item(a, i);
    LINE;
    cout << "*Выборочный вывод*\n";
    cout<<"--> "<<a->object1->object1->value_int<<" ["<<&a->object1->object1->value_int<<"]\n";
    cout<<"--> "<<a->object2->object2->value_int<<" ["<<&a->object2->object2->value_int<<"]\n";
    cout<<"--> "<<a->object1->object2->value_int<<" ["<<&a->object1->object2->value_int<<"]\n";
    cout<<"--> "<<a->object2->object1->object2->value_int<<" ["<<&a->object2->object1->object2->value_int<<"]\n";
    LINE;
    cout << "*Вывод всей структуры*\n";
    struct_outer(a);
    return 0;
}

void add_item(ExampleClass*& abstract_val, int transfer_int)
{

    static ExampleClass *FirstStatic, *SecondStatic;
    if (abstract_val == NULL) {
        abstract_val = new ExampleClass;
        abstract_val->value_int = transfer_int;
        abstract_val->object1 = NULL;
        abstract_val->object2 = NULL;
        global_counter++;
        if (global_counter == 1)
            SecondStatic = abstract_val;
        if ((global_counter + 1) % 3 == 0)
            FirstStatic = abstract_val;
        if (((global_counter + 2) % 3 == 0) && global_counter != 1) {
            SecondStatic = abstract_val;
            FirstStatic->object2 = abstract_val;
        }
        if (global_counter % 3 == 0) {
            abstract_val->object2 = SecondStatic;
            SecondStatic->object2 = abstract_val;
        }
    }
    else {
        add_item(abstract_val->object1, transfer_int);
    }
}


void struct_outer(ExampleClass*& abstract_val)
{
    if (abstract_val != NULL) {
        cout<<"--> "<<abstract_val->value_int <<" ["<<&abstract_val->value_int<<"]\n";
        struct_outer(abstract_val->object1);
    }
}
