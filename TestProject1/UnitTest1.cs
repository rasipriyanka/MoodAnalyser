using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMoodAnalyser()
        {
            ///Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            MoodAnalyser moodanalyzer = new MoodAnalyser();
            ///Act
            string actual = moodanalyzer.MoodAnalyzer(message);
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
