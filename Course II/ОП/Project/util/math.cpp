/**
 *
 * Возвращает максимальное из трех int
 *
 */
int MaxOfThree(int a, int b, int c)
{
    int max = a;

    if(b > max)
    {
        max = b;
    }

    if(c > max)
    {
        max = c;
    }

    return max;
}

/**
 *
 * Возвращает максимальное из трех double
 *
 */
double MaxOfThreeDoubles(double a, double b, double c)
{
    double max = a;

    if(b > max)
    {
        max = b;
    }

    if(c > max)
    {
        max = c;
    }

    return max;
}

/**
 *
 * Возвращает максимальное из двух int
 *
 */
int MaxOfTwo(int a, int b)
{
    int max = a;

    if(b > max) max = b;

    return b;
}

/**
 *
 * Возвращает минимальное из двух int
 *
 */
int MinOfTwo(int a, int b)
{
    int min = a;

    if(b < min) min = b;

    return min;
}

/**
 *
 * Возвращает максимальное из двух double
 *
 */
double MaxOfTwoDoubles(double a, double b)
{
    double max = a;

    if(b > max) max = b;

    return b;
}

/**
 *
 * Возвращает минимальное из двух double
 *
 */
double MinOfTwoDoubles(double a, double b)
{
    double min = a;

    if(b < min) min = b;

    return min;
}

/**
 *
 * Возвращает рандомное значение int от min до max
 *
 */
int getRandomInt(int min, int max)
{

    return  min + (rand() % (int)(max - min + 1));
}