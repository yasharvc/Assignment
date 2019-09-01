using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests
{
    public class ApiConsumerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Create_A_Customer_valid()
        {
            var expected = new Xero.Api.Core.Model.Contact
            {
                Name = $"TestCustomer{Guid.NewGuid().ToString()}"
            };
            var apiConsumer = new XeroApiConsumer.Connection.ApiConsumer();

            expected = await apiConsumer.CreateCustomerAsync(expected);
            var customerFromAPI = await apiConsumer.GetContactByIDAsync(expected.Id);

            Assert.AreEqual(expected.Id, customerFromAPI.Id);
            Assert.AreEqual(expected.Name, customerFromAPI.Name);

            //There is no way to remove created customer
        }
    }
}