using NUnit.Framework;
using SimulatedPrecompiledCommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTestLibrary
{
  [TestFixture]
  public class OtherDummyTest : IntegrationTestBaseClass
  {
    [Test]
    public void FalseTest()
    {
      Assert.IsFalse(false);
    }
  }
}
