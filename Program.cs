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
                DateTime date = new DateTime(1111, monthNumber, 1);
                Console.WriteLine(date.ToString("MMMM"));
                //Console.ReadKey();
            }
            void EvenNumbers_1059()
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
                //Console.ReadKey();
            }
            void PositiveNumbers_1060()
            {
                int inputCount = 0, positiveCount = 0;
                List<double> inputs = new List<double>();
                while (inputCount < 6)
                {
                    double inputNumber = double.Parse(Console.ReadLine());
                    inputs.Add(inputNumber);
                    inputCount++;
                    if (inputNumber >= 0) positiveCount++;
                }
                Console.WriteLine($"{positiveCount} valores positivos");
                //Console.ReadLine();
            }
            void EventTime_1061()
            {
                int sd, ed;
                Console.Write("Dia ");
                sd = Convert.ToInt32(Console.ReadLine());
                string[] startTime = Console.ReadLine().Trim().Split(':');
                int sh = Convert.ToInt32(startTime[0]);
                int sm = Convert.ToInt32(startTime[1]);
                int ss = Convert.ToInt32(startTime[2]);

                Console.Write("Dia ");
                ed = Convert.ToInt32(Console.ReadLine());
                string[] endTime = Console.ReadLine().Split(':');
                int eh = Convert.ToInt32(endTime[0]);
                int em = Convert.ToInt32(endTime[1]);
                int es = Convert.ToInt32(endTime[2]);

                DateTime startDateTime = new DateTime(1111, 4, sd, sh, sm, ss);
                DateTime endDateTime = new DateTime(1111, 4, ed, eh, em, es);
                //TimeSpan timeSpan = new TimeSpan(0,0,0,0);
                TimeSpan timeSpan = endDateTime - startDateTime;
                Console.WriteLine($"{timeSpan.Days} dia(s)");
                Console.WriteLine($"{timeSpan.Hours} hora(s)");
                Console.WriteLine($"{timeSpan.Minutes} minuto(s)");
                Console.WriteLine($"{timeSpan.Seconds} segundo(s)");
                //Console.ReadLine();
            }
            void PositiveAndAverage_1064()
            {
                int inputCount = 0, positiveCount = 0;
                double sum = 0.00;
                List<double> inputs = new List<double>();
                while (inputCount < 6)
                {
                    double inputNumber = double.Parse(Console.ReadLine());
                    inputs.Add(inputNumber);
                    inputCount++;
                    if (inputNumber >= 0)
                    {
                        positiveCount++;
                        sum += inputNumber;
                    }
                }
                Console.WriteLine($"{positiveCount} valores positivos\n{(sum / positiveCount).ToString("0.0")}");
                //Console.ReadLine();
            }
            void EvenBetweenfiveNumbers_1065()
            {
                int inputCount = 0, evenCount = 0;
                while (inputCount < 5)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    inputCount++;
                    if (number % 2 == 0) evenCount++;
                }
                Console.WriteLine($"{evenCount} valores pares");
                //Console.ReadLine();
            }
            void EvenOddPositiveAndNegative_1066()
            {
                int inputCount = 0, evenCount = 0, oddCount = 0, posCount = 0, negCount = 0;
                while (inputCount < 5)
                {
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number % 2 == 0) evenCount++;
                    if (number % 2 != 0) oddCount++;
                    if (number > 0) posCount++;
                    if (number < 0) negCount++;
                    inputCount++;
                }
                Console.WriteLine($"{evenCount} valor(es) par(es)");
                Console.WriteLine($"{oddCount} valor(es) impar(es)");
                Console.WriteLine($"{posCount} valor(es) positivo(s)");
                Console.WriteLine($"{negCount} valor(es) negativo(s)");
                //Console.ReadLine();
            }
            void OddNumbers_1067()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && n <= 1000)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                Console.ReadLine();

            }
            void SixOddNumbers_1070()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int oddCount = 0;
                do
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine(n);
                        oddCount++;
                    }
                    n++;
                } while (oddCount < 6);
                Console.ReadLine();
            }
            void SumofConsecutiveOddNumbersI_1071()
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                if (x > y)
                {
                    int z;
                    z = x;
                    x = y;
                    y = z;
                }

                for (int i = (x + 1); i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }
            void EvenSquare_1073()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n >= 5 && n <= 2000)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"{i}^2 = {i * i}");
                        }
                    }
                }
                Console.ReadLine();
            }
            void EvenOrOdd_1074()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                List<int> inputs = new List<int>();
                int i = 0;
                while (i < n)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    inputs.Add(x);
                    i++;
                }
                foreach (var item in inputs)
                {
                    if (item == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else if (item > 0)
                    {
                        if (item % 2 == 0) Console.WriteLine($"EVEN POSITIVE");
                        if (item % 2 != 0) Console.WriteLine($"ODD POSITIVE");
                    }
                    else
                    {
                        if (item % 2 == 0) Console.WriteLine($"EVEN NEGATIVE");
                        if (item % 2 != 0) Console.WriteLine($"ODD NEGATIVE");
                    }
                }
                //Console.ReadLine();
            }
            void Remaining2_1075()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2");
                for (int i = 1; i <= 10000; i++)
                {

                    if (i % n == 0) Console.WriteLine($"{i + 2}");
                    if (i + 2 >= 10000) break;
                }
                Console.ReadLine();
            }
            void MultiplicationTable_1078()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} x {n} = {i * n}");
                }
                Console.ReadLine();
            }
            void WeightedAverages_1079()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                List<double> avgList = new List<double>();
                int i = 1;
                while (i <= n)
                {
                    string[] strings = Console.ReadLine().Split(' ');
                    double n1 = Convert.ToDouble(strings[0]);
                    double n2 = Convert.ToDouble(strings[1]);
                    double n3 = Convert.ToDouble(strings[2]);
                    double avg = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / (2 + 3 + 5);
                    avgList.Add(avg);
                    i++;
                }
                foreach (var item in avgList)
                {
                    Console.WriteLine(item.ToString("0.0"));
                }
                Console.ReadLine();
            }
            void HighestAndPosition_1080()
            {
                int[] numbers = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }
                int maxValue = numbers.Max();
                int position = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (numbers[i] == maxValue) position = i + 1;
                }
                Console.WriteLine($"{maxValue}\n{position}");
                Console.ReadLine();
            }
            void Experiments_1094()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int tC=0, tR=0, tS = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    int animalNumber = Convert.ToInt32(inputs[0]);
                    char animalType =Convert.ToChar(inputs[1]);
                    if (animalType == 'C') tC += animalNumber;
                    if (animalType == 'R') tR += animalNumber;
                    if (animalType == 'S') tS += animalNumber;
                }
                double totalAnimal=Convert.ToDouble( tC+tR+tS);
                double CP , RP , SP ;
                CP = Convert.ToDouble( tC * 100 / totalAnimal);
                RP = Convert.ToDouble(tR * 100 / totalAnimal);
                SP = Convert.ToDouble(tS * 100 / totalAnimal);
                Console.WriteLine($"Total: {totalAnimal} cobaias");
                Console.WriteLine($"Total de coelhos: {tC}");
                Console.WriteLine($"Total de ratos: {tR}");
                Console.WriteLine($"Total de sapos: {tS}");
                Console.WriteLine($"Percentual de coelhos: {CP.ToString("0.00")} %");
                Console.WriteLine($"Percentual de ratos: {RP.ToString("0.00")} %");
                Console.WriteLine($"Percentual de sapos: {SP.ToString("0.00")} %");
                Console.ReadLine();


            }
            void SequenceIJ1_1095()
            {
                
                int i = 1, j = 60;
                do
                {
                    Console.WriteLine($"I={i} J={j}");
                    i += 3;
                    j -= 5;
                } while (j >=0);
                Console.ReadKey();
            }

            //loop Start
            ConsoleKey input = new ConsoleKey();
            do
            {
                Console.WriteLine("                       Welcome to Practice Pad                       ");
                Console.WriteLine("                                 *                                   ");
                SequenceIJ1_1095();
                Console.WriteLine("                                 *                                   ");
                Console.Write("           Press any key to repeat or Exit press [E/e]");
                input = Console.ReadKey().Key;
                Console.Write("\n");
            } while (input != ConsoleKey.E);
            //loop end
            
            







        }
    }
}
