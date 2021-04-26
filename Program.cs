using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int tie = 0;
            for (int i = 0; i < 100; i++)
            {

                Random r = new Random();
                int computerChoice = r.Next(3);

                if (computerChoice == 0)
                {
                    a++;
                }

                else if (computerChoice == 1)
                {
                    tie++;
                }
                else if (computerChoice == 2)
                {
                    b++;
                }
            }

            Console.WriteLine("Player A wins {0} of 100 games", a);
            Console.WriteLine("Player B wins {0} of 100 games", b);
            Console.WriteLine("Tie: {0} of 100 games", tie);
        }
    }
}