using System;

namespace preworkChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNum = new int[] { 3, 2, 5, 6, 8, 1 };
            Console.WriteLine("Select from the following numbers to get an output 3, 2, 5, 6, 8, 1");
            int response = Int32.Parse(Console.ReadLine());
            userOutput(arrOfNum, response);
            Console.ReadLine();
        }

        public static void userOutput(int[] arrOfNum, int response)
        {

            int output = 0;
            for (int i = 0; i < arrOfNum.Length; i++)
            {
                if (response == arrOfNum[i])
                    output += arrOfNum[i];
            }
            Console.WriteLine($"your output is {output}");
        }
    }
}