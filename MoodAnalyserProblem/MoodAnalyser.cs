using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string Message;
        public string DisplayMoodAnalyzer(string message) //Creating a constructer 
        {
            Message = message;
            if (Message.ToLower().Contains("happy"))
            {
                return "Happy";
            }
            else
            {
                return "Sad";
            }
        }
    }
}

