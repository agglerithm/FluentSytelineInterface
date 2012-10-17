using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class Customers : IdoConstants
    {
        public const string IDO_NAME = "SL.SLCustomers";
        public const string Address1 = "Addr_1";
        public const string Address2 = "Addr_2"; 
        public const string BalMethod = "BalMethod";
        public const string BankCode = "BankCode";
        public const string BranchId = "BranchId";
        public const string City = "City";
        public const string Contact = "Contact_1";
        public const string Contact2 = "Contact_2";
        public const string Country = "Country"; 
        public const string County = "County";
        public const string Currency = "CurrCode"; 
        public const string CustomerNumber = "CustNum";  
        public const string CustomerSequence = "CustSeq";
        public const string CustType = "CustType";  
        public const string Delterm = "Delterm"; 
        public const string DoInvoice = "DoInvoice";  
        public const string EndUserType = "EndUserType"; 
        public const string InvCategory = "InvCategory";
        public const string InvFreq = "InvFreq";   
        public const string Name = "Name";     
        public const string ShipCode = "ShipCode";
       // public const string SICCode = "SICCode"; 
        public const string Slsman = "Slsman";
        public const string State = "State"; 
        public const string TaxCode = "TaxCode1";
        public const string TaxRegNum = "TaxRegNum1";
        public const string TermsCode = "TermsCode";
        public const string TerritoryCode = "TerritoryCode";   
        public const string Whse = "Whse";
        public const string Zip = "Zip"; 
        public const string Address3 = "Addr_3";
        public const string Address4 = "Addr_4";
        public const string AdrRecordDate = "AdrRecordDate";
        public const string AdrRowPointer = "AdrRowPointer";
        public const string AmtOverInvAmt = "AmtOverInvAmt";
        public const string ApsPullUp = "ApsPullUp";
        public const string AvgBalOs = "AvgBalOs";
        public const string AvgDaysOs = "AvgDaysOs"; 
        public const string BillToCountry = "BillToCountry";
        public const string BillToEmail = "BillToEmail"; 
        public const string CalcDate = "CalcDate";
        public const string CcContact_2 = "CcContact_2";
        public const string CcExportType = "CcExportType";
        public const string CcPhone_2 = "CcPhone_2";
        public const string Charfld1 = "Charfld1";
        public const string Charfld2 = "Charfld2";
        public const string Charfld3 = "Charfld3"; 
        public const string CompanyRevenue = "CompanyRevenue";
        public const string Consolidate = "Consolidate";
        public const string Contact_1 = "Contact_1";
        public const string Contact_2 = "Contact_2";
        public const string Contact_3 = "Contact_3";
        public const string CorpAddress = "CorpAddress";
        public const string CorpadrAddr_1 = "CorpadrAddr_1";
        public const string CorpadrAddr_2 = "CorpadrAddr_2";
        public const string CorpadrAddr_3 = "CorpadrAddr_3";
        public const string CorpadrAddr_4 = "CorpadrAddr_4";
        public const string CorpadrCity = "CorpadrCity";
        public const string CorpadrCountry = "CorpadrCountry";
        public const string CorpadrCounty = "CorpadrCounty";
        public const string CorpadrCreditHold = "CorpadrCreditHold";
        public const string CorpadrCurrCode = "CorpadrCurrCode";
        public const string CorpadrFaxNum = "CorpadrFaxNum";
        public const string CorpadrName = "CorpadrName";
        public const string CorpadrState = "CorpadrState";
        public const string CorpadrZip = "CorpadrZip";
        public const string CorpCred = "CorpCred";
        public const string CorpCust = "CorpCust";
        public const string CorpDisplayAddress = "CorpDisplayAddress";
        public const string CouExpDocReqd = "CouExpDocReqd"; 
        public const string CreateDate = "CreateDate";
        public const string CreditHold = "CreditHold";
        public const string CreditHoldDate = "CreditHoldDate";
        public const string CreditHoldDescription = "CreditHoldDescription";
        public const string CreditHoldReason = "CreditHoldReason";
        public const string CreditHoldUser = "CreditHoldUser";
        public const string CreditLimit = "CreditLimit";
        public const string CrmGuid = "CrmGuid";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCode = "CurrCode";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string CustBank = "CustBank";
        public const string CustNum = "CustNum";
        public const string CustNum_1 = "CustNum_1";
        public const string CustomerEmailAddr = "CustomerEmailAddr";
        public const string CustSeq = "CustSeq";
        public const string CustSeq_1 = "CustSeq_1"; 
        public const string Datefld = "Datefld";
        public const string DaysOverInvDueDate = "DaysOverInvDueDate";
        public const string Decifld1 = "Decifld1";
        public const string Decifld2 = "Decifld2";
        public const string Decifld3 = "Decifld3"; 
        public const string DeltermDescription = "DeltermDescription";
        public const string DerBillToAddress = "DerBillToAddress";
        public const string DerCreditHold = "DerCreditHold";
        public const string DerCustNum = "DerCustNum";
        public const string DerDiscLstYr = "DerDiscLstYr";
        public const string DerDiscYtd = "DerDiscYtd";
        public const string DerGlobal = "DerGlobal";
        public const string DerOrderBal = "DerOrderBal";
        public const string DerPostedBal = "DerPostedBal";
        public const string DerSalesLstYr = "DerSalesLstYr";
        public const string DerSalesPtd = "DerSalesPtd";
        public const string DerSalesYtd = "DerSalesYtd";
        public const string DerShipToAddress = "DerShipToAddress";
        public const string DiscLstYr = "DiscLstYr";
        public const string DiscYtd = "DiscYtd"; 
        public const string DraftPrintFlag = "DraftPrintFlag";
        public const string EcCode = "EcCode";
        public const string EdiCust = "EdiCust";
        public const string Einvoice = "Einvoice"; 
        public const string EndUserTypeDesc = "EndUserTypeDesc";
        public const string EtpArAcct = "EtpArAcct";
        public const string EtpArAcctUnit1 = "EtpArAcctUnit1";
        public const string EtpArAcctUnit2 = "EtpArAcctUnit2";
        public const string EtpArAcctUnit3 = "EtpArAcctUnit3";
        public const string EtpArAcctUnit4 = "EtpArAcctUnit4";
        public const string ExportType = "ExportType";
        public const string ExternalEmailAddr = "ExternalEmailAddr";
        public const string FaxNum = "FaxNum";
        public const string FinChg = "FinChg";
        public const string HistDaysOs = "HistDaysOs";
        public const string IncludeTaxInPrice = "IncludeTaxInPrice";
        public const string InternalEmailAddr = "InternalEmailAddr";
        public const string InternetUrl = "InternetUrl"; 
        public const string InvCategoryDescription = "InvCategoryDescription"; 
        public const string InWorkflow = "InWorkflow";
        public const string LangCode = "LangCode";
        public const string LargDaysOs = "LargDaysOs";
        public const string LargeBalOs = "LargeBalOs";
        public const string LastBalOs = "LastBalOs";
        public const string LastDaysOs = "LastDaysOs";
        public const string LastFinChg = "LastFinChg";
        public const string LastInv = "LastInv";
        public const string LastPaid = "LastPaid";
        public const string LcrReqd = "LcrReqd";
        public const string Logifld = "Logifld"; 
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string NumberOfEmployees = "NumberOfEmployees";
        public const string NumInvoices = "NumInvoices";
        public const string NumPeriods = "NumPeriods";
        public const string OnePackInv = "OnePackInv";
        public const string PayDay = "PayDay";
        public const string PayDayEndTime_1 = "PayDayEndTime_1";
        public const string PayDayEndTime_2 = "PayDayEndTime_2";
        public const string PayDayStartTime_1 = "PayDayStartTime_1";
        public const string PayDayStartTime_2 = "PayDayStartTime_2";
        public const string PayType = "PayType";
        public const string Phone_1 = "Phone_1";
        public const string Phone_2 = "Phone_2";
        public const string Phone_3 = "Phone_3";
        public const string Pricecode = "Pricecode";
        public const string PricecodeDescription = "PricecodeDescription";
        public const string PrintPackInv = "PrintPackInv";
        public const string ProcessInd = "ProcessInd";
        public const string RcvInternalEmail = "RcvInternalEmail";
        public const string RecordDate = "RecordDate";
        public const string RevisionDay = "RevisionDay";
        public const string RevisionDayEndTime_1 = "RevisionDayEndTime_1";
        public const string RevisionDayEndTime_2 = "RevisionDayEndTime_2";
        public const string RevisionDayStartTime_1 = "RevisionDayStartTime_1";
        public const string RevisionDayStartTime_2 = "RevisionDayStartTime_2";
        public const string RowPointer = "RowPointer";
        public const string SalesLstYr = "SalesLstYr";
        public const string SalesPtd = "SalesPtd";
        public const string SalesYtd = "SalesYtd";
        public const string SendCustomerEmail = "SendCustomerEmail"; 
        public const string ShipCodeDescription = "ShipCodeDescription";
        public const string ShipEarly = "ShipEarly";
        public const string ShipPartial = "ShipPartial";
        public const string ShipSite = "ShipSite";
        public const string ShipToEmail = "ShipToEmail";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string ShowInShipToDropDownList = "ShowInShipToDropDownList";
        public const string SICCode = "SICCode";
        public const string SLCoitems = "SLCoitems";
        public const string SLCoitemsEstimates = "SLCoitemsEstimates";
        public const string SLCoitemsEstimatesFiltered = "SLCoitemsEstimatesFiltered";
        public const string SLCoitemsFiltered = "SLCoitemsFiltered";
        public const string SLCos = "SLCos";
        public const string SLCosEstimates = "SLCosEstimates";
        public const string SLCustlogs = "SLCustlogs";
        public const string SLCustomerContacts = "SLCustomerContacts"; 
        public const string SLDoSeqs = "SLDoSeqs";
        public const string SLItemcusts = "SLItemcusts"; 
        public const string StateCycle = "StateCycle";
        public const string Summarize = "Summarize";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode1Description = "TaxCode1Description";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxCode2Description = "TaxCode2Description";
        public const string TaxRegNum1 = "TaxRegNum1";
        public const string TaxRegNum2 = "TaxRegNum2";
        public const string TelexNum = "TelexNum";
        public const string TermDescription = "TermDescription"; 
        public const string TerrDescription = "TerrDescription"; 
        public const string TransNat = "TransNat";
        public const string TransNat2 = "TransNat2";
        public const string TransNat2Description = "TransNat2Description";
        public const string TransNatDescription = "TransNatDescription";
        public const string UBRowPointer = "UBRowPointer";
        public const string UseExchRate = "UseExchRate";
        public const string UseRevisionPayDays = "UseRevisionPayDays"; 
        public static CustomersBuilder GetFullProjection()
        {
            return FromSyteline.Customers.Address1.Address2.BalMethod.BankCode.BranchId.City.Zip
                .Contact.Contact2.Country.County.Currency.CustomerNumber
                .CustomerSequence.CustType.Delterm.DoInvoice.EndUserType
                .InvCategory.InvFreq.Name
                .RowPointer.ShipCode.Slsman.State
                .TaxCode.TaxRegNum.TermsCode.TerritoryCode.Whse;
        }

    }

 

    public class CustomersBuilder :
        IdoQueryBuilder<CustomersBuilder, CustomersFilterExpressionBuilder>
    {
        public CustomersBuilder(IExpressionInterpreter ei) : base(Customers.IDO_NAME, ei) { }
        public CustomersBuilder CustomerNumber { get { AddProperty(Customers.CustomerNumber); return this; } }
        public CustomersBuilder Contact { get { AddProperty(Customers.Contact); return this; } }
        public CustomersBuilder Currency { get { AddProperty(Customers.Currency); return this; } }
        public CustomersBuilder BankCode { get { AddProperty(Customers.BankCode); return this; } }
        public CustomersBuilder CustomerSequence { get { AddProperty(Customers.CustomerSequence); return this; } }
        public CustomersBuilder Address1 { get { AddProperty(Customers.Address1); return this; } }
        public CustomersBuilder Address2 { get { AddProperty(Customers.Address2); return this; } }  
        public CustomersBuilder BalMethod { get { AddProperty(Customers.BalMethod); return this; } } 
  
        public CustomersBuilder BranchId { get { AddProperty(Customers.BranchId); return this; } }
        public CustomersBuilder City { get { AddProperty(Customers.City); return this; } } 
        public CustomersBuilder Contact2 { get { AddProperty(Customers.Contact2); return this; } }
        public CustomersBuilder Country { get { AddProperty(Customers.Country); return this; } }
        public CustomersBuilder County { get { AddProperty(Customers.County); return this; } }    
        public CustomersBuilder CustType { get { AddProperty(Customers.CustType); return this; } }  
        public CustomersBuilder Delterm { get { AddProperty(Customers.Delterm); return this; } } 
        public CustomersBuilder DoInvoice { get { AddProperty(Customers.DoInvoice); return this; } } 
        public CustomersBuilder EndUserType { get { AddProperty(Customers.EndUserType); return this; } } 
        public CustomersBuilder InvCategory { get { AddProperty(Customers.InvCategory); return this; } }
        public CustomersBuilder InvFreq { get { AddProperty(Customers.InvFreq); return this; } }   
        public CustomersBuilder Name { get { AddProperty(Customers.Name); return this; } }     
        public CustomersBuilder ShipCode { get { AddProperty(Customers.ShipCode); return this; } }
       // public CustomersBuilder SICCode { get { AddProperty(Customers.SICCode); return this; } } 
        public CustomersBuilder Slsman { get { AddProperty(Customers.Slsman); return this; } }
        public CustomersBuilder State { get { AddProperty(Customers.State); return this; } } 
        public CustomersBuilder TaxCode { get { AddProperty(Customers.TaxCode); return this; } }
        public CustomersBuilder TaxRegNum { get { AddProperty(Customers.TaxRegNum); return this; } }
        public CustomersBuilder TermsCode { get { AddProperty(Customers.TermsCode); return this; } }
        public CustomersBuilder TerritoryCode { get { AddProperty(Customers.TerritoryCode); return this; } } 
        public CustomersBuilder Zip { get { AddProperty(Customers.Zip); return this; } } 
        public CustomersBuilder Whse { get { AddProperty(Customers.Whse); return this; } }
        public CustomersBuilder Address3 { get { AddProperty(Customers.Address3); return this; } }
        public CustomersBuilder Address4 { get { AddProperty(Customers.Address4); return this; } }
        public CustomersBuilder AdrRecordDate { get { AddProperty(Customers.AdrRecordDate); return this; } }
        public CustomersBuilder AdrRowPointer { get { AddProperty(Customers.AdrRowPointer); return this; } }
        public CustomersBuilder AmtOverInvAmt { get { AddProperty(Customers.AmtOverInvAmt); return this; } }
        public CustomersBuilder ApsPullUp { get { AddProperty(Customers.ApsPullUp); return this; } }
        public CustomersBuilder AvgBalOs { get { AddProperty(Customers.AvgBalOs); return this; } }
        public CustomersBuilder AvgDaysOs { get { AddProperty(Customers.AvgDaysOs); return this; } } 
        public CustomersBuilder BillToCountry { get { AddProperty(Customers.BillToCountry); return this; } }
        public CustomersBuilder BillToEmail { get { AddProperty(Customers.BillToEmail); return this; } } 
        public CustomersBuilder CalcDate { get { AddProperty(Customers.CalcDate); return this; } }
        public CustomersBuilder CcContact_2 { get { AddProperty(Customers.CcContact_2); return this; } }
        public CustomersBuilder CcExportType { get { AddProperty(Customers.CcExportType); return this; } }
        public CustomersBuilder CcPhone_2 { get { AddProperty(Customers.CcPhone_2); return this; } }
        public CustomersBuilder Charfld1 { get { AddProperty(Customers.Charfld1); return this; } }
        public CustomersBuilder Charfld2 { get { AddProperty(Customers.Charfld2); return this; } }
        public CustomersBuilder Charfld3 { get { AddProperty(Customers.Charfld3); return this; } } 
        public CustomersBuilder CompanyRevenue { get { AddProperty(Customers.CompanyRevenue); return this; } }
        public CustomersBuilder Consolidate { get { AddProperty(Customers.Consolidate); return this; } }
        public CustomersBuilder Contact_1 { get { AddProperty(Customers.Contact_1); return this; } }
        public CustomersBuilder Contact_2 { get { AddProperty(Customers.Contact_2); return this; } }
        public CustomersBuilder Contact_3 { get { AddProperty(Customers.Contact_3); return this; } }
        public CustomersBuilder CorpAddress { get { AddProperty(Customers.CorpAddress); return this; } }
        public CustomersBuilder CorpadrAddr_1 { get { AddProperty(Customers.CorpadrAddr_1); return this; } }
        public CustomersBuilder CorpadrAddr_2 { get { AddProperty(Customers.CorpadrAddr_2); return this; } }
        public CustomersBuilder CorpadrAddr_3 { get { AddProperty(Customers.CorpadrAddr_3); return this; } }
        public CustomersBuilder CorpadrAddr_4 { get { AddProperty(Customers.CorpadrAddr_4); return this; } }
        public CustomersBuilder CorpadrCity { get { AddProperty(Customers.CorpadrCity); return this; } }
        public CustomersBuilder CorpadrCountry { get { AddProperty(Customers.CorpadrCountry); return this; } }
        public CustomersBuilder CorpadrCounty { get { AddProperty(Customers.CorpadrCounty); return this; } }
        public CustomersBuilder CorpadrCreditHold { get { AddProperty(Customers.CorpadrCreditHold); return this; } }
        public CustomersBuilder CorpadrCurrCode { get { AddProperty(Customers.CorpadrCurrCode); return this; } }
        public CustomersBuilder CorpadrFaxNum { get { AddProperty(Customers.CorpadrFaxNum); return this; } }
        public CustomersBuilder CorpadrName { get { AddProperty(Customers.CorpadrName); return this; } }
        public CustomersBuilder CorpadrState { get { AddProperty(Customers.CorpadrState); return this; } }
        public CustomersBuilder CorpadrZip { get { AddProperty(Customers.CorpadrZip); return this; } }
        public CustomersBuilder CorpCred { get { AddProperty(Customers.CorpCred); return this; } }
        public CustomersBuilder CorpCust { get { AddProperty(Customers.CorpCust); return this; } }
        public CustomersBuilder CorpDisplayAddress { get { AddProperty(Customers.CorpDisplayAddress); return this; } }
        public CustomersBuilder CouExpDocReqd { get { AddProperty(Customers.CouExpDocReqd); return this; } } 
        public CustomersBuilder CreateDate { get { AddProperty(Customers.CreateDate); return this; } }
        public CustomersBuilder CreditHold { get { AddProperty(Customers.CreditHold); return this; } }
        public CustomersBuilder CreditHoldDate { get { AddProperty(Customers.CreditHoldDate); return this; } }
        public CustomersBuilder CreditHoldDescription { get { AddProperty(Customers.CreditHoldDescription); return this; } }
        public CustomersBuilder CreditHoldReason { get { AddProperty(Customers.CreditHoldReason); return this; } }
        public CustomersBuilder CreditHoldUser { get { AddProperty(Customers.CreditHoldUser); return this; } }
        public CustomersBuilder CreditLimit { get { AddProperty(Customers.CreditLimit); return this; } }
        public CustomersBuilder CrmGuid { get { AddProperty(Customers.CrmGuid); return this; } }
        public CustomersBuilder CurrAmtFormat { get { AddProperty(Customers.CurrAmtFormat); return this; } }
        public CustomersBuilder CurrAmtTotFormat { get { AddProperty(Customers.CurrAmtTotFormat); return this; } }
        public CustomersBuilder CurrCode { get { AddProperty(Customers.CurrCode); return this; } }
        public CustomersBuilder CurrCstPrcFormat { get { AddProperty(Customers.CurrCstPrcFormat); return this; } }
        public CustomersBuilder CustBank { get { AddProperty(Customers.CustBank); return this; } }
        public CustomersBuilder CustNum { get { AddProperty(Customers.CustNum); return this; } }
        public CustomersBuilder CustNum_1 { get { AddProperty(Customers.CustNum_1); return this; } }
        public CustomersBuilder CustomerEmailAddr { get { AddProperty(Customers.CustomerEmailAddr); return this; } }
        public CustomersBuilder CustSeq { get { AddProperty(Customers.CustSeq); return this; } }
        public CustomersBuilder CustSeq_1 { get { AddProperty(Customers.CustSeq_1); return this; } } 
        public CustomersBuilder Datefld { get { AddProperty(Customers.Datefld); return this; } }
        public CustomersBuilder DaysOverInvDueDate { get { AddProperty(Customers.DaysOverInvDueDate); return this; } }
        public CustomersBuilder Decifld1 { get { AddProperty(Customers.Decifld1); return this; } }
        public CustomersBuilder Decifld2 { get { AddProperty(Customers.Decifld2); return this; } }
        public CustomersBuilder Decifld3 { get { AddProperty(Customers.Decifld3); return this; } } 
        public CustomersBuilder DeltermDescription { get { AddProperty(Customers.DeltermDescription); return this; } }
        public CustomersBuilder DerBillToAddress { get { AddProperty(Customers.DerBillToAddress); return this; } }
        public CustomersBuilder DerCreditHold { get { AddProperty(Customers.DerCreditHold); return this; } }
        public CustomersBuilder DerCustNum { get { AddProperty(Customers.DerCustNum); return this; } }
        public CustomersBuilder DerDiscLstYr { get { AddProperty(Customers.DerDiscLstYr); return this; } }
        public CustomersBuilder DerDiscYtd { get { AddProperty(Customers.DerDiscYtd); return this; } }
        public CustomersBuilder DerGlobal { get { AddProperty(Customers.DerGlobal); return this; } }
        public CustomersBuilder DerOrderBal { get { AddProperty(Customers.DerOrderBal); return this; } }
        public CustomersBuilder DerPostedBal { get { AddProperty(Customers.DerPostedBal); return this; } }
        public CustomersBuilder DerSalesLstYr { get { AddProperty(Customers.DerSalesLstYr); return this; } }
        public CustomersBuilder DerSalesPtd { get { AddProperty(Customers.DerSalesPtd); return this; } }
        public CustomersBuilder DerSalesYtd { get { AddProperty(Customers.DerSalesYtd); return this; } }
        public CustomersBuilder DerShipToAddress { get { AddProperty(Customers.DerShipToAddress); return this; } }
        public CustomersBuilder DiscLstYr { get { AddProperty(Customers.DiscLstYr); return this; } }
        public CustomersBuilder DiscYtd { get { AddProperty(Customers.DiscYtd); return this; } } 
        public CustomersBuilder DraftPrintFlag { get { AddProperty(Customers.DraftPrintFlag); return this; } }
        public CustomersBuilder EcCode { get { AddProperty(Customers.EcCode); return this; } }
        public CustomersBuilder EdiCust { get { AddProperty(Customers.EdiCust); return this; } }
        public CustomersBuilder Einvoice { get { AddProperty(Customers.Einvoice); return this; } } 
        public CustomersBuilder EndUserTypeDesc { get { AddProperty(Customers.EndUserTypeDesc); return this; } }
        public CustomersBuilder EtpArAcct { get { AddProperty(Customers.EtpArAcct); return this; } }
        public CustomersBuilder EtpArAcctUnit1 { get { AddProperty(Customers.EtpArAcctUnit1); return this; } }
        public CustomersBuilder EtpArAcctUnit2 { get { AddProperty(Customers.EtpArAcctUnit2); return this; } }
        public CustomersBuilder EtpArAcctUnit3 { get { AddProperty(Customers.EtpArAcctUnit3); return this; } }
        public CustomersBuilder EtpArAcctUnit4 { get { AddProperty(Customers.EtpArAcctUnit4); return this; } }
        public CustomersBuilder ExportType { get { AddProperty(Customers.ExportType); return this; } }
        public CustomersBuilder ExternalEmailAddr { get { AddProperty(Customers.ExternalEmailAddr); return this; } }
        public CustomersBuilder FaxNum { get { AddProperty(Customers.FaxNum); return this; } }
        public CustomersBuilder FinChg { get { AddProperty(Customers.FinChg); return this; } }
        public CustomersBuilder HistDaysOs { get { AddProperty(Customers.HistDaysOs); return this; } }
        public CustomersBuilder IncludeTaxInPrice { get { AddProperty(Customers.IncludeTaxInPrice); return this; } }
        public CustomersBuilder InternalEmailAddr { get { AddProperty(Customers.InternalEmailAddr); return this; } }
        public CustomersBuilder InternetUrl { get { AddProperty(Customers.InternetUrl); return this; } } 
        public CustomersBuilder InvCategoryDescription { get { AddProperty(Customers.InvCategoryDescription); return this; } } 
        public CustomersBuilder InWorkflow { get { AddProperty(Customers.InWorkflow); return this; } }
        public CustomersBuilder LangCode { get { AddProperty(Customers.LangCode); return this; } }
        public CustomersBuilder LargDaysOs { get { AddProperty(Customers.LargDaysOs); return this; } }
        public CustomersBuilder LargeBalOs { get { AddProperty(Customers.LargeBalOs); return this; } }
        public CustomersBuilder LastBalOs { get { AddProperty(Customers.LastBalOs); return this; } }
        public CustomersBuilder LastDaysOs { get { AddProperty(Customers.LastDaysOs); return this; } }
        public CustomersBuilder LastFinChg { get { AddProperty(Customers.LastFinChg); return this; } }
        public CustomersBuilder LastInv { get { AddProperty(Customers.LastInv); return this; } }
        public CustomersBuilder LastPaid { get { AddProperty(Customers.LastPaid); return this; } }
        public CustomersBuilder LcrReqd { get { AddProperty(Customers.LcrReqd); return this; } }
        public CustomersBuilder Logifld { get { AddProperty(Customers.Logifld); return this; } } 
        public CustomersBuilder NoteExistsFlag { get { AddProperty(Customers.NoteExistsFlag); return this; } }
        public CustomersBuilder NumberOfEmployees { get { AddProperty(Customers.NumberOfEmployees); return this; } }
        public CustomersBuilder NumInvoices { get { AddProperty(Customers.NumInvoices); return this; } }
        public CustomersBuilder NumPeriods { get { AddProperty(Customers.NumPeriods); return this; } }
        public CustomersBuilder OnePackInv { get { AddProperty(Customers.OnePackInv); return this; } }
        public CustomersBuilder PayDay { get { AddProperty(Customers.PayDay); return this; } }
        public CustomersBuilder PayDayEndTime_1 { get { AddProperty(Customers.PayDayEndTime_1); return this; } }
        public CustomersBuilder PayDayEndTime_2 { get { AddProperty(Customers.PayDayEndTime_2); return this; } }
        public CustomersBuilder PayDayStartTime_1 { get { AddProperty(Customers.PayDayStartTime_1); return this; } }
        public CustomersBuilder PayDayStartTime_2 { get { AddProperty(Customers.PayDayStartTime_2); return this; } }
        public CustomersBuilder PayType { get { AddProperty(Customers.PayType); return this; } }
        public CustomersBuilder Phone_1 { get { AddProperty(Customers.Phone_1); return this; } }
        public CustomersBuilder Phone_2 { get { AddProperty(Customers.Phone_2); return this; } }
        public CustomersBuilder Phone_3 { get { AddProperty(Customers.Phone_3); return this; } }
        public CustomersBuilder Pricecode { get { AddProperty(Customers.Pricecode); return this; } }
        public CustomersBuilder PricecodeDescription { get { AddProperty(Customers.PricecodeDescription); return this; } }
        public CustomersBuilder PrintPackInv { get { AddProperty(Customers.PrintPackInv); return this; } }
        public CustomersBuilder ProcessInd { get { AddProperty(Customers.ProcessInd); return this; } }
        public CustomersBuilder RcvInternalEmail { get { AddProperty(Customers.RcvInternalEmail); return this; } }
        public CustomersBuilder RecordDate { get { AddProperty(Customers.RecordDate); return this; } }
        public CustomersBuilder RevisionDay { get { AddProperty(Customers.RevisionDay); return this; } }
        public CustomersBuilder RevisionDayEndTime_1 { get { AddProperty(Customers.RevisionDayEndTime_1); return this; } }
        public CustomersBuilder RevisionDayEndTime_2 { get { AddProperty(Customers.RevisionDayEndTime_2); return this; } }
        public CustomersBuilder RevisionDayStartTime_1 { get { AddProperty(Customers.RevisionDayStartTime_1); return this; } }
        public CustomersBuilder RevisionDayStartTime_2 { get { AddProperty(Customers.RevisionDayStartTime_2); return this; } } 
        public CustomersBuilder SalesLstYr { get { AddProperty(Customers.SalesLstYr); return this; } }
        public CustomersBuilder SalesPtd { get { AddProperty(Customers.SalesPtd); return this; } }
        public CustomersBuilder SalesYtd { get { AddProperty(Customers.SalesYtd); return this; } }
        public CustomersBuilder SendCustomerEmail { get { AddProperty(Customers.SendCustomerEmail); return this; } } 
        public CustomersBuilder ShipCodeDescription { get { AddProperty(Customers.ShipCodeDescription); return this; } }
        public CustomersBuilder ShipEarly { get { AddProperty(Customers.ShipEarly); return this; } }
        public CustomersBuilder ShipPartial { get { AddProperty(Customers.ShipPartial); return this; } }
        public CustomersBuilder ShipSite { get { AddProperty(Customers.ShipSite); return this; } }
        public CustomersBuilder ShipToEmail { get { AddProperty(Customers.ShipToEmail); return this; } }
        public CustomersBuilder ShowInDropDownList { get { AddProperty(Customers.ShowInDropDownList); return this; } }
        public CustomersBuilder ShowInShipToDropDownList { get { AddProperty(Customers.ShowInShipToDropDownList); return this; } }
        public CustomersBuilder SICCode { get { AddProperty(Customers.SICCode); return this; } }
        public CustomersBuilder SLCoitems { get { AddProperty(Customers.SLCoitems); return this; } }
        public CustomersBuilder SLCoitemsEstimates { get { AddProperty(Customers.SLCoitemsEstimates); return this; } }
        public CustomersBuilder SLCoitemsEstimatesFiltered { get { AddProperty(Customers.SLCoitemsEstimatesFiltered); return this; } }
        public CustomersBuilder SLCoitemsFiltered { get { AddProperty(Customers.SLCoitemsFiltered); return this; } }
        public CustomersBuilder SLCos { get { AddProperty(Customers.SLCos); return this; } }
        public CustomersBuilder SLCosEstimates { get { AddProperty(Customers.SLCosEstimates); return this; } }
        public CustomersBuilder SLCustlogs { get { AddProperty(Customers.SLCustlogs); return this; } }
        public CustomersBuilder SLCustomerContacts { get { AddProperty(Customers.SLCustomerContacts); return this; } } 
        public CustomersBuilder SLDoSeqs { get { AddProperty(Customers.SLDoSeqs); return this; } }
        public CustomersBuilder SLItemcusts { get { AddProperty(Customers.SLItemcusts); return this; } } 
        public CustomersBuilder StateCycle { get { AddProperty(Customers.StateCycle); return this; } }
        public CustomersBuilder Summarize { get { AddProperty(Customers.Summarize); return this; } }
        public CustomersBuilder TaxCode1 { get { AddProperty(Customers.TaxCode1); return this; } }
        public CustomersBuilder TaxCode1Description { get { AddProperty(Customers.TaxCode1Description); return this; } }
        public CustomersBuilder TaxCode2 { get { AddProperty(Customers.TaxCode2); return this; } }
        public CustomersBuilder TaxCode2Description { get { AddProperty(Customers.TaxCode2Description); return this; } }
        public CustomersBuilder TaxRegNum1 { get { AddProperty(Customers.TaxRegNum1); return this; } }
        public CustomersBuilder TaxRegNum2 { get { AddProperty(Customers.TaxRegNum2); return this; } }
        public CustomersBuilder TelexNum { get { AddProperty(Customers.TelexNum); return this; } }
        public CustomersBuilder TermDescription { get { AddProperty(Customers.TermDescription); return this; } } 
        public CustomersBuilder TerrDescription { get { AddProperty(Customers.TerrDescription); return this; } } 
        public CustomersBuilder TransNat { get { AddProperty(Customers.TransNat); return this; } }
        public CustomersBuilder TransNat2 { get { AddProperty(Customers.TransNat2); return this; } }
        public CustomersBuilder TransNat2Description { get { AddProperty(Customers.TransNat2Description); return this; } }
        public CustomersBuilder TransNatDescription { get { AddProperty(Customers.TransNatDescription); return this; } }
        public CustomersBuilder UBRowPointer { get { AddProperty(Customers.UBRowPointer); return this; } }
        public CustomersBuilder UseExchRate { get { AddProperty(Customers.UseExchRate); return this; } }
        public CustomersBuilder UseRevisionPayDays { get { AddProperty(Customers.UseRevisionPayDays); return this; } } 

        public CustomersBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (CustomersBuilder) base.WithChildren(builders);
        }

        public CustomersBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (CustomersBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class CustomersFilterExpressionBuilder : FilterExpressionBuilder<CustomersBuilder>
    {
        public FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder> CustomerNumber
        {
            get { return new FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder>(_builder, Customers.CustomerNumber); }
        }
        public FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder> Currency
        {
            get { return new FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder>(_builder, Customers.Currency); }
        }
        public FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder> BankCode
        {
            get { return new FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder>(_builder, Customers.BankCode); }
        }
        public FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder> CustomerSequence
        {
            get { return new FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder>(_builder, Customers.CustomerSequence); }
        }

        public FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder> CustomerName
        {
            get { return new FilterExpression<CustomersBuilder, CustomersFilterExpressionBuilder>(_builder, Customers.Name); }
        }
    }

    public class CustomersValues : IdoCommandBuilder
    {
        public CustomersValues() : base(Customers.IDO_NAME) {}
 
        public CustomersValues CustomerNumber(string value)
        {
            AddValue(Customers.CustomerNumber, value);
            return this;
        }
        public CustomersValues Currency(string value)
        {
            AddValue(Customers.Currency, value);
            return this;
        }
        public CustomersValues BankCode(string value)
        {
            AddValue(Customers.BankCode, value);
            return this;
        }
        public CustomersValues CustomerSequence(string value)
        {
            AddValue(Customers.CustomerSequence, value);
            return this;
        }

        public IIdoCommandBuilder Contact(string value)
        {
            AddValue(Customers.Contact, value);
            return this;
        }

        public IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.Customers.Add(get_property_names());
        }
    }
}