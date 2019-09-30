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
        [TestMethod]
    public void LeetConverter_ContainsO_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("sn0w", testLeetSpeak.LeetConverter("snow"));
    }
  }
}