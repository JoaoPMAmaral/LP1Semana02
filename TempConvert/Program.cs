using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Temperature: ");
            string temperature = Console.ReadLine();

            Console.Write("Unit(C/F): ");
            string units = Console.ReadLine();
            
            double convertedNumber;
            double temp = double.Parse(temperature);

            switch (units)
            {
                case "C":
                convertedNumber = temp * 1.8 + 32;
                Console.WriteLine($"{temperature} C = {convertedNumber:f2} F");
                break;

                case "F":
                convertedNumber = (temp-32)/1.8;
                Console.WriteLine($"{temperature} F = {convertedNumber:f2} C");
                break;
            }
        }
    }
}
