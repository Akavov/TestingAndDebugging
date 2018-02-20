using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Matrix.Matrix m;

        [TestMethod]
        public void TestMethod1()
        {
            m = new Matrix.Matrix(2, 2);
            int a = 8;
            int b;
            m.setMatrixCons();
            b = m.getNumber(0, 0);

            Assert.AreEqual(a, b);


        }
    }
}
