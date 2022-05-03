using System;

namespace Zadanie
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double[] db = new double[3];
            char[] cr = { 'H', 'E', 'L' };
            db[0] = 123;
            db[1] = 34567;
            db[2] = 365464;
            void*[] dp = new void*[sizeof(double) * 3 / sizeof(char)];
            double*[] ch = new double*[sizeof(double) * 3 / sizeof(char)];
            char* test;
            for (int d = 0; d < db.Length; d++)
            {
                for (int i = 0; i < sizeof(double); i++)
                {
                    fixed (double* gg = &db[d])
                    {
                        test = (char*)gg;
                        test[i] = cr[d];
                        Console.WriteLine(*test);
                        //Console.WriteLine(**ch[0]);
                    }
                }

            }
        }
    }
}
