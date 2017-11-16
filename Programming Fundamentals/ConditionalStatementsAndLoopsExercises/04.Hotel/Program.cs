using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = (Console.ReadLine());
            var nightsCount = int.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50; doublePrice = 65; suitePrice = 75;
                    break;
                case "June":
                case "September":
                    studioPrice = 60; doublePrice = 72; suitePrice = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68; doublePrice = 77; suitePrice = 89;
                    break;
            }
            if ((month == "May" || month == "October") && nightsCount > 7)
            {
                studioPrice *= 0.95;
            }
            else if ((month == "June" || month == "September") && nightsCount > 14)
            {
                doublePrice *= 0.9;
            }
            else if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                suitePrice *= 0.85;
            }

            double endStudioPrice = studioPrice * nightsCount;
            double endDoublePrice = doublePrice * nightsCount;
            double endSuitePrice = suitePrice * nightsCount;

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                endStudioPrice -= studioPrice;
            }
            Console.WriteLine($"Studio: {endStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {endDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {endSuitePrice:F2} lv.");
        }
    }
}
