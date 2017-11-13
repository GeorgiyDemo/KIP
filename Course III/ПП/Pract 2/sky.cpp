#include <iostream>
#include <math.h>

using namespace std;
int leng = 0;

class tangle {
public:
	tangle* point1;
	tangle* point2;
	int inf;
};

tangle *a = NULL;


void additem(tangle* &now,  int inf) {
	static tangle* now1, *now2, *now3;
	if (now == NULL) {
		now = new tangle;
		now->inf = inf;
		now->point1 = NULL;
		now->point2 = NULL;
		leng++;
		if (leng == 1) now2 = now;
		if ((leng + 1) % 3 == 0) now1 = now;
		if (((leng + 2) % 3 == 0) && leng != 1) {
			now2 = now;
			now1->point2 = now;
		}
		if (leng % 3 == 0)
		{
			now->point2 = now2;
			now2->point2 = now;
		}	}
else
{
	additem(now->point1, inf);
}
	}


void print(tangle *&now)
{
	if (now != NULL) {
		cout << now->inf << endl;
		print(now->point1);
	}
}



	int main() {
		for (int i = 1; i <= 6; i++)
		{
			additem(a, i);
		}
		setlocale(LC_ALL, "rus");
		cout << "Показательный вывод: "<<endl;
		printf("%d\n", a->point1->point1->inf);
		printf("%d\n", a->point2->point2->inf);
		printf("%d\n", a->point1->point2->inf);
		printf("%d\n", a->point2->point1->point2->inf);
		cout << "Вывод всей структуры: "<<endl;
		print(a);
	return 0;
	}

