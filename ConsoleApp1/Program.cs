using System;
using System.IO;

namespace ChuckNorrisJokeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of facts");
            int username = Convert.ToInt32(Console.ReadLine());
            GetJokes(username);
        }
        private static void GetJokes(int jokesNumber)
        {
            string filePath = @"C:\Users\opilane\samples\funFacts.txt";
            string[] jokeAboutChuck = File.ReadAllLines(filePath);

            if (jokesNumber > jokeAboutChuck.Length)
            {
                jokesNumber = jokeAboutChuck.Length;
            }


            for (int i = 0; i < jokesNumber; i++)
            {
                Console.WriteLine(jokeAboutChuck[i]);
            }
        }
    }
}
