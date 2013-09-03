namespace CITesting
{
    using CIBackend;

    using NUnit.Framework;

    [TestFixture]
    public class MyCounterTests
    {
        private MyCounter myCounter;

        [SetUp]
        public void InitBusinessLogic()
        {
            myCounter = new MyCounter(100);
        }

        [Test]
        public void BusinessLogicDecrementation()
        {
            myCounter.Decrement();

            // Assert
            Assert.AreEqual(99, myCounter.Counter);
        }

        [Test]
        public void BusinessLogicIncrementation()
        {
            myCounter.Increment();
            Assert.AreEqual(101, myCounter.Counter);
        }

        [Test]
        public void BusinessLogicInstantiation()
        {

            Assert.AreEqual(100, myCounter.Counter);
        }
    }
}
