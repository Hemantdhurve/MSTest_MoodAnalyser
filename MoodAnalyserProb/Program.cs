using System;

namespace MoodAnalyserProb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");

            //Creating object of MoodAnalyser class

            MoodAnalyser moodobj=new MoodAnalyser();

            Console.WriteLine("Enter your Mood:");
            string message=Console.ReadLine();

            Console.WriteLine(moodobj.AnalyseMood(message));
        }
    }
}