using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPictures = int.Parse(Console.ReadLine());
            int timeForFiltering = int.Parse(Console.ReadLine());
            int goodPictures = int.Parse(Console.ReadLine());
            int timeForUploading = int.Parse(Console.ReadLine());


            double filterPicture = Math.Ceiling(countPictures * (goodPictures / 100.0));
            double firstAnswer = (double)countPictures * timeForFiltering;
            double secondAnswer = filterPicture * timeForUploading;
            double answer = firstAnswer + secondAnswer;

            TimeSpan time = TimeSpan.FromSeconds(answer);
            string totalTime = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(totalTime);
        }
    }
}
