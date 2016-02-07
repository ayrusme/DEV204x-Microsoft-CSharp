using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_edX
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<9;i++)
            {
                Console.Write("\n");
                for(j=1;j<9;j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X\t");
                    }
                    else
                        Console.Write("O\t");
                }
            }
            Console.ReadKey(true);
        }
    }
}
