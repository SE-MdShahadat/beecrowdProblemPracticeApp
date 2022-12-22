using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace beecrowdPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeeCrowdSolution beeCrowdSolution = new BeeCrowdSolution();

            //loop Start
            ConsoleKey input = new ConsoleKey();
            do
            {
                Console.WriteLine("                       Welcome to Practice Pad                       ");
                Console.WriteLine("                                 *                                   ");
                beeCrowdSolution.Test();
                Console.WriteLine("                                 *                                   ");
                Console.Write("           Press any key to repeat or Exit press [E/e]");
                input = Console.ReadKey().Key;
                Console.Write("\n");
            } while (input != ConsoleKey.E);
            //loop end

            
        }
    }
}
