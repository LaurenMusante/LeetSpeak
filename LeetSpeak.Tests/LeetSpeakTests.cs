using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void LeetConverter_ContainsE_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("appl3", testLeetSpeak.LeetConverter("apple"));
    }
  }
}