#include <iostream>
#include <math.h>

using namespace std;
int i, j, ind1, ind2;
double s, d;
int num_points;

struct point
 {
  char name[10];
  int x;
  int y;
 };

int main(){
  cout << "Кол-во точек: ";
 cin >> num_points;

 point *pnts = new point[num_points];

 for (i=0; i<num_points; i++)
  {
   cout << "Идентификатор: ";
   cin >> pnts[i].name;
   cout << "Координата X: ";
   cin >> pnts[i].x;
   cout << "Координата Y: ";
   cin >> pnts[i].y;
  }

 for (j=0; j<num_points; j++)
 for (i=j+1; i<num_points; i++)
  {
   s = sqrt((pnts[i].y-pnts[j].y)*(pnts[i].y-pnts[j].y)+(pnts[i].x-pnts[j].x)*(pnts[i].x-pnts[j].x));

   if (s>d)
    {
     d=s;
     ind1 = j;
     ind2 = i;
    }
  }
 cout << "Результат:";
 cout << "Точка " << pnts[ind1].name << "(" << pnts[ind1].x << "," << pnts[ind1].y << ") и ";
 cout << "точка " << pnts[ind2].name << "(" << pnts[ind2].x << "," << pnts[ind2].y << ")" << endl;
 cout << "Расстояние: " << d;

 delete[] pnts; 
 return 0;
} 