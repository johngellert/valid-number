using System;

namespace valid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                
                Console.WriteLine("Enter any number between 1 and 10:");

                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine((number > 0 && number <= 10) ? "Valid" : "Invalid");

                Console.WriteLine("Enter x to quit palying");
                keepPlaying = (Console.ReadLine()) != "x" ? true : false ;
            }
        }      
    }
}

