using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPOPraktik1
{
    public class Proizvedenie
    {
        public static double[] FormVector(double[,] matr)
        {
            int n = matr.GetLength(0);   
            int m = matr.GetLength(1);  
            double[] b = new double[n];

            for (int i = 0; i < n; i++)
            {
                double sum = 1;               
                for (int j = 0; j < m; j++)
                {
                    sum = sum * matr[i, j];
                }
                b[i] = sum;
            }
            return b;
        }
    }
}
