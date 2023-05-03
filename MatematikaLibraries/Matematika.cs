using System;
using System.Globalization;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB (int a, int b)
        {
            int temp1 = 0;
            while (b > 0)
            {
                temp1 = a % b;
                a = b;
                b = temp1;
            }
            return a;
        }
        public static int KPK(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int KPK = max;

            while(KPK % min != 0)
            {
                KPK /= min;
            }
            return KPK;
        }
        public static string Turunan(int[] persamaan)
        {
            string turuna; 
            int a = 0;
            int b = 0;
            int c = 0;
            int i = 0;
            while (i < 3)
            {
                 a = persamaan[0];
                 b = persamaan[1];
                 c = persamaan[2];
                i = i + 1;
            }
            turuna = a + "x2 " + b + "x " + c;
            return turuna;
         }
        public static string Integral(int[] persamaan)
        {
            string integr;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int i = 0;
            while (i < 4)
            {
                a = persamaan[0] / 4;
                b = persamaan[1] / 3;
                c = persamaan[2] / 2;
                d = persamaan[3] / 1;
                i = i + 1;
            }
            integr = a + "x4 " + b + "x3 " + c + "x2 " + d + "x + C";
            return integr;
           
        }
    }
}