using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfPeople);

            Console.WriteLine(courses);
        }
    }
}
