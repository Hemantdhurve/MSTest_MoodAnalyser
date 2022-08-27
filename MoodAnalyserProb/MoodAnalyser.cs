using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProb
{
    public class MoodAnalyser
    {
        //Refactor to take message in Constructor
        public string message;
        public MoodAnalyser()
        {
                
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {

                if (message.ToUpper().Contains("SAD"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(Exception ex)
            {
                return "Happy";
            }  
        }  
    }
}
