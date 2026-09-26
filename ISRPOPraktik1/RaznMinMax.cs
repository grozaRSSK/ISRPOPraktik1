using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPOPraktik1
{
    public class RaznMinMax
    {
        public static double[] FormVector(double[,] matr)
        {
            int n = matr.GetLength(0);
            int m = matr.GetLength(1);
            double[] b = new double[n];

            for (int i = 0; i < n; i++)
            {
                double max = matr[i, 0];
                double min = matr[i, 0];
                for (int j = 1; j < m; j++)
                {
                    if (max < matr[i, j]) max = matr[i, j];
                    if (min > matr[i, j]) min = matr[i, j];
                }
                b[i] = max - min;
            }
            return b;
        }
    }
}
