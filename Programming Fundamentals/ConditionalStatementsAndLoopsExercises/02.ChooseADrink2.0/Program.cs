using System;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = (Console.ReadLine());
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (profession == "Athlete")
            {
               
                price = quantity * 0.70;
            }
            else if (profession == "Businessman")
            {
                
                price = quantity * 1.00;
            }
            else if (profession == "Businesswoman")
            {
                
                price = quantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                
                price = quantity * 1.70;
            }
            else
            {
                
                price = quantity * 1.20;
            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
