using NUnit.Framework;

namespace Tests
{
    public class ApiConnectorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Connection_is_ok_valid() => new XeroApiConsumer.Connection.ApiConnector();
    }
}