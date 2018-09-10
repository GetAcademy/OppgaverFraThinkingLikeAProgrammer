using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaverFraThinkingLikeAProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2_1();
        }

        private static void Exercise2_1()
        {
            for (int row = 1; row <= 4; row++)
            {
                for (int hashNum = 1; hashNum <= row - 1; hashNum++)
                {
                    Console.Write(" ");
                }
                var n = 2*(5 - row);
                for (int hashNum = 1; hashNum <= n; hashNum++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
