// project: calculatorApp
// version: 1.0
// author: almasa
using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberone, numbertow;

            Console.WriteLine("enter number one!");
          numberone = double.Parse( Console.ReadLine());
            Console.WriteLine("enter number two!");
          numbertow= double.Parse( Console.ReadLine());

            Console.WriteLine("choose an operation:");
            Console.WriteLine("1-addition");
            Console.WriteLine("2-subtraction");
            Console.WriteLine("3-multiplication");
            Console.WriteLine("4-division");
            double choice;
            choice = double.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.WriteLine("correct choice");
            }
            else { Console.WriteLine("incorrect choice"); }
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine(numberone + numbertow);
                    break;
                case 2:
                    Console.WriteLine(numberone - numbertow);
                    break;
                case 3:
                    Console.WriteLine(numberone * numbertow);
                    break;
                case 4:
                    Console.WriteLine(numberone / numbertow);
                    if (numbertow == 0)
                    {
                        Console.WriteLine("cannot divide by zero!");
                    }
                    break;
            }
            return;
            
        }
    }
}