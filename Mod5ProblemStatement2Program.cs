using System;

namespace Mod5ProblemStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

                int int1, int2;
                Console.Write("\n\n");
                Console.Write("Check whether two integers are greater then 18th or not:\n");
                Console.Write("-------------------------------------------");
                Console.Write("\n\n");
                Console.Write("Enter the current time as a number between 1 and 24: ");
               int1 = Convert.ToInt32(Console.ReadLine());

                 Console.Write("Enter the number 18: ");
                 int2 = Convert.ToInt32(Console.ReadLine());

              if (int1 >= int2)
                   Console.WriteLine("Good Evening, sir\n", int1, int2);
              else
                  Console.WriteLine("maam\n", int1, int2);
        }   
    }
}
