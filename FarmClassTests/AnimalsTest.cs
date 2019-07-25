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
            Horse h1 = new Horse(); h1.SetName("Frank");
            Horse h2 = new Horse(); h2.SetName("Bob");

            Assert.AreEqual("Frank", h1.GetName());
            Assert.AreEqual("Bob", h2.GetName());
        }
        public void TestPig()
        {
            Pig p1 = new Pig();
            Assert.AreEqual("pig", p1.GetAnimal());
        }
        public void TestChicken()
        {
            Chicken c1 = new Chicken();
            Assert.AreEqual(2, c1.GetNumLegs());
        }
        public void TestSheep()
        {
            Sheep s1 = new Sheep();
            Assert.AreEqual("white", s1.GetColor());
        }
    }
}
