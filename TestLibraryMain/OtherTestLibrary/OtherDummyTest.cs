using NUnit.Framework;

namespace OtherTestLibrary
{
  [TestFixture]
  public class OtherDummyTest 
  {
    [Test]
    public void FalseTest()
    {
      Assert.IsFalse(false);
    }
  }
}
