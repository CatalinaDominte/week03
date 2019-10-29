using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_28102019
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Program to Check Whether the Entered Year is a Leap Year or Not
            //Leap();

            //You have data in a file in two rows. On the third row save the sum of the numbers above.
            //Txt();

            Console.ReadLine();
        }

        private static void Txt()
        {
            string[] lines = System.IO.File.ReadAllLines(@"F:\1CSharp\WriteLines.txt");
            int[] numere = new int[lines.Length];
            int sum = 0;
            foreach (var line in lines)
            {
                sum += int.Parse(line);

            }
            System.IO.File.AppendAllText(@"F:\1CSharp\WriteLines.txt", "sum: " + sum.ToString());
        }

        private static void Leap()
        {
            Console.Write("Introduceti un an: ");
            int an = int.Parse(Console.ReadLine());
            if (an < 1582)
            {
                Console.WriteLine("Nu exista ani bisecti inainte de 1582");
            }
            else
            {
                if (an % 4 == 0)
                {
                    if (an % 400 != 0 && an % 100 == 0)
                    {
                        Console.WriteLine("Anul cautat nu este bisect");
                    }
                    else
                    {
                        Console.WriteLine("Anul cautat este bisect");
                    }
                }
                else
                {
                    Console.WriteLine("Anul cautat nu este bisect");
                }

            }
        }
    }
}
