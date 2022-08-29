using MoodAnalyserProb;

namespace MSTest_MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        //Test Case 1.1  Given I am in Sad Mood Message Should return Sad Mood

        [TestMethod]
        public void GivenSADMood_ShouldReturnSAD()
        {

            //Arrange

            string message = "I am in Sad Mood";
            MoodAnalyser obj = new MoodAnalyser(message);

            string expected = "Sad";

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(expected, actual);
        }


        //Test Case 1.2  Given I am in Happy Mood Message Should return Happy Mood

        [TestMethod]
        public void GivenHappyMoodMessage_ShouldReturnHAPPY()
        {

            //Arrange

            string message = "I am in Happy Mood";
            MoodAnalyser obj = new MoodAnalyser(message);

            string expected = "Happy";

            //Act

            string actual = obj.AnalyseMood();

            //Assert

            Assert.AreEqual(expected, actual);
        }

        //Test Case 2.1 Given Null Mood Should Return Happy

        //[TestMethod]
        //public void GivenNullMood_ShouldReturnHAPPY()
        //{

        //    //Arrange

        //    string message = null;
        //    MoodAnalyser obj = new MoodAnalyser(message);

        //    //Act

        //    string actual = obj.AnalyseMood();

        //    //Assert

        //    Assert.AreEqual(actual, "Happy");
        //}

        //UC3 Given Null or Empty Message when Analyse Should Return Exception HandleMessage

        [TestMethod]

        public void GivenNullorEmptyMessage_ShouldReturnExceptionHandleMessage()
        {
            //Arrange
            string message = "";
            MoodAnalyser obj = new MoodAnalyser(message);
            string expected = "Mood Should Not Be Empty";

            //Act
            string actual = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test Case 3.1 Given Null Mood Should throw MoodAnalysis Exception

        [TestMethod]
        public void GivenNullMood_ShouldthrowMoodAnalysisException_IndicatingNullMood()
        {
            try
            {
                //Arrange
                MoodAnalyser obj = new MoodAnalyser("null");
                //Act
                string actual = obj.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Null", e.Message);
            }
        }

        //Test Case 3.2 Given Empty Mood Should throw MoodAnalysis Exception

        [TestMethod]
        public void GivenEmptyMood_ShouldthrowMoodAnalysisException_IndicatingEmptyMood()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyser obj = new MoodAnalyser(message);
               
                //Act
                string actual = obj.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Mood Should Not Be Empty", e.Message);
            }
        }

        //Test Case 4.1 Given MoodAnalyser ClassName should return object of MoodAnalyser

        [TestMethod]
        public void GivenAnalyseMoodClassName_ShouldreturnMoodAnalyseObject()
        {
            //Arrange

            object expected = new MoodAnalyser();

            //Act
            object factory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProb.MoodAnalyser");

            //Assert

            Assert.AreNotEqual(expected, factory);
        }
    }
}