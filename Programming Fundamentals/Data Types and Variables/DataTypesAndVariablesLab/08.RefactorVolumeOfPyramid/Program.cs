using System;

namespace _08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, V = 0, height;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            V = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}
