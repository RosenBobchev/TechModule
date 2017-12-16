using System;
using System.Globalization;
using System.Numerics;

namespace _01.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesTaken = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int goodPictures = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(picturesTaken * (goodPictures / 100.0));
            double totalPictures = (double)picturesTaken * filterTime;
            double uploadedPictures = filteredPictures * uploadTime;


            TimeSpan answer = TimeSpan.FromSeconds(totalPictures + uploadedPictures);
            Console.WriteLine(string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}", answer.Days, answer.Hours, answer.Minutes, answer.Seconds));

        }
    }
}
