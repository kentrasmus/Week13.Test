using System;
using System.IO;

namespace rakendus_Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\toyota.txt";
            string userFile = Console.ReadLine();
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"{userFile} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} does not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created.");
                File.Create(fullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}.");
            }
            else
            {
                File.Create(fullFilePath);
                Console.WriteLine($"{userFile}.txt has been created in {rootDirectory}.");
            }

        }
    }
}
