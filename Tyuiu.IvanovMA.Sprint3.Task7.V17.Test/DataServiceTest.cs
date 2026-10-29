
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IvanovMA.Sprint3.Task7.V17.Lib;

namespace Tyuiu.IvanovMA.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] expected =
            {
                -0.62,
                -16.79,
                -17.77,
                -6.30,
                -5.04,
                -6.00,
                -7.85,
                -2.43,
                5.91,
                4.33,
                -11.82
            };

            double[] actual =
                ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.001);
            }
        }
    }
}
