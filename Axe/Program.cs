using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            for (int rown = 0; rown < N; rown++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',3*N),new string('-',rown),new string('-', 2*N-2-rown));
            }
            for (int rows2 = 0; rows2 < N/2; rows2++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * N), new string('-', N-1), new string ('-', N-1));
            }
            for (int row3 = 0; row3 < N/2-1; row3++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3*N-row3),new string('-', (N-1)+2*row3), new string('-',(N-1)-row3));
            }
            Console.WriteLine("{0}{1}{2}", new string('-', 3*N-(N/2-1)), new string('*', 2*N-1-(N%2)), new string ('-',5*N-(3 * N - (N / 2 - 1))-(2 * N - 1 - (N % 2))));
        }
    }
}
