
#include <iostream>
#include <cmath>
using namespace std;
const int n = 10;

double func(double x, double y){
	return pow(cos(1.5*y + x), 2) + 1.4;
}

void runger(double x, double y, double h, double b){
	double k1, k2, k3, k4;
	int i = 0;
	cout << x-1<< "            " << y << "               k1      " << "           k2      " << "           k3      " << "            k4     \n";
	for (x += h; x <= b + h; x += h)
	{
		i++;
		k1 = func(x - h, y);
		k2 = func(x - h / 2, y + h*k1 / 2);
		k3 = func(x - h / 2, y + h*k2 / 2);
		k4 = func(x, y + h*k3);
		y += h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
		cout << i << "            " << x << "            " << y << "            " << k1 << "             " << k2 << "             " << k3 << "             " << k4<<"\n";
	}
}

int main() {
	double x = 1;
	double y = 0.9;
	double h = 0.1;
	double b = 2;
	runger(x, y, h, b);
	return 0;
}
