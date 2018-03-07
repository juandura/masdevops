namespace arkano.taller.test
{
    using arkano.taller.core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HomeTest
    {
        [TestMethod]
        [DataRow(100)]
        public void Test01(int value)
        {
            Assert.IsTrue(value > 0);
            Assert.IsFalse(string.IsNullOrEmpty(new Home().Text));
        }

        [TestMethod]
        public void Test02()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test03()
        {
            Assert.IsFalse(false);
        }
    }
}
