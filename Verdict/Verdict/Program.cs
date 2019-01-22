using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdict
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                if (line == "ac")
                {
                    Console.WriteLine("Accepted");
                } else if(line == "wa")
                {
                    Console.WriteLine("Wrong Answer");
                }
                else if (line == "rte")
                {
                    Console.WriteLine("Run Time Error");
                }
                else if(line == "tle")
                {
                    Console.WriteLine("Time Limit Exceeded");
                }

            }
        }
    }
}
