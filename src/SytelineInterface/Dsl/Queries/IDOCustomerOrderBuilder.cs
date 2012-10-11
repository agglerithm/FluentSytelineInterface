using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{ 
    public class CustomerOrder : IdoConstants
    {
        public const string IDO_NAME = "SL.SLCos";
        public const string BillToAddress1 = "BillToAddr_1";
        public const string BillToAddress2 = "BillToAddr_2"; 
        public const string BillToCity = "BillToCity";
        public const string BillToContact = "BillToContact_3"; 
        public const string BillToName = "BillToName"; 
        public const string BillToState = "BillToState";
        public const string BillToZip = "BillToZip";
        public const string CustomerNumber = "CustNum";
        public const string CustSeq = "CustSeq";
        public const string OrderDate = "OrderDate";
        public const string OrderNumber = "CoNum";
        public const string Site = "OrigSite";
        public const string Warehouse = "Whse";
        public const string ShipToCode = "CustSeq";
        public const string OrderType = "Type";
        public const string PONumber = "CustPo";
        public const string Status = "Stat"; 
        public const string Salesman = "Slsman";
        public const string EndUserType = "EndUserType";
        public const string Discount = "Disc";
        public const string TaxCode = "TaxCode1";
        public const string Carrier = "coUf_LRM_Carrier";
        public const string ClassOfService = "coUf_LRM_ClassOfService";
        public const string ShippingInstructions = "coUf_LRM_BOLMsg";
        public const string PackListInstructions = "coUf_LRM_PackListMsg"; 
        public const string ShipToAddr1 = "ShipToAddr_1";
        public const string ShipToAddr2 = "ShipToAddr_2"; 
        public const string ShipToCity = "ShipToCity";
        public const string ShipToState = "ShipToState";
        public const string ShipToZip = "ShipToZip";
        public const string ShipToCountry = "ShipToCountry"; 
        public const string ShipToName = "ShipToName";
        public const string TermsCode = "TermsCode";
        public const string TermsCodeDesc = "TermsCodeDesc";
        public const string TermsCodeDiscDays = "TermsCodeDiscDays";
        public const string TermsCodeDiscPct = "TermsCodeDiscPct";
        public const string TermsCodeDueDays = "TermsCodeDueDays"; 
        public const string DropShipOverride = "couf_enduser_flag";
        public const string DropShipName = "couf_enduser_name";
        public const string DropShipAddress1 = "couf_enduser_addr1";
        public const string DropShipAddress2 = "couf_enduser_addr2";

        public const string DropShipCity = "couf_enduser_city";
        public const string DropShipState = "couf_enduser_state";
        public const string DropShipZip = "couf_enduser_zip";
        public const string DropShipCountry = "couf_enduser_country";
        public const string PickStatus = "couf_pick_status";
        public const string CancelBackorders = "couf_cancel_backorders";


        public const string DiscountAmount = "DiscAmount"; public const string AckStat = "AckStat";
        public const string AdrName = "AdrName";
        public const string ApplyToInvNum = "ApplyToInvNum";
        public const string ApsPullUp = "ApsPullUp";
        public const string BillToAddr_1 = "BillToAddr_1";
        public const string BillToAddr_2 = "BillToAddr_2";
        public const string BillToAddr_3 = "BillToAddr_3";
        public const string BillToAddr_4 = "BillToAddr_4"; 
        public const string BillToContact_3 = "BillToContact_3";
        public const string BillToCountry = "BillToCountry";
        public const string BillToEmailAddr = "BillToEmailAddr";
        public const string BillToFaxNum = "BillToFaxNum"; 
        public const string BillToPhone_3 = "BillToPhone_3"; 
        public const string Cad01CreditHold = "Cad01CreditHold";
        public const string Cad01Name = "Cad01Name";
        public const string Cad0CorpAddress = "Cad0CorpAddress";
        public const string Cad0CorpCred = "Cad0CorpCred";
        public const string Cad0CorpCust = "Cad0CorpCust";
        public const string Cad0CreditHold = "Cad0CreditHold";
        public const string Cad0CurrPlaces = "Cad0CurrPlaces";
        public const string Cad0Name = "Cad0Name";
        public const string CadrCurrCode = "CadrCurrCode";
        public const string CadrName = "CadrName";
        public const string CfgMainConfigGid = "CfgMainConfigGid";
        public const string CfgMainConfigModel = "CfgMainConfigModel";
        public const string CfgMainConfigStatus = "CfgMainConfigStatus";
        public const string Charfld1 = "Charfld1";
        public const string Charfld2 = "Charfld2";
        public const string Charfld3 = "Charfld3";
        public const string CloseDate = "CloseDate";
        public const string CoCreditHold = "CoCreditHold";
        public const string ConfigId = "ConfigId";
        public const string Consolidate = "Consolidate";
        public const string Contact = "Contact";
        public const string CoNum = "CoNum";
        public const string CoNumSort = "CoNumSort";
        public const string ConvertType = "ConvertType";
        public const string CorpCust = "CorpCust";
        public const string Cost = "Cost";
        public const string CreditHold = "CreditHold";
        public const string CreditHoldDate = "CreditHoldDate";
        public const string CreditHoldReason = "CreditHoldReason";
        public const string CreditHoldReasonDesc = "CreditHoldReasonDesc";
        public const string CreditHoldUser = "CreditHoldUser";
        public const string Cur0AmtFormat = "Cur0AmtFormat";
        public const string Cur0CstPrcFormat = "Cur0CstPrcFormat";
        public const string CurrCode = "CurrCode";
        public const string CurrDescription = "CurrDescription";
        public const string Cus01Contact_3 = "Cus01Contact_3";
        public const string Cus01Phone_3 = "Cus01Phone_3";
        public const string CusCustType = "CusCustType";
        public const string CusLangCode = "CusLangCode";
        public const string CusLcrReqd = "CusLcrReqd";
        public const string CustNum = "CustNum";
        public const string CustPayType = "CustPayType";
        public const string CustPo = "CustPo"; 
        public const string CusTypTaxablePrice = "CusTypTaxablePrice";
        public const string CusUseExchRate = "CusUseExchRate";
        public const string Datefld = "Datefld";
        public const string Decifld1 = "Decifld1";
        public const string Decifld2 = "Decifld2";
        public const string Decifld3 = "Decifld3";
        public const string Delterm = "Delterm";
        public const string DeltermDesc = "DeltermDesc";
        public const string DerASPSearch = "DerASPSearch";
        public const string DerBillToAddress = "DerBillToAddress";
        public const string DerCoNum = "DerCoNum";
        public const string DerCoverSheetCompany = "DerCoverSheetCompany";
        public const string DerCoverSheetContact = "DerCoverSheetContact";
        public const string DerCurrCode = "DerCurrCode";
        public const string DerCustProspect = "DerCustProspect";
        public const string DerCustProspectCompany = "DerCustProspectCompany";
        public const string DerDestination = "DerDestination";
        public const string DerDoLines = "DerDoLines";
        public const string DerHasXRef = "DerHasXRef";
        public const string DerLangCode = "DerLangCode";
        public const string DerLineExists = "DerLineExists";
        public const string DerMessage = "DerMessage";
        public const string DerMethod = "DerMethod";
        public const string DerNumCopies = "DerNumCopies";
        public const string DerNumPackages = "DerNumPackages";
        public const string DerOldStat = "DerOldStat";
        public const string DerOrderType = "DerOrderType";
        public const string DerPreviousStat = "DerPreviousStat";
        public const string DerProfileExists = "DerProfileExists";
        public const string DerRevaluedExchRate = "DerRevaluedExchRate";
        public const string DerSelect = "DerSelect";
        public const string DerShipToAddress = "DerShipToAddress";
        public const string DerShipVia = "DerShipVia";
        public const string DerSlsmanName = "DerSlsmanName";
        public const string DerStatFormatted = "DerStatFormatted";
        public const string DerTotalProgBillAmt = "DerTotalProgBillAmt";
        public const string DerWeight = "DerWeight";
        public const string Disc = "Disc";
        public const string DiscAmount = "DiscAmount";
        public const string DiscountType = "DiscountType";
        public const string EdiOrder = "EdiOrder";
        public const string EdiType = "EdiType";
        public const string EffDate = "EffDate";
        public const string Einvoice = "Einvoice"; 
        public const string EndUserTypeDesc = "EndUserTypeDesc";
        public const string EstNum = "EstNum";
        public const string ExchRate = "ExchRate";
        public const string ExpDate = "ExpDate";
        public const string ExportType = "ExportType";
        public const string ExternalConfirmationRef = "ExternalConfirmationRef";
        public const string FixedRate = "FixedRate";
        public const string FormatBillToAddress = "FormatBillToAddress";
        public const string FormatShipToAddress = "FormatShipToAddress";
        public const string FovhdCostT = "FovhdCostT";
        public const string Freight = "Freight";
        public const string FreightT = "FreightT";
        public const string FrtTaxCode1 = "FrtTaxCode1";
        public const string FrtTaxCode1Desc = "FrtTaxCode1Desc";
        public const string FrtTaxCode2 = "FrtTaxCode2";
        public const string FrtTaxCode2Desc = "FrtTaxCode2Desc";
        public const string IncludeTaxInPrice = "IncludeTaxInPrice";
        public const string InvFreq = "InvFreq";
        public const string Invoiced = "Invoiced";
        public const string InWorkflow = "InWorkflow";
        public const string IsExternal = "IsExternal";
        public const string LbrCostT = "LbrCostT";
        public const string LcrNum = "LcrNum";
        public const string Logifld = "Logifld";
        public const string MatlCostT = "MatlCostT";
        public const string MChargesT = "MChargesT";
        public const string MiscCharges = "MiscCharges";
        public const string MscTaxCode1 = "MscTaxCode1";
        public const string MscTaxCode1Desc = "MscTaxCode1Desc";
        public const string MscTaxCode2 = "MscTaxCode2";
        public const string MscTaxCode2Desc = "MscTaxCode2Desc";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OppId = "OppId"; 
        public const string OrderSource = "OrderSource";
        public const string OrigSite = "OrigSite";
        public const string OutCostT = "OutCostT";
        public const string Phone = "Phone";
        public const string PrepaidAmt = "PrepaidAmt";
        public const string PrepaidT = "PrepaidT";
        public const string Price = "Price";
        public const string Pricecode = "Pricecode";
        public const string PricecodeDesc = "PricecodeDesc";
        public const string ProcessInd = "ProcessInd";
        public const string ProCompany = "ProCompany";
        public const string ProjectedDate = "ProjectedDate";
        public const string ProspectCompany = "ProspectCompany";
        public const string ProspectId = "ProspectId";
        public const string QtyPackages = "QtyPackages";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string SalesTax = "SalesTax";
        public const string SalesTax2 = "SalesTax2";
        public const string SalesTaxT = "SalesTaxT";
        public const string SalesTaxT2 = "SalesTaxT2";
        public const string ShipCode = "ShipCode";
        public const string ShipCodeDesc = "ShipCodeDesc";
        public const string ShipEarly = "ShipEarly";
        public const string ShipPartial = "ShipPartial"; 
        public const string ShipToContact_2 = "ShipToContact_2"; 
        public const string ShipToEmailAddr = "ShipToEmailAddr";
        public const string ShipToFaxNum = "ShipToFaxNum"; 
        public const string ShipToPhone_2 = "ShipToPhone_2"; 
        public const string SLCoBlns = "SLCoBlns";
        public const string SLCoitems = "SLCoitems";
        public const string SLCoShips = "SLCoShips";
        public const string SLCoSlsComms = "SLCoSlsComms";
        public const string SLRsvdInvs = "SLRsvdInvs";
        public const string Slsman = "Slsman";
        public const string SLXTaxes = "SLXTaxes";
        public const string Stat = "Stat";
        public const string Summarize = "Summarize";
        public const string SyncReqd = "SyncReqd";
        public const string TakenBy = "TakenBy";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode1Desc = "TaxCode1Desc";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxCode2Desc = "TaxCode2Desc"; 
        public const string TransNat = "TransNat";
        public const string TransNat2 = "TransNat2";
        public const string TransNat2Description = "TransNat2Description";
        public const string TransNatDesc = "TransNatDesc";
        public const string Type = "Type";
        public const string UbEstSetLineStat = "UbEstSetLineStat";
        public const string UbPackNum = "UbPackNum";
        public const string UbProgBillBillingDate = "UbProgBillBillingDate";
        public const string UbProgBillDescription = "UbProgBillDescription";
        public const string UbProgBillInvoiceFlag = "UbProgBillInvoiceFlag";
        public const string UbProgBillPercentToBill = "UbProgBillPercentToBill";
        public const string UseExchRate = "UseExchRate";
        public const string VovhdCostT = "VovhdCostT";
        public const string Weight = "Weight";


        public static CustomerOrderBuilder GetFullProjection()
        {
            return FromSyteline.CustomerOrder.CustomerNumber.Discount.OrderNumber
                .OrderDate.OrderType.EndUserType.PONumber.Salesman.
                ShippingInstructions.ShipToName.ShipToAddr1
                .ShipToAddr2.ShipToCity.ShipToState.ShipToZip.ShipToCountry.
                Site.Status.TaxCode.Terms.Warehouse.Carrier.DiscountAmount.DropShipAddress1.DropShipAddress2.DropShipCity.DropShipState.DropShipCountry.DropShipOverride.DropShipName.PickStatus.PackListInstructions;
        }

        public static CustomerOrderBuilder GetFullProjectionWithCustomerAndLineItems()
        {
            return
                GetFullProjectionWithCustomer().WithChildren( CustomerOrderLineItem.GetFullProjection().LinkBy(CustomerOrder.OrderNumber,
                                                                     CustomerOrderLineItem.OrderNumber));
        }
        public static CustomerOrderBuilder GetFullProjectionWithCustomer()
        {
            return GetFullProjection().BillToName.BillToContact
                .BillToAddr1.BillToAddr2.BillToCity.BillToState.BillToZip
                .Terms.TermsDescription.TermsDiscountDays.TermsDiscountPercent
                .TermsDueDays.CustSeq;
        }
    }


    public class CustomerOrderBuilder :
        IdoQueryBuilder<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>
    {
        public CustomerOrderBuilder(IExpressionInterpreter ei) : base(CustomerOrder.IDO_NAME, ei) { }

        public CustomerOrderBuilder CustomerNumber { get {  AddProperty(CustomerOrder.CustomerNumber); return this; } }
        public CustomerOrderBuilder OrderDate { get {  AddProperty(CustomerOrder.OrderDate); return this; } }
        public CustomerOrderBuilder OrderNumber { get {  AddProperty(CustomerOrder.OrderNumber); return this; } }
        public CustomerOrderBuilder Site { get { AddProperty(CustomerOrder.Site); return this; } }
        public CustomerOrderBuilder Warehouse { get { AddProperty(CustomerOrder.Warehouse); return this; } }
        public CustomerOrderBuilder ShipToCode { get { AddProperty(CustomerOrder.ShipToCode); return this; } }
        public CustomerOrderBuilder OrderType { get { AddProperty(CustomerOrder.OrderType); return this; } }
        public CustomerOrderBuilder PONumber { get { AddProperty(CustomerOrder.PONumber); return this; } }
        public CustomerOrderBuilder Status { get { AddProperty(CustomerOrder.Status); return this; } }
        public CustomerOrderBuilder Terms { get { AddProperty(CustomerOrder.TermsCode); return this; } }
        public CustomerOrderBuilder TermsDueDays { get { AddProperty(CustomerOrder.TermsCodeDueDays); return this; } }
        public CustomerOrderBuilder TermsDiscountDays { get { AddProperty(CustomerOrder.TermsCodeDiscDays); return this; } }
        public CustomerOrderBuilder TermsDiscountPercent { get { AddProperty(CustomerOrder.TermsCodeDiscPct); return this; } }
        public CustomerOrderBuilder TermsDescription { get { AddProperty(CustomerOrder.TermsCodeDesc); return this; } }
        public CustomerOrderBuilder Salesman { get { AddProperty(CustomerOrder.Salesman); return this; } }
        public CustomerOrderBuilder EndUserType { get { AddProperty(CustomerOrder.EndUserType); return this; } }
        public CustomerOrderBuilder CancelBackorders { get {AddProperty(CustomerOrder.CancelBackorders);
            return this;}}
        public CustomerOrderBuilder Discount { get { AddProperty(CustomerOrder.Discount); return this; } }
        public CustomerOrderBuilder TaxCode { get { AddProperty(CustomerOrder.TaxCode); return this; } }
        public CustomerOrderBuilder Carrier { get { AddProperty(CustomerOrder.Carrier); return this; } }
        public CustomerOrderBuilder ShippingInstructions { get { AddProperty(CustomerOrder.ShippingInstructions); return this; } }
        public CustomerOrderBuilder PackListInstructions { get { AddProperty(CustomerOrder.PackListInstructions); return this; } }

        public CustomerOrderBuilder ShipToAddr1 { get { AddProperty(CustomerOrder.ShipToAddr1); return this; } }
        public CustomerOrderBuilder ShipToAddr2 { get { AddProperty(CustomerOrder.ShipToAddr2); return this; } } 
        public CustomerOrderBuilder ShipToCity { get { AddProperty(CustomerOrder.ShipToCity); return this; } }
        public CustomerOrderBuilder ShipToState { get { AddProperty(CustomerOrder.ShipToState); return this; } }
        public CustomerOrderBuilder ShipToZip { get { AddProperty(CustomerOrder.ShipToZip); return this; } }
        public CustomerOrderBuilder ShipToCountry { get { AddProperty(CustomerOrder.ShipToCountry); return this; } } 
//        public CustomerOrderBuilder ShipToEmailAddr { get { AddProperty(CustomerOrder.ShipToEmailAddr); return this; } }
//        public CustomerOrderBuilder ShipToFaxNum { get { AddProperty(CustomerOrder.ShipToFaxNum); return this; } }
//        public CustomerOrderBuilder ShipToPhone { get { AddProperty(CustomerOrder.ShipToPhone2); return this; } }
        public CustomerOrderBuilder ShipToName { get { AddProperty(CustomerOrder.ShipToName); return this; } }
        public CustomerOrderBuilder BillToAddr1 { get { AddProperty(CustomerOrder.BillToAddress1); return this; } }
        public CustomerOrderBuilder BillToAddr2 { get { AddProperty(CustomerOrder.BillToAddress2); return this; } } 
        public CustomerOrderBuilder BillToCity { get { AddProperty(CustomerOrder.BillToCity); return this; } }
        public CustomerOrderBuilder BillToState { get { AddProperty(CustomerOrder.BillToState); return this; } }
        public CustomerOrderBuilder BillToZip { get { AddProperty(CustomerOrder.BillToZip); return this; } }  
        public CustomerOrderBuilder BillToName { get { AddProperty(CustomerOrder.BillToName); return this; } }
        public CustomerOrderBuilder BillToContact { get { AddProperty(CustomerOrder.BillToContact); return this; } }
        public CustomerOrderBuilder PickStatus { get { AddProperty(CustomerOrder.PickStatus); return this; } }
        public CustomerOrderBuilder CustSeq { get { AddProperty(CustomerOrder.CustSeq); return this; } }
        public CustomerOrderBuilder DropShipOverride { get { AddProperty(CustomerOrder.DropShipOverride);
        return this;
        }
        }
        public CustomerOrderBuilder DropShipAddress1
        {
            get
            {
                AddProperty(CustomerOrder.DropShipAddress1);
                return this;
            }
        }
        public CustomerOrderBuilder DropShipAddress2
        {
            get
            {
                AddProperty(CustomerOrder.DropShipAddress2);
                return this;
            }
        }
        public CustomerOrderBuilder DropShipCity
        {
            get
            {
                AddProperty(CustomerOrder.DropShipCity);
                return this;
            }
        }
        public CustomerOrderBuilder DropShipState
        {
            get
            {
                AddProperty(CustomerOrder.DropShipState);
                return this;
            }
        }
        public CustomerOrderBuilder DropShipZip
        {
            get
            {
                AddProperty(CustomerOrder.DropShipZip);
                return this;
            }
        }
        public CustomerOrderBuilder DropShipCountry
        {
            get
            {
                AddProperty(CustomerOrder.DropShipCountry);
                return this;
            }
        }

        public CustomerOrderBuilder DropShipName
        {
            get
            {
                AddProperty(CustomerOrder.DropShipName);
                return this;
            }
        }

        public CustomerOrderBuilder DiscountAmount
        {
            get  { AddProperty(CustomerOrder.DiscountAmount); return this; }  
        }

        public new CustomerOrderBuilder LinkBy(string parentField, string childField)
        {
            return (CustomerOrderBuilder) base.LinkBy(parentField,childField);
        }

        public new CustomerOrderBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (CustomerOrderBuilder) base.WithChildren(builders);
        }

        public CustomerOrderBuilder AckStat { get { AddProperty(CustomerOrder.AckStat); return this; } }
        public CustomerOrderBuilder AdrName { get { AddProperty(CustomerOrder.AdrName); return this; } }
        public CustomerOrderBuilder ApplyToInvNum { get { AddProperty(CustomerOrder.ApplyToInvNum); return this; } }
        public CustomerOrderBuilder ApsPullUp { get { AddProperty(CustomerOrder.ApsPullUp); return this; } }
        public CustomerOrderBuilder BillToAddr_1 { get { AddProperty(CustomerOrder.BillToAddr_1); return this; } }
        public CustomerOrderBuilder BillToAddr_2 { get { AddProperty(CustomerOrder.BillToAddr_2); return this; } }
        public CustomerOrderBuilder BillToAddr_3 { get { AddProperty(CustomerOrder.BillToAddr_3); return this; } }
        public CustomerOrderBuilder BillToAddr_4 { get { AddProperty(CustomerOrder.BillToAddr_4); return this; } } 
        public CustomerOrderBuilder BillToContact_3 { get { AddProperty(CustomerOrder.BillToContact_3); return this; } }
        public CustomerOrderBuilder BillToCountry { get { AddProperty(CustomerOrder.BillToCountry); return this; } }
        public CustomerOrderBuilder BillToEmailAddr { get { AddProperty(CustomerOrder.BillToEmailAddr); return this; } }
        public CustomerOrderBuilder BillToFaxNum { get { AddProperty(CustomerOrder.BillToFaxNum); return this; } } 
        public CustomerOrderBuilder BillToPhone_3 { get { AddProperty(CustomerOrder.BillToPhone_3); return this; } } 
        public CustomerOrderBuilder Cad01CreditHold { get { AddProperty(CustomerOrder.Cad01CreditHold); return this; } }
        public CustomerOrderBuilder Cad01Name { get { AddProperty(CustomerOrder.Cad01Name); return this; } }
        public CustomerOrderBuilder Cad0CorpAddress { get { AddProperty(CustomerOrder.Cad0CorpAddress); return this; } }
        public CustomerOrderBuilder Cad0CorpCred { get { AddProperty(CustomerOrder.Cad0CorpCred); return this; } }
        public CustomerOrderBuilder Cad0CorpCust { get { AddProperty(CustomerOrder.Cad0CorpCust); return this; } }
        public CustomerOrderBuilder Cad0CreditHold { get { AddProperty(CustomerOrder.Cad0CreditHold); return this; } }
        public CustomerOrderBuilder Cad0CurrPlaces { get { AddProperty(CustomerOrder.Cad0CurrPlaces); return this; } }
        public CustomerOrderBuilder Cad0Name { get { AddProperty(CustomerOrder.Cad0Name); return this; } }
        public CustomerOrderBuilder CadrCurrCode { get { AddProperty(CustomerOrder.CadrCurrCode); return this; } }
        public CustomerOrderBuilder CadrName { get { AddProperty(CustomerOrder.CadrName); return this; } }
        public CustomerOrderBuilder CfgMainConfigGid { get { AddProperty(CustomerOrder.CfgMainConfigGid); return this; } }
        public CustomerOrderBuilder CfgMainConfigModel { get { AddProperty(CustomerOrder.CfgMainConfigModel); return this; } }
        public CustomerOrderBuilder CfgMainConfigStatus { get { AddProperty(CustomerOrder.CfgMainConfigStatus); return this; } }
        public CustomerOrderBuilder Charfld1 { get { AddProperty(CustomerOrder.Charfld1); return this; } }
        public CustomerOrderBuilder Charfld2 { get { AddProperty(CustomerOrder.Charfld2); return this; } }
        public CustomerOrderBuilder Charfld3 { get { AddProperty(CustomerOrder.Charfld3); return this; } }
        public CustomerOrderBuilder CloseDate { get { AddProperty(CustomerOrder.CloseDate); return this; } }
        public CustomerOrderBuilder CoCreditHold { get { AddProperty(CustomerOrder.CoCreditHold); return this; } }
        public CustomerOrderBuilder ConfigId { get { AddProperty(CustomerOrder.ConfigId); return this; } }
        public CustomerOrderBuilder Consolidate { get { AddProperty(CustomerOrder.Consolidate); return this; } }
        public CustomerOrderBuilder Contact { get { AddProperty(CustomerOrder.Contact); return this; } }
        public CustomerOrderBuilder CoNum { get { AddProperty(CustomerOrder.CoNum); return this; } }
        public CustomerOrderBuilder CoNumSort { get { AddProperty(CustomerOrder.CoNumSort); return this; } }
        public CustomerOrderBuilder ConvertType { get { AddProperty(CustomerOrder.ConvertType); return this; } }
        public CustomerOrderBuilder CorpCust { get { AddProperty(CustomerOrder.CorpCust); return this; } }
        public CustomerOrderBuilder Cost { get { AddProperty(CustomerOrder.Cost); return this; } }
        public CustomerOrderBuilder CreditHold { get { AddProperty(CustomerOrder.CreditHold); return this; } }
        public CustomerOrderBuilder CreditHoldDate { get { AddProperty(CustomerOrder.CreditHoldDate); return this; } }
        public CustomerOrderBuilder CreditHoldReason { get { AddProperty(CustomerOrder.CreditHoldReason); return this; } }
        public CustomerOrderBuilder CreditHoldReasonDesc { get { AddProperty(CustomerOrder.CreditHoldReasonDesc); return this; } }
        public CustomerOrderBuilder CreditHoldUser { get { AddProperty(CustomerOrder.CreditHoldUser); return this; } }
        public CustomerOrderBuilder Cur0AmtFormat { get { AddProperty(CustomerOrder.Cur0AmtFormat); return this; } }
        public CustomerOrderBuilder Cur0CstPrcFormat { get { AddProperty(CustomerOrder.Cur0CstPrcFormat); return this; } }
        public CustomerOrderBuilder CurrCode { get { AddProperty(CustomerOrder.CurrCode); return this; } }
        public CustomerOrderBuilder CurrDescription { get { AddProperty(CustomerOrder.CurrDescription); return this; } }
        public CustomerOrderBuilder Cus01Contact_3 { get { AddProperty(CustomerOrder.Cus01Contact_3); return this; } }
        public CustomerOrderBuilder Cus01Phone_3 { get { AddProperty(CustomerOrder.Cus01Phone_3); return this; } }
        public CustomerOrderBuilder CusCustType { get { AddProperty(CustomerOrder.CusCustType); return this; } }
        public CustomerOrderBuilder CusLangCode { get { AddProperty(CustomerOrder.CusLangCode); return this; } }
        public CustomerOrderBuilder CusLcrReqd { get { AddProperty(CustomerOrder.CusLcrReqd); return this; } }
        public CustomerOrderBuilder CustNum { get { AddProperty(CustomerOrder.CustNum); return this; } }
        public CustomerOrderBuilder CustPayType { get { AddProperty(CustomerOrder.CustPayType); return this; } }
        public CustomerOrderBuilder CustPo { get { AddProperty(CustomerOrder.CustPo); return this; } } 
        public CustomerOrderBuilder CusTypTaxablePrice { get { AddProperty(CustomerOrder.CusTypTaxablePrice); return this; } }
        public CustomerOrderBuilder CusUseExchRate { get { AddProperty(CustomerOrder.CusUseExchRate); return this; } }
        public CustomerOrderBuilder Datefld { get { AddProperty(CustomerOrder.Datefld); return this; } }
        public CustomerOrderBuilder Decifld1 { get { AddProperty(CustomerOrder.Decifld1); return this; } }
        public CustomerOrderBuilder Decifld2 { get { AddProperty(CustomerOrder.Decifld2); return this; } }
        public CustomerOrderBuilder Decifld3 { get { AddProperty(CustomerOrder.Decifld3); return this; } }
        public CustomerOrderBuilder Delterm { get { AddProperty(CustomerOrder.Delterm); return this; } }
        public CustomerOrderBuilder DeltermDesc { get { AddProperty(CustomerOrder.DeltermDesc); return this; } }
        public CustomerOrderBuilder DerASPSearch { get { AddProperty(CustomerOrder.DerASPSearch); return this; } }
        public CustomerOrderBuilder DerBillToAddress { get { AddProperty(CustomerOrder.DerBillToAddress); return this; } }
        public CustomerOrderBuilder DerCoNum { get { AddProperty(CustomerOrder.DerCoNum); return this; } }
        public CustomerOrderBuilder DerCoverSheetCompany { get { AddProperty(CustomerOrder.DerCoverSheetCompany); return this; } }
        public CustomerOrderBuilder DerCoverSheetContact { get { AddProperty(CustomerOrder.DerCoverSheetContact); return this; } }
        public CustomerOrderBuilder DerCurrCode { get { AddProperty(CustomerOrder.DerCurrCode); return this; } }
        public CustomerOrderBuilder DerCustProspect { get { AddProperty(CustomerOrder.DerCustProspect); return this; } }
        public CustomerOrderBuilder DerCustProspectCompany { get { AddProperty(CustomerOrder.DerCustProspectCompany); return this; } }
        public CustomerOrderBuilder DerDestination { get { AddProperty(CustomerOrder.DerDestination); return this; } }
        public CustomerOrderBuilder DerDoLines { get { AddProperty(CustomerOrder.DerDoLines); return this; } }
        public CustomerOrderBuilder DerHasXRef { get { AddProperty(CustomerOrder.DerHasXRef); return this; } }
        public CustomerOrderBuilder DerLangCode { get { AddProperty(CustomerOrder.DerLangCode); return this; } } 
        public CustomerOrderBuilder DerLineExists { get { AddProperty(CustomerOrder.DerLineExists); return this; } }
        public CustomerOrderBuilder DerMessage { get { AddProperty(CustomerOrder.DerMessage); return this; } }
        public CustomerOrderBuilder DerMethod { get { AddProperty(CustomerOrder.DerMethod); return this; } }
        public CustomerOrderBuilder DerNumCopies { get { AddProperty(CustomerOrder.DerNumCopies); return this; } }
        public CustomerOrderBuilder DerNumPackages { get { AddProperty(CustomerOrder.DerNumPackages); return this; } }
        public CustomerOrderBuilder DerOldStat { get { AddProperty(CustomerOrder.DerOldStat); return this; } }
        public CustomerOrderBuilder DerOrderType { get { AddProperty(CustomerOrder.DerOrderType); return this; } }
        public CustomerOrderBuilder DerPreviousStat { get { AddProperty(CustomerOrder.DerPreviousStat); return this; } }
        public CustomerOrderBuilder DerProfileExists { get { AddProperty(CustomerOrder.DerProfileExists); return this; } }
        public CustomerOrderBuilder DerRevaluedExchRate { get { AddProperty(CustomerOrder.DerRevaluedExchRate); return this; } }
        public CustomerOrderBuilder DerSelect { get { AddProperty(CustomerOrder.DerSelect); return this; } }
        public CustomerOrderBuilder DerShipToAddress { get { AddProperty(CustomerOrder.DerShipToAddress); return this; } }
        public CustomerOrderBuilder DerShipVia { get { AddProperty(CustomerOrder.DerShipVia); return this; } }
        public CustomerOrderBuilder DerSlsmanName { get { AddProperty(CustomerOrder.DerSlsmanName); return this; } }
        public CustomerOrderBuilder DerStatFormatted { get { AddProperty(CustomerOrder.DerStatFormatted); return this; } }
        public CustomerOrderBuilder DerTotalProgBillAmt { get { AddProperty(CustomerOrder.DerTotalProgBillAmt); return this; } }
        public CustomerOrderBuilder DerWeight { get { AddProperty(CustomerOrder.DerWeight); return this; } }
        public CustomerOrderBuilder Disc { get { AddProperty(CustomerOrder.Disc); return this; } }
        public CustomerOrderBuilder DiscAmount { get { AddProperty(CustomerOrder.DiscAmount); return this; } }
        public CustomerOrderBuilder DiscountType { get { AddProperty(CustomerOrder.DiscountType); return this; } }
        public CustomerOrderBuilder EdiOrder { get { AddProperty(CustomerOrder.EdiOrder); return this; } }
        public CustomerOrderBuilder EdiType { get { AddProperty(CustomerOrder.EdiType); return this; } }
        public CustomerOrderBuilder EffDate { get { AddProperty(CustomerOrder.EffDate); return this; } }
        public CustomerOrderBuilder Einvoice { get { AddProperty(CustomerOrder.Einvoice); return this; } } 
        public CustomerOrderBuilder EndUserTypeDesc { get { AddProperty(CustomerOrder.EndUserTypeDesc); return this; } }
        public CustomerOrderBuilder EstNum { get { AddProperty(CustomerOrder.EstNum); return this; } }
        public CustomerOrderBuilder ExchRate { get { AddProperty(CustomerOrder.ExchRate); return this; } }
        public CustomerOrderBuilder ExpDate { get { AddProperty(CustomerOrder.ExpDate); return this; } }
        public CustomerOrderBuilder ExportType { get { AddProperty(CustomerOrder.ExportType); return this; } }
        public CustomerOrderBuilder ExternalConfirmationRef { get { AddProperty(CustomerOrder.ExternalConfirmationRef); return this; } }
        public CustomerOrderBuilder FixedRate { get { AddProperty(CustomerOrder.FixedRate); return this; } }
        public CustomerOrderBuilder FormatBillToAddress { get { AddProperty(CustomerOrder.FormatBillToAddress); return this; } }
        public CustomerOrderBuilder FormatShipToAddress { get { AddProperty(CustomerOrder.FormatShipToAddress); return this; } }
        public CustomerOrderBuilder FovhdCostT { get { AddProperty(CustomerOrder.FovhdCostT); return this; } }
        public CustomerOrderBuilder Freight { get { AddProperty(CustomerOrder.Freight); return this; } }
        public CustomerOrderBuilder FreightT { get { AddProperty(CustomerOrder.FreightT); return this; } }
        public CustomerOrderBuilder FrtTaxCode1 { get { AddProperty(CustomerOrder.FrtTaxCode1); return this; } }
        public CustomerOrderBuilder FrtTaxCode1Desc { get { AddProperty(CustomerOrder.FrtTaxCode1Desc); return this; } }
        public CustomerOrderBuilder FrtTaxCode2 { get { AddProperty(CustomerOrder.FrtTaxCode2); return this; } }
        public CustomerOrderBuilder FrtTaxCode2Desc { get { AddProperty(CustomerOrder.FrtTaxCode2Desc); return this; } }
        public CustomerOrderBuilder IncludeTaxInPrice { get { AddProperty(CustomerOrder.IncludeTaxInPrice); return this; } }
        public CustomerOrderBuilder InvFreq { get { AddProperty(CustomerOrder.InvFreq); return this; } }
        public CustomerOrderBuilder Invoiced { get { AddProperty(CustomerOrder.Invoiced); return this; } }
        public CustomerOrderBuilder InWorkflow { get { AddProperty(CustomerOrder.InWorkflow); return this; } }
        public CustomerOrderBuilder IsExternal { get { AddProperty(CustomerOrder.IsExternal); return this; } }
        public CustomerOrderBuilder LbrCostT { get { AddProperty(CustomerOrder.LbrCostT); return this; } }
        public CustomerOrderBuilder LcrNum { get { AddProperty(CustomerOrder.LcrNum); return this; } }
        public CustomerOrderBuilder Logifld { get { AddProperty(CustomerOrder.Logifld); return this; } }
        public CustomerOrderBuilder MatlCostT { get { AddProperty(CustomerOrder.MatlCostT); return this; } }
        public CustomerOrderBuilder MChargesT { get { AddProperty(CustomerOrder.MChargesT); return this; } }
        public CustomerOrderBuilder MiscCharges { get { AddProperty(CustomerOrder.MiscCharges); return this; } }
        public CustomerOrderBuilder MscTaxCode1 { get { AddProperty(CustomerOrder.MscTaxCode1); return this; } }
        public CustomerOrderBuilder MscTaxCode1Desc { get { AddProperty(CustomerOrder.MscTaxCode1Desc); return this; } }
        public CustomerOrderBuilder MscTaxCode2 { get { AddProperty(CustomerOrder.MscTaxCode2); return this; } }
        public CustomerOrderBuilder MscTaxCode2Desc { get { AddProperty(CustomerOrder.MscTaxCode2Desc); return this; } }
        public CustomerOrderBuilder NoteExistsFlag { get { AddProperty(CustomerOrder.NoteExistsFlag); return this; } }
        public CustomerOrderBuilder OppId { get { AddProperty(CustomerOrder.OppId); return this; } } 
        public CustomerOrderBuilder OrderSource { get { AddProperty(CustomerOrder.OrderSource); return this; } }
        public CustomerOrderBuilder OrigSite { get { AddProperty(CustomerOrder.OrigSite); return this; } }
        public CustomerOrderBuilder OutCostT { get { AddProperty(CustomerOrder.OutCostT); return this; } }
        public CustomerOrderBuilder Phone { get { AddProperty(CustomerOrder.Phone); return this; } }
        public CustomerOrderBuilder PrepaidAmt { get { AddProperty(CustomerOrder.PrepaidAmt); return this; } }
        public CustomerOrderBuilder PrepaidT { get { AddProperty(CustomerOrder.PrepaidT); return this; } }
        public CustomerOrderBuilder Price { get { AddProperty(CustomerOrder.Price); return this; } }
        public CustomerOrderBuilder Pricecode { get { AddProperty(CustomerOrder.Pricecode); return this; } }
        public CustomerOrderBuilder PricecodeDesc { get { AddProperty(CustomerOrder.PricecodeDesc); return this; } }
        public CustomerOrderBuilder ProcessInd { get { AddProperty(CustomerOrder.ProcessInd); return this; } }
        public CustomerOrderBuilder ProCompany { get { AddProperty(CustomerOrder.ProCompany); return this; } }
        public CustomerOrderBuilder ProjectedDate { get { AddProperty(CustomerOrder.ProjectedDate); return this; } }
        public CustomerOrderBuilder ProspectCompany { get { AddProperty(CustomerOrder.ProspectCompany); return this; } }
        public CustomerOrderBuilder ProspectId { get { AddProperty(CustomerOrder.ProspectId); return this; } }
        public CustomerOrderBuilder QtyPackages { get { AddProperty(CustomerOrder.QtyPackages); return this; } }
        public CustomerOrderBuilder RecordDate { get { AddProperty(CustomerOrder.RecordDate); return this; } }
        public CustomerOrderBuilder RowPointer { get { AddProperty(CustomerOrder.RowPointer); return this; } }
        public CustomerOrderBuilder SalesTax { get { AddProperty(CustomerOrder.SalesTax); return this; } }
        public CustomerOrderBuilder SalesTax2 { get { AddProperty(CustomerOrder.SalesTax2); return this; } }
        public CustomerOrderBuilder SalesTaxT { get { AddProperty(CustomerOrder.SalesTaxT); return this; } }
        public CustomerOrderBuilder SalesTaxT2 { get { AddProperty(CustomerOrder.SalesTaxT2); return this; } }
        public CustomerOrderBuilder ShipCode { get { AddProperty(CustomerOrder.ShipCode); return this; } }
        public CustomerOrderBuilder ShipCodeDesc { get { AddProperty(CustomerOrder.ShipCodeDesc); return this; } }
        public CustomerOrderBuilder ShipEarly { get { AddProperty(CustomerOrder.ShipEarly); return this; } }
        public CustomerOrderBuilder ShipPartial { get { AddProperty(CustomerOrder.ShipPartial); return this; } } 
        public CustomerOrderBuilder ShipToContact_2 { get { AddProperty(CustomerOrder.ShipToContact_2); return this; } } 
        public CustomerOrderBuilder ShipToEmailAddr { get { AddProperty(CustomerOrder.ShipToEmailAddr); return this; } }
        public CustomerOrderBuilder ShipToFaxNum { get { AddProperty(CustomerOrder.ShipToFaxNum); return this; } } 
        public CustomerOrderBuilder ShipToPhone_2 { get { AddProperty(CustomerOrder.ShipToPhone_2); return this; } } 
        public CustomerOrderBuilder SLCoBlns { get { AddProperty(CustomerOrder.SLCoBlns); return this; } }
        public CustomerOrderBuilder SLCoitems { get { AddProperty(CustomerOrder.SLCoitems); return this; } }
        public CustomerOrderBuilder SLCoShips { get { AddProperty(CustomerOrder.SLCoShips); return this; } }
        public CustomerOrderBuilder SLCoSlsComms { get { AddProperty(CustomerOrder.SLCoSlsComms); return this; } }
        public CustomerOrderBuilder SLRsvdInvs { get { AddProperty(CustomerOrder.SLRsvdInvs); return this; } }
        public CustomerOrderBuilder Slsman { get { AddProperty(CustomerOrder.Slsman); return this; } }
        public CustomerOrderBuilder SLXTaxes { get { AddProperty(CustomerOrder.SLXTaxes); return this; } }
        public CustomerOrderBuilder Stat { get { AddProperty(CustomerOrder.Stat); return this; } }
        public CustomerOrderBuilder Summarize { get { AddProperty(CustomerOrder.Summarize); return this; } }
        public CustomerOrderBuilder SyncReqd { get { AddProperty(CustomerOrder.SyncReqd); return this; } }
        public CustomerOrderBuilder TakenBy { get { AddProperty(CustomerOrder.TakenBy); return this; } }
        public CustomerOrderBuilder TaxCode1 { get { AddProperty(CustomerOrder.TaxCode1); return this; } }
        public CustomerOrderBuilder TaxCode1Desc { get { AddProperty(CustomerOrder.TaxCode1Desc); return this; } }
        public CustomerOrderBuilder TaxCode2 { get { AddProperty(CustomerOrder.TaxCode2); return this; } }
        public CustomerOrderBuilder TaxCode2Desc { get { AddProperty(CustomerOrder.TaxCode2Desc); return this; } }
        public CustomerOrderBuilder TermsCode { get { AddProperty(CustomerOrder.TermsCode); return this; } }
        public CustomerOrderBuilder TermsCodeDesc { get { AddProperty(CustomerOrder.TermsCodeDesc); return this; } }
        public CustomerOrderBuilder TermsCodeDiscDays { get { AddProperty(CustomerOrder.TermsCodeDiscDays); return this; } }
        public CustomerOrderBuilder TermsCodeDiscPct { get { AddProperty(CustomerOrder.TermsCodeDiscPct); return this; } }
        public CustomerOrderBuilder TermsCodeDueDays { get { AddProperty(CustomerOrder.TermsCodeDueDays); return this; } }
        public CustomerOrderBuilder TransNat { get { AddProperty(CustomerOrder.TransNat); return this; } }
        public CustomerOrderBuilder TransNat2 { get { AddProperty(CustomerOrder.TransNat2); return this; } }
        public CustomerOrderBuilder TransNat2Description { get { AddProperty(CustomerOrder.TransNat2Description); return this; } }
        public CustomerOrderBuilder TransNatDesc { get { AddProperty(CustomerOrder.TransNatDesc); return this; } }
        public CustomerOrderBuilder Type { get { AddProperty(CustomerOrder.Type); return this; } }
        public CustomerOrderBuilder UbEstSetLineStat { get { AddProperty(CustomerOrder.UbEstSetLineStat); return this; } }
        public CustomerOrderBuilder UbPackNum { get { AddProperty(CustomerOrder.UbPackNum); return this; } }
        public CustomerOrderBuilder UbProgBillBillingDate { get { AddProperty(CustomerOrder.UbProgBillBillingDate); return this; } }
        public CustomerOrderBuilder UbProgBillDescription { get { AddProperty(CustomerOrder.UbProgBillDescription); return this; } }
        public CustomerOrderBuilder UbProgBillInvoiceFlag { get { AddProperty(CustomerOrder.UbProgBillInvoiceFlag); return this; } }
        public CustomerOrderBuilder UbProgBillPercentToBill { get { AddProperty(CustomerOrder.UbProgBillPercentToBill); return this; } }
        public CustomerOrderBuilder UseExchRate { get { AddProperty(CustomerOrder.UseExchRate); return this; } }
        public CustomerOrderBuilder VovhdCostT { get { AddProperty(CustomerOrder.VovhdCostT); return this; } }
        public CustomerOrderBuilder Weight { get { AddProperty(CustomerOrder.Weight); return this; } } 
        public CustomerOrderBuilder ClassOfService { get { AddProperty(CustomerOrder.ClassOfService); return this; } } 
                    

 
    }

    public class CustomerOrderFilterExpressionBuilder : FilterExpressionBuilder<CustomerOrderBuilder>
    {
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder> OrderType
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.OrderType); }
        }
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder> OrderNumber
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.OrderNumber); }
        }
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder> CustomerNumber
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.CustomerNumber); }
        }
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder> OrderDate
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.OrderDate); }
        }
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder> PickStatus
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.PickStatus); }
        }
        public FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>  Status
        {
            get { return new FilterExpression<CustomerOrderBuilder, CustomerOrderFilterExpressionBuilder>(_builder, CustomerOrder.Status); }
        }
    }
}