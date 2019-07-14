using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Startup
    {
        static void Main(string[] args)
        {
            var result = countingValleys(8, "UDDDUDUU");

            Console.WriteLine(result);
        }

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int valleyCount = 0;
            int currElevation = 0;
            int prevElevation = 0;

            foreach (var step in s)
            {
                if (step == 'U')
                {
                    prevElevation = currElevation;
                    currElevation++;
                }
                else
                {
                    prevElevation = currElevation;
                    currElevation--;
                }

                if (currElevation == 0 && prevElevation < 0)
                {
                    valleyCount++;
                }
            }

            return valleyCount;
        }
    }
}
