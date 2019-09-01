using DataModels;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace Tests
{
    public class ApiConsumer_Invoice_Tests
	{
		XeroApiConsumer.Connection.ApiConsumer ApiConsumer { get; set; }
		[SetUp]
        public async Task Setup()
        {
			ApiConsumer = new XeroApiConsumer.Connection.ApiConsumer();
		}
		
		[Test]
		public async Task Get_All_Invoices_valid()
		{
			var lst = await ApiConsumer.GetAllInvoicesAsync();
			Assert.IsTrue(lst.Count() > 0);
		}
	}
}