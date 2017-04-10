using OtherTestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestLibraryMain
{
    //public class InheritsFromOtherDummyTest : OtherDummyTest
    //{
    //}

    public class InheritsFromOtherDummyTestOnly : OnlyHereInOtherTest
    {
        [Test]
        public void TestInInheritedClass()
        {
            Assert.Pass();
        }

    }
}
