using System;

namespace _07.CakeIngrediends
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = (Console.ReadLine());
            var ingredientsCount = 0;

            while (ingredient != "Bake!")
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = (Console.ReadLine());
            }
            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}
