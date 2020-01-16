using System;
using System.Globalization;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.Write("Hello! Please enter your name: ");
            string name = myTI.ToTitleCase(Console.ReadLine());
            Console.WriteLine("Hello, " + name +".");
            
            bool goAgain = true;
            while (goAgain == true)
            {
                int input = -1;
                while (input < 1 || input > 100)
                {
                    Console.Write("Please enter a whole number between 1 and 100: ");
                    if (int.TryParse(Console.ReadLine(), out int trytest))
                    {
                        input = trytest;
                    }
                }

                if (input % 2 != 0)
                {
                    Console.WriteLine("The number " + input + " is odd.");

                }
                else
                {
                    if (input < 25)
                    {
                        Console.WriteLine("The number " + input + " is even and less than 25.");
                    }
                    else
                    {
                        Console.WriteLine("The number " + input + " is even.");
                    }
                }
                    Console.WriteLine(name + "," + " if you would like to test another number, type 'yes'. " +
                        "Type anything else if not.");
                    string stop = Console.ReadLine();
                    if (stop.ToLower() != "yes")
                    { goAgain = false; }
            }
        }
    }
}
