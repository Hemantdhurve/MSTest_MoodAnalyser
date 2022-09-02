using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProb
{
    //UC6 
    public class MoodAnalyserReflector
    {
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserProb.MoodAnalyser");
                object moodAanalyseObject = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProb.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAanalyseObject, null);
                return mood.ToString();

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "No Such Method Found");
            }
        }
    }
}
