// using System;
// using System.Linq;

// namespace ConsoleApp2
// {
//     class Louis
//     {
//         public static void Checkjob()
//         {
//             int age = 0;
//             string education;
//             int experience = 0;
//             bool firstCondition = false;
//             bool secondCondition = false;

//             Console.WriteLine("Enter your age : ");
//             age = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter your education : ");
//             education = Console.ReadLine();

//             Console.WriteLine("Enter your experience (years) : ");
//             experience = Convert.ToInt32(Console.ReadLine());

//             if (age >= 22 && age <= 35)
//             {
//                 if (education == "Bachelor's degree" || education == "Master's degree" || education == "Doctorate")
//                 {
//                     firstCondition = true;
//                 }
//                 if (age >= 35 && experience > 5)
//                 {
//                     secondCondition = true;
//                 }
//             }

//             if (firstCondition || secondCondition)
//             {
//                 Console.WriteLine("Pass");
//             }
//             else
//             {
//                 Console.WriteLine("Fail");
//             }
//         }

//         public static void Checkpassword()
//         {
//             string password;
//             bool isUpper;
//             bool isLower;
//             bool isDigit;
//             bool specific = false; // Initialize specific to false
//             char[] check = { '!', '@', '#', '$', '%', '^', '&', '*' };

//             Console.WriteLine("Enter your password: ");
//             password = Console.ReadLine();

//             if (password.Length >= 8)
//             {
//                 isUpper = password.Any(char.IsUpper);
//                 isLower = password.Any(char.IsLower);
//                 isDigit = password.Any(char.IsDigit);

//                 foreach (char c in password)
//                 {
//                     if (check.Contains(c))
//                     {
//                         specific = true;
//                         break;
//                     }
//                 }

//                 if (isUpper && isLower && isDigit && specific)
//                 {
//                     Console.WriteLine("Password pass");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Password fail");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Password fail");
//             }
//         }

//         public static void HolidayChecker()
//         {
//             string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//             string day;
//             bool isHoliday;
//             bool isAdditionalCompanyHoliday;

//             Console.WriteLine("Enter the day of the week (Monday-Sunday): ");
//             day = Console.ReadLine();

//             if (!daysOfWeek.Contains(day))
//             {
//                 Console.WriteLine("Invalid day of the week.");
//                 return;
//             }

//             Console.WriteLine("Is it a public holiday? (true/false): ");
//             isHoliday = Convert.ToBoolean(Console.ReadLine());

//             Console.WriteLine("Is it an additional company holiday? (true/false): ");
//             isAdditionalCompanyHoliday = Convert.ToBoolean(Console.ReadLine());

//             if (day == "Saturday" || day == "Sunday" || isHoliday || isAdditionalCompanyHoliday)
//             {
//                 Console.WriteLine("The day is a holiday.");
//             }
//             else
//             {
//                 Console.WriteLine("The day is not a holiday.");
//             }
//         }

//         public static void CalculateShippingCost()
//         {
//             double weight;
//             double cost;

//             Console.WriteLine("Enter the weight of the product in kilograms: ");
//             weight = Convert.ToDouble(Console.ReadLine());

//             if (weight <= 1)
//             {
//                 cost = 50;
//             }
//             else if (weight <= 5)
//             {
//                 cost = 100;
//             }
//             else if (weight <= 10)
//             {
//                 cost = 200;
//             }
//             else
//             {
//                 cost = 250;
//             }

//             Console.WriteLine($"The shipping cost is: {cost} Baht");
//         }

//         public static void CheckLeapYear()
//         {
//             int year;
//             bool isLeapYear = false;

//             Console.WriteLine("Enter a year (AD): ");
//             year = Convert.ToInt32(Console.ReadLine());

//             if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//             {
//                 isLeapYear = true;
//             }

//             if (isLeapYear)
//             {
//                 Console.WriteLine($"{year} is a leap year.");
//             }
//             else
//             {
//                 Console.WriteLine($"{year} is not a leap year.");
//             }
//         }

//         public static void CalculateIncomeTax()
//         {
//             double income;
//             double tax = 0;

//             Console.WriteLine("Enter your annual income (Baht): ");
//             income = Convert.ToDouble(Console.ReadLine());

//             if (income <= 150000)
//             {
//                 tax = 0;
//             }
//             else if (income <= 300000)
//             {
//                 tax = income * 0.05;
//             }
//             else if (income <= 500000)
//             {
//                 tax = income * 0.1;
//             }
//             else
//             {
//                 tax = income * 0.15;
//             }

//             Console.WriteLine($"Income tax payable: {tax} Baht");
//         }

//         public static void ConvertTemperature()
//         {
//             double temperature;
//             string unit;

//             Console.WriteLine("Enter the temperature value: ");
//             temperature = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("Enter the unit of temperature (C, F, K): ");
//             unit = Console.ReadLine().ToUpper();

//             switch (unit)
//             {
//                 case "C":
//                     Console.WriteLine($"Temperature in Fahrenheit: {temperature * 9 / 5 + 32} F");
//                     Console.WriteLine($"Temperature in Kelvin: {temperature + 273.15} K");
//                     break;
//                 case "F":
//                     Console.WriteLine($"Temperature in Celsius: {(temperature - 32) * 5 / 9} C");
//                     Console.WriteLine($"Temperature in Kelvin: {(temperature - 32) * 5 / 9 + 273.15} K");
//                     break;
//                 case "K":
//                     Console.WriteLine($"Temperature in Celsius: {temperature - 273.15} C");
//                     Console.WriteLine($"Temperature in Fahrenheit: {(temperature - 273.15) * 9 / 5 + 32} F");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid unit of temperature.");
//                     break;
//             }
//         }

//         public static void CalculateBTSFare()
//         {
//             int numStations;
//             double fare;

//             Console.WriteLine("Enter the number of BTS stations traveled: ");
//             numStations = Convert.ToInt32(Console.ReadLine());

//             if (numStations >= 1 && numStations <= 3)
//             {
//                 fare = 16;
//             }
//             else if (numStations >= 4 && numStations <= 8)
//             {
//                 fare = 23;
//             }
//             else if (numStations >= 9)
//             {
//                 fare = 31;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid number of stations.");
//                 return;
//             }

//             Console.WriteLine($"The fare for {numStations} stations is: {fare} Baht");
//         }

//         private static bool IsPrime(int number)
//         {
//             if (number < 2) return false;
//             for (int i = 2; i <= Math.Sqrt(number); i++)
//             {
//                 if (number % i == 0) return false;
//             }
//             return true;
//         }

//         public static void FindTwinPrime(int n)
//         {
//             for (int i = 1; i <= n; i++)
//             {
//                 if (IsPrime(i) && IsPrime(i + 2))
//                 {
//                     Console.WriteLine($"Twin primes: {i} and {i + 2}");
//                 }
//             }
//         }

//         public static void DrawNumber8(int height)
//         {
//             if (height % 2 == 0 || height <= 5)
//             {
//                 Console.WriteLine("Invalid height.");
//                 return;
//             }

//             int middle = height / 2;

//             for (int i = 0; i < height; i++)
//             {
//                 if (i == 0 || i == middle || i == height - 1)
//                 {
//                     Console.WriteLine(new string('*', height));
//                 }
//                 else
//                 {
//                     Console.WriteLine("*" + new string(' ', height - 2) + "*");
//                 }
//             }
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Louis.Checkjob();
//             // Louis.Checkpassword();
//             // Louis.HolidayChecker();
//             // Louis.CalculateShippingCost();
//             // Louis.CheckLeapYear();
//             // Louis.CalculateIncomeTax();
//             // Louis.ConvertTemperature();
//             // Louis.CalculateBTSFare();
//             // Louis.FindTwinPrime(100);
//             // Louis.DrawNumber8(7); // Example height
//         }
//     }
// }