using Day10Assignment2.Singleton;

namespace Day10Assignment2.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_OnlyOneInstanceExists()
        {
            var instance1 = Logger.GetInstance();
            var instance2 = Logger.GetInstance();

            Assert.Same(instance1, instance2);
        }
    }
}