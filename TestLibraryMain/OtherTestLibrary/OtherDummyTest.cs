using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
