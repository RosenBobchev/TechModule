using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            int packagePrice = 0;
            double discount = 0;
            int hallPrice = 0;
            int totalPrice = 0;
            string hallName = "";

            switch (package)
            {
                case "normal": discount = 0.95; packagePrice = 500; break;
                case "gold": discount = 0.90; packagePrice = 750; break;
                case "platinum": discount = 0.85; packagePrice = 1000; break;

            }
            if (count > 0 && count <= 120)
            {
                if (count <= 50)
                {
                    hallPrice = 2500;
                    hallName = "Small Hall";

                }
                else if (count <= 100)
                {
                    hallPrice = 5000;
                    hallName = "Terrace";

                }
                else if (count <= 120)
                {
                    hallPrice = 7500;
                    hallName = "Great Hall";

                }
                totalPrice = hallPrice + packagePrice;
                double finalPrice = totalPrice * discount;
                double pricePerPerson = finalPrice / count;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

