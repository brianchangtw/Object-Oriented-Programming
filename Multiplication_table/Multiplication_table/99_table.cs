using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int outer;
            int inner;
            Console.WriteLine("9 * 9 Table");
            for(outer=1;outer<=9;outer++)
            {
                for(inner=1;inner<=9;inner++)
                {
                    Console.Write("[{0,2} *{1,2} ={2,2}] ", inner, outer, inner * outer);
                }
                Console.WriteLine();            
            }
            Console.Read();
        }
    }
}
