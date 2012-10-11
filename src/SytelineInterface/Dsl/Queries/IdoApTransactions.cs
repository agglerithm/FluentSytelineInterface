using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    public class IdoApTransactions : IdoConstants
    {
        public const string IDO_NAME = "SLAptrxs";
        public const string ApAcct = "ApAcct";
        public const string ApAcctUnit1 = "ApAcctUnit1";
        public const string ApAcctUnit2 = "ApAcctUnit2";
        public const string ApAcctUnit3 = "ApAcctUnit3";
        public const string ApAcctUnit4 = "ApAcctUnit4";
        public const string Authorizer = "Authorizer";
        public const string AuthStatus = "AuthStatus";
        public const string BrokerageAmt = "BrokerageAmt";
        public const string BuilderPoNum = "BuilderPoNum";
        public const string BuilderPoOrigSite = "BuilderPoOrigSite";
        public const string BuilderVoucher = "BuilderVoucher";
        public const string BuilderVoucherOrigSite = "BuilderVoucherOrigSite";
        public const string ChaAccessUnit1 = "ChaAccessUnit1";
        public const string ChaAccessUnit2 = "ChaAccessUnit2";
        public const string ChaAccessUnit3 = "ChaAccessUnit3";
        public const string ChaAccessUnit4 = "ChaAccessUnit4";
        public const string ChaDescription = "ChaDescription";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrPlaces = "CurrPlaces";
        public const string DerDistExists = "DerDistExists";
        public const string DiscAmt = "DiscAmt";
        public const string DiscDate = "DiscDate";
        public const string DiscDays = "DiscDays";
        public const string DiscPct = "DiscPct";
        public const string DistDate = "DistDate";
        public const string DueDate = "DueDate";
        public const string DueDays = "DueDays";
        public const string DutyAmt = "DutyAmt";
        public const string ExchRate = "ExchRate";
        public const string FixedRate = "FixedRate";
        public const string Freight = "Freight";
        public const string GrnNum = "GrnNum";
        public const string IncludesTax = "IncludesTax";
        public const string IncludeTaxInCost = "IncludeTaxInCost";
        public const string InsuranceAmt = "InsuranceAmt";
        public const string InvAmt = "InvAmt";
        public const string InvDate = "InvDate";
        public const string InvNum = "InvNum";
        public const string InWorkflow = "InWorkflow";
        public const string LocFrtAmt = "LocFrtAmt";
        public const string MiscCharges = "MiscCharges";
        public const string NonDiscAmt = "NonDiscAmt";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PoNum = "PoNum";
        public const string PostFromPo = "PostFromPo";
        public const string PreRegister = "PreRegister";
        public const string ProxCode = "ProxCode";
        public const string ProxDay = "ProxDay";
        public const string PurchAmt = "PurchAmt";
        public const string RecordDate = "RecordDate";
        public const string Ref = "Ref";
        public const string RowPointer = "RowPointer";
        public const string SalesTax = "SalesTax";
        public const string SalesTax_2 = "SalesTax_2";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode2 = "TaxCode2";
        public const string Tc1Description = "Tc1Description";
        public const string Tc2Description = "Tc2Description";
        public const string Txt = "Txt";
        public const string Type = "Type";
        public const string UbEnable = "UbEnable";
        public const string UbEnableSalesTax = "UbEnableSalesTax";
        public const string UbEnableSalesTax2 = "UbEnableSalesTax2";
        public const string UbGenerateDistributions = "UbGenerateDistributions";
        public const string UbToSite = "UbToSite";
        public const string UbVendNum = "UbVendNum";
        public const string VenCurrCode = "VenCurrCode";
        public const string VendaddrName = "VendaddrName";
        public const string VendNum = "VendNum";
        public const string Voucher = "Voucher";


    }

    public class IdoApTransactionsBuilder
        : IdoQueryBuilder<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>
    {
        public IdoApTransactionsBuilder(IExpressionInterpreter interpreter) : base(IdoApTransactions.IDO_NAME, interpreter) { }

        public IdoApTransactionsBuilder ApAcct { get { AddProperty(IdoApTransactions.ApAcct); return this; } }
        public IdoApTransactionsBuilder ApAcctUnit1 { get { AddProperty(IdoApTransactions.ApAcctUnit1); return this; } }
        public IdoApTransactionsBuilder ApAcctUnit2 { get { AddProperty(IdoApTransactions.ApAcctUnit2); return this; } }
        public IdoApTransactionsBuilder ApAcctUnit3 { get { AddProperty(IdoApTransactions.ApAcctUnit3); return this; } }
        public IdoApTransactionsBuilder ApAcctUnit4 { get { AddProperty(IdoApTransactions.ApAcctUnit4); return this; } }
        public IdoApTransactionsBuilder Authorizer { get { AddProperty(IdoApTransactions.Authorizer); return this; } }
        public IdoApTransactionsBuilder AuthStatus { get { AddProperty(IdoApTransactions.AuthStatus); return this; } }
        public IdoApTransactionsBuilder BrokerageAmt { get { AddProperty(IdoApTransactions.BrokerageAmt); return this; } }
        public IdoApTransactionsBuilder BuilderPoNum { get { AddProperty(IdoApTransactions.BuilderPoNum); return this; } }
        public IdoApTransactionsBuilder BuilderPoOrigSite { get { AddProperty(IdoApTransactions.BuilderPoOrigSite); return this; } }
        public IdoApTransactionsBuilder BuilderVoucher { get { AddProperty(IdoApTransactions.BuilderVoucher); return this; } }
        public IdoApTransactionsBuilder BuilderVoucherOrigSite { get { AddProperty(IdoApTransactions.BuilderVoucherOrigSite); return this; } }
        public IdoApTransactionsBuilder ChaAccessUnit1 { get { AddProperty(IdoApTransactions.ChaAccessUnit1); return this; } }
        public IdoApTransactionsBuilder ChaAccessUnit2 { get { AddProperty(IdoApTransactions.ChaAccessUnit2); return this; } }
        public IdoApTransactionsBuilder ChaAccessUnit3 { get { AddProperty(IdoApTransactions.ChaAccessUnit3); return this; } }
        public IdoApTransactionsBuilder ChaAccessUnit4 { get { AddProperty(IdoApTransactions.ChaAccessUnit4); return this; } }
        public IdoApTransactionsBuilder ChaDescription { get { AddProperty(IdoApTransactions.ChaDescription); return this; } }
        public IdoApTransactionsBuilder CurrAmtFormat { get { AddProperty(IdoApTransactions.CurrAmtFormat); return this; } }
        public IdoApTransactionsBuilder CurrPlaces { get { AddProperty(IdoApTransactions.CurrPlaces); return this; } }
        public IdoApTransactionsBuilder DerDistExists { get { AddProperty(IdoApTransactions.DerDistExists); return this; } }
        public IdoApTransactionsBuilder DiscAmt { get { AddProperty(IdoApTransactions.DiscAmt); return this; } }
        public IdoApTransactionsBuilder DiscDate { get { AddProperty(IdoApTransactions.DiscDate); return this; } }
        public IdoApTransactionsBuilder DiscDays { get { AddProperty(IdoApTransactions.DiscDays); return this; } }
        public IdoApTransactionsBuilder DiscPct { get { AddProperty(IdoApTransactions.DiscPct); return this; } }
        public IdoApTransactionsBuilder DistDate { get { AddProperty(IdoApTransactions.DistDate); return this; } }
        public IdoApTransactionsBuilder DueDate { get { AddProperty(IdoApTransactions.DueDate); return this; } }
        public IdoApTransactionsBuilder DueDays { get { AddProperty(IdoApTransactions.DueDays); return this; } }
        public IdoApTransactionsBuilder DutyAmt { get { AddProperty(IdoApTransactions.DutyAmt); return this; } }
        public IdoApTransactionsBuilder ExchRate { get { AddProperty(IdoApTransactions.ExchRate); return this; } }
        public IdoApTransactionsBuilder FixedRate { get { AddProperty(IdoApTransactions.FixedRate); return this; } }
        public IdoApTransactionsBuilder Freight { get { AddProperty(IdoApTransactions.Freight); return this; } }
        public IdoApTransactionsBuilder GrnNum { get { AddProperty(IdoApTransactions.GrnNum); return this; } }
        public IdoApTransactionsBuilder IncludesTax { get { AddProperty(IdoApTransactions.IncludesTax); return this; } }
        public IdoApTransactionsBuilder IncludeTaxInCost { get { AddProperty(IdoApTransactions.IncludeTaxInCost); return this; } }
        public IdoApTransactionsBuilder InsuranceAmt { get { AddProperty(IdoApTransactions.InsuranceAmt); return this; } }
        public IdoApTransactionsBuilder InvAmt { get { AddProperty(IdoApTransactions.InvAmt); return this; } }
        public IdoApTransactionsBuilder InvDate { get { AddProperty(IdoApTransactions.InvDate); return this; } }
        public IdoApTransactionsBuilder InvNum { get { AddProperty(IdoApTransactions.InvNum); return this; } }
        public IdoApTransactionsBuilder InWorkflow { get { AddProperty(IdoApTransactions.InWorkflow); return this; } }
        public IdoApTransactionsBuilder LocFrtAmt { get { AddProperty(IdoApTransactions.LocFrtAmt); return this; } }
        public IdoApTransactionsBuilder MiscCharges { get { AddProperty(IdoApTransactions.MiscCharges); return this; } }
        public IdoApTransactionsBuilder NonDiscAmt { get { AddProperty(IdoApTransactions.NonDiscAmt); return this; } }
        public IdoApTransactionsBuilder NoteExistsFlag { get { AddProperty(IdoApTransactions.NoteExistsFlag); return this; } }
        public IdoApTransactionsBuilder PoNum { get { AddProperty(IdoApTransactions.PoNum); return this; } }
        public IdoApTransactionsBuilder PostFromPo { get { AddProperty(IdoApTransactions.PostFromPo); return this; } }
        public IdoApTransactionsBuilder PreRegister { get { AddProperty(IdoApTransactions.PreRegister); return this; } }
        public IdoApTransactionsBuilder ProxCode { get { AddProperty(IdoApTransactions.ProxCode); return this; } }
        public IdoApTransactionsBuilder ProxDay { get { AddProperty(IdoApTransactions.ProxDay); return this; } }
        public IdoApTransactionsBuilder PurchAmt { get { AddProperty(IdoApTransactions.PurchAmt); return this; } }
        public IdoApTransactionsBuilder RecordDate { get { AddProperty(IdoApTransactions.RecordDate); return this; } }
        public IdoApTransactionsBuilder Ref { get { AddProperty(IdoApTransactions.Ref); return this; } }
        public IdoApTransactionsBuilder RowPointer { get { AddProperty(IdoApTransactions.RowPointer); return this; } }
        public IdoApTransactionsBuilder SalesTax { get { AddProperty(IdoApTransactions.SalesTax); return this; } }
        public IdoApTransactionsBuilder SalesTax_2 { get { AddProperty(IdoApTransactions.SalesTax_2); return this; } }
        public IdoApTransactionsBuilder ShowInDropDownList { get { AddProperty(IdoApTransactions.ShowInDropDownList); return this; } }
        public IdoApTransactionsBuilder TaxCode1 { get { AddProperty(IdoApTransactions.TaxCode1); return this; } }
        public IdoApTransactionsBuilder TaxCode2 { get { AddProperty(IdoApTransactions.TaxCode2); return this; } }
        public IdoApTransactionsBuilder Tc1Description { get { AddProperty(IdoApTransactions.Tc1Description); return this; } }
        public IdoApTransactionsBuilder Tc2Description { get { AddProperty(IdoApTransactions.Tc2Description); return this; } }
        public IdoApTransactionsBuilder Txt { get { AddProperty(IdoApTransactions.Txt); return this; } }
        public IdoApTransactionsBuilder Type { get { AddProperty(IdoApTransactions.Type); return this; } }
        public IdoApTransactionsBuilder UbEnable { get { AddProperty(IdoApTransactions.UbEnable); return this; } }
        public IdoApTransactionsBuilder UbEnableSalesTax { get { AddProperty(IdoApTransactions.UbEnableSalesTax); return this; } }
        public IdoApTransactionsBuilder UbEnableSalesTax2 { get { AddProperty(IdoApTransactions.UbEnableSalesTax2); return this; } }
        public IdoApTransactionsBuilder UbGenerateDistributions { get { AddProperty(IdoApTransactions.UbGenerateDistributions); return this; } }
        public IdoApTransactionsBuilder UbToSite { get { AddProperty(IdoApTransactions.UbToSite); return this; } }
        public IdoApTransactionsBuilder UbVendNum { get { AddProperty(IdoApTransactions.UbVendNum); return this; } }
        public IdoApTransactionsBuilder VenCurrCode { get { AddProperty(IdoApTransactions.VenCurrCode); return this; } }
        public IdoApTransactionsBuilder VendaddrName { get { AddProperty(IdoApTransactions.VendaddrName); return this; } }
        public IdoApTransactionsBuilder VendNum { get { AddProperty(IdoApTransactions.VendNum); return this; } }
        public IdoApTransactionsBuilder Voucher { get { AddProperty(IdoApTransactions.Voucher); return this; } }


    }

    public class SLAptrxsFilterExpressionBuilder
        : FilterExpressionBuilder<IdoApTransactionsBuilder>
    {
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ApAcct
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ApAcct); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit1
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ApAcctUnit1); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit2
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ApAcctUnit2); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit3
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ApAcctUnit3); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit4
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ApAcctUnit4); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Authorizer
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Authorizer); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> AuthStatus
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.AuthStatus); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> BrokerageAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.BrokerageAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> BuilderPoNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.BuilderPoNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> BuilderPoOrigSite
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.BuilderPoOrigSite); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> BuilderVoucher
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.BuilderVoucher); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> BuilderVoucherOrigSite
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.BuilderVoucherOrigSite); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit1
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ChaAccessUnit1); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit2
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ChaAccessUnit2); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit3
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ChaAccessUnit3); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit4
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ChaAccessUnit4); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ChaDescription
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ChaDescription); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> CurrAmtFormat
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.CurrAmtFormat); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> CurrPlaces
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.CurrPlaces); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DerDistExists
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DerDistExists); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DiscAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DiscAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DiscDate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DiscDate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DiscDays
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DiscDays); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DiscPct
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DiscPct); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DistDate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DistDate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DueDate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DueDate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DueDays
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DueDays); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> DutyAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.DutyAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ExchRate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ExchRate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> FixedRate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.FixedRate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Freight
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Freight); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> GrnNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.GrnNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> IncludesTax
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.IncludesTax); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> IncludeTaxInCost
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.IncludeTaxInCost); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> InsuranceAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.InsuranceAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> InvAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.InvAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> InvDate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.InvDate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> InvNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.InvNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.InWorkflow); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> LocFrtAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.LocFrtAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> MiscCharges
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.MiscCharges); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> NonDiscAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.NonDiscAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.NoteExistsFlag); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.PoNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> PostFromPo
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.PostFromPo); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> PreRegister
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.PreRegister); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ProxCode
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ProxCode); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ProxDay
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ProxDay); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> PurchAmt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.PurchAmt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.RecordDate); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Ref
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Ref); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.RowPointer); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> SalesTax
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.SalesTax); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> SalesTax_2
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.SalesTax_2); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> ShowInDropDownList
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.ShowInDropDownList); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> TaxCode1
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.TaxCode1); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> TaxCode2
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.TaxCode2); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Tc1Description
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Tc1Description); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Tc2Description
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Tc2Description); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Txt
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Txt); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Type); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbEnable
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbEnable); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbEnableSalesTax
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbEnableSalesTax); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbEnableSalesTax2
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbEnableSalesTax2); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbGenerateDistributions
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbGenerateDistributions); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbToSite
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbToSite); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> UbVendNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.UbVendNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> VenCurrCode
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.VenCurrCode); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> VendaddrName
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.VendaddrName); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.VendNum); }
        }
        public FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder> Voucher
        {
            get { return new FilterExpression<IdoApTransactionsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, IdoApTransactions.Voucher); }
        }


    }
}