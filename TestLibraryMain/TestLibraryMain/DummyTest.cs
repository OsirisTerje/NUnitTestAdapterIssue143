using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryMain
{
  [TestFixture]
  public class DummyTest
  {
    [Test]
    public void TestTruth()
    {
      Assert.IsTrue(true);
    }
  }
}
