using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class Vendors : IdoConstants
    {
        public const string IDO_NAME = "SLVendors";
        public const string Account = "Account";
        public const string AccountName = "AccountName";
        public const string ActiveForDataIntegration = "ActiveForDataIntegration";
        public const string BankaAddr1 = "BankaAddr_1";
        public const string BankaAddr2 = "BankaAddr_2";
        public const string BankaAddr3 = "BankaAddr_3";
        public const string BankaAddr4 = "BankaAddr_4";
        public const string BankaCity = "BankaCity";
        public const string BankaCountry = "BankaCountry";
        public const string BankaState = "BankaState";
        public const string BankaZip = "BankaZip";
        public const string BankCode = "BankCode";
        public const string BhName = "BhName";
        public const string BranchId = "BranchId";
        public const string Category = "Category";
        public const string Charfld1 = "Charfld1";
        public const string Charfld2 = "Charfld2";
        public const string Charfld3 = "Charfld3";
        public const string Contact = "Contact";
        public const string CouEcCode = "CouEcCode";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCode = "CurrCode";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string CurrDescription = "CurrDescription";
        public const string CurrPartOfEuro = "CurrPartOfEuro";
        public const string Datefld = "Datefld";
        public const string Decifld1 = "Decifld1";
        public const string Decifld2 = "Decifld2";
        public const string Decifld3 = "Decifld3";
        public const string Delterm = "Delterm";
        public const string DelTermDescription = "DelTermDescription";
        public const string Der1099OutData = "Der1099OutData";
        public const string DerAgeBal1 = "DerAgeBal1";
        public const string DerAgeBal2 = "DerAgeBal2";
        public const string DerAgeBal3 = "DerAgeBal3";
        public const string DerAgeBal4 = "DerAgeBal4";
        public const string DerAgeBal5 = "DerAgeBal5";
        public const string DerAgeBal6 = "DerAgeBal6";
        public const string DerDiscLstYr = "DerDiscLstYr";
        public const string DerDiscYtd = "DerDiscYtd";
        public const string DerFormatAddress = "DerFormatAddress";
        public const string DerNewAmount = "DerNewAmount";
        public const string DerNewDomesticAmount = "DerNewDomesticAmount";
        public const string DerOldAmount = "DerOldAmount";
        public const string DerOldDomesticAmount = "DerOldDomesticAmount";
        public const string DerPayFiscalYTD = "DerPayFiscalYTD";
        public const string DerPayLastFiscalYr = "DerPayLastFiscalYr";
        public const string DerPayLstYr = "DerPayLstYr";
        public const string DerPayYTD = "DerPayYTD";
        public const string DerPurchLstYr = "DerPurchLstYr";
        public const string DerPurchYTD = "DerPurchYTD";
        public const string DerRemoteAptrxpsCount = "DerRemoteAptrxpsCount";
        public const string DerTotalDifference = "DerTotalDifference";
        public const string DerType = "DerType";
        public const string DerVendNum = "DerVendNum";
        public const string DerVoucher = "DerVoucher";
        public const string DiscLstYr = "DiscLstYr";
        public const string DiscYtd = "DiscYtd";
        public const string EdiVend = "EdiVend";
        public const string EFTBankNum = "EFTBankNum";
        public const string ExternalEmailAddr = "ExternalEmailAddr";
        public const string Fob = "Fob";
        public const string IncludeTaxInCost = "IncludeTaxInCost";
        public const string InternalEmailAddr = "InternalEmailAddr";
        public const string InternetUrl = "InternetUrl";
        public const string InWorkflow = "InWorkflow";
        public const string LangCode = "LangCode";
        public const string LastPaid = "LastPaid";
        public const string LastPurch = "LastPurch";
        public const string LcrReqd = "LcrReqd";
        public const string Logifld = "Logifld";
        public const string Name = "Name";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PayFiscalYTD = "PayFiscalYTD";
        public const string PayHoldDescription = "PayHoldDescription";
        public const string PayHoldReasonClass = "PayHoldReasonClass";
        public const string PayLastFiscalYr = "PayLastFiscalYr";
        public const string PayLstYr = "PayLstYr";
        public const string PayType = "PayType";
        public const string PayYtd = "PayYtd";
        public const string Phone = "Phone";
        public const string PriceBy = "PriceBy";
        public const string PrintPrice = "PrintPrice";
        public const string PrintVATonPO = "PrintVATonPO";
        public const string ProcessInd = "ProcessInd";
        public const string PurAcct = "PurAcct";
        public const string PurAcctUnit1 = "PurAcctUnit1";
        public const string PurAcctUnit2 = "PurAcctUnit2";
        public const string PurAcctUnit3 = "PurAcctUnit3";
        public const string PurAcctUnit4 = "PurAcctUnit4";
        public const string PurchLstYr = "PurchLstYr";
        public const string PurChtAccessUnit1 = "PurChtAccessUnit1";
        public const string PurChtAccessUnit2 = "PurChtAccessUnit2";
        public const string PurChtAccessUnit3 = "PurChtAccessUnit3";
        public const string PurChtAccessUnit4 = "PurChtAccessUnit4";
        public const string PurChtDescription = "PurChtDescription";
        public const string PurchYtd = "PurchYtd";
        public const string RecordDate = "RecordDate";
        public const string RequestAcknowledgement = "RequestAcknowledgement";
        public const string RowPointer = "RowPointer";
        public const string ShipCode = "ShipCode";
        public const string ShipCodeDescription = "ShipCodeDescription";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string SLApdraftts = "SLApdraftts";
        public const string SLAptrxpAlls = "SLAptrxpAlls";
        public const string SLAptrxps = "SLAptrxps";
        public const string SLGrnHdrs = "SLGrnHdrs";
        public const string SLGrnLines = "SLGrnLines";
        public const string SLGrnLinesFiltered = "SLGrnLinesFiltered";
        public const string SLItemvends = "SLItemvends";
        public const string SLPoItems = "SLPoItems";
        public const string SLPoItemsFiltered = "SLPoItemsFiltered";
        public const string SLPos = "SLPos";
        public const string SLVendlogs = "SLVendlogs"; 
        public const string Status = "Stat";
        public const string SupplyWebVendor = "SupplyWebVendor";
        public const string SynchronizedToBus = "SynchronizedToBus";
        public const string Tax1Description = "Tax1Description";
        public const string Tax2Description = "Tax2Description";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxRegNum1 = "TaxRegNum1";
        public const string TaxRegNum2 = "TaxRegNum2";
        public const string TerDescription = "TerDescription";
        public const string TermsCode = "TermsCode";
        public const string Transit = "Transit";
        public const string TransNat = "TransNat";
        public const string TransNat2 = "TransNat2";
        public const string TransNat2Description = "TransNat2Description";
        public const string TransNatDescription = "TransNatDescription";
        public const string VadAddr_1 = "VadAddr_1";
        public const string VadAddr_2 = "VadAddr_2";
        public const string VadAddr_3 = "VadAddr_3";
        public const string VadAddr_4 = "VadAddr_4";
        public const string VadCity = "VadCity";
        public const string VadCountry = "VadCountry";
        public const string VadCounty = "VadCounty";
        public const string VadFaxNum = "VadFaxNum";
        public const string VadPayHold = "VadPayHold";
        public const string VadPayHoldDate = "VadPayHoldDate";
        public const string VadPayHoldReason = "VadPayHoldReason";
        public const string VadPayHoldUser = "VadPayHoldUser";
        public const string VadRAddr_1 = "VadRAddr_1";
        public const string VadRAddr_2 = "VadRAddr_2";
        public const string VadRAddr_3 = "VadRAddr_3";
        public const string VadRAddr_4 = "VadRAddr_4";
        public const string VadRCity = "VadRCity";
        public const string VadRCountry = "VadRCountry";
        public const string VadRCounty = "VadRCounty";
        public const string VadRecordDate = "VadRecordDate";
        public const string VadRName = "VadRName";
        public const string VadRowPointer = "VadRowPointer";
        public const string VadRState = "VadRState";
        public const string VadRZip = "VadRZip";
        public const string VadState = "VadState";
        public const string VadTelexNum = "VadTelexNum";
        public const string VadZip = "VadZip";
        public const string VCDescription = "VCDescription";
        public const string VchOverPoCostTolerance = "VchOverPoCostTolerance";
        public const string VchUnderPoCostTolerance = "VchUnderPoCostTolerance";
        public const string VendNum = "VendNum";
        public const string VendRemit = "VendRemit";
        public const string VendType = "VendType";
        public const string Whse = "Whse";


    }

    public class VendorsBuilder
        : IdoQueryBuilder<VendorsBuilder, VendorsFilterExpressionBuilder>
    {
        public VendorsBuilder(IExpressionInterpreter interpreter) : base(Vendors.IDO_NAME, interpreter) { }

        public VendorsBuilder Account { get { AddProperty(Vendors.Account); return this; } }
        public VendorsBuilder AccountName { get { AddProperty(Vendors.AccountName); return this; } }
        public VendorsBuilder ActiveForDataIntegration { get { AddProperty(Vendors.ActiveForDataIntegration); return this; } }
        public VendorsBuilder BankaAddr1 { get { AddProperty(Vendors.BankaAddr1); return this; } }
        public VendorsBuilder BankaAddr2 { get { AddProperty(Vendors.BankaAddr2); return this; } }
        public VendorsBuilder BankaAddr3 { get { AddProperty(Vendors.BankaAddr3); return this; } }
        public VendorsBuilder BankaAddr4 { get { AddProperty(Vendors.BankaAddr4); return this; } }
        public VendorsBuilder BankaCity { get { AddProperty(Vendors.BankaCity); return this; } }
        public VendorsBuilder BankaCountry { get { AddProperty(Vendors.BankaCountry); return this; } }
        public VendorsBuilder BankaState { get { AddProperty(Vendors.BankaState); return this; } }
        public VendorsBuilder BankaZip { get { AddProperty(Vendors.BankaZip); return this; } }
        public VendorsBuilder BankCode { get { AddProperty(Vendors.BankCode); return this; } }
        public VendorsBuilder BhName { get { AddProperty(Vendors.BhName); return this; } }
        public VendorsBuilder BranchId { get { AddProperty(Vendors.BranchId); return this; } }
        public VendorsBuilder Category { get { AddProperty(Vendors.Category); return this; } }
        public VendorsBuilder Charfld1 { get { AddProperty(Vendors.Charfld1); return this; } }
        public VendorsBuilder Charfld2 { get { AddProperty(Vendors.Charfld2); return this; } }
        public VendorsBuilder Charfld3 { get { AddProperty(Vendors.Charfld3); return this; } }
        public VendorsBuilder Contact { get { AddProperty(Vendors.Contact); return this; } }
        public VendorsBuilder CouEcCode { get { AddProperty(Vendors.CouEcCode); return this; } }
        public VendorsBuilder CurrAmtFormat { get { AddProperty(Vendors.CurrAmtFormat); return this; } }
        public VendorsBuilder CurrAmtTotFormat { get { AddProperty(Vendors.CurrAmtTotFormat); return this; } }
        public VendorsBuilder CurrCode { get { AddProperty(Vendors.CurrCode); return this; } }
        public VendorsBuilder CurrCstPrcFormat { get { AddProperty(Vendors.CurrCstPrcFormat); return this; } }
        public VendorsBuilder CurrDescription { get { AddProperty(Vendors.CurrDescription); return this; } }
        public VendorsBuilder CurrPartOfEuro { get { AddProperty(Vendors.CurrPartOfEuro); return this; } }
        public VendorsBuilder Datefld { get { AddProperty(Vendors.Datefld); return this; } }
        public VendorsBuilder Decifld1 { get { AddProperty(Vendors.Decifld1); return this; } }
        public VendorsBuilder Decifld2 { get { AddProperty(Vendors.Decifld2); return this; } }
        public VendorsBuilder Decifld3 { get { AddProperty(Vendors.Decifld3); return this; } }
        public VendorsBuilder Delterm { get { AddProperty(Vendors.Delterm); return this; } }
        public VendorsBuilder DelTermDescription { get { AddProperty(Vendors.DelTermDescription); return this; } }
        public VendorsBuilder Der1099OutData { get { AddProperty(Vendors.Der1099OutData); return this; } }
        public VendorsBuilder DerAgeBal1 { get { AddProperty(Vendors.DerAgeBal1); return this; } }
        public VendorsBuilder DerAgeBal2 { get { AddProperty(Vendors.DerAgeBal2); return this; } }
        public VendorsBuilder DerAgeBal3 { get { AddProperty(Vendors.DerAgeBal3); return this; } }
        public VendorsBuilder DerAgeBal4 { get { AddProperty(Vendors.DerAgeBal4); return this; } }
        public VendorsBuilder DerAgeBal5 { get { AddProperty(Vendors.DerAgeBal5); return this; } }
        public VendorsBuilder DerAgeBal6 { get { AddProperty(Vendors.DerAgeBal6); return this; } }
        public VendorsBuilder DerDiscLstYr { get { AddProperty(Vendors.DerDiscLstYr); return this; } }
        public VendorsBuilder DerDiscYtd { get { AddProperty(Vendors.DerDiscYtd); return this; } }
        public VendorsBuilder DerFormatAddress { get { AddProperty(Vendors.DerFormatAddress); return this; } }
        public VendorsBuilder DerNewAmount { get { AddProperty(Vendors.DerNewAmount); return this; } }
        public VendorsBuilder DerNewDomesticAmount { get { AddProperty(Vendors.DerNewDomesticAmount); return this; } }
        public VendorsBuilder DerOldAmount { get { AddProperty(Vendors.DerOldAmount); return this; } }
        public VendorsBuilder DerOldDomesticAmount { get { AddProperty(Vendors.DerOldDomesticAmount); return this; } }
        public VendorsBuilder DerPayFiscalYTD { get { AddProperty(Vendors.DerPayFiscalYTD); return this; } }
        public VendorsBuilder DerPayLastFiscalYr { get { AddProperty(Vendors.DerPayLastFiscalYr); return this; } }
        public VendorsBuilder DerPayLstYr { get { AddProperty(Vendors.DerPayLstYr); return this; } }
        public VendorsBuilder DerPayYTD { get { AddProperty(Vendors.DerPayYTD); return this; } }
        public VendorsBuilder DerPurchLstYr { get { AddProperty(Vendors.DerPurchLstYr); return this; } }
        public VendorsBuilder DerPurchYTD { get { AddProperty(Vendors.DerPurchYTD); return this; } }
        public VendorsBuilder DerRemoteAptrxpsCount { get { AddProperty(Vendors.DerRemoteAptrxpsCount); return this; } }
        public VendorsBuilder DerTotalDifference { get { AddProperty(Vendors.DerTotalDifference); return this; } }
        public VendorsBuilder DerType { get { AddProperty(Vendors.DerType); return this; } }
        public VendorsBuilder DerVendNum { get { AddProperty(Vendors.DerVendNum); return this; } }
        public VendorsBuilder DerVoucher { get { AddProperty(Vendors.DerVoucher); return this; } }
        public VendorsBuilder DiscLstYr { get { AddProperty(Vendors.DiscLstYr); return this; } }
        public VendorsBuilder DiscYtd { get { AddProperty(Vendors.DiscYtd); return this; } }
        public VendorsBuilder EdiVend { get { AddProperty(Vendors.EdiVend); return this; } }
        public VendorsBuilder EFTBankNum { get { AddProperty(Vendors.EFTBankNum); return this; } }
        public VendorsBuilder ExternalEmailAddr { get { AddProperty(Vendors.ExternalEmailAddr); return this; } }
        public VendorsBuilder Fob { get { AddProperty(Vendors.Fob); return this; } }
        public VendorsBuilder IncludeTaxInCost { get { AddProperty(Vendors.IncludeTaxInCost); return this; } }
        public VendorsBuilder InternalEmailAddr { get { AddProperty(Vendors.InternalEmailAddr); return this; } }
        public VendorsBuilder InternetUrl { get { AddProperty(Vendors.InternetUrl); return this; } }
        public VendorsBuilder InWorkflow { get { AddProperty(Vendors.InWorkflow); return this; } }
        public VendorsBuilder LangCode { get { AddProperty(Vendors.LangCode); return this; } }
        public VendorsBuilder LastPaid { get { AddProperty(Vendors.LastPaid); return this; } }
        public VendorsBuilder LastPurch { get { AddProperty(Vendors.LastPurch); return this; } }
        public VendorsBuilder LcrReqd { get { AddProperty(Vendors.LcrReqd); return this; } }
        public VendorsBuilder Logifld { get { AddProperty(Vendors.Logifld); return this; } }
        public VendorsBuilder Name { get { AddProperty(Vendors.Name); return this; } }
        public VendorsBuilder NoteExistsFlag { get { AddProperty(Vendors.NoteExistsFlag); return this; } }
        public VendorsBuilder PayFiscalYTD { get { AddProperty(Vendors.PayFiscalYTD); return this; } }
        public VendorsBuilder PayHoldDescription { get { AddProperty(Vendors.PayHoldDescription); return this; } }
        public VendorsBuilder PayHoldReasonClass { get { AddProperty(Vendors.PayHoldReasonClass); return this; } }
        public VendorsBuilder PayLastFiscalYr { get { AddProperty(Vendors.PayLastFiscalYr); return this; } }
        public VendorsBuilder PayLstYr { get { AddProperty(Vendors.PayLstYr); return this; } }
        public VendorsBuilder PayType { get { AddProperty(Vendors.PayType); return this; } }
        public VendorsBuilder PayYtd { get { AddProperty(Vendors.PayYtd); return this; } }
        public VendorsBuilder Phone { get { AddProperty(Vendors.Phone); return this; } }
        public VendorsBuilder PriceBy { get { AddProperty(Vendors.PriceBy); return this; } }
        public VendorsBuilder PrintPrice { get { AddProperty(Vendors.PrintPrice); return this; } }
        public VendorsBuilder PrintVATonPO { get { AddProperty(Vendors.PrintVATonPO); return this; } }
        public VendorsBuilder ProcessInd { get { AddProperty(Vendors.ProcessInd); return this; } }
        public VendorsBuilder PurAcct { get { AddProperty(Vendors.PurAcct); return this; } }
        public VendorsBuilder PurAcctUnit1 { get { AddProperty(Vendors.PurAcctUnit1); return this; } }
        public VendorsBuilder PurAcctUnit2 { get { AddProperty(Vendors.PurAcctUnit2); return this; } }
        public VendorsBuilder PurAcctUnit3 { get { AddProperty(Vendors.PurAcctUnit3); return this; } }
        public VendorsBuilder PurAcctUnit4 { get { AddProperty(Vendors.PurAcctUnit4); return this; } }
        public VendorsBuilder PurchLstYr { get { AddProperty(Vendors.PurchLstYr); return this; } }
        public VendorsBuilder PurChtAccessUnit1 { get { AddProperty(Vendors.PurChtAccessUnit1); return this; } }
        public VendorsBuilder PurChtAccessUnit2 { get { AddProperty(Vendors.PurChtAccessUnit2); return this; } }
        public VendorsBuilder PurChtAccessUnit3 { get { AddProperty(Vendors.PurChtAccessUnit3); return this; } }
        public VendorsBuilder PurChtAccessUnit4 { get { AddProperty(Vendors.PurChtAccessUnit4); return this; } }
        public VendorsBuilder PurChtDescription { get { AddProperty(Vendors.PurChtDescription); return this; } }
        public VendorsBuilder PurchYtd { get { AddProperty(Vendors.PurchYtd); return this; } }
        public VendorsBuilder RecordDate { get { AddProperty(Vendors.RecordDate); return this; } }
        public VendorsBuilder RequestAcknowledgement { get { AddProperty(Vendors.RequestAcknowledgement); return this; } }
        public VendorsBuilder RowPointer { get { AddProperty(Vendors.RowPointer); return this; } }
        public VendorsBuilder ShipCode { get { AddProperty(Vendors.ShipCode); return this; } }
        public VendorsBuilder ShipCodeDescription { get { AddProperty(Vendors.ShipCodeDescription); return this; } }
        public VendorsBuilder ShowInDropDownList { get { AddProperty(Vendors.ShowInDropDownList); return this; } }
        public VendorsBuilder SLApdraftts { get { AddProperty(Vendors.SLApdraftts); return this; } }
        public VendorsBuilder SLAptrxpAlls { get { AddProperty(Vendors.SLAptrxpAlls); return this; } }
        public VendorsBuilder SLAptrxps { get { AddProperty(Vendors.SLAptrxps); return this; } }
        public VendorsBuilder SLGrnHdrs { get { AddProperty(Vendors.SLGrnHdrs); return this; } }
        public VendorsBuilder SLGrnLines { get { AddProperty(Vendors.SLGrnLines); return this; } }
        public VendorsBuilder SLGrnLinesFiltered { get { AddProperty(Vendors.SLGrnLinesFiltered); return this; } }
        public VendorsBuilder SLItemvends { get { AddProperty(Vendors.SLItemvends); return this; } }
        public VendorsBuilder SLPoItems { get { AddProperty(Vendors.SLPoItems); return this; } }
        public VendorsBuilder SLPoItemsFiltered { get { AddProperty(Vendors.SLPoItemsFiltered); return this; } }
        public VendorsBuilder SLPos { get { AddProperty(Vendors.SLPos); return this; } }
        public VendorsBuilder SLVendlogs { get { AddProperty(Vendors.SLVendlogs); return this; } } 
        public VendorsBuilder Status { get { AddProperty(Vendors.Status); return this; } }
        public VendorsBuilder SupplyWebVendor { get { AddProperty(Vendors.SupplyWebVendor); return this; } }
        public VendorsBuilder SynchronizedToBus { get { AddProperty(Vendors.SynchronizedToBus); return this; } }
        public VendorsBuilder Tax1Description { get { AddProperty(Vendors.Tax1Description); return this; } }
        public VendorsBuilder Tax2Description { get { AddProperty(Vendors.Tax2Description); return this; } }
        public VendorsBuilder TaxCode1 { get { AddProperty(Vendors.TaxCode1); return this; } }
        public VendorsBuilder TaxCode2 { get { AddProperty(Vendors.TaxCode2); return this; } }
        public VendorsBuilder TaxRegNum1 { get { AddProperty(Vendors.TaxRegNum1); return this; } }
        public VendorsBuilder TaxRegNum2 { get { AddProperty(Vendors.TaxRegNum2); return this; } }
        public VendorsBuilder TerDescription { get { AddProperty(Vendors.TerDescription); return this; } }
        public VendorsBuilder TermsCode { get { AddProperty(Vendors.TermsCode); return this; } }
        public VendorsBuilder Transit { get { AddProperty(Vendors.Transit); return this; } }
        public VendorsBuilder TransNat { get { AddProperty(Vendors.TransNat); return this; } }
        public VendorsBuilder TransNat2 { get { AddProperty(Vendors.TransNat2); return this; } }
        public VendorsBuilder TransNat2Description { get { AddProperty(Vendors.TransNat2Description); return this; } }
        public VendorsBuilder TransNatDescription { get { AddProperty(Vendors.TransNatDescription); return this; } }
        public VendorsBuilder VadAddr_1 { get { AddProperty(Vendors.VadAddr_1); return this; } }
        public VendorsBuilder VadAddr_2 { get { AddProperty(Vendors.VadAddr_2); return this; } }
        public VendorsBuilder VadAddr_3 { get { AddProperty(Vendors.VadAddr_3); return this; } }
        public VendorsBuilder VadAddr_4 { get { AddProperty(Vendors.VadAddr_4); return this; } }
        public VendorsBuilder VadCity { get { AddProperty(Vendors.VadCity); return this; } }
        public VendorsBuilder VadCountry { get { AddProperty(Vendors.VadCountry); return this; } }
        public VendorsBuilder VadCounty { get { AddProperty(Vendors.VadCounty); return this; } }
        public VendorsBuilder VadFaxNum { get { AddProperty(Vendors.VadFaxNum); return this; } }
        public VendorsBuilder VadPayHold { get { AddProperty(Vendors.VadPayHold); return this; } }
        public VendorsBuilder VadPayHoldDate { get { AddProperty(Vendors.VadPayHoldDate); return this; } }
        public VendorsBuilder VadPayHoldReason { get { AddProperty(Vendors.VadPayHoldReason); return this; } }
        public VendorsBuilder VadPayHoldUser { get { AddProperty(Vendors.VadPayHoldUser); return this; } }
        public VendorsBuilder VadRAddr_1 { get { AddProperty(Vendors.VadRAddr_1); return this; } }
        public VendorsBuilder VadRAddr_2 { get { AddProperty(Vendors.VadRAddr_2); return this; } }
        public VendorsBuilder VadRAddr_3 { get { AddProperty(Vendors.VadRAddr_3); return this; } }
        public VendorsBuilder VadRAddr_4 { get { AddProperty(Vendors.VadRAddr_4); return this; } }
        public VendorsBuilder VadRCity { get { AddProperty(Vendors.VadRCity); return this; } }
        public VendorsBuilder VadRCountry { get { AddProperty(Vendors.VadRCountry); return this; } }
        public VendorsBuilder VadRCounty { get { AddProperty(Vendors.VadRCounty); return this; } }
        public VendorsBuilder VadRecordDate { get { AddProperty(Vendors.VadRecordDate); return this; } }
        public VendorsBuilder VadRName { get { AddProperty(Vendors.VadRName); return this; } }
        public VendorsBuilder VadRowPointer { get { AddProperty(Vendors.VadRowPointer); return this; } }
        public VendorsBuilder VadRState { get { AddProperty(Vendors.VadRState); return this; } }
        public VendorsBuilder VadRZip { get { AddProperty(Vendors.VadRZip); return this; } }
        public VendorsBuilder VadState { get { AddProperty(Vendors.VadState); return this; } }
        public VendorsBuilder VadTelexNum { get { AddProperty(Vendors.VadTelexNum); return this; } }
        public VendorsBuilder VadZip { get { AddProperty(Vendors.VadZip); return this; } }
        public VendorsBuilder VCDescription { get { AddProperty(Vendors.VCDescription); return this; } }
        public VendorsBuilder VchOverPoCostTolerance { get { AddProperty(Vendors.VchOverPoCostTolerance); return this; } }
        public VendorsBuilder VchUnderPoCostTolerance { get { AddProperty(Vendors.VchUnderPoCostTolerance); return this; } }
        public VendorsBuilder VendNum { get { AddProperty(Vendors.VendNum); return this; } }
        public VendorsBuilder VendRemit { get { AddProperty(Vendors.VendRemit); return this; } }
        public VendorsBuilder VendType { get { AddProperty(Vendors.VendType); return this; } }
        public VendorsBuilder Whse { get { AddProperty(Vendors.Whse); return this; } }


    }

    public class VendorsFilterExpressionBuilder
        : FilterExpressionBuilder<VendorsBuilder>
    {
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Account
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Account); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> AccountName
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.AccountName); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ActiveForDataIntegration
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ActiveForDataIntegration); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaAddr_1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaAddr1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaAddr_2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaAddr2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaAddr_3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaAddr3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaAddr_4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaAddr4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaCity
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaCity); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaCountry
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaCountry); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaState
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaState); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankaZip
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankaZip); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BankCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BankCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BhName
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BhName); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> BranchId
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.BranchId); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Category
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Category); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Charfld1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Charfld1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Charfld2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Charfld2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Charfld3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Charfld3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Contact
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Contact); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CouEcCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CouEcCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrAmtFormat
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrAmtFormat); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrAmtTotFormat); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrCstPrcFormat
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrCstPrcFormat); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> CurrPartOfEuro
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.CurrPartOfEuro); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Datefld
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Datefld); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Decifld1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Decifld1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Decifld2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Decifld2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Decifld3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Decifld3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Delterm
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Delterm); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DelTermDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DelTermDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Der1099OutData
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Der1099OutData); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal5
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal5); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerAgeBal6
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerAgeBal6); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerDiscLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerDiscLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerDiscYtd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerDiscYtd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerFormatAddress
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerFormatAddress); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerNewAmount
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerNewAmount); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerNewDomesticAmount
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerNewDomesticAmount); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerOldAmount
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerOldAmount); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerOldDomesticAmount
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerOldDomesticAmount); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPayFiscalYTD
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPayFiscalYTD); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPayLastFiscalYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPayLastFiscalYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPayLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPayLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPayYTD
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPayYTD); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPurchLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPurchLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerPurchYTD
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerPurchYTD); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerRemoteAptrxpsCount
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerRemoteAptrxpsCount); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerTotalDifference
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerTotalDifference); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerType
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerType); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerVendNum
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerVendNum); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DerVoucher
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DerVoucher); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DiscLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DiscLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> DiscYtd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.DiscYtd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> EdiVend
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.EdiVend); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> EFTBankNum
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.EFTBankNum); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ExternalEmailAddr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ExternalEmailAddr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Fob
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Fob); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> IncludeTaxInCost
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.IncludeTaxInCost); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> InternalEmailAddr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.InternalEmailAddr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> InternetUrl
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.InternetUrl); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.InWorkflow); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> LangCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.LangCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> LastPaid
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.LastPaid); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> LastPurch
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.LastPurch); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> LcrReqd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.LcrReqd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Logifld
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Logifld); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Name
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Name); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.NoteExistsFlag); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayFiscalYTD
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayFiscalYTD); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayHoldDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayHoldDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayHoldReasonClass
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayHoldReasonClass); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayLastFiscalYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayLastFiscalYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayType
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayType); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PayYtd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PayYtd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Phone
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Phone); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PriceBy
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PriceBy); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PrintPrice
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PrintPrice); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PrintVATonPO
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PrintVATonPO); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ProcessInd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ProcessInd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurAcct
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurAcct); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurAcctUnit1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurAcctUnit1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurAcctUnit2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurAcctUnit2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurAcctUnit3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurAcctUnit3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurAcctUnit4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurAcctUnit4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurchLstYr
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurchLstYr); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurChtAccessUnit1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurChtAccessUnit1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurChtAccessUnit2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurChtAccessUnit2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurChtAccessUnit3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurChtAccessUnit3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurChtAccessUnit4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurChtAccessUnit4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurChtDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurChtDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> PurchYtd
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.PurchYtd); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.RecordDate); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> RequestAcknowledgement
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.RequestAcknowledgement); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.RowPointer); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ShipCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ShipCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ShipCodeDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ShipCodeDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> ShowInDropDownList
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.ShowInDropDownList); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLApdraftts
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLApdraftts); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLAptrxpAlls
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLAptrxpAlls); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLAptrxps
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLAptrxps); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLGrnHdrs
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLGrnHdrs); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLGrnLines
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLGrnLines); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLGrnLinesFiltered
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLGrnLinesFiltered); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLItemvends
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLItemvends); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLPoItems
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLPoItems); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLPoItemsFiltered
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLPoItemsFiltered); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLPos
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLPos); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SLVendlogs
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SLVendlogs); }
        }
 
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Stat
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Status); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SupplyWebVendor
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SupplyWebVendor); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> SynchronizedToBus
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.SynchronizedToBus); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Tax1Description
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Tax1Description); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Tax2Description
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Tax2Description); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TaxCode1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TaxCode1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TaxCode2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TaxCode2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TaxRegNum1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TaxRegNum1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TaxRegNum2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TaxRegNum2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TerDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TerDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TermsCode
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TermsCode); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Transit
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Transit); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TransNat
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TransNat); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TransNat2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TransNat2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TransNat2Description
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TransNat2Description); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> TransNatDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.TransNatDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadAddr_1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadAddr_1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadAddr_2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadAddr_2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadAddr_3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadAddr_3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadAddr_4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadAddr_4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadCity
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadCity); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadCountry
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadCountry); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadCounty
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadCounty); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadFaxNum
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadFaxNum); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadPayHold
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadPayHold); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadPayHoldDate
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadPayHoldDate); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadPayHoldReason
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadPayHoldReason); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadPayHoldUser
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadPayHoldUser); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRAddr_1
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRAddr_1); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRAddr_2
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRAddr_2); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRAddr_3
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRAddr_3); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRAddr_4
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRAddr_4); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRCity
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRCity); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRCountry
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRCountry); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRCounty
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRCounty); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRecordDate
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRecordDate); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRName
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRName); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRowPointer
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRowPointer); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRState
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRState); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadRZip
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadRZip); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadState
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadState); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadTelexNum
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadTelexNum); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VadZip
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VadZip); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VCDescription
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VCDescription); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VchOverPoCostTolerance
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VchOverPoCostTolerance); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VchUnderPoCostTolerance
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VchUnderPoCostTolerance); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VendNum); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VendRemit
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VendRemit); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> VendType
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.VendType); }
        }
        public FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<VendorsBuilder, VendorsFilterExpressionBuilder>(_builder, Vendors.Whse); }
        }


    }
}
