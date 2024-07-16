using System;

namespace ConsoleApp1
{
    class Patiwat
    {
        public static void TemperatureConverter(string[] args)
        {
            double temperature;
            char unit;
            char targetUnit;
            double convertedTemp;

            Console.WriteLine("Enter temperature value: ");
            temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit of the given temperature (C/F/K): ");
            unit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Enter the unit to convert to (C/F/K): ");
            targetUnit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            convertedTemp = ConvertTemperature(temperature, unit, targetUnit);

            Console.WriteLine($"The converted temperature is {convertedTemp} {targetUnit}");
        }

        static double ConvertTemperature(double temp, char fromUnit, char toUnit)
        {
            if (fromUnit == toUnit)
                return temp;

            double tempInCelsius = fromUnit switch
            {
                'F' => (temp - 32) * 5 / 9,
                'K' => temp - 273.15,
                'C' => temp,
                _ => throw new ArgumentException("Invalid unit")
            };

            return toUnit switch
            {
                'F' => tempInCelsius * 9 / 5 + 32,
                'K' => tempInCelsius + 273.15,
                'C' => tempInCelsius,
                _ => throw new ArgumentException("Invalid unit")
            };
        }

        public static void SimpleCalculator(string[] args)
        {
            double num1;
            double num2;
            char operation;
            double result;

            Console.WriteLine("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /): ");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }

        public static double PerformOperation(double num1, double num2, char operation)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        result = double.NaN; // Not a Number
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    result = double.NaN; // Not a Number
                    break;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Patiwat.TemperatureConverter(args);
            Patiwat.SimpleCalculator(args);
        }
    }
}