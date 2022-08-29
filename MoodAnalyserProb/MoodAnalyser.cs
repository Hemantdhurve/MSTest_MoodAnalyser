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
        string className;
        string constructorName;
        public MoodAnalyser()
        {
                
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser(string className,string constructorName)
        {

        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");

                }
                if (message.ToUpper().Contains("SAD"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
           
            catch(MoodAnalyserCustomException obj)
            {
                //return "Mood Should Not Be Empty";
                string exception = obj.Message;
                return exception;
            }
        }  
    }
}
