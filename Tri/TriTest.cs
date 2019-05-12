using System;
using NUnit.Framework;

namespace Tri
{
    [TestFixture]
    public class TriTest
    {
        public Tri Triangle;
        [SetUp]
        public void SetUp()
        {
            Triangle = new Tri();
        }

        [Test]
        [TestCase(1,2,3)]
        [TestCase(1,1,3)]
        public void NotTriangle(int edge1, int edge2, int edge3)
        {
            Assert.AreEqual("not triangle", Triangle.GetType(edge1, edge2, edge3));
        }

        [Test]
        public void RegularTriangle()
        {
            Assert.AreEqual("regular triangle", Triangle.GetType(3, 3, 3));
        }

        [Test]
        public void IsoscelesTriangle()
        {
            Assert.AreEqual("acute isosceles triangle", Triangle.GetType(3, 3, 2));
            Assert.AreEqual("obtuse isosceles triangle", Triangle.GetType(3, 3, 5));
        }

        [Test]
        public void ObtuseTriangle()
        {
            Assert.AreEqual("obtuse triangle", Triangle.GetType(3, 4, 6));
        }

        [Test]
        public void AcuteTriangle()
        {
            Assert.AreEqual("acute triangle", Triangle.GetType(10, 19, 21));
        }

        [Test]
        public void RightTriangle()
        {
            Assert.AreEqual("right triangle", Triangle.GetType(3, 4, 5));
        }

        [Test]
        [TestCase(3, 4, 5)]
        [TestCase(3, 5, 4)]
        [TestCase(4, 3, 5)]
        [TestCase(4, 5, 3)]
        [TestCase(5, 4, 3)]
        [TestCase(5, 3, 4)]
        public void SwapInputOrder(int edge1, int edge2, int edge3)
        {
            Assert.AreEqual("right triangle", Triangle.GetType(edge1, edge2, edge3));
        }

        [Test]
        public void InputNearIntegerMax()
        {
            Assert.AreEqual("regular triangle", Triangle.GetType(int.MaxValue, int.MaxValue, int.MaxValue));
            Assert.AreEqual("acute isosceles triangle", Triangle.GetType(int.MaxValue-1, int.MaxValue-1, int.MaxValue));
            Assert.AreEqual("not triangle", Triangle.GetType(unchecked(int.MaxValue + 1), int.MaxValue - 1, int.MaxValue));
            Assert.AreEqual("acute triangle", Triangle.GetType(int.MaxValue -2, int.MaxValue - 1, int.MaxValue));
        }


        [Test]
        [TestCase(-1,0,1)]
        [TestCase(-1,-2,-3)]
        [TestCase(-1,-2,0)]
        [TestCase(0,0,0)]
        public void InvalidInput(int edge1, int edge2, int edge3)
        {
            Assert.AreEqual("not triangle", Triangle.GetType(edge1, edge2, edge3));
        }
    }
}
