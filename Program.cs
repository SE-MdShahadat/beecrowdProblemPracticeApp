using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace beecrowdPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleKey input = new ConsoleKey();
            do
            {
                Console.WriteLine("                       Welcome to Practice Pad                       ");
                Console.WriteLine("                                 *                                   ");
                GameTimewithMinutes_1047();
                Console.WriteLine("                                 *                                   ");
                Console.Write("           Press any key to repeat or Exit press [E/e]");
                input = Console.ReadKey().Key;
                Console.Write("\n");
            } while (input!=ConsoleKey.E);

            void Average3_1040()
            {
                string inputNumberString1 = Console.ReadLine();
                string[] inputNumber = inputNumberString1.Split(' ');
                double n1 = double.Parse(inputNumber[0]);
                double n2 = double.Parse(inputNumber[1]);
                double n3 = double.Parse(inputNumber[2]);
                double n4 = double.Parse(inputNumber[3]);
                double avg = 0, avgWithExtra;
                avg = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10.0;
                string inputNumberString2 = Console.ReadLine();
                Console.WriteLine("Media: " + string.Format("{0:0.0}", Math.Truncate(avg * 10) / 10));
                if (avg >= 7.0) Console.WriteLine("Aluno aprovado.");
                if (avg < 5.0) Console.WriteLine("Aluno reprovado.");
                if (avg >= 5.0 && avg <= 6.9) Console.WriteLine("Aluno em exame.");
                if (!string.IsNullOrEmpty(inputNumberString2))
                {
                    double n5 = double.Parse(inputNumberString2);
                    avgWithExtra = (avg + n5) / 2.0;
                    Console.WriteLine("Nota do exame: " + n5.ToString("0.0"));
                    if (avgWithExtra >= 5.0) Console.WriteLine("Aluno aprovado.");
                    if (avgWithExtra < 5.0) Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + string.Format("{0:0.0}", Math.Truncate(avgWithExtra * 10) / 10));
                }

                //Console.ReadLine();
            }
            void CoordinatesOfAPoint_1041()
            {
                string inputNumberString1 = Console.ReadLine();
                string[] inputNumber = inputNumberString1.Split(' ');
                double x = double.Parse(inputNumber[0]);
                double y = double.Parse(inputNumber[1]);
                if (x == 0.0 && y == 0.0) Console.WriteLine("Origem");
                if(x==0.0 || y == 0.0)
                {
                    if (x > 0.0 || x < 0.0 && y == 0.0) Console.WriteLine("Eixo X");
                    if (x == 0.0 && y > 0.0 || y < 0.0) Console.WriteLine("Eixo Y");
                }
                if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");
                if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");
                if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");
                if (x > 0.0 && y < 0.0) Console.WriteLine("Q4");

                //Console.ReadLine();
            }
            void SimpleSort_1042()
            {
                string inputNumberString1 = Console.ReadLine();
                string[] inputNumber = inputNumberString1.Split(' ');
                List<double> numbers = new List<double>();
                foreach (var item in inputNumber)
                {
                    numbers.Add(double.Parse(item));
                }
                numbers.Sort();
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                foreach (var item in inputNumber)
                {
                    Console.WriteLine(item);
                }
                //Console.ReadLine();
            }
            void Triangle_Types_1045()
            {
                string inputString = Console.ReadLine();
                string[] inputNumber = inputString.Split(' ');
                double [] numbers = new double[inputNumber.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = double.Parse(inputNumber[j]);
                }
                Array.Sort(numbers);
                Array.Reverse(numbers);
                int i = 0;
                double A = 0, B = 0, C = 0;
                foreach (var item in numbers)
                {
                    if (i == 0) A = Convert.ToDouble(item);
                    if (i == 1) B = Convert.ToDouble(item);
                    if (i == 2) C = Convert.ToDouble(item);
                    i++;
                }
                if (A >= (B + C))
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                    return;
                }; 
                if ((A * A) == ((B * B) + (C * C))) Console.WriteLine("TRIANGULO RETANGULO");
                if ((A * A) > ((B * B) + (C * C))) Console.WriteLine("TRIANGULO OBTUSANGULO");
                if ((A * A) < ((B * B) + (C * C))) Console.WriteLine("TRIANGULO ACUTANGULO");
                if (A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                    return;
                };
                if (A == B || B == C || C == A) Console.WriteLine("TRIANGULO ISOSCELES");
                Console.ReadLine();

            }
            void GameTime_1046()
            {
                string[] inputs =Console.ReadLine().ToString().Split(' ');
                int startHour = int.Parse(inputs[0]);
                int endHour = int.Parse(inputs[1]);
                int gameDuration = 0;
                if (startHour >= endHour)
                {
                    gameDuration = ((24 - startHour) + endHour);
                }
                else if(startHour < endHour)
                {
                    gameDuration =  endHour -startHour;
                }
                Console.WriteLine($"O JOGO DUROU {gameDuration} HORA(S)");
                //Console.ReadKey();
            }
            void GameTimewithMinutes_1047()
            {
                
                string[] inputs = Console.ReadLine().ToString().Split(' ');
                int initialHour, initialMinute, finalHour, finalMinute, gameDurationInMinutes;
                initialHour= int.Parse(inputs[0]);
                initialMinute= int.Parse(inputs[1]);
                finalHour= int.Parse(inputs[2]);
                finalMinute= int.Parse(inputs[3]);

                if(initialHour == initialMinute && finalHour == finalMinute && initialMinute == finalMinute)
                {
                    Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                }
                else if(initialHour > finalHour) // when duration till next day
                {
                    gameDurationInMinutes = (finalHour * 60) +((24-initialHour) * 60) + (finalMinute-initialMinute);
                    Console.WriteLine($"O JOGO DUROU {gameDurationInMinutes / 60} HORA(S) E {gameDurationInMinutes % 60} MINUTO(S)");
                }
                else if(initialHour < finalHour) // when duration in present day
                {
                    gameDurationInMinutes = ((finalHour-initialHour)*60)  + (finalMinute - initialMinute);
                    Console.WriteLine($"O JOGO DUROU {gameDurationInMinutes / 60} HORA(S) E {gameDurationInMinutes % 60} MINUTO(S)");
                }
                Console.ReadKey();

            }
        }
    }
}
