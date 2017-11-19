using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Array;

namespace Tribonacci_Sequence
{
    class Program
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            List<double> signatureList = signature.ToList();
            return Doubles(signature, n, signatureList);
        }

        private double[] Doubles(double[] signature, int n, List<double> signatureList)
        {
            if (n == 0)
            {
                return new double[] {0};
            }
            else if (n <= signature.Length)
            {
                return signatureList.Take(n).ToArray();
            }
            else
            {
                for (int i = 0; i < n - signature.Length; i++)
                {
                    signatureList.Add(signatureList.Skip(i).Take(3).Sum(x => x));
                }
                return signatureList.ToArray();
            }
        }
    }
}
