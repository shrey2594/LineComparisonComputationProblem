using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProgram
{
    public class LengthComparison
    {
        public static void Comparison(double Length1,double Length2)
        {
            if (Length1 < Length2)
            {
                Console.WriteLine("Line1 is shorter than Line2");
            }
            else
            {
                Console.WriteLine("Line2 is shorter than Line1");
            }
        }
    }
}
