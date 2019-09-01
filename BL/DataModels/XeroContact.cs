using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using Xero.Api.Core.Model;

namespace DataModels
{
    public class XeroContact
    {
		public static implicit operator XeroContact(Contact c)
		{
			var res = new XeroContact
			{
				Id = c.Id,
				ContactStatus = c.ContactStatus.GetEnumMemberValue(),
				Name = c.Name,
				ContactNumber = c.ContactNumber,
				FirstName = c.FirstName,
				LastName = c.LastName,
				EmailAddress = c.EmailAddress,
				SkypeUserName = c.SkypeUserName,
				BankAccountDetails = c.BankAccountDetails,
				TaxNumber = c.TaxNumber,
				AccountsReceivableTaxType = c.AccountsReceivableTaxType,
				AccountsPayableTaxType = c.AccountsPayableTaxType,
				IsSupplier = c.IsSupplier,
				IsCustomer = c.IsCustomer,
				DefaultCurrency = c.DefaultCurrency,
				Website = c.Website,
				Discount = c.Discount,
				XeroNetworkKey = c.XeroNetworkKey,
				HasAttachments = c.HasAttachments,
				PurchaseAccountCode = c.PurchaseAccountCode,
				SalesAccountCode = c.SalesAccountCode,
				SalesTrackingCategories = JsonConvert.SerializeObject(c.SalesTrackingCategories),
				PurchasesTrackingCategories = JsonConvert.SerializeObject(c.PurchasesTrackingCategories),
				BrandingTheme = JsonConvert.SerializeObject(c.BrandingTheme),
				BatchPayments = JsonConvert.SerializeObject(c.BatchPayments),
				Balances = JsonConvert.SerializeObject(c.Balances),
				PaymentTerms = JsonConvert.SerializeObject(c.PaymentTerms),
				ContactPersons = JsonConvert.SerializeObject(c.ContactPersons),
				Addresses = JsonConvert.SerializeObject(c.Addresses),
				Phones = JsonConvert.SerializeObject(c.Phones),
				ContactGroups = JsonConvert.SerializeObject(c.ContactGroups),
				AccountNumber = c.AccountNumber

			};
			return res;
		}
        [DataMember(Name = "ContactID")]
        public Guid Id { get; set; }
        public string ContactStatus { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SkypeUserName { get; set; }
        public string BankAccountDetails { get; set; }
        public string TaxNumber { get; set; }
        public string AccountsReceivableTaxType { get; set; }
        public string AccountsPayableTaxType { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsCustomer { get; set; }
        public string DefaultCurrency { get; set; }
        public string Website { get; set; }
        public decimal? Discount { get; set; }
        public string XeroNetworkKey { get; set; }
        public bool? HasAttachments { get; set; }
        public string PurchaseAccountCode { get; set; }
        public string SalesAccountCode { get; set; }
        public string SalesTrackingCategories { get; set; }
        public string PurchasesTrackingCategories { get; set; }
        public string BrandingTheme { get; set; }
        public string BatchPayments { get; set; }
        public string Balances { get; set; }
        public string PaymentTerms { get; set; }
        public string ContactPersons { get; set; }
        public string Addresses { get; set; }
        public string Phones { get; set; }
        public string ContactGroups { get; set; }
        public string AccountNumber { get; set; }
    }
}