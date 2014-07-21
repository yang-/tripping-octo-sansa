namespace CITesting
{
    using CIBackend;

    using NUnit.Framework;

    [TestFixture]
    public class MyCounterTests
    {
        private CounterLogic _counter;

        [SetUp]
        public void InitBusinessLogic()
        {
            _counter = new CounterLogic(100);
        }

        [Test]
        public void BusinessLogicDecrementation()
        {
            _counter.Decrement();

            // Assert
            Assert.AreEqual(100, _counter.Counter);
        }

        [Test]
        public void BusinessLogicIncrementation()
        {
            _counter.Increment();
            Assert.AreEqual(101, _counter.Counter);
        }

        [Test]
        public void BusinessLogicInstantiation()
        {

            Assert.AreEqual(100, _counter.Counter);
        }
    }
}
