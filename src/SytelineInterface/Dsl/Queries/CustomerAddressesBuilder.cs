using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class CustomerAddresses : IdoConstants
    {
        public const string IDO_NAME = "SLCustAddrs";
        public const string Address1 = "Addr_1";
        public const string Address2 = "Addr_2";
        public const string Address3 = "Addr_3";
        public const string Address4 = "Addr_4";
        public const string AmtOverInvAmt = "AmtOverInvAmt";
        public const string ArparmsAgeDesc_1 = "ArparmsAgeDesc_1";
        public const string ArparmsAgeDesc_2 = "ArparmsAgeDesc_2";
        public const string ArparmsAgeDesc_3 = "ArparmsAgeDesc_3";
        public const string ArparmsAgeDesc_4 = "ArparmsAgeDesc_4";
        public const string ArparmsAgeDesc_5 = "ArparmsAgeDesc_5";
        public const string BalMethod = "BalMethod";
        public const string BillToEmail = "BillToEmail";
        public const string City = "City";
        public const string CorpAddress = "CorpAddress";
        public const string CorpCred = "CorpCred";
        public const string CorpCust = "CorpCust";
        public const string Country = "Country";
        public const string County = "County";
        public const string CreditHold = "CreditHold";
        public const string CreditHoldDate = "CreditHoldDate";
        public const string CreditHoldReason = "CreditHoldReason";
        public const string CreditHoldUser = "CreditHoldUser";
        public const string CreditLimit = "CreditLimit";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCode = "CurrCode";
        public const string CustNum = "CustNum";
        public const string CustSeq = "CustSeq";
        public const string CustTpTpCode = "CustTpTpCode";
        public const string DaysOverInvDueDate = "DaysOverInvDueDate";
        public const string DerAgeBal1 = "DerAgeBal1";
        public const string DerAgeBal2 = "DerAgeBal2";
        public const string DerAgeBal3 = "DerAgeBal3";
        public const string DerAgeBal4 = "DerAgeBal4";
        public const string DerAgeBal5 = "DerAgeBal5";
        public const string DerAgeBal6 = "DerAgeBal6";
        public const string DerBillToAddress = "DerBillToAddress";
        public const string DerCustomerShipToExists = "DerCustomerShipToExists";
        public const string DerEarth = "DerEarth";
        public const string DerOrderBal = "DerOrderBal";
        public const string DerPostedBal = "DerPostedBal";
        public const string DerShipToAddress = "DerShipToAddress";
        public const string ExternalEmailAddr = "ExternalEmailAddr";
        public const string FaxNum = "FaxNum";
        public const string InternalEmailAddr = "InternalEmailAddr";
        public const string InternetUrl = "InternetUrl";
        public const string InWorkflow = "InWorkflow";
        public const string Name = "Name";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string ShipToEmail = "ShipToEmail";
        public const string SLArtranAlls = "SLArtranAlls";
        public const string State = "State";
        public const string TelexNum = "TelexNum";
        public const string Zip = "Zip";
        public const string Salesperson = "CustSlsman";


    }

    public class CustomerAddressesBuilder
        : IdoQueryBuilder<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>
    {
        public CustomerAddressesBuilder(IExpressionInterpreter interpreter) : base(CustomerAddresses.IDO_NAME, interpreter) { }

        public CustomerAddressesBuilder Address1 { get { AddProperty(CustomerAddresses.Address1); return this; } }
        public CustomerAddressesBuilder Address2 { get { AddProperty(CustomerAddresses.Address2); return this; } }
        public CustomerAddressesBuilder Address3 { get { AddProperty(CustomerAddresses.Address3); return this; } }
        public CustomerAddressesBuilder Address4 { get { AddProperty(CustomerAddresses.Address4); return this; } }
        public CustomerAddressesBuilder AmtOverInvAmt { get { AddProperty(CustomerAddresses.AmtOverInvAmt); return this; } }
        public CustomerAddressesBuilder ArparmsAgeDesc_1 { get { AddProperty(CustomerAddresses.ArparmsAgeDesc_1); return this; } }
        public CustomerAddressesBuilder ArparmsAgeDesc_2 { get { AddProperty(CustomerAddresses.ArparmsAgeDesc_2); return this; } }
        public CustomerAddressesBuilder ArparmsAgeDesc_3 { get { AddProperty(CustomerAddresses.ArparmsAgeDesc_3); return this; } }
        public CustomerAddressesBuilder ArparmsAgeDesc_4 { get { AddProperty(CustomerAddresses.ArparmsAgeDesc_4); return this; } }
        public CustomerAddressesBuilder ArparmsAgeDesc_5 { get { AddProperty(CustomerAddresses.ArparmsAgeDesc_5); return this; } }
        public CustomerAddressesBuilder BalMethod { get { AddProperty(CustomerAddresses.BalMethod); return this; } }
        public CustomerAddressesBuilder BillToEmail { get { AddProperty(CustomerAddresses.BillToEmail); return this; } }
        public CustomerAddressesBuilder City { get { AddProperty(CustomerAddresses.City); return this; } }
        public CustomerAddressesBuilder CorpAddress { get { AddProperty(CustomerAddresses.CorpAddress); return this; } }
        public CustomerAddressesBuilder CorpCred { get { AddProperty(CustomerAddresses.CorpCred); return this; } }
        public CustomerAddressesBuilder CorpCust { get { AddProperty(CustomerAddresses.CorpCust); return this; } }
        public CustomerAddressesBuilder Country { get { AddProperty(CustomerAddresses.Country); return this; } }
        public CustomerAddressesBuilder County { get { AddProperty(CustomerAddresses.County); return this; } }
        public CustomerAddressesBuilder CreditHold { get { AddProperty(CustomerAddresses.CreditHold); return this; } }
        public CustomerAddressesBuilder CreditHoldDate { get { AddProperty(CustomerAddresses.CreditHoldDate); return this; } }
        public CustomerAddressesBuilder CreditHoldReason { get { AddProperty(CustomerAddresses.CreditHoldReason); return this; } }
        public CustomerAddressesBuilder CreditHoldUser { get { AddProperty(CustomerAddresses.CreditHoldUser); return this; } }
        public CustomerAddressesBuilder CreditLimit { get { AddProperty(CustomerAddresses.CreditLimit); return this; } }
        public CustomerAddressesBuilder CurrAmtFormat { get { AddProperty(CustomerAddresses.CurrAmtFormat); return this; } }
        public CustomerAddressesBuilder CurrAmtTotFormat { get { AddProperty(CustomerAddresses.CurrAmtTotFormat); return this; } }
        public CustomerAddressesBuilder Salesperson { get { AddProperty(CustomerAddresses.Salesperson); return this; } }
        public CustomerAddressesBuilder CurrCode { get { AddProperty(CustomerAddresses.CurrCode); return this; } }
        public CustomerAddressesBuilder CustNum { get { AddProperty(CustomerAddresses.CustNum); return this; } }
        public CustomerAddressesBuilder CustSeq { get { AddProperty(CustomerAddresses.CustSeq); return this; } }
        public CustomerAddressesBuilder CustTpTpCode { get { AddProperty(CustomerAddresses.CustTpTpCode); return this; } }
        public CustomerAddressesBuilder DaysOverInvDueDate { get { AddProperty(CustomerAddresses.DaysOverInvDueDate); return this; } }
        public CustomerAddressesBuilder DerAgeBal1 { get { AddProperty(CustomerAddresses.DerAgeBal1); return this; } }
        public CustomerAddressesBuilder DerAgeBal2 { get { AddProperty(CustomerAddresses.DerAgeBal2); return this; } }
        public CustomerAddressesBuilder DerAgeBal3 { get { AddProperty(CustomerAddresses.DerAgeBal3); return this; } }
        public CustomerAddressesBuilder DerAgeBal4 { get { AddProperty(CustomerAddresses.DerAgeBal4); return this; } }
        public CustomerAddressesBuilder DerAgeBal5 { get { AddProperty(CustomerAddresses.DerAgeBal5); return this; } }
        public CustomerAddressesBuilder DerAgeBal6 { get { AddProperty(CustomerAddresses.DerAgeBal6); return this; } }
        public CustomerAddressesBuilder DerBillToAddress { get { AddProperty(CustomerAddresses.DerBillToAddress); return this; } }
        public CustomerAddressesBuilder DerCustomerShipToExists { get { AddProperty(CustomerAddresses.DerCustomerShipToExists); return this; } }
        public CustomerAddressesBuilder DerEarth { get { AddProperty(CustomerAddresses.DerEarth); return this; } }
        public CustomerAddressesBuilder DerOrderBal { get { AddProperty(CustomerAddresses.DerOrderBal); return this; } }
        public CustomerAddressesBuilder DerPostedBal { get { AddProperty(CustomerAddresses.DerPostedBal); return this; } }
        public CustomerAddressesBuilder DerShipToAddress { get { AddProperty(CustomerAddresses.DerShipToAddress); return this; } }
        public CustomerAddressesBuilder ExternalEmailAddr { get { AddProperty(CustomerAddresses.ExternalEmailAddr); return this; } }
        public CustomerAddressesBuilder FaxNum { get { AddProperty(CustomerAddresses.FaxNum); return this; } }
        public CustomerAddressesBuilder InternalEmailAddr { get { AddProperty(CustomerAddresses.InternalEmailAddr); return this; } }
        public CustomerAddressesBuilder InternetUrl { get { AddProperty(CustomerAddresses.InternetUrl); return this; } }
        public CustomerAddressesBuilder InWorkflow { get { AddProperty(CustomerAddresses.InWorkflow); return this; } }
        public CustomerAddressesBuilder Name { get { AddProperty(CustomerAddresses.Name); return this; } }
        public CustomerAddressesBuilder NoteExistsFlag { get { AddProperty(CustomerAddresses.NoteExistsFlag); return this; } }
        public CustomerAddressesBuilder RecordDate { get { AddProperty(CustomerAddresses.RecordDate); return this; } }
        public CustomerAddressesBuilder RowPointer { get { AddProperty(CustomerAddresses.RowPointer); return this; } }
        public CustomerAddressesBuilder ShipToEmail { get { AddProperty(CustomerAddresses.ShipToEmail); return this; } }
        public CustomerAddressesBuilder SLArtranAlls { get { AddProperty(CustomerAddresses.SLArtranAlls); return this; } }
        public CustomerAddressesBuilder State { get { AddProperty(CustomerAddresses.State); return this; } }
        public CustomerAddressesBuilder TelexNum { get { AddProperty(CustomerAddresses.TelexNum); return this; } }
        public CustomerAddressesBuilder Zip { get { AddProperty(CustomerAddresses.Zip); return this; } }


    }

    public class SLCustAddrsFilterExpressionBuilder
        : FilterExpressionBuilder<CustomerAddressesBuilder>
    {
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Addr_1
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Address1); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Addr_2
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Address2); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Addr_3
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Address3); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Addr_4
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Address4); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> AmtOverInvAmt
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.AmtOverInvAmt); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ArparmsAgeDesc_1
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ArparmsAgeDesc_1); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ArparmsAgeDesc_2
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ArparmsAgeDesc_2); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ArparmsAgeDesc_3
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ArparmsAgeDesc_3); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ArparmsAgeDesc_4
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ArparmsAgeDesc_4); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ArparmsAgeDesc_5
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ArparmsAgeDesc_5); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> BalMethod
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.BalMethod); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> BillToEmail
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.BillToEmail); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> City
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.City); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CorpAddress
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CorpAddress); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CorpCred
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CorpCred); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CorpCust
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CorpCust); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Country
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Country); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> County
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.County); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CreditHold
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CreditHold); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CreditHoldDate
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CreditHoldDate); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CreditHoldReason
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CreditHoldReason); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CreditHoldUser
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CreditHoldUser); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CreditLimit
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CreditLimit); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CurrAmtFormat
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CurrAmtFormat); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CurrAmtTotFormat); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CurrCode
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CurrCode); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CustNum
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CustNum); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CustSeq
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CustSeq); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> CustTpTpCode
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.CustTpTpCode); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DaysOverInvDueDate
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DaysOverInvDueDate); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal1
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal1); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal2
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal2); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal3
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal3); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal4
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal4); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal5
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal5); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerAgeBal6
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerAgeBal6); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerBillToAddress
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerBillToAddress); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerCustomerShipToExists
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerCustomerShipToExists); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerEarth
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerEarth); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerOrderBal
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerOrderBal); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerPostedBal
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerPostedBal); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> DerShipToAddress
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.DerShipToAddress); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ExternalEmailAddr
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ExternalEmailAddr); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> FaxNum
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.FaxNum); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> InternalEmailAddr
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.InternalEmailAddr); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> InternetUrl
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.InternetUrl); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.InWorkflow); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Name
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Name); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.NoteExistsFlag); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.RecordDate); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.RowPointer); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> ShipToEmail
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.ShipToEmail); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> SLArtranAlls
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.SLArtranAlls); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> State
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.State); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> TelexNum
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.TelexNum); }
        }
        public FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder> Zip
        {
            get { return new FilterExpression<CustomerAddressesBuilder, SLCustAddrsFilterExpressionBuilder>(_builder, CustomerAddresses.Zip); }
        }


    }
}
