using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 }));
            Console.WriteLine(jumpingOnClouds(new int[] {0, 0, 0, 0, 1, 0 }));
        }

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int jumpsCount = 0;
            int i = 0;

            while (i < c.Length - 1)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }

                jumpsCount++;
            }

            return jumpsCount;
        }
    }
}
