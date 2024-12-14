using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculator

            Console.Title = "Calculator";
            Console.WriteLine("Welcome to Calculator");

            Console.WriteLine("Enter a values");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now select a operation\n\tdiv || mul || add || sub");
            string o = Console.ReadLine();

            if (string.IsNullOrEmpty(o))
            {
                Console.WriteLine("No operator detected");
            }
            else
            {
                switch(o.ToLower())
                {
                    case "div":
                        Console.WriteLine(a / b);
                        break;

                    case "mul":
                        Console.WriteLine(a * b);
                        break;

                    case "add":
                        Console.WriteLine(a + b);
                        break;

                    case "sub":
                        Console.WriteLine(a - b);
                        break;
                }
            }

            Console.ReadLine();
        
        }
    }
}