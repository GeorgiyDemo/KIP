using namespace std;


void TheFirst()
{
    newPractical(1, 2, (IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {

                int dd = 0; double p,s;

                ShowIt("Вычислите длину окружности и площадь круга по заданному диаметру.\n");


                ShowIt("Введите диаметр: "); cin>>dd;

                //P=2πR

                p = 2 * 3.14 * (dd/2);

                s = 3.14 * ((dd/2) * (dd/2));

                ShowIt("Длина   окружности: " + to_string(p));
                ShowIt("Площадь окружности: " + to_string(s));

            },
            /*
             *
             * Задание 2
             *
             */
            []()->int {

                int s0,x0,d0,xx0, need0, weekN, curS = 0;

                ShowIt("Каждую неделю Саша получает от родителей сумму в размере S руб. "
                               "на карманные расходы. Из них Х% он тратит на сладости, а "
                               "оставшиеся деньги откладывает на покупку компьютера. Определите,"
                               " когда Саша сможет купить компьютер, ес- ли кроме собственных "
                               "сбережений у него есть 3000 руб., подаренные на день рожденья "
                               "бабушкой и дедушкой, и 10 000 руб., подаренные мамой и папой. "
                               "Стоимость ком- пьютера — 970 долл.\n");


                ShowIt("Введите сумму, которую родители дают Саше на карманные расходы: "); cin>>s0;
                ShowIt("Введите процент, который Саша тратит на сладости: ");cin>>x0;
                ShowIt("Введите курс доллара: "); cin>>d0;

                xx0 = s0 * x0 / 100;

                ShowIt("Начальная сумма 1300 рублей, а каждую неделю +"
                       + to_string(s0) + "руб., и -" + to_string(x0) +
                               "% (" + to_string(xx0) + "руб) на сладости. Итоги подсчета: ");

                need0 = d0 * 970;

                weekN = 0;

                while(curS < need0)
                {
                    curS += s0 - xx0;
                    weekN++;
                    ShowIt("Неделя " + to_string(weekN) + ". На руках: " + to_string(curS) + "руб. Осталось: " +
                                   to_string(need0 - curS) + "руб. ");
                }

                ShowIt("Саше необходимо " + to_string(weekN) + " недели, что бы купить компьютер.");

            }
    });

}

void TheSecond()
{

    newPractical(2, 5, (IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {
                double l1,l2, r, x1, y1, x2, y2;
                bool flag;

                ShowIt("Вверите значение точки x1: "); cin>>x1;
                ShowIt("Вверите значение точки y1: "); cin>>y1;

                ShowIt("Вверите значение точки x2: "); cin>>x2;
                ShowIt("Вверите значение точки y2: "); cin>>y2;

                ShowIt("Вверите радиус окружности: "); cin>>r;

                l1 = sqrt(x1*x1+y1*y1);
                l2 = sqrt(x2*x2+y2*y2);

                if (l1>l2) {

                    if (r > l2) flag = false;
                    else flag = true;
                }
                else {

                    if (r > l1) flag = false;
                    else flag = true;

                }

                if(flag) ShowIt("Вместится ли в него круг радиуса R: Да");
                else ShowIt("Вместится ли в него круг радиуса R: Нет");
            },
            /*
             *
             * Задание 2
             *
             */
            []()->int {
                double l1,l2, r, mH, a,b,c, x1, y1, x2, y2;
                bool flag;
                string str;

                ShowIt("Введите А: "); cin>>a; ShowIt("Введите B: "); cin>>b; ShowIt("Введите C: "); cin>>c;

                if(a == c)
                {
                    a = a * a;
                    b = b * b;
                    c = c * c;
                }
                else if(a > b && b > c)
                {
                    a = MaxOfThreeDoubles(a, b, c);
                    b = a;
                    c = a;
                }
                else
                {
                    a = b + c;
                    b = b;
                    c = 0;
                }

                ShowIt("A: " + cutStr(to_string(a), 4));
                ShowIt("B: " + cutStr(to_string(b), 4));
                ShowIt("C: " + cutStr(to_string(c), 4));
            },
            /**
             *
             * Задание 3
             *
             */
            []()->int {
                double l1,l2, r, mH, a,b,c, x1, y1, x2, y2;
                bool flag;
                string str;

                ShowIt("Введите А: "); cin>>a; ShowIt("Введите B: "); cin>>b; ShowIt("Введите C: "); cin>>c;

                if((a == b || b == c || a == c) && (a+b>c && a+c>b && b+c>a))
                {
                    //Равнобедренный : Формула высоты:

                    l1 = sqrt((a * a) - (b * b)/2);
                    l2 = sqrt((a * a) - (c * c)/2);

                    mH = a;

                    if(a == b) mH = c;
                    else if(a == c) mH = b;

                    ShowIt("Основание: " + cutStr(to_string(mH), 4));
                    ShowIt("Высота 1: " + cutStr(to_string(MaxOfTwoDoubles(l1, l2)), 4));
                    ShowIt("Высота 2: " + cutStr(to_string(MinOfTwoDoubles(l1, l2)), 4));

                }
                else
                {
                    ShowIt("Равнобедренный треугольник не найден!");
                }
            },
            /*
             *
             * Задание 4
             *
             */
            []()->int {},
            /*
             *
             * Задание 5
             *
             */
            []()->int {
                double l1,l2, r, mH, a,b,c, x1, y1, x2, y2;
                bool flag;
                string str;
                drawHeader("Задание #5");

                ShowIt("Введите день недели (пн|вт|ср|чт|пт|сб|вс): ");   cin>>str;
                ShowIt("Введите тариф: ");                          cin>>l1; //l1 - тариф
                ShowIt("Введите кол-во минут: ");                   cin>>b; //b - кол-во минут

                if(str == "сб" || str == "вс")
                {
                    l1 = l1 - (l1*0.2);
                    c = 20;
                }
                else
                {
                    c = 0;
                }



                ShowIt("Ваш тариф составляет " + cutStr(to_string(round(l1)), 4)
                       + " руб. в минуту, с учетом скидки " + cutStr(to_string(c), 4) + "%");
                ShowIt("Разговор " + cutStr(to_string(b),6) + " мин. будет стоить "
                       + cutStr(to_string(b * round(l1)), 4) + "руб.");
            }

    });

}

int factorial(int n) {
    if (n < 0 ) {
        return 0;
    }
    return n ? n * factorial(n - 1) : 1;
}

void The3d()
{
    newPractical(3, 3,(IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int {


                int b = 1, n;

                ShowIt("Введите кол-во минут: "); cin>>n;

                for(int i = 0; i<n; i++)
                {
                    if(i%5==0 && i > 0)
                    {
                        b = b * 2;
                    }

                    ShowIt("Минут прошло: " + cutStr(to_string(i+1), 6) + " \tБактерий: " + to_string(b));
                }

            },

            /*
             *
             * Задание 2
             *
             */
            []()->int {

                int n;
                double S, Si, Sx = 0;

                ShowIt("Введите X: "); cin>>Sx;
                ShowIt("Введите N: "); cin>>n;

                for(int i = 0; i <= n; i++)
                {
                    Si = (pow((i-1) * Sx, i)/factorial(i));

                    ShowIt("Шаг " + to_string(i+1) + ":\t\t " + cutStr(to_string(S), 4) + "\t\t + \t"
                           + cutStr(to_string(Si), 4));

                    S = S + Si;
                }

                nullLine();
                ShowIt("Ответ: " + cutStr(to_string(S), 4));


            },

            /*
             *
             * Задание 3
             *
             */
            []()->int {

                int fl, eat = 0;

                ShowIt("Кол-во комаров было съедено в первый день: "); cin>>eat;

                fl = 0;

                while(eat<=100)
                {
                    eat = eat + fl * 20;

                    ShowIt("День: " + to_string(fl + 1) + "\t Комары: "+to_string(eat));
                    if(eat>=100) break;

                    fl++;
                }

                ShowIt("Ответ: " + to_string(fl) + " дн.");
            }

    });
}

void The4th()
{
    newPractical(4, 3,(IntFunction[]) {
            /*
             *
             * Задание 1
             *
             */
            []() -> int {

                myArray a = myArray();

                a.Create()
                        .Show();

                ShowIt("Ответ: " + to_string(a.getMultiply()));

            },
            /*
             *
             * Задание 2
             *
             */
            []() -> int {

                myArray a = myArray();

                a.Create(false, -10, 10)
                        .Show();

                ShowIt("Ответ: " + cutStr(to_string(a.getAverage(true)), 4));
            },
            /*
             *
             * Задание 3
             *
             */
            []() -> int {
                myArray a = myArray();
                myArray b = myArray();
                myArray c = myArray();

                a.CreateFateful(5, 1, 100);
                b.CreateFateful(5, 30, 80);
                c.CreateFateful(10, 0, 0);

                for(int i = 0; i < 5; i++)
                {
                    c.setValue(a.getValue(i) - b.getValue(i), i * 2 - 1);
                    c.setValue(a.getValue(i) + b.getValue(i), i * 2);
                }

                c.setValue(a.getValue(4) - b.getValue(4), 9);

                ShowIt("Array A:"); a.Show();
                ShowIt("Array B:"); b.Show();
                ShowIt("Array C:"); c.Show();
            }

    });
}

void The6th()
{
    newPractical(6, 3, (IntFunction[]){
            /*
             *
             * Задание 1
             *
             */
            []()->int
            {
                int ** matrix;
                int n, m;

                ShowIt("Введите n: "); cin>>n;
                ShowIt("Введите m: "); cin>>m;

                matrix = CreateNewMatrix(n, m);

                showMatrix(matrix, n, m);

                nullLine();

                ShowIt("Предпоследний столбец: ");

                nullLine();

                for(int i = 0; i<m; i++)
                    ShowIt(to_string(matrix[i][n-2]));
            },
            /*
             *
             * Задание 2
             *
             */
            []()->int
            {
                int ** matrix;
                double cache;
                int n,m, min, max, mm;

                ShowIt("Введите n: "); cin>>n;
                ShowIt("Введите m: "); cin>>m;

                matrix = CreateNewMatrix(n, m);

                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                    {
                        ShowIt("Введите элемент ["+to_string(i)+"x"+to_string(j)+"]: ");
                        cin>>cache;

                        matrix[i][j] = (int)cache;
                    }

                showMatrix(matrix, n, m);

                min = 99999;

                nullLine();

                ShowIt("Главная диагональ: ");

                nullLine();

                for(int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                    {
                        if(j == i)
                        {
                            if(matrix[i][j] < min) min = matrix[i][j];
                            ShowIt(to_string(matrix[i][j]));
                        }
                    }

                nullLine();

                ShowIt("Минимальное число: " + to_string(min));

            },
            /*
             *
             * Задание 3
             *
             */
            []()->int {

                int **matrix;
                double cache;
                int imax, jmin, s;
                int n, m, min, max, mm, a, b;

                imax = 0;
                jmin = 0;

                ShowIt("Введите n: ");
                cin >> n;
                m = n;

                matrix = CreateNewMatrix(n, m);

                showMatrix(matrix, n, n);

                mm = 0;

                nullLine();

                for (a = 0; a < n; a++)
                    for (b = 0; b < n; b++)
                        if (matrix[a][b] >= mm) {
                            mm = matrix[a][b];
                            imax = a;
                        }

                mm = 0;

                for (a = 0; a < n; a++)
                    for (b = 0; b < m; b++)
                        if (matrix[a][b] <= mm) {
                            mm = matrix[a][b];
                            jmin = b;
                        }

                s = 0;

                for (int i = 0; i < n; i++) {
                    s += matrix[imax][i] * matrix[i][jmin];
                }

                ShowIt("Ответ: " + to_string(s));
            }

    });
}

