using System;

namespace Assignment_3
{
    class Program
    {
        public static List<int> FindFactor(int input)     
        {           
            List<int> lst = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    lst.Add(i);
                }
            }
            return lst;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                List<int> result = FindFactor(i);
                if (result.Count == 2)
                {
                    Console.WriteLine($"{i} is prime number");
                }
 
            }
        }

    }
}