using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  // All tests go into this class. //
  [TestClass]
  public class PingPongTests
  {
    // First test method to check for number being divisible by 5. //
    [TestMethod]
    public void IsPing_PingDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPing(25));
    }
    // Second test method to check for number being divisible by 3. //
    [TestMethod]
    public void IsPong_PongDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPong(12));
    }
    // Third test method to check for number being by 3 and 5. //
    [TestMethod]
    public void IsPingPong_PingPongDivisibleByThreeAndFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual(true, testPingPong.IsPingPong(15));
    }
  }
}