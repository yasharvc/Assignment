using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Core.Model;

namespace ApiConsumer.Model
{
    public class SalesTrackingCategory : TrackingCategory { }
    public class PurchasesTrackingCategory : TrackingCategory { }


    public class Balance : Xero.Api.Core.Model.Balance
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }

    public class BatchPaymentContactDefaults : Xero.Api.Core.Model.BatchPaymentContactDefaults
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    //Maybe not needed
    public class Balances : Xero.Api.Core.Model.Balances
    {
        [DataMember(EmitDefaultValue = false)]
        public new Balance AccountsReceivable { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public new Balance AccountsPayable { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    public class PaymentTerms : Xero.Api.Core.Model.PaymentTerms
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [DataMember]
        public new Terms Bills { get; set; }

        [DataMember]
        public new Terms Sales { get; set; }
    }
    public class Terms : Xero.Api.Core.Model.Terms
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    public class Address : Xero.Api.Core.Model.Address
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    public class Phone : Xero.Api.Core.Model.Phone
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
    public class LineItem : Xero.Api.Core.Model.LineItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }

    public class ContactGroup : Xero.Api.Core.Model.ContactGroup
    {
        public new List<ContactGroup_Contact> Contacts { get; set; }
    }

    public class ContactGroup_Contact
    {
        public Guid ContactId { get; set; }
        public XContact Contact { get; set; }
        public Guid ContactGroupId { get; set; }
        public ContactGroup ContactGroup { get; set; }
    }

    public class CreditNote : Xero.Api.Core.Model.CreditNote
    {
        public Guid Id { get; set; }
        public new XContact Contact { get; set; }
    }

    public class Prepayment : Xero.Api.Core.Model.Prepayment
    {
        public new List<LineItem> LineItems { get; set; }
    }
    public class Payment : Xero.Api.Core.Model.Payment
    {
        public new Invoice Invoice { get; set; }
        public new CreditNote CreditNote { get; set; }
        public new Prepayment Prepayment { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public new Overpayment Overpayment { get; set; }
    }
    public class Overpayment : Xero.Api.Core.Model.Overpayment
    {
        public new List<LineItem> LineItems { get; set; }
        public new XContact Contact { get; set; }
    }

    //public class ValidationError: Xero.Api.Infrastructure.Model.ValidationError
    //{
    //	public Guid Id { get; set; }
    //}
    //public class Warning : Xero.Api.Infrastructure.Model.Warning
    //{
    //	public Guid Id { get; set; }
    //}
    //public class  : Xero.Api.Core.Model.
    //	{
    //		public Guid Id { get; set; } = Guid.NewGuid();
    //	}
}
