using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Startup
    {
        static void Main(string[] args)
        {
            sockMerchant(9, new int[]{ 10, 20, 20, 10, 10, 30, 50, 10, 20});
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var dict = new Dictionary<int, int>();

            foreach (var color in ar)
            {
                if (dict.Keys.Contains(color))
                {
                    dict[color]++;
                }
                else
                {
                    dict.Add(color, 1);
                }
            }

            int pairsCount = 0;

            foreach (var colorPair in dict)
            {
                pairsCount += dict[colorPair.Key] / 2;
            }

            
            return pairsCount;
        }
    }
}
