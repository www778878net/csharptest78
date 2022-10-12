namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t=nugettest.Class1.add(3, 2);
            Assert.IsTrue(t == 5);
        }
    }
}