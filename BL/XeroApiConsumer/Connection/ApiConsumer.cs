using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace XeroApiConsumer.Connection
{
    public class ApiConsumer
    {
        ApiConnector ApiConnector { get; set; }
        public ApiConsumer():this(new ApiConnector())
        {
        }
        public ApiConsumer(ApiConnector api)
        {
            this.ApiConnector = api;
        }

        public async Task<Contact> GetContactByIDAsync(Guid Id) => await ApiConnector.Api.Contacts.FindAsync(Id);

        public async Task<IEnumerable<Contact>> GetAllContacts() => await ApiConnector.Api.Contacts.FindAsync();

        public async Task<Contact> CreateCustomerAsync(Contact contact) => await ApiConnector.Api.Contacts.CreateAsync(contact);
    }
}
