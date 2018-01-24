#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {
	setlocale(LC_ALL, "Russian");
	const int kol = 19; //кол-во работ
	int sr, ost, i = 0;
	double otv;
	int osenki[kol];//массив для оценок
	string s;

	ifstream fs("file.txt", ios::in | ios::binary); //связываем файл
	if (!fs) return 1;  // если не нашли файл, то завершаем 
	while (getline(fs, s)) { // пока не достигнут конец файла класть 
очередную строку в переменную (s)
		osenki[i] = atoi(s.c_str());// переводим  строку в инт
		i++;
	}
	fs.close();

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
	otv = ost; //ответ = остаток 
	otv = otv / kol + sr; //операция для красивого вывода
	cout << otv << endl;

	ofstream out("output.txt");
	out << "Ваш средний балл:" << otv; //вывод в файл
	out.close();

	system("pause");
	return 0;
}

