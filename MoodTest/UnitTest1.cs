using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationSystem;


//UC 9 Test

namespace UserRegistrationSystem
{
    [TestClass]
    public class MoodTest
    {

        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SaD";
            string message = " I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow("Iam in Happy Mood")]

        public void GivenHappyShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string mood = moodAnalyser.AnalyserMood();

            Assert.AreEqual(expected, mood);
        }

    }
}
