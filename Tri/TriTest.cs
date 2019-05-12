using System;
using NUnit.Framework;

namespace Tri
{
    [TestFixture]
    public class TriTest
    {
        public Tri Tringle;
        [SetUp]
        public void SetUp()
        {
            Tringle = new Tri();
        }

        [Test]
        public void NotTriangle()
        {
            Assert.AreEqual("not triangle", Tringle.getType(1, 2, 3));
        }
    }
}
