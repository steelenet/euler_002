using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_002_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int term1 = 1;
            int term2 = 2;
            int termTemp = 0;
            int sum = 0;

            while (termTemp < 4000000)
            {
                termTemp = term1 + term2;
                term1 = term2;
                term2 = termTemp;

                if (termTemp % 2 == 0)
                {
                    sum = termTemp + sum;
                }

                //Console.WriteLine(termTemp);
                //Console.ReadKey();
            }

            sum = sum + 2;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
