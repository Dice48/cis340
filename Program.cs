using System;

namespace CISMO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Noah", "Liam", "Tom", "Alex", "James", "John", "Mason", "Logan", "Mateo", "Ethan" };
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }

            int[] Scores = { 43, 74, 73, 85, 53, 52, 73, 54, 25, 46 };
            for (int i = 0; i < Scores.Length; i++)
            {
                Console.WriteLine(Scores[i]);
            }
            double[] Times = { 1.43, 1.74, 1.73, 1.85, 1.53, 1.52, 1.73, 1.54, 2.25, 1.46 };
            for (int i = 0; i < Times.Length; i++)
            {
                Console.WriteLine(Times[i]);
            }

        }
    }
}
