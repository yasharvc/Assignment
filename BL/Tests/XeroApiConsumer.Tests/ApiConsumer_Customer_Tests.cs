using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class ApiConsumer_Customer_Tests
	{
		XeroApiConsumer.Connection.ApiConsumer ApiConsumer { get; set; }
		[SetUp]
        public void Setup()
        {
			ApiConsumer = new XeroApiConsumer.Connection.ApiConsumer();
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

		[Test]
		public void Create_Empty_Customer_invalid()
		{
			var expected = new Xero.Api.Core.Model.Contact();
			var apiConsumer = new XeroApiConsumer.Connection.ApiConsumer();

			Assert.ThrowsAsync<Xero.Api.Infrastructure.Exceptions.ValidationException>(() => apiConsumer.CreateCustomerAsync(expected));
		}

		[Test]
		public async Task Get_All_Contacts_valid()
		{
			var lst = await ApiConsumer.GetAllContactsAsync();

			Assert.IsTrue(lst.Count() > 0);
		}
    }
}