using System;

namespace ConsoleApp1
{
    class Patiwat
    {
        public static void TemperatureConverter(string[] args)
        {
            Console.WriteLine("Enter temperature value: ");
            int temperature = int.Parse(Console.ReadLine());
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Patiwat.TemperatureConverter(args);
            }
        }
    }
}