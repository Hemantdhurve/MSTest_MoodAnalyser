using MoodAnalyserProb;

namespace MSTest_MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        //Test Case 1.1  Given I am in Sad Mood Should return Sad Mood

        [TestMethod]
        public void TestMethod1()
        {

            //Arrange

            MoodAnalyser obj = new MoodAnalyser();
            
            string message = "I am in Sad Mood";                 //we can also pass this message directly in the object

            string expected = "Sad Mood";

            //Act

            string actual=obj.AnalyseMood(message);

            //Assert

            Assert.AreEqual(expected, actual);
        }


        //Test Case 1.2  Given I am in Any Mood Should return Happy Mood

        [TestMethod]
        public void TestMethod2()
        {

            //Arrange

            MoodAnalyser obj = new MoodAnalyser();

            string message = "I am in Any Mood";                 //we can also pass this message directly in the object

            string expected = "Happy Mood";

            //Act

            string actual = obj.AnalyseMood(message);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}