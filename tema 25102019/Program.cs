using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_25102019
{
    class Program
    {
        static void Main(string[] args)
        {


            //7.Write a Program which checks if two Strings are Anagram or not
            //Anagrame();

            //8.Write a function to print the nth number in Fibonacci series
            //Console.WriteLine(NthFibonacci(20));

            //9.Write a function to count a total number of set bits in a 32-bit Integer
            //Console.WriteLine(BitSet(12));

            //10.Write a function to remove duplicate characters from String

            //12.C# program to check if a number is Armstrong number or not
            //Console.WriteLine(Armstrong(1634));

            //13.Algorithm to check if a number is Prime or not
            //Prim();

            //15.Algorithm to check if a number is a Palindrome
            //Palindrome();

            //17.Sorting an Array using Selection Sort
            //SelectionSort();

            //18.Sorting an Array using Bubble Sort
            //Bubble();

            Console.ReadLine();
        }

        private static void Anagrame()
        {
            string x = "emirat";
            string y = "martie";
            Console.WriteLine(SortingAString(x));
            Console.WriteLine(SortingAString(y));
            if (SortingAString(x) == SortingAString(y))
            {
                Console.WriteLine("Cuvintele sunt anagrame");
            }
            else
            {
                Console.WriteLine("Cuvintele nu sunt anagrame");
            }
        }


        static string SortingAString(string n)
        {
            
            char[] arr = n.ToCharArray();

           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        char x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            
            string sorted = new string(arr);
            return sorted;
        }

        private static void SelectionSort()
        {
            int[] arr = new int[] { 6, 8, 6, 3, 4, 135, 0, 7 };
            int min_pos = 0;
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min_pos = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_pos])
                    {
                        min_pos = j;
                    }

                }
                if (min_pos != i)
                {
                    x = arr[i];
                    arr[i] = arr[min_pos];
                    arr[min_pos] = x;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void Bubble()
        {
            int[] arr = new int[] { 6, 8, 6, 3, 4, 135, 0, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int x = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void Palindrome()
        {
            Console.WriteLine("introduceti in cuvant:");

            string word = Console.ReadLine();
            int flag = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[word.Length - i - 1])
                {
                    flag++;
                }
            }
            if (flag == word.Length)
            {
                Console.WriteLine("Cuvantul este un palindrom");
            }
            else
            {
                Console.WriteLine("Cuvantul nu este un palindrom");
            }
        }

        private static void Prim()
        {
            Console.WriteLine("Introduceti un numar: ");
            int nr = int.Parse(Console.ReadLine());

            int flag = 0;
           
            for (int i = 2; i <= nr/2; i++)
            {
                if (nr % i == 0)
                {
                    Console.WriteLine("Numarul nu este prim");
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("Numarul este prim");
            }
        }

        static int Armstrong(int value)
        {
            
            int n = 0;
            int sum = 0;
            int number = 0;
            while(value>0)
            {
                value = value / 10;
                n++;
            }
            
            for (int j = value; j > 0; j=j/10)
            {
                number = j % 10;
                
                sum = sum + number^n;
                
            }
            if (sum == value)
               
            Console.WriteLine("Aceasta este un numar Armstrong");
            else
            {
                Console.WriteLine("Aceasta nu este un numar Armstrong");
            }
            return value;    
        }


        
        
        static int BitSet(int n)
        {
            int[] binary = new int[32];
            for (int i = 0; i < binary.Length; i++)
            {
                binary[i] = n % 2;
                n = n / 2;
                
            }
            int sum = 0;
            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j]==1)
                {
                    sum++;
                }
            }
            return (sum); 
        }
   
         static int NthFibonacci(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

    }
}
