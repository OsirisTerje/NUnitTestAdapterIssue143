using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OtherTestLibrary
{
    public class OnlyHereInOtherTest
    {
        [Test]
        public void FalseTestWithNoInherit()
        {
            Assert.IsFalse(false);
        }
    }
}
