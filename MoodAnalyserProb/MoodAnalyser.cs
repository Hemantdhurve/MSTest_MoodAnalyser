using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProb
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }
        }
    }
}
