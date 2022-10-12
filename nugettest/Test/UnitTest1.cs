using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nugettinit78.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = nugettest.Class1.add(3, 2);
            Assert.IsTrue(t == 6);
        }
    }
}