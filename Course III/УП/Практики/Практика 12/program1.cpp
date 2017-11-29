/*
Создать класс четырехугольник, члены класса – координаты 4-хточек.
Предусмотреть в классе методы проверки существования четырехугольника вычисления и 
вывода сведений о фигуре – длины сторон, диагоналей, периметр, площадь. 
Создать производный класс –параллелограмм, предусмотреть в классе проверку, 
является ли фигура параллелограммом. 

Написать программу, демонстрирующую работу с классом: дано N 
четырехугольников и M параллелограммов, найти среднюю площадь N 
четырехугольников и параллелограммы наименьшей и наибольшей площади.
*/

#include <vector>
#include <map>
#include <string>
#include <cstdlib>
#include <iostream>
#include <math.h>

using namespace std;
class figure {
protected:
	int point1[2];
	int point2[2];
	int point3[2];
	int point4[2];

public:
    /*figure()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 0;
    }
*/
    figure(int point1_buf,int point2_buf,int point3_buf,int point4_buf)
    {
        
        
    }

/*
    bool proverka()
    {
        return abs(a - b) == abs(c - d) && abs(a - c) == abs(b - d);
    }

    int perimentr()
    { 
    	return 2 * (a + b);
    }

    int area() { return abs(a - b) * abs(a - c); }

    double diagonal() {
    	return sqrt(((a - b) * (a - b)) + ((a - c) * (a - c))); }
	};
*/
};
/*
class parale : public figure {
    double f;

public:
    parale(void)
        : figure(0, 0, 0, 0)
    {
    }

    parale(int a1, int b1, int c1, int d1)
        : figure(a1, b1, c1, d1)
    {
    }

    void setF(double f1) { f = f1; }
    double getF() {
    	return f;
    }
    double getG() { return 180 - f; }
};
*/
int main(int argc, char* argv[]){

	int point1[2] = {1,1};
	int point2[2] = {1,1};
	int point3[2] = {1,1};
	int point4[2] = {1,1};

	map <bool, string> formatter;
		formatter[true] = "Проверку прошел!";
		formatter[false] = "Проверку не прошел(";


	//vector myVector1[0, 1];
    figure obj1(point1,point2,point3,point4);

    //cout<<formatter[obj1.proverka()];
    //cout<<"Периметр:"<<obj1.perimentr();


cout<<"\n";
}