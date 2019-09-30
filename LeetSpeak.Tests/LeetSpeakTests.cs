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
    [TestMethod]
    public void LeetConverter_ContainsCapitalI_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("1ggy", testLeetSpeak.LeetConverter("Iggy"));
    }
    [TestMethod]
    public void LeetConverter_ContainsT_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("s7y", testLeetSpeak.LeetConverter("sty"));
    }
    [TestMethod]
    public void LeetConverter_ContainsS_True()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("burri70z", testLeetSpeak.LeetConverter("burritos"));
    }
  }
}