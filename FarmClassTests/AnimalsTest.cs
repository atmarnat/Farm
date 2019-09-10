using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;

namespace FarmClassTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHorse()
        {
            Horse h1 = new Horse(); h1.Name ="Frank";
            Horse h2 = new Horse(); h2.Name ="Bob";

            Assert.AreEqual("Frank", h1.Name);
            Assert.AreEqual("Bob", h2.Name);
        }
        public void TestPig()
        {
            Pig p1 = new Pig();
            Assert.AreEqual("pig", p1.Type);
        }
        public void TestChicken()
        {
            Chicken c1 = new Chicken();
            Assert.AreEqual(2, c1.Legs);
        }
        public void TestSheep()
        {
            Sheep s1 = new Sheep();
            Assert.AreEqual("white", s1.Color);
        }
    }
}
