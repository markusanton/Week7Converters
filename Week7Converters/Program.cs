using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to convert celsius to fahrenheit type A.");
            Console.WriteLine("If you want to convert farenheit to celsius type B.");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice == "a")
            {
                CelsiusFahrenheit();
            }
            else if (userChoice == "b")
            {
                FahrenheitCelsius();
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
        public static void CelsiusFahrenheit()
        {
            Console.WriteLine("Enter your temperature in celsius.");
            double userInput = Double.Parse(Console.ReadLine());
            double fahrenheitResult = (userInput * 9) / 5 + 32;
            Console.WriteLine($"{userInput} celsius is {fahrenheitResult} fahrenheit.");

        }
        public static void FahrenheitCelsius()
        {
            Console.WriteLine("Enter your temperature in fahrenheit.");
            double userInput = Double.Parse(Console.ReadLine());
            double celsiusResult = (userInput - 32) * 5 / 9;
            Console.WriteLine($"{userInput} in fahrenheit is {celsiusResult} celsius.");
        }
    }
}
