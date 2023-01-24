using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// test for circle area
        /// </summary>
        [TestMethod]
        public void TestCircle()
        {
            var fig = new FigureCalc(2);

            double expected = 12.56;

            Assert.AreEqual(expected, fig.result);

        }
        /// <summary>
        /// test for triangle area
        /// </summary>
        [TestMethod]
        public void TestTriangle()
        {
            var fig = new FigureCalc(2, 4, 5);

            double expected = 6;

            Assert.AreEqual(expected, fig.result);

        }
        /// <summary>
        /// test for triangle type
        /// </summary>
        [TestMethod]
        public void TestTriangleType()
        {
            var fig = new FigureCalc(2, 4, 5);

            string expected = "right";

            Assert.AreEqual(expected, fig.type);

        }
    }
}
