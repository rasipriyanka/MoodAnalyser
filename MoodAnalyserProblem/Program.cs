using System;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            moodAnalyzer.MoodAnalyzer("I am in sad mood");
        }
    }
}
