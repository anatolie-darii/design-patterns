using DesignPatterns.Proxy;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.Proxy
{
    [TestClass]
    public class ProxyTests
    {
        private readonly ISubject sut = new DesignPatterns.Proxy.Proxy();

        [TestMethod]
        public void ShouldDoActionByRealSubject()
        {
            const string Expected = "Message send by subject";
            var actual = this.sut.DoAction("Message");

            Assert.AreEqual(Expected, actual);
        }
    }
}