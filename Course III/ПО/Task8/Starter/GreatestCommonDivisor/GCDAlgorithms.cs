using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
    static class GCDAlgorithms
    {

        public static int FindGCDEuclid(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        public static int FindGCDEuclid(int a, int b, int c)
        {
            while (b != 0)
                b = a % (a = b);
            return FindGCDEuclid(a,c);

        }

        public static int FindGCDEuclid(int a, int b, int c, int d)
        {
            while (b != 0)
                b = a % (a = b);
            return FindGCDEuclid(a, c, d);

        }

        public static int FindGCDEuclid(int a, int b, int c, int d, int e)
        {
            while (b != 0)
                b = a % (a = b);
            return FindGCDEuclid(a, c, d, e);

        }

        //Алгоритм Стейна/Стайна
        public static long Stain(long a, long b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a == b)
                return a;
            if (a == 1 || b == 1)
                return 1;
            if ((a & 1) == 0)
                return ((b & 1) == 0)
                    ? Stain(a >> 1, b >> 1) << 1
                    : Stain(a >> 1, b);
            else
                return ((b & 1) == 0)
                    ? Stain(a, b >> 1)
                    : Stain(b, a > b ? a - b : b - a);
        }
    }
}
