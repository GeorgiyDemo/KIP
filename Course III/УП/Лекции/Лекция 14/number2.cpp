#include "stdafx.h"
#include <iostream>

using namespace std;
class vector {
public:
	int x, y, z;
	vector(int a, int b, int c) { x = a; y = b; z = c; }
	friend ostream& operator << (ostream &stream, vector obj);
	friend istream& operator >> (istream &stream, vector &obj);
};
ostream &operator <<(ostream &stream, vector obj)
{
	stream << obj.x << ", ";
	stream << obj.y << ", ";
	stream << obj.z << "\n";
	return stream;
};
istream &operator >> (istream &stream, vector &obj)
{
	cout << "Enter x,y,z:";
	stream >> obj.x >> obj.y >> obj.z;
	return stream;
}
int main(void)
{
	vector a(1, 2, 3);
	cout << a;
	cin >> a;
	cout << a;
	return 0;
}
