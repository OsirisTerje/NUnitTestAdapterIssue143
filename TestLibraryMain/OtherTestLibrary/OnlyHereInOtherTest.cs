using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OtherTestLibrary
{
    public abstract class OnlyHereInOtherTest
    {
        [Test]
        public void FalseTestWithNoInherit()
        {
            Assert.IsFalse(false);
        }
    }
}
