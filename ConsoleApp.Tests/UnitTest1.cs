using NUnit.Framework;
using ConsoleApp;

namespace Tests
{
    internal class Tests
    {
        private MyClass my;

        [SetUp]
        public void Setup() => this.my = new MyClass();

        [Test]
        public void Test1() => Assert.Equals(this.my.IsAlwaysTrue(), false);
    }
}
