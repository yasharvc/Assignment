using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApiConsumer.Model
{
    public class XContact : Xero.Api.Core.Model.Contact
    {
        //public new List<ValidationError> Errors { get; set; }
        //public new List<Warning> Warnings { get; set; }
        public new ICollection<SalesTrackingCategory> SalesTrackingCategories { get; set; }
        public new ICollection<PurchasesTrackingCategory> PurchasesTrackingCategories { get; set; }
        public new Balances Balances { get; set; }
        public new BatchPaymentContactDefaults BatchPayments { get; set; }
        public new PaymentTerms PaymentTerms { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public new ICollection<Address> Addresses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public new List<Phone> Phones { get; set; }
        public new List<ContactGroup_Contact> ContactGroups { get; set; }
    }
}

