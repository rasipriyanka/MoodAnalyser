using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string Message;
        //Creating a constructer 
        public string  MoodAnalyzer(string message) 
            {
                Message = message;
                if (Message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
        }
    }


