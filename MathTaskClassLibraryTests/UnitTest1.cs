using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab10;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //Исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //Получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // Сравнение актуального рузультата с тестируемым
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RectangleAreaCelind_3and5_15returned()
        {
            //Исходные данные
            int a = 3;
            int b = 5;
            double expected = 141.37;

            //Получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            double actual = g.RectangleAreaCelindr(a, b);

            // Сравнение актуального рузультата с тестируемым
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestManagent()
        {
            Management man = new Management();

            double[] test1 = man.SlovingQuadEquation(1, 1, 1); // d < 0 return null
            double[] test2 = man.SlovingQuadEquation(1, -6, 9); // d = 0 return x1 = 3
            double[] test3 = man.SlovingQuadEquation(.8, 2.8, 2); // d > 0 return x1 = -2.499999999999999 x2 = -1.0000000000000002

            Assert.AreEqual(test1, null);
            Assert.AreEqual(3, test2[0]);
            Assert.AreEqual(-2.499999999999999, test3[0]);
            Assert.AreEqual(-1.0000000000000002, test3[1]);
        }
        [TestMethod]
        public void TestFailManagent()
        {
            Management man = new Management();

            double[] test1 = man.SlovingQuadEquation(1, 1, 2); // d < 0 return !null
            double[] test2 = man.SlovingQuadEquation(1, -16, 9); // d = 0 return x1 != 3
            double[] test3 = man.SlovingQuadEquation(4.8, 2.8, 2); // d > 0 return x1 != -2.499999999999999 x2 = -1.0000000000000002

            Assert.AreEqual(test1, null);
            Assert.AreEqual(3, test2[0]);
            Assert.AreEqual(-2.499999999999999, test3[0]);
            Assert.AreEqual(-1.0000000000000002, test3[1]);
        }
    }
}
