using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i;
            int evenVariable = 0;
            for (i = 0; i < 41; ++i)     
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

                
                if (n3 % 2 == 0)
                {
                    evenVariable += n3;
                }

               
            }

            Console.WriteLine($"\n\n {evenVariable}");
        }
    }
}

