#include <iostream>
#include <iomanip>
#include <math.h>
using namespace std;

class РешениеУравнений {
	double методПоловинногоДеления(double a, double b, double eps) {
		double c;
		while ((b - a) / 2>eps) {
			c = (a + b) / 2;
			if ((F(a)*F(c))>0) a = c;
			else b = c;
		}
		return c;
	}
	double leftRange() {
		double a = 1;
		while (F(a) >= 0) { a -= 0.5; }
		return a;
	}
	double rightRange() {
		double a = 1;
		while (F(a) <= 0) { a += 0.5; }
		return a;
	}
public:
	double F(double x) { return exp(x) + x + 1/*x*x*x*x*x - 2*/; }
	void решить() {
		double eps, a, b;
		a = leftRange();
		b = rightRange();
		cout << "Численное решение уравнений\n\nИнтервал от " << 
a << " до " << b << endl;
		cout << "Введите погрешность: "; cin >> eps;
		cout << "\nМетод половинного деления: x = " << 
методПоловинногоДеления(a, b, eps) << endl;
	}
};
class Гаусс {
	int i, j, n, m, pgF;
	double pgAll, **a, *x, **pg, *pgX;

	void arrayIn() {
		cout << "\n.....Ввод матрицы А.....\n\n";
		for (i = 0; i < n; i++)
			for (j = 0; j < m; j++) {
				cout << "Элемент [" << i + 1 << "][" << 
j + 1 << "]: ";
				cin >> a[i][j];
				if (pgF == 2) {
					cout << "Погрешность элемента [" 
<< i + 1 << "][" << j + 1 << "]: ";
					cin >> pg[i][j];
				}
				else pg[i][j] = pgAll;
			}
	}

	void arrayOut() {
		cout << "\n.....Исходная матрица.....\n";
		for (i = 0; i < n; i++) {
			cout << endl;
			for (j = 0; j < m; j++) cout << setw(7) << 
a[i][j];
		}
		cout << "\n\n.....Погрешности элементов матрицы.....\n";
		for (i = 0; i < n; i++) {
			cout << endl;
			for (j = 0; j < m; j++) cout << setw(7) << 
pg[i][j];
		}
	}

	void gauss() {
		int k;
		double gausA, gausPG;
		for (i = 0; i < n; i++) {
			gausA = a[i][i];
			gausPG = pg[i][i];
			for (j = n;j >= i; j--) {
				pg[i][j] = (fabs(a[i][j]) * gausPG + 
fabs(gausA)*pg[i][j]) / (gausA * gausA);
				a[i][j] /= gausA;
			}
			for (j = i + 1; j < n; j++) {
				gausA = a[j][i];
				gausPG = pg[j][i];
				for (k = n; k >= i; k--) {
					pg[j][k] += fabs(a[i][k]) * 
gausPG + fabs(gausA) * pg[i][k];
					a[j][k] -= gausA * a[i][k];
				}
			}
		}
		x[n - 1] = a[n - 1][n];
		for (i = n - 2; i >= 0; i--) {
			x[i] = a[i][n];
			pgX[i] = pg[i][n];
			for (j = i + 1; j < n; j++) {
				x[i] -= a[i][j] * x[j];
				pgX[i] += (fabs(a[i][j])*pgX[j] + 
fabs(x[j])*pg[i][j]);
			}
		}
		cout << "\n\n.....Ответ.....\n";
		for (i = 0; i < n; i++) cout << "\nX" << i + 1 << " = " 
<< x[i] << " Погрешность = " << pgX[i];
		cout << endl << endl;
	}
public:
	void решить() {
		cout << "Введите кол-во строк: "; cin >> n;
		cout << "Введите кол-во столбцов: "; cin >> m;
		cout << "Одинкаковая погрешность у всех - 1, разная - 2: 
"; cin >> pgF;

		if (pgF == 1) {
			cout << "Введите одинковую погрешность: ";
			cin >> pgAll;
		}

		x = new double[m];
		pgX = new double[m];
		a = new double *[n];
		pg = new double *[n];
		for (i = 0; i < n; i++) {
			a[i] = new double[n];
			pg[i] = new double[n];
		}
		arrayIn();
		arrayOut();
		gauss();
	}
};
class Итерации {
	int n, m, i, j, k, checker, iteration;
	double **a, *b, *x, *xn, eps;

	//Ручный ввод массивов
	void enter() {
		cout << "<Заполняем коэффициенты>\n";
		for (i = 0;i<n;i++)
			for (j = 0;j<m;j++) {
				cout << "Введите элемент [" << i + 1 << 
"][" << j + 1 << "]: ";
				cin >> a[i][j];
			}

		cout << "<Заполняем свободные члены>\n";
		for (i = 0;i<n;i++) {
			cout << "Введите элемент [" << i + 1 << "]: ";
			cin >> b[i];
			x[i] = 0;
		}

	}

	//Вывод массивов на экран
	void outarray() {
		cout << "\nИсходная матрица:\n";
		for (i = 0;i<n;i++) {
			cout << "\n";
			for (j = 0;j<m;j++)
				cout << setw(5) << a[i][j];
			cout << setw(5) << b[i];
		}
		cout << "\n";
	}

	//Функция метода простых итераций
	void simple_iteration() {

		iteration = 0;
		while (true) {

			xn[0] = (b[0] - (a[0][1] * x[1] + a[0][2] * x[2] 
+ a[0][3] * x[3])) / a[0][0];
			xn[1] = (b[1] - (a[1][0] * x[0] + a[1][2] * x[2] 
+ a[1][3] * x[3])) / a[1][1];
			xn[2] = (b[2] - (a[2][0] * x[0] + a[2][1] * x[1] 
+ a[2][3] * x[3])) / a[2][2];
			if (n == 4)
				xn[3] = (b[3] - (a[3][0] * x[0] + 
a[3][1] * x[1] + a[3][2] * x[2])) / a[3][3];

			checker = 0;
			for (i = 0;i<4;i++)
				if (fabs(xn[i] - x[i])<eps)
					checker++;

			if (checker == 4)
				break;

			for (int i = 0;i<4;i++)
				x[i] = xn[i];
			cout << "\nИтерация №" << iteration + 1 << 
":\nx1 = " << xn[0] << "\nx2 = " << xn[1] << "\nx3 = " << xn[2] << "\n";
			if (n == 4)
				cout << "x4 = " << xn[3] << "\n";
			iteration++;
		}

		for (i = 0;i<4;i++)
			x[i] = xn[i];

		cout << "\n-------------------\nИтераций всего: " << 
iteration + 1;
		for (i = 0;i<n;i++)
			cout << "\n" << x[i];

	}
public:
	void решение() {

		cout << "Введите точность (пример: 0.005) => "; cin >> 
eps;
		cout << "Введите n => "; cin >> n;
		cout << "Введите m => "; cin >> m;

		a = new double *[m];
		for (i = 0;i<n;i++)
			a[i] = new double[n];
		b = new double[m];
		x = new double[m];
		xn = new double[m];

		enter();
		outarray();
		simple_iteration();

		cout << "\n";
	}
};
class Интегрирование {
	double F(double x) { return 1 / (x + 2); }
	double методЛевыхПрямоугольников(double a, int n, double h) {
		double s = 0;
		for (int i = 0; i < n; i++) s += F(a + i * h) * h;
		return s;
	}
	double методПравыхПрямоугольников(double a, int n, double h) {
		double s = 0;
		for (int i = 1; i <= n; i++) s += F(a + i * h) * h;
		return s;
	}
	double методСреднихПрямоугольников(double a, int n, double h) {
		double s = 0;
		for (int i = 0; i < n; i++) s += F(a + i * h + h / 2) * 
h;
		return s;
	}
	double методТрапеций(double a, int n, double h) {
		double s = 0;
		s += F(a) / 2 * h;
		for (int i = 1; i < n; i++) s += F(a + i * h) * h;
		s += F(a + n * h) / 2 * h;
		return s;
	}
	double методСимпсона(double a, int n, double h) {
		double s = 0;
		for (int i = 0; i <= n; i++) {
			if (i == 0 || i == n) s += F(a + i * h);
			else if (i % 2 == 0) s += F(a + i * h) * 2;
			else s += F(a + i * h) * 4;
		}
		return s * h / 3;
	}
	double методНьютонаКотеса(double ba, int n, double a, double h) 
{
		double C[7], s = 0;
		switch (n) {
		case 1: { C[0] = (ba / 2); C[1] = C[0]; break; }
		case 2: { C[0] = (ba / 6); C[1] = (4 * ba / 6); C[2] = 
C[0]; break; }
		case 3: { C[0] = (ba / 8); C[1] = (3 * ba / 8); C[2] = 
C[1]; C[3] = C[0]; break; }
		case 4: { C[0] = (7 * ba / 90); C[1] = (16 * ba / 45); 
C[2] = (2 * ba / 15); C[3] = C[1]; C[4] = C[0]; break; }
		case 5: { C[0] = (19 * ba / 288); C[1] = (25 * ba / 96); 
C[2] = (25 * ba / 144); C[3] = C[2]; C[4] = C[1]; C[5] = C[0]; break; }
		case 6: { C[0] = (41 * ba / 840); C[1] = (9 * ba / 35); 
C[2] = (9 * ba / 280); C[3] = (34 * ba / 105); C[4] = C[2]; C[5] = C[1]; 
C[6] = C[0]; break;}
		};
		for (int i = 0; i <= n; i++) s += F(a + i * h) * C[i];
		return s;
	}
public:
	void решить() {
		int n;
		double a, b, h;
		cout << "Численное интегрирование\n\nИнтервал от "; cin 
>> a;
		system("cls");
		cout << "Численное интегрирование\n\nИнтервал от " << a 
<< " до "; cin >> b;
		cout << "Шагов "; cin >> n;
		cout << endl;
		h = (b - a) / n;
		cout << "Метод левых   прямоугольников: " << 
методЛевыхПрямоугольников(a, n, h)   << endl;
		cout << "Метод правых  прямоугольников: " << 
методПравыхПрямоугольников(a, n, h)  << endl;
		cout << "Метод средних прямоугольников: " << 
методСреднихПрямоугольников(a, n, h) << endl;
		cout << "Метод трапеций: " << методТрапеций(a, n, h) << 
endl;
		cout << "Метод Симпсона: ";
		if (n % 2 == 0) cout << методСимпсона(a, n, h) << endl;
		else cout << "не четное число шагов" << endl;
		cout << "Метод Ньютона-Котеса: ";
		if (n <= 7) cout << методНьютонаКотеса(b - a, n, a, h) 
<< endl;
		else cout << "число шагов больше 6" << endl;
		cout << endl;
	}
};
class Дифференцирование {
	double F(double x, double y) { return sqrt(4 * x*x + 1) - 3 * 
y*y; }
	void методЭйлера(double a, double b, double y, double h) {
		for (double x = a; x <= b + h; x += h) {
			if (x != a) y = y + F(x - h, y) * h;
			cout << x << "\t" << y << endl;
		}
	}
	void методРунгеКутта(double a, double b, double y, double h) {
		double x, k1, k2, k3, k4;
		for (double X = a; X <= b + h; X += h) {
			if (X != a) {
				x = X - h;
				k1 = F(x, y);
				k2 = F(x + h / 2, y + (h / 2) * k1);
				k3 = F(x + h / 2, y + (h / 2) * k2);
				k4 = F(x + h, y + h * k3);
				y = y + (h / 6) * (k1 + 2 * k2 + 2 * k3 
+ k4);
			}
			cout << X << "\t" << y << endl;
		}
	} public:
		void решить() {
			double a, b, h, y;
			cout << "Численное дифференцирование\n\nИнтервал 
от "; cin >> a;
			system("cls");
			cout << "Численное дифференцирование\n\nИнтервал 
от " << a << " до "; cin >> b;
			cout << "Шаг: "; cin >> h;
			cout << "Y(" << a << ") = "; cin >> y;
			cout << "\nМетод Эйлера\n"; методЭйлера(a, b, y, 
h);
			cout << "\nМетод Рунге-Кутта\n"; 
методРунгеКутта(a, b, y, h);
			cout << endl;
		}
};
class Производные {
	void производные(double n) {
		double x[4], y[4], f[4][2], h;
		for (int i = 0; i < n; i++) {
			cout << "x" << i << " = "; cin >> x[i];
			cout << "y" << i << " = "; cin >> y[i];
		}
		h = x[1] - x[0];
		if (n == 3) {
			f[0][0] = (1 / (2 * h)) * (-3 * y[0] + 4 * y[1] 
- y[2]) + (h * h / 3);
			f[1][0] = (1 / (2 * h)) * (-y[0] + y[2]) - (h * 
h / 6);
			f[2][0] = (1 / (2 * h)) * (y[0] - 4 * y[1] + 3 * 
y[2]) + (h * h / 3);

			f[0][1] = (1 / (h * h)) * (y[0] - 2 * y[1] + 
y[2]) - h;
			f[1][1] = (1 / (h * h)) * (y[0] - 2 * y[1] + 
y[2]) - (h * h / 12);
			f[2][1] = (1 / (h * h)) * (y[0] - 2 * y[1] + 
y[2]) + h;
		}
		else if (n == 4) {
			f[0][0] = (1 / (6 * h)) * (-11 * y[0] + 18 * 
y[1] - 9 * y[2] + 2 * y[3]) - (h * h * h / 4);
			f[1][0] = (1 / (6 * h)) * (-2 * y[0] - 3 * y[1] 
+ 6 * y[2] - y[3]) + (h * h * h / 12);
			f[2][0] = (1 / (6 * h)) * (y[0] - 6 * y[1] + 3 * 
y[2] + 2 * y[3]) - (h * h * h / 12);
			f[3][0] = (1 / (6 * h)) * (-2 * y[0] + 9 * y[1] 
- 18 * y[2] + 11 * y[3]) + (h * h * h / 4);

			f[0][1] = (1 / (h * h)) * (2 * y[0] - 5 * y[1] + 
4 * y[2] - y[3]) + (11 / 12 * (h * h));
			f[1][1] = (1 / (h * h)) * (y[0] - 2 * y[1] + 
y[2]) - (1 / 12 * (h * h));
			f[2][1] = (1 / (h * h)) * (y[1] - 2 * y[2] + 
y[3]) - (1 / 12 * (h * h));
			f[3][1] = (1 / (h * h)) * (-y[0] + 4 * y[1] - 5 
* y[2] + 2 * y[3]) + (11 / 12 * (h * h));
		}

		system("cls");
		cout << "Численное нахождение производных\n\nКол-во 
узлов (3 или 4): " << n << "\nШаг: " << h << "\n\n";
		for (int i = 0; i < n; i++) {
			cout << "x" << i << " = " << x[i] << "\ty" << i 
<< " = " << y[i] << "\tf'(x" << i << ") = " << f[i][0] << "\tf''(x" << i 
<< ") = " << f[i][1] << endl;
		}
	}
public:
	void решить() {
		double n;
		cout << "Численное нахождение производных\n\nКол-во 
узлов (3 или 4): "; cin >> n;
		if (n == 3 || n == 4) производные(n);
		else cout << "Узлов должно быть 3 или 4!";
		cout << endl;
	}
};

void main() {
	Интегрирование Интегрирование;
	Дифференцирование Дифференцирование;
	РешениеУравнений РешениеУравнений;
	Гаусс Гаусс;
	Производные Производные;
	int flag;
	setlocale(0, "");
		int x = 0;

	while (true) {
		system("cls");
		cout << "Численные методы в программировании\n1 - 
Интегрирование\n2 - Дифференцирование\n" <<
			"3 - Решение уравнений\n4 - Производные\n5 - 
Гаусс\n0 - Выход\nДействие: ";
		cin >> flag;
		system("cls");
		switch (flag) {
		case 1: Интегрирование.решить(); break;
		case 2: Дифференцирование.решить(); break;
		case 3: РешениеУравнений.решить(); break;
		case 4: Производные.решить(); break;
		case 5: Гаусс.решить(); break;
		default: return;
		}
		system("pause");
	}
}
