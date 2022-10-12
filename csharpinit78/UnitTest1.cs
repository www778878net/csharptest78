namespace csharpinit78
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = Class1.add(3, 2);

            Assert.AreEqual(5, test);
        }
    }
}