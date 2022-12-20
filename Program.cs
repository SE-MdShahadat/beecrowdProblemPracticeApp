using System;
using System.Collections;
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
                Month_1052();
                Console.WriteLine("                                 *                                   ");
                Console.Write("           Press any key to repeat or Exit press [E/e]");
                input = Console.ReadKey().Key;
                Console.Write("\n");
            } while (input != ConsoleKey.E);

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
                if (x == 0.0 || y == 0.0)
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
                double[] numbers = new double[inputNumber.Length];
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
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                    return;
                };
                if (A == B || B == C || C == A) Console.WriteLine("TRIANGULO ISOSCELES");
                Console.ReadLine();

            }
            void GameTime_1046()
            {
                string[] inputs = Console.ReadLine().ToString().Split(' ');
                int startHour = int.Parse(inputs[0]);
                int endHour = int.Parse(inputs[1]);
                int gameDuration = 0;
                if (startHour >= endHour)
                {
                    gameDuration = ((24 - startHour) + endHour);
                }
                else if (startHour < endHour)
                {
                    gameDuration = endHour - startHour;
                }
                Console.WriteLine($"O JOGO DUROU {gameDuration} HORA(S)");
                //Console.ReadKey();
            }
            void GameTimewithMinutes_1047()
            {

                string[] inputs = Console.ReadLine().ToString().Split(' ');
                int initialHour, initialMinute, finalHour, finalMinute, gameDurationInMinutes;
                initialHour = int.Parse(inputs[0]);
                initialMinute = int.Parse(inputs[1]);
                finalHour = int.Parse(inputs[2]);
                finalMinute = int.Parse(inputs[3]);

                if (initialHour == initialMinute && finalHour == finalMinute && initialMinute == finalMinute)
                {
                    Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                }
                else if (initialHour > finalHour) // when duration till next day
                {
                    gameDurationInMinutes = (finalHour * 60) + ((24 - initialHour) * 60) + (finalMinute - initialMinute);
                    Console.WriteLine($"O JOGO DUROU {gameDurationInMinutes / 60} HORA(S) E {gameDurationInMinutes % 60} MINUTO(S)");
                }
                else if (initialHour < finalHour) // when duration in present day
                {
                    gameDurationInMinutes = ((finalHour - initialHour) * 60) + (finalMinute - initialMinute);
                    Console.WriteLine($"O JOGO DUROU {gameDurationInMinutes / 60} HORA(S) E {gameDurationInMinutes % 60} MINUTO(S)");
                }
                Console.ReadKey();

            }
            void Snack_1038()
            {
                string[] inputText = Console.ReadLine().Split(new char[] { });
                int x = int.Parse(inputText[0]);
                int y = int.Parse(inputText[1]);
                //double price = 0.00;
                if (x == 1) Console.WriteLine("Total: R$ " + (4.00 * y).ToString("0.00"));
                if (x == 2) Console.WriteLine("Total: R$ " + (4.50 * y).ToString("0.00"));
                if (x == 3) Console.WriteLine("Total: R$ " + (5.00 * y).ToString("0.00"));
                if (x == 4) Console.WriteLine("Total: R$ " + (2.00 * y).ToString("0.00"));
                if (x == 5) Console.WriteLine("Total: R$ " + (1.50 * y).ToString("0.00"));
                //Console.ReadLine();
            }
            void Multiples_1044()
            {
                string[] inputText1 = Console.ReadLine().Split(new char[] { });
                int n1 = int.Parse(inputText1[0]);
                int n2 = int.Parse(inputText1[1]);
                if (n1 > n2)
                {
                    if (n1 % n2 == 0)
                    {
                        Console.WriteLine("Sao Multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Nao sao Multiplos");
                    }
                }
                else
                {
                    if (n2 % n1 == 0)
                    {
                        Console.WriteLine("Sao Multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Nao sao Multiplos");
                    }
                }

                Console.ReadLine();

            }
            void SalaryIncrease_1048()
            {
                double salary = Convert.ToDouble(Console.ReadLine());
                double increment = 0.00;
                int percentage = 0;
                if (salary >= 0.00 && salary <= 400.00)
                {
                    percentage = 15;
                    increment = salary * percentage / 100;
                    salary = (double)salary + increment;
                }
                else if (salary >= 400.01 && salary <= 800.00)
                {
                    percentage = 12;
                    increment = salary * percentage / 100;
                    salary = (double)salary + increment;
                }
                else if (salary >= 800.01 && salary <= 1200.00)
                {
                    percentage = 10;
                    increment = salary * percentage / 100;
                    salary = (double)salary + increment;
                }
                else if (salary >= 1200.01 && salary <= 2000.00)
                {
                    percentage = 7;
                    increment = salary * percentage / 100;
                    salary = (double)salary + increment;
                }
                else if (salary > 2000)
                {
                    percentage = 4;
                    increment = salary * percentage / 100;
                    salary = (double)(salary + increment);
                }

                Console.WriteLine($"Novo salario: {salary.ToString("0.00")}");
                Console.WriteLine($"Reajuste ganho: {increment.ToString("0.00")}");
                Console.WriteLine($"Em percentual: {percentage} %");
                Console.ReadKey();
            }
            void Animal_1049()
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                if (input1 == "vertebrado")
                {
                    if (input2 == "ave")
                    {
                        if (input3 == "carnivoro")
                        {
                            Console.WriteLine("aguia");
                        }
                        else if (input3 == "onivoro")
                        {
                            Console.WriteLine("pomba");
                        }
                    }
                    else if (input2 == "mamifero")
                    {
                        if (input3 == "onivoro")
                        {
                            Console.WriteLine("homem");
                        }
                        else if (input3 == "herbivoro")
                        {
                            Console.WriteLine("vaca");
                        }
                    }
                }
                else if (input1 == "invertebrado")
                {
                    if (input2 == "inseto")
                    {
                        if (input3 == "hematofago")
                        {
                            Console.WriteLine("pulga");
                        }
                        else if (input3 == "herbivoro")
                        {
                            Console.WriteLine("lagarta");
                        }
                    }
                    else if (input2 == "anelideo")
                    {
                        if (input3 == "hematofago")
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else if (input3 == "onivoro")
                        {
                            Console.WriteLine("minhoca");
                        }
                    }

                }
                Console.ReadKey();
            }
            void DDD_1050()
            {
                Dictionary<int, string> addressBook = new Dictionary<int, string>()
                {
                    { 61, "Brasilia" },
                    { 71, "Salvador" },
                    { 11, "Sao Paulo" },
                    { 21, "Rio de Janeiro" },
                    { 32, "Juiz de Fora" },
                    { 19, "Campinas" },
                    { 27, "Vitoria" },
                    { 31, "Belo Horizonte" },

                };
                int DDD = int.Parse(Console.ReadLine());
                int inList = 0;
                foreach (var item in addressBook)
                {
                    if (DDD == item.Key)
                    {
                        Console.WriteLine(item.Value);
                        inList++;
                    }
                }
                if (inList == 0) Console.WriteLine("DDD nao cadastrado");
                //Console.ReadKey();

            }
            void Taxes_1051()
            {
                double salary = Convert.ToDouble(Console.ReadLine());
                double taxAmount = 0.00;
                double percentage = 0.00;
                if (salary >= 0.00 && salary <= 2000.00)
                {
                    Console.WriteLine("Isento");
                    return;
                }
                else if (salary >= 2000.01 && salary <= 3000.00)
                {
                    percentage = 0.08;
                    taxAmount = (salary - 2000) * percentage;
                }
                else if (salary >= 3000.01 && salary <= 4500.00)
                {
                    percentage = 0.18;
                    taxAmount = 1000 * 0.08;
                    taxAmount = taxAmount + (salary - 3000) * percentage;
                }
                else if (salary > 4500)
                {
                    percentage = 0.28;
                    taxAmount = 1000 * 0.08;
                    taxAmount = taxAmount + 1500 * 0.18;
                    taxAmount = taxAmount + (salary - 4500) * percentage;
                }
                Console.WriteLine($"R$ {taxAmount.ToString("0.00")}");
                //Console.ReadKey();
            }

            void Month_1052()
            {
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                DateTime date= new DateTime(1111,monthNumber,1);
                Console.WriteLine(date.ToString("MMMM"));
                //Console.ReadKey();
            }

        }
    }
}
