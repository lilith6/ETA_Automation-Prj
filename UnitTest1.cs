namespace ETA_Automation_Prj
{
    [TestFixture]
    public class ExampleTests
    {
        private int _sharedValue;

        [SetUp]
        public void Setup()
        {
            _sharedValue = 10;
            Console.WriteLine("Setup shared value.");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(10, _sharedValue);
        }

        [Test]
        public void Test2()
        {
            _sharedValue += 5;
            Assert.AreEqual(15, _sharedValue);
        }
    }
}