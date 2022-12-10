using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinacion = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int singleNightPrice = 0;

            if (destinacion == "France")
            {
                switch (dates)
                {
                    case "21-23":
                        singleNightPrice = 30; break;
                    case "24-27":
                        singleNightPrice = 35; break;
                    case "28-31":
                        singleNightPrice = 40; break;
                }
            }
            else if (destinacion == "Italy")
            {
                switch (dates)
                {
                    case "21-23":
                        singleNightPrice = 28; break;
                    case "24-27":
                        singleNightPrice = 32; break;
                    case "28-31":
                        singleNightPrice = 39; break;
                }
            }
            else if (destinacion == "Germany")
            {
                switch (dates)
                {
                    case "21-23":
                        singleNightPrice = 33; break;
                    case "24-27":
                        singleNightPrice = 37; break;
                    case "28-31":
                        singleNightPrice = 43; break;
                }
            }
            int totalSum = singleNightPrice * nights;

            Console.WriteLine($"Easter trip to Germany : {totalSum:f2} leva.");
        }
    }
}
