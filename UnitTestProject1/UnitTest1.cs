using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] c = { 3, 0, 51, 15, 4, 0 };
            int result = Lab_2.Program.maxElement(c);
            Assert.AreEqual(2, result);
            int res = Lab_2.Program.suma(c);
            Assert.AreEqual(70, res);
        }
    }
}
