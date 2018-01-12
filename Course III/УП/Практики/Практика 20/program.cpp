#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {

	setlocale(LC_ALL, "RUS");
	const int kol = 19;
	int sr, ost, i, sum, osenki[kol];;
	double otv;
	string s;

	i = sum = 0;

	ifstream fs("INPUT.txt");
	if (!fs) return 1; 
	
	while (getline(fs, s)) {
			osenki[i] = atoi(s.c_str());
		i++;
	}
	fs.close();

	for (i = 0; i < kol; i++)
		sum += osenki[i];

	_asm {
		mov eax, 0; начальное значение суммы
		mov ecx, kol; счетчик цикла
		mov esi, 0; начальное значение индекса
		l : add eax, osenki[esi]; eax = eax + osenki[i]
			add esi, 4; следующий индекс
			loop l; цикл  n раз
			//в eax хранится сумма
			mov edx, 0  //тут будет храниться остаток
			mov ebx, kol //делитель 19
			div ebx // eax/ebx  само деление
			mov sr, eax // результат деления 
			mov ost, edx // остаток деления

	}
	
	otv = ost;
	otv = otv / kol + sr;

	cout << "Текущие оценки: \n";
	for (i = 0; i < kol; i++)
		cout << osenki[i]<< " ";
	cout << "\nСумма оценок: " << sum;
	cout << "\nКол-во оценок: " << kol;
	cout << "\nСредний балл: " << otv << endl;

	ofstream out("OUT.txt");
	out << "Средний балл: " << otv; //вывод в файл
	out.close();

	system("pause");
	return 0;
}