/*
    Задание №1
        Создайте динамический массив (vector) размерностью 17 элементов 
        и заполните его случайным образом числами от 1 до 99 в десятичном формате.
        Создайте новый массив vector2, разделив элементы массива на {1,0,5} соответственно,
        новый массив не должен содержать целых чисел. Выведите исходный и полученный массив на экран и в файл в несколько форматированных столбцов. 
        Обработайте исключания при делении на 0 и если файл не открывается. 
    Задание №2
        Найти среднее квадратическое полученного вектора с использованием указателя (нули программа не суммирует).
        Данные вводить из файла. Осуществить контроль входных данных, используя обработку исключительных ситуаций.
*/

#include <iostream>
#include <vector>
#include <time.h>
using namespace std;

const int n = 17;
class VectorClass
{

    protected:
        vector<int> vector1;
        vector<double> vector2;

    public:
        void initvector1();
        void outvector1();
        void initvector2();
        void outvector2();
};

void VectorClass::initvector1(){
        for (int i=0;i<n;i++)
            vector1.push_back(rand() % 99);
}

void VectorClass::initvector2(){
        for (int i=0;i<n;i++){
            vector2.push_back(vector1[i]/5.0);
        }
}

void VectorClass::outvector1(){
    cout << "\nИсходный вектор:\n[";
    for (int i = 0; i < n; i++) {
        cout<<vector1[i]<<" "; 
    }
    cout<<"]\n";
}

void VectorClass::outvector2(){
    cout << "\nПреобразованный вектор:\n[";
    for (int i = 0; i < n; i++) {
        cout<<vector2[i]<<" "; 
    }
    cout<<"]\n";
}

int main(){
    srand(time(NULL));
    VectorClass* KOTobj;
    KOTobj = new VectorClass;
    KOTobj->initvector1();
    KOTobj->outvector1();
    KOTobj->initvector2();
    KOTobj->outvector2();

    cout<<"\n";
    return 0;
}