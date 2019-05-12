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
            Assert.AreEqual("not triangle", Tringle.GetType(1, 2, 3));
        }

        [Test]
        public void RegularTriangle()
        {
            Assert.AreEqual("regular triangle", Tringle.GetType(3, 3, 3));
        }

        [Test]
        public void IsoscelesTriangle()
        {
            Assert.AreEqual("acute isosceles triangle", Tringle.GetType(3, 3, 2));
            Assert.AreEqual("acute isosceles triangle", Tringle.GetType(3, 3, 4));
        }

        [Test]
        public void ObtuseTriangle()
        {
            Assert.AreEqual("obtuse triangle", Tringle.GetType(3, 4, 6));
        }

        [Test]
        public void AcuteTriangle()
        {
            Assert.AreEqual("acute triangle", Tringle.GetType(10, 19, 21));
        }
    }
}
