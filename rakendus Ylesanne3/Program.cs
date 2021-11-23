using System;
using System.Collections.Generic;
using System.IO;




namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            string starsPath = @"C:\Users\opilane\samples\samples\stars.txt";
            string planetsPath = @"C:\Users\opilane\samples\samples\planets.txt";
            string MilkyWayPath = @"C:\Users\opilane\samples\samples\MilkyWay.txt";
            List<string> star = new List<string>();
            List<string> planets = new List<string>();
            string[] sourceData = File.ReadAllLines(MilkyWayPath);
            foreach(string element in sourceData)
            {
                if (element.Contains("star"))
                {
                    star.Add(element);
                }
                if (element.Contains("planet"))
                {
                    planets.Add(element);
                }
                File.WriteAllLines(starsPath, star);
                File.WriteAllLines(planetsPath, planets);
            }
        }  
    }
}