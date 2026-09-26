using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPOPraktik1
{
    public class AvgStolbik
    {
        public static double[] FormVector(double[,] matr)
        {
            int n = matr.GetLength(0);
            int m = matr.GetLength(1);
            double[] b = new double[m];

            for (int j = 0; j < m; j++)
            {
                double avg = 0;
                for (int i = 0; i < n; i++)
                {
                    avg = avg + matr[i, j];
                }
                b[j] = avg / n;
            }
            return b;
        }
    }
}
