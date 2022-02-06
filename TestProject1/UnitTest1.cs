using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///Arrange
            string message = "Im in happy Mood";
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.DisplayMoodAnalyzer(message);//hear we check the mood of user is happy or sad
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
