using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{ 
    public class CustomerOrderLineItem : IdoConstants
    { 
        public const string IDO_NAME = "SLCoitems";
        public const string Item = "Item";
        public const string CustomerPartNumber = "CustItem";
        public const string CustomerNumber = "CoCustNum";
        public const string QtyOrdered = "QtyOrderedConv";
        public const string OrderNumber = "CoNum";
        public const string LineNumber = "CoLine";
        public const string ReleaseNumber = "CoRelease";
        public const string Status = "Stat";
        public const string Description = "Description";
        public const string UnitOfMeasure = "UM"; 
        public const string Price = "PriceConv";
        public const string DueDate = "DueDate"; 
        public const string ShipSite = "ShipSite";
        public const string Warehouse = "Whse";
        public const string InventoryFrequency = "InvFreq"; 
        public const string Address1 = "AdrAddr_1";
        public const string Address2 = "AdrAddr_2"; 
        public const string AddressCity = "AdrCity"; 
        public const string AddressName = "AdrName";
        public const string AddressState = "AdrState";
        public const string AddressZip = "AdrZip"; 
        public const string Adr01CreditHold = "Adr01CreditHold";
        public const string Adr0CorpCred = "Adr0CorpCred";
        public const string Adr0CorpCust = "Adr0CorpCust";
        public const string Adr0CreditHold = "Adr0CreditHold";
        public const string Adr0Name = "Adr0Name";
        public const string AdrAddr_1 = "AdrAddr_1";
        public const string AdrAddr_2 = "AdrAddr_2";
        public const string AdrAddr_3 = "AdrAddr_3";
        public const string AdrAddr_4 = "AdrAddr_4";
        public const string AdrCity = "AdrCity";
        public const string AdrCountry = "AdrCountry";
        public const string AdrCreditHold = "AdrCreditHold";
        public const string AdrCurrCode = "AdrCurrCode";
        public const string AdrCurrdescription = "AdrCurrdescription";
        public const string AdrFaxNum = "AdrFaxNum";
        public const string AdrName = "AdrName";
        public const string AdrState = "AdrState";
        public const string AdrZip = "AdrZip";
        public const string BatchId = "BatchId";
        public const string Bol = "Bol";
        public const string BrkQty_1 = "BrkQty_1";
        public const string BrkQty_2 = "BrkQty_2";
        public const string BrkQty_3 = "BrkQty_3";
        public const string BrkQty_4 = "BrkQty_4";
        public const string BrkQty_5 = "BrkQty_5";
        public const string CblBlanketQtyConv = "CblBlanketQtyConv";
        public const string CblCoLine = "CblCoLine";
        public const string CblContPriceConv = "CblContPriceConv";
        public const string CblEffDate = "CblEffDate";
        public const string CblExpDate = "CblExpDate";
        public const string CblItem = "CblItem";
        public const string CblShipSite = "CblShipSite";
        public const string CblStat = "CblStat";
        public const string CblUM = "CblUM";
        public const string CfgMainConfigGid = "CfgMainConfigGid";
        public const string CfgMainConfigModel = "CfgMainConfigModel";
        public const string CfgMainConfigStatus = "CfgMainConfigStatus";
        public const string CgsTotal = "CgsTotal";
        public const string CgsTotalFovhd = "CgsTotalFovhd";
        public const string CgsTotalLbr = "CgsTotalLbr";
        public const string CgsTotalMatl = "CgsTotalMatl";
        public const string CgsTotalOut = "CgsTotalOut";
        public const string CgsTotalVovhd = "CgsTotalVovhd";
        public const string CoCloseDate = "CoCloseDate";
        public const string CoCoCustNum = "CoCoCustNum";
        public const string CoConsolidate = "CoConsolidate";
        public const string CoCost = "CoCost";
        public const string CoCreditHold = "CoCreditHold";
        public const string CoCustNum = "CoCustNum";
        public const string CoCustPo = "CoCustPo";
        public const string CoEdiOrder = "CoEdiOrder";
        public const string CoExchRate = "CoExchRate";
        public const string CoExportType = "CoExportType";
        public const string CoiiCoNum = "CoiiCoNum";
        public const string CoInvFreq = "CoInvFreq";
        public const string CoLine = "CoLine";
        public const string CommCode = "CommCode";
        public const string ComSupplQtyReq = "ComSupplQtyReq";
        public const string ConfigID = "ConfigID";
        public const string ConsNum = "ConsNum";
        public const string Consolidate = "Consolidate";
        public const string CoNum = "CoNum";
        public const string CoOrderDate = "CoOrderDate";
        public const string CoOrigSite = "CoOrigSite";
        public const string CoPrice = "CoPrice";
        public const string CoRelease = "CoRelease";
        public const string CosDoLine = "CosDoLine";
        public const string CosDoNum = "CosDoNum";
        public const string CosDoSeq = "CosDoSeq";
        public const string CosQtyInvoiced = "CosQtyInvoiced";
        public const string CosQtyReturned = "CosQtyReturned";
        public const string CosQtyShipped = "CosQtyShipped";
        public const string Cost = "Cost";
        public const string CoStat = "CoStat";
        public const string CostConv = "CostConv";
        public const string CoTaxCode1 = "CoTaxCode1";
        public const string CoTaxCode2 = "CoTaxCode2";
        public const string CoTermsCode = "CoTermsCode";
        public const string OrderType = "CoType";
        public const string CoUseExchRate = "CoUseExchRate";
        public const string CoWhse = "CoWhse";
        public const string CurrencyAmtFormat = "CurrencyAmtFormat";
        public const string CurrencyCstPrcFormat = "CurrencyCstPrcFormat";
        public const string CurrencyPlaces = "CurrencyPlaces";
        public const string CusContact_2 = "CusContact_2";
        public const string CusCustType = "CusCustType";
        public const string CusDoInvoice = "CusDoInvoice";
        public const string CusPhone_2 = "CusPhone_2";
        public const string CustItem = "CustItem";
        public const string CustNum = "CustNum";
        public const string CustPo = "CustPo";
        public const string CustSeq = "CustSeq";
        public const string CusUseExchRate = "CusUseExchRate";
        public const string Delterm = "Delterm";
        public const string DerAllowOverCreditLimit = "DerAllowOverCreditLimit";
        public const string DerApsOrderID = "DerApsOrderID";
        public const string DerCanChangeItem = "DerCanChangeItem";
        public const string DerCanChgShipSite = "DerCanChgShipSite";
        public const string DerCfgJobIsConfigurable = "DerCfgJobIsConfigurable";
        public const string DerCoverSheetCompany = "DerCoverSheetCompany";
        public const string DerCoverSheetContact = "DerCoverSheetContact";
        public const string DerCurrCode = "DerCurrCode";
        public const string DerCurrencyPlaces = "DerCurrencyPlaces";
        public const string DerDropShipAddress = "DerDropShipAddress";
        public const string DerDropShipCustAddr = "DerDropShipCustAddr";
        public const string DerDropShipFlag = "DerDropShipFlag";
        public const string DerExtPrice = "DerExtPrice";
        public const string DerFovhdCostConv = "DerFovhdCostConv";
        public const string DerFovhdExtended = "DerFovhdExtended";
        public const string DerInfobar = "DerInfobar";
        public const string DerItemFeatTempl = "DerItemFeatTempl";
        public const string DerItExist = "DerItExist";
        public const string DerLbrExtended = "DerLbrExtended";
        public const string DerLoc = "DerLoc";
        public const string DerLot = "DerLot";
        public const string DerMatlExtended = "DerMatlExtended";
        public const string DerMaxQtyToPackConv = "DerMaxQtyToPackConv";
        public const string DerMessage = "DerMessage";
        public const string DerNetPrice = "DerNetPrice";
        public const string DerOldCoLine = "DerOldCoLine";
        public const string DerOldCoNum = "DerOldCoNum";
        public const string DerOldStat = "DerOldStat";
        public const string DerOrigQtyOrderedConv = "DerOrigQtyOrderedConv";
        public const string DerOutExtended = "DerOutExtended";
        public const string DerProgBillTotalBilled = "DerProgBillTotalBilled";
        public const string DerProgBillTotalInvoiced = "DerProgBillTotalInvoiced";
        public const string DerQtyInvoicedConv = "DerQtyInvoicedConv";
        public const string DerQtyPackedConv = "DerQtyPackedConv";
        public const string DerQtyPicked = "DerQtyPicked";
        public const string DerQtyReady = "DerQtyReady";
        public const string DerQtyReadyConv = "DerQtyReadyConv";
        public const string DerQtyRsvdConv = "DerQtyRsvdConv";
        public const string DerQtyShippedConv = "DerQtyShippedConv";
        public const string DerQtyToInvoice = "DerQtyToInvoice";
        public const string DerQtyToPack = "DerQtyToPack";
        public const string DerQtyToPackConv = "DerQtyToPackConv";
        public const string DerQtyToPick = "DerQtyToPick";
        public const string DerQtyToShip = "DerQtyToShip";
        public const string DerSelected = "DerSelected";
        public const string DerSerialPrefix = "DerSerialPrefix";
        public const string DerShiIteActive = "DerShiIteActive";
        public const string TotalCost = "DerTotCost";
        public const string DerTotExtended = "DerTotExtended";
        public const string DerTotQtyToInvoice = "DerTotQtyToInvoice";
        public const string DerUomConvFactor = "DerUomConvFactor";
        public const string DerVovhdExtended = "DerVovhdExtended"; 
        public const string Disc = "Disc";
        public const string DltDescription = "DltDescription";
        public const string DoLine = "DoLine"; 
        public const string EcCode = "EcCode";
        public const string ExportValue = "ExportValue";
        public const string ExtendedCost = "ExtendedCost";
        public const string ExtendedPrice = "ExtendedPrice";
        public const string ExternalReservationRef = "ExternalReservationRef";
        public const string FeatStr = "FeatStr";
        public const string FovhdCost = "FovhdCost";
        public const string FovhdCostConv = "FovhdCostConv";
        public const string InvFreq = "InvFreq";
        public const string InWorkflow = "InWorkflow";
        public const string ItAutoJob = "ItAutoJob";
        public const string ItAutoPost = "ItAutoPost";
        public const string ItCfgModel = "ItCfgModel";
        public const string ItCoPostConfig = "ItCoPostConfig";
        public const string ItDescription = "ItDescription"; 
        public const string IteWhsQtyOnHand = "IteWhsQtyOnHand";
        public const string ItKit = "ItKit";
        public const string ItLotTracked = "ItLotTracked";
        public const string ItOrderConfigurable = "ItOrderConfigurable";
        public const string ItPlanFlag = "ItPlanFlag";
        public const string ItReservable = "ItReservable";
        public const string ItSerialTracked = "ItSerialTracked";
        public const string ItSupplySite = "ItSupplySite";
        public const string ItUM = "ItUM";
        public const string ItUWsPrice = "ItUWsPrice";
        public const string LbrCost = "LbrCost";
        public const string LbrCostConv = "LbrCostConv";
        public const string Margin = "Margin";
        public const string MarginPercent = "MarginPercent";
        public const string MatlCost = "MatlCost";
        public const string MatlCostConv = "MatlCostConv";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string Origin = "Origin";
        public const string OutCost = "OutCost";
        public const string OutCostConv = "OutCostConv";
        public const string Packed = "Packed";
        public const string ParCfgConfigGid = "ParCfgConfigGid";
        public const string PickDate = "PickDate";
        public const string PrgBillApp = "PrgBillApp";
        public const string PrgBillTot = "PrgBillTot"; 
        public const string Pricecode = "Pricecode";
        public const string PricecodeDesc = "PricecodeDesc";
        public const string PriceConv = "PriceConv";
        public const string PrintKitComponents = "PrintKitComponents";
        public const string ProcessInd = "ProcessInd";
        public const string ProCompany = "ProCompany";
        public const string ProCurrCode = "ProCurrCode";
        public const string ProjectedDate = "ProjectedDate";
        public const string PromiseDate = "PromiseDate";
        public const string ProspectId = "ProspectId";
        public const string QtyInvoiced = "QtyInvoiced"; 
        public const string QtyOrderedConv = "QtyOrderedConv";
        public const string QtyPacked = "QtyPacked";
        public const string QtyReady = "QtyReady";
        public const string QtyReturned = "QtyReturned";
        public const string QtyRsvd = "QtyRsvd";
        public const string QtyShipped = "QtyShipped";
        public const string RecordDate = "RecordDate";
        public const string RefLineSuf = "RefLineSuf";
        public const string RefNum = "RefNum";
        public const string RefRelease = "RefRelease";
        public const string RefType = "RefType";
        public const string ReleaseDate = "ReleaseDate";
        public const string Reprice = "Reprice";
        public const string RmaLine = "RmaLine";
        public const string RmaNum = "RmaNum";
        public const string RowPointer = "RowPointer";
        public const string ShiIteActive = "ShiIteActive";
        public const string ShipDate = "ShipDate"; 
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string SLProgbills = "SLProgbills";
        public const string SLRsvdInvs = "SLRsvdInvs";
        public const string SLSerials = "SLSerials"; 
        public const string Summarize = "Summarize";
        public const string SupplQtyConvFactor = "SupplQtyConvFactor";
        public const string SyncReqd = "SyncReqd";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode2 = "TaxCode2";
        public const string Tc1Description = "Tc1Description";
        public const string Tc2Description = "Tc2Description";
        public const string TermsDescription = "TermsDescription";
        public const string TransNat = "TransNat";
        public const string TransNat2 = "TransNat2";
        public const string TransNat2Description = "TransNat2Description";
        public const string Transport = "Transport";
        public const string TrnDescription = "TrnDescription";
        public const string UbDispMsg = "UbDispMsg";
        public const string UbDispXRefMsg = "UbDispXRefMsg";
        public const string UbGenerateQty = "UbGenerateQty";
        public const string UbIncrPrice = "UbIncrPrice";
        public const string UbItem = "UbItem";
        public const string UbItemCustAdd = "UbItemCustAdd";
        public const string UbItemCustUpdate = "UbItemCustUpdate";
        public const string UbNetAdjust = "UbNetAdjust";
        public const string UbNewDisc = "UbNewDisc";
        public const string UbNewNet = "UbNewNet";
        public const string UbNewPrice = "UbNewPrice";
        public const string UbOldNet = "UbOldNet";
        public const string UbPackNum = "UbPackNum";
        public const string UbPlanOnSave = "UbPlanOnSave";
        public const string UbProgBillAmount = "UbProgBillAmount";
        public const string UbQtyToAdjust = "UbQtyToAdjust";
        public const string UbRangeQty = "UbRangeQty";
        public const string UbSelect = "UbSelect";
        public const string UbSelectedQty = "UbSelectedQty";
        public const string UbSetItemCust = "UbSetItemCust";
        public const string UbTargetQty = "UbTargetQty";
        public const string UM = "UM";
        public const string UnitWeight = "UnitWeight";
        public const string VovhdCost = "VovhdCost";
        public const string VovhdCostConv = "VovhdCostConv"; 
        public const string WksBasis = "WksBasis";
        public const string WksValue = "WksValue";
         

        public static CustomerOrderLineItemBuilder GetFullProjection()
        {
            return FromSyteline.CustomerOrderLineItems.CustomerNumber.CustomerPartNumber.Item.LineNumber
                .OrderNumber.ReleaseNumber.QtyOrdered.Warehouse.Price.Description.InventoryFrequency.ShipSite.Status.UoM
                .Address1.Address2.AddressName.AddressCity.AddressState.AddressZip;
        }
    }

    public class CustomerOrderLineItemBuilder :
        IdoQueryBuilder<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder>
    {
        public CustomerOrderLineItemBuilder(IExpressionInterpreter ei) : base(CustomerOrderLineItem.IDO_NAME, ei) { }

        public CustomerOrderLineItemBuilder Item { get { AddProperty(CustomerOrderLineItem.Item); return this; } }
        public CustomerOrderLineItemBuilder Address1 { get { AddProperty(CustomerOrderLineItem.Address1); return this; } }
        public CustomerOrderLineItemBuilder Address2 { get { AddProperty(CustomerOrderLineItem.Address2); return this; } }
        public CustomerOrderLineItemBuilder AddressCity { get { AddProperty(CustomerOrderLineItem.AddressCity); return this; } }
        public CustomerOrderLineItemBuilder AddressState { get { AddProperty(CustomerOrderLineItem.AddressState); return this; } }
        public CustomerOrderLineItemBuilder AddressZip { get { AddProperty(CustomerOrderLineItem.AddressZip); return this; } }
        public CustomerOrderLineItemBuilder AddressName { get { AddProperty(CustomerOrderLineItem.AddressName); return this; } }

        public CustomerOrderLineItemBuilder LineNumber { get { AddProperty(CustomerOrderLineItem.LineNumber); return this; } }

        public CustomerOrderLineItemBuilder CustomerPartNumber { get { AddProperty(CustomerOrderLineItem.CustomerPartNumber); return this; } }

        public CustomerOrderLineItemBuilder CustomerNumber { get { AddProperty(CustomerOrderLineItem.CustomerNumber); return this; } }
          

        public CustomerOrderLineItemBuilder ReleaseNumber { get { AddProperty(CustomerOrderLineItem.ReleaseNumber); return this; } }
         
        public CustomerOrderLineItemBuilder OrderNumber
        {
            get { AddProperty(CustomerOrderLineItem.OrderNumber); return this; } 
        }
        public CustomerOrderLineItemBuilder Status
        {
            get
            {
                AddProperty(CustomerOrderLineItem.Status);
                return this;
            }
        }
        public CustomerOrderLineItemBuilder Warehouse
        {
            get { AddProperty(CustomerOrderLineItem.Warehouse);
                return this; }
        }
 

 

        public CustomerOrderLineItemBuilder InventoryFrequency
        {            
            get { AddProperty(CustomerOrderLineItem.InventoryFrequency);
                return this; }
        }

        public CustomerOrderLineItemBuilder UoM
        {
                      get { AddProperty(CustomerOrderLineItem.UnitOfMeasure);
                return this; }
        }


        public new CustomerOrderLineItemBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (CustomerOrderLineItemBuilder) base.WithChildren(builders);
        }

        public new CustomerOrderLineItemBuilder LinkBy(string parentField, string childField)
        {
            return  (CustomerOrderLineItemBuilder) base.LinkBy(parentField, childField);
        }

        public CustomerOrderLineItemBuilder Adr01CreditHold { get { AddProperty(CustomerOrderLineItem.Adr01CreditHold); return this; } }
        public CustomerOrderLineItemBuilder Adr0CorpCred { get { AddProperty(CustomerOrderLineItem.Adr0CorpCred); return this; } }
        public CustomerOrderLineItemBuilder Adr0CorpCust { get { AddProperty(CustomerOrderLineItem.Adr0CorpCust); return this; } }
        public CustomerOrderLineItemBuilder Adr0CreditHold { get { AddProperty(CustomerOrderLineItem.Adr0CreditHold); return this; } }
        public CustomerOrderLineItemBuilder Adr0Name { get { AddProperty(CustomerOrderLineItem.Adr0Name); return this; } }
        public CustomerOrderLineItemBuilder AdrAddr_1 { get { AddProperty(CustomerOrderLineItem.AdrAddr_1); return this; } }
        public CustomerOrderLineItemBuilder AdrAddr_2 { get { AddProperty(CustomerOrderLineItem.AdrAddr_2); return this; } }
        public CustomerOrderLineItemBuilder AdrAddr_3 { get { AddProperty(CustomerOrderLineItem.AdrAddr_3); return this; } }
        public CustomerOrderLineItemBuilder AdrAddr_4 { get { AddProperty(CustomerOrderLineItem.AdrAddr_4); return this; } }
        public CustomerOrderLineItemBuilder AdrCity { get { AddProperty(CustomerOrderLineItem.AdrCity); return this; } }
        public CustomerOrderLineItemBuilder AdrCountry { get { AddProperty(CustomerOrderLineItem.AdrCountry); return this; } }
        public CustomerOrderLineItemBuilder AdrCreditHold { get { AddProperty(CustomerOrderLineItem.AdrCreditHold); return this; } }
        public CustomerOrderLineItemBuilder AdrCurrCode { get { AddProperty(CustomerOrderLineItem.AdrCurrCode); return this; } }
        public CustomerOrderLineItemBuilder AdrCurrdescription { get { AddProperty(CustomerOrderLineItem.AdrCurrdescription); return this; } }
        public CustomerOrderLineItemBuilder AdrFaxNum { get { AddProperty(CustomerOrderLineItem.AdrFaxNum); return this; } }
        public CustomerOrderLineItemBuilder AdrName { get { AddProperty(CustomerOrderLineItem.AdrName); return this; } }
        public CustomerOrderLineItemBuilder AdrState { get { AddProperty(CustomerOrderLineItem.AdrState); return this; } }
        public CustomerOrderLineItemBuilder AdrZip { get { AddProperty(CustomerOrderLineItem.AdrZip); return this; } }
        public CustomerOrderLineItemBuilder BatchId { get { AddProperty(CustomerOrderLineItem.BatchId); return this; } }
        public CustomerOrderLineItemBuilder Bol { get { AddProperty(CustomerOrderLineItem.Bol); return this; } }
        public CustomerOrderLineItemBuilder BrkQty_1 { get { AddProperty(CustomerOrderLineItem.BrkQty_1); return this; } }
        public CustomerOrderLineItemBuilder BrkQty_2 { get { AddProperty(CustomerOrderLineItem.BrkQty_2); return this; } }
        public CustomerOrderLineItemBuilder BrkQty_3 { get { AddProperty(CustomerOrderLineItem.BrkQty_3); return this; } }
        public CustomerOrderLineItemBuilder BrkQty_4 { get { AddProperty(CustomerOrderLineItem.BrkQty_4); return this; } }
        public CustomerOrderLineItemBuilder BrkQty_5 { get { AddProperty(CustomerOrderLineItem.BrkQty_5); return this; } }
        public CustomerOrderLineItemBuilder CblBlanketQtyConv { get { AddProperty(CustomerOrderLineItem.CblBlanketQtyConv); return this; } }
        public CustomerOrderLineItemBuilder CblCoLine { get { AddProperty(CustomerOrderLineItem.CblCoLine); return this; } }
        public CustomerOrderLineItemBuilder CblContPriceConv { get { AddProperty(CustomerOrderLineItem.CblContPriceConv); return this; } }
        public CustomerOrderLineItemBuilder CblEffDate { get { AddProperty(CustomerOrderLineItem.CblEffDate); return this; } }
        public CustomerOrderLineItemBuilder CblExpDate { get { AddProperty(CustomerOrderLineItem.CblExpDate); return this; } }
        public CustomerOrderLineItemBuilder CblItem { get { AddProperty(CustomerOrderLineItem.CblItem); return this; } }
        public CustomerOrderLineItemBuilder CblShipSite { get { AddProperty(CustomerOrderLineItem.CblShipSite); return this; } }
        public CustomerOrderLineItemBuilder CblStat { get { AddProperty(CustomerOrderLineItem.CblStat); return this; } }
        public CustomerOrderLineItemBuilder CblUM { get { AddProperty(CustomerOrderLineItem.CblUM); return this; } }
        public CustomerOrderLineItemBuilder CfgMainConfigGid { get { AddProperty(CustomerOrderLineItem.CfgMainConfigGid); return this; } }
        public CustomerOrderLineItemBuilder CfgMainConfigModel { get { AddProperty(CustomerOrderLineItem.CfgMainConfigModel); return this; } }
        public CustomerOrderLineItemBuilder CfgMainConfigStatus { get { AddProperty(CustomerOrderLineItem.CfgMainConfigStatus); return this; } }
        public CustomerOrderLineItemBuilder CgsTotal { get { AddProperty(CustomerOrderLineItem.CgsTotal); return this; } }
        public CustomerOrderLineItemBuilder CgsTotalFovhd { get { AddProperty(CustomerOrderLineItem.CgsTotalFovhd); return this; } }
        public CustomerOrderLineItemBuilder CgsTotalLbr { get { AddProperty(CustomerOrderLineItem.CgsTotalLbr); return this; } }
        public CustomerOrderLineItemBuilder CgsTotalMatl { get { AddProperty(CustomerOrderLineItem.CgsTotalMatl); return this; } }
        public CustomerOrderLineItemBuilder CgsTotalOut { get { AddProperty(CustomerOrderLineItem.CgsTotalOut); return this; } }
        public CustomerOrderLineItemBuilder CgsTotalVovhd { get { AddProperty(CustomerOrderLineItem.CgsTotalVovhd); return this; } }
        public CustomerOrderLineItemBuilder CoCloseDate { get { AddProperty(CustomerOrderLineItem.CoCloseDate); return this; } }
        public CustomerOrderLineItemBuilder CoCoCustNum { get { AddProperty(CustomerOrderLineItem.CoCoCustNum); return this; } }
        public CustomerOrderLineItemBuilder CoConsolidate { get { AddProperty(CustomerOrderLineItem.CoConsolidate); return this; } }
        public CustomerOrderLineItemBuilder CoCost { get { AddProperty(CustomerOrderLineItem.CoCost); return this; } }
        public CustomerOrderLineItemBuilder CoCreditHold { get { AddProperty(CustomerOrderLineItem.CoCreditHold); return this; } }
        public CustomerOrderLineItemBuilder CoCustNum { get { AddProperty(CustomerOrderLineItem.CoCustNum); return this; } }
        public CustomerOrderLineItemBuilder CoCustPo { get { AddProperty(CustomerOrderLineItem.CoCustPo); return this; } }
        public CustomerOrderLineItemBuilder CoEdiOrder { get { AddProperty(CustomerOrderLineItem.CoEdiOrder); return this; } }
        public CustomerOrderLineItemBuilder CoExchRate { get { AddProperty(CustomerOrderLineItem.CoExchRate); return this; } }
        public CustomerOrderLineItemBuilder CoExportType { get { AddProperty(CustomerOrderLineItem.CoExportType); return this; } }
        public CustomerOrderLineItemBuilder CoiiCoNum { get { AddProperty(CustomerOrderLineItem.CoiiCoNum); return this; } }
        public CustomerOrderLineItemBuilder CoInvFreq { get { AddProperty(CustomerOrderLineItem.CoInvFreq); return this; } }
        public CustomerOrderLineItemBuilder CoLine { get { AddProperty(CustomerOrderLineItem.CoLine); return this; } }
        public CustomerOrderLineItemBuilder CommCode { get { AddProperty(CustomerOrderLineItem.CommCode); return this; } }
        public CustomerOrderLineItemBuilder ComSupplQtyReq { get { AddProperty(CustomerOrderLineItem.ComSupplQtyReq); return this; } }
        public CustomerOrderLineItemBuilder ConfigID { get { AddProperty(CustomerOrderLineItem.ConfigID); return this; } }
        public CustomerOrderLineItemBuilder ConsNum { get { AddProperty(CustomerOrderLineItem.ConsNum); return this; } }
        public CustomerOrderLineItemBuilder Consolidate { get { AddProperty(CustomerOrderLineItem.Consolidate); return this; } }
        public CustomerOrderLineItemBuilder CoNum { get { AddProperty(CustomerOrderLineItem.CoNum); return this; } }
        public CustomerOrderLineItemBuilder CoOrderDate { get { AddProperty(CustomerOrderLineItem.CoOrderDate); return this; } }
        public CustomerOrderLineItemBuilder CoOrigSite { get { AddProperty(CustomerOrderLineItem.CoOrigSite); return this; } }
        public CustomerOrderLineItemBuilder CoPrice { get { AddProperty(CustomerOrderLineItem.CoPrice); return this; } }
        public CustomerOrderLineItemBuilder CoRelease { get { AddProperty(CustomerOrderLineItem.CoRelease); return this; } }
        public CustomerOrderLineItemBuilder CosDoLine { get { AddProperty(CustomerOrderLineItem.CosDoLine); return this; } }
        public CustomerOrderLineItemBuilder CosDoNum { get { AddProperty(CustomerOrderLineItem.CosDoNum); return this; } }
        public CustomerOrderLineItemBuilder CosDoSeq { get { AddProperty(CustomerOrderLineItem.CosDoSeq); return this; } }
        public CustomerOrderLineItemBuilder CosQtyInvoiced { get { AddProperty(CustomerOrderLineItem.CosQtyInvoiced); return this; } }
        public CustomerOrderLineItemBuilder CosQtyReturned { get { AddProperty(CustomerOrderLineItem.CosQtyReturned); return this; } }
        public CustomerOrderLineItemBuilder CosQtyShipped { get { AddProperty(CustomerOrderLineItem.CosQtyShipped); return this; } }
        public CustomerOrderLineItemBuilder Cost { get { AddProperty(CustomerOrderLineItem.Cost); return this; } }
        public CustomerOrderLineItemBuilder CoStat { get { AddProperty(CustomerOrderLineItem.CoStat); return this; } }
        public CustomerOrderLineItemBuilder CostConv { get { AddProperty(CustomerOrderLineItem.CostConv); return this; } }
        public CustomerOrderLineItemBuilder CoTaxCode1 { get { AddProperty(CustomerOrderLineItem.CoTaxCode1); return this; } }
        public CustomerOrderLineItemBuilder CoTaxCode2 { get { AddProperty(CustomerOrderLineItem.CoTaxCode2); return this; } }
        public CustomerOrderLineItemBuilder CoTermsCode { get { AddProperty(CustomerOrderLineItem.CoTermsCode); return this; } }
        public CustomerOrderLineItemBuilder CoType { get { AddProperty(CustomerOrderLineItem.OrderType); return this; } }
        public CustomerOrderLineItemBuilder CoUseExchRate { get { AddProperty(CustomerOrderLineItem.CoUseExchRate); return this; } }
        public CustomerOrderLineItemBuilder CoWhse { get { AddProperty(CustomerOrderLineItem.CoWhse); return this; } }
        public CustomerOrderLineItemBuilder CurrencyAmtFormat { get { AddProperty(CustomerOrderLineItem.CurrencyAmtFormat); return this; } }
        public CustomerOrderLineItemBuilder CurrencyCstPrcFormat { get { AddProperty(CustomerOrderLineItem.CurrencyCstPrcFormat); return this; } }
        public CustomerOrderLineItemBuilder CurrencyPlaces { get { AddProperty(CustomerOrderLineItem.CurrencyPlaces); return this; } }
        public CustomerOrderLineItemBuilder CusContact_2 { get { AddProperty(CustomerOrderLineItem.CusContact_2); return this; } }
        public CustomerOrderLineItemBuilder CusCustType { get { AddProperty(CustomerOrderLineItem.CusCustType); return this; } }
        public CustomerOrderLineItemBuilder CusDoInvoice { get { AddProperty(CustomerOrderLineItem.CusDoInvoice); return this; } }
        public CustomerOrderLineItemBuilder CusPhone_2 { get { AddProperty(CustomerOrderLineItem.CusPhone_2); return this; } }
        public CustomerOrderLineItemBuilder CustItem { get { AddProperty(CustomerOrderLineItem.CustItem); return this; } }
        public CustomerOrderLineItemBuilder CustNum { get { AddProperty(CustomerOrderLineItem.CustNum); return this; } }
        public CustomerOrderLineItemBuilder CustPo { get { AddProperty(CustomerOrderLineItem.CustPo); return this; } }
        public CustomerOrderLineItemBuilder CustSeq { get { AddProperty(CustomerOrderLineItem.CustSeq); return this; } }
        public CustomerOrderLineItemBuilder CusUseExchRate { get { AddProperty(CustomerOrderLineItem.CusUseExchRate); return this; } }
        public CustomerOrderLineItemBuilder Delterm { get { AddProperty(CustomerOrderLineItem.Delterm); return this; } }
        public CustomerOrderLineItemBuilder DerAllowOverCreditLimit { get { AddProperty(CustomerOrderLineItem.DerAllowOverCreditLimit); return this; } }
        public CustomerOrderLineItemBuilder DerApsOrderID { get { AddProperty(CustomerOrderLineItem.DerApsOrderID); return this; } }
        public CustomerOrderLineItemBuilder DerCanChangeItem { get { AddProperty(CustomerOrderLineItem.DerCanChangeItem); return this; } }
        public CustomerOrderLineItemBuilder DerCanChgShipSite { get { AddProperty(CustomerOrderLineItem.DerCanChgShipSite); return this; } }
        public CustomerOrderLineItemBuilder DerCfgJobIsConfigurable { get { AddProperty(CustomerOrderLineItem.DerCfgJobIsConfigurable); return this; } }
        public CustomerOrderLineItemBuilder DerCoverSheetCompany { get { AddProperty(CustomerOrderLineItem.DerCoverSheetCompany); return this; } }
        public CustomerOrderLineItemBuilder DerCoverSheetContact { get { AddProperty(CustomerOrderLineItem.DerCoverSheetContact); return this; } }
        public CustomerOrderLineItemBuilder DerCurrCode { get { AddProperty(CustomerOrderLineItem.DerCurrCode); return this; } }
        public CustomerOrderLineItemBuilder DerCurrencyPlaces { get { AddProperty(CustomerOrderLineItem.DerCurrencyPlaces); return this; } }
        public CustomerOrderLineItemBuilder DerDropShipAddress { get { AddProperty(CustomerOrderLineItem.DerDropShipAddress); return this; } }
        public CustomerOrderLineItemBuilder DerDropShipCustAddr { get { AddProperty(CustomerOrderLineItem.DerDropShipCustAddr); return this; } }
        public CustomerOrderLineItemBuilder DerDropShipFlag { get { AddProperty(CustomerOrderLineItem.DerDropShipFlag); return this; } }
        public CustomerOrderLineItemBuilder DerExtPrice { get { AddProperty(CustomerOrderLineItem.DerExtPrice); return this; } }
        public CustomerOrderLineItemBuilder DerFovhdCostConv { get { AddProperty(CustomerOrderLineItem.DerFovhdCostConv); return this; } }
        public CustomerOrderLineItemBuilder DerFovhdExtended { get { AddProperty(CustomerOrderLineItem.DerFovhdExtended); return this; } }
        public CustomerOrderLineItemBuilder DerInfobar { get { AddProperty(CustomerOrderLineItem.DerInfobar); return this; } }
        public CustomerOrderLineItemBuilder DerItemFeatTempl { get { AddProperty(CustomerOrderLineItem.DerItemFeatTempl); return this; } }
        public CustomerOrderLineItemBuilder DerItExist { get { AddProperty(CustomerOrderLineItem.DerItExist); return this; } }
        public CustomerOrderLineItemBuilder DerLbrExtended { get { AddProperty(CustomerOrderLineItem.DerLbrExtended); return this; } }
        public CustomerOrderLineItemBuilder DerLoc { get { AddProperty(CustomerOrderLineItem.DerLoc); return this; } }
        public CustomerOrderLineItemBuilder DerLot { get { AddProperty(CustomerOrderLineItem.DerLot); return this; } }
        public CustomerOrderLineItemBuilder DerMatlExtended { get { AddProperty(CustomerOrderLineItem.DerMatlExtended); return this; } }
        public CustomerOrderLineItemBuilder DerMaxQtyToPackConv { get { AddProperty(CustomerOrderLineItem.DerMaxQtyToPackConv); return this; } }
        public CustomerOrderLineItemBuilder DerMessage { get { AddProperty(CustomerOrderLineItem.DerMessage); return this; } }
        public CustomerOrderLineItemBuilder DerNetPrice { get { AddProperty(CustomerOrderLineItem.DerNetPrice); return this; } }
        public CustomerOrderLineItemBuilder DerOldCoLine { get { AddProperty(CustomerOrderLineItem.DerOldCoLine); return this; } }
        public CustomerOrderLineItemBuilder DerOldCoNum { get { AddProperty(CustomerOrderLineItem.DerOldCoNum); return this; } }
        public CustomerOrderLineItemBuilder DerOldStat { get { AddProperty(CustomerOrderLineItem.DerOldStat); return this; } }
        public CustomerOrderLineItemBuilder DerOrigQtyOrderedConv { get { AddProperty(CustomerOrderLineItem.DerOrigQtyOrderedConv); return this; } }
        public CustomerOrderLineItemBuilder DerOutExtended { get { AddProperty(CustomerOrderLineItem.DerOutExtended); return this; } }
        public CustomerOrderLineItemBuilder DerProgBillTotalBilled { get { AddProperty(CustomerOrderLineItem.DerProgBillTotalBilled); return this; } }
        public CustomerOrderLineItemBuilder DerProgBillTotalInvoiced { get { AddProperty(CustomerOrderLineItem.DerProgBillTotalInvoiced); return this; } }
        public CustomerOrderLineItemBuilder DerQtyInvoicedConv { get { AddProperty(CustomerOrderLineItem.DerQtyInvoicedConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyPackedConv { get { AddProperty(CustomerOrderLineItem.DerQtyPackedConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyPicked { get { AddProperty(CustomerOrderLineItem.DerQtyPicked); return this; } }
        public CustomerOrderLineItemBuilder DerQtyReady { get { AddProperty(CustomerOrderLineItem.DerQtyReady); return this; } }
        public CustomerOrderLineItemBuilder DerQtyReadyConv { get { AddProperty(CustomerOrderLineItem.DerQtyReadyConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyRsvdConv { get { AddProperty(CustomerOrderLineItem.DerQtyRsvdConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyShippedConv { get { AddProperty(CustomerOrderLineItem.DerQtyShippedConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyToInvoice { get { AddProperty(CustomerOrderLineItem.DerQtyToInvoice); return this; } }
        public CustomerOrderLineItemBuilder DerQtyToPack { get { AddProperty(CustomerOrderLineItem.DerQtyToPack); return this; } }
        public CustomerOrderLineItemBuilder DerQtyToPackConv { get { AddProperty(CustomerOrderLineItem.DerQtyToPackConv); return this; } }
        public CustomerOrderLineItemBuilder DerQtyToPick { get { AddProperty(CustomerOrderLineItem.DerQtyToPick); return this; } }
        public CustomerOrderLineItemBuilder DerQtyToShip { get { AddProperty(CustomerOrderLineItem.DerQtyToShip); return this; } }
        public CustomerOrderLineItemBuilder DerSelected { get { AddProperty(CustomerOrderLineItem.DerSelected); return this; } }
        public CustomerOrderLineItemBuilder DerSerialPrefix { get { AddProperty(CustomerOrderLineItem.DerSerialPrefix); return this; } }
        public CustomerOrderLineItemBuilder DerShiIteActive { get { AddProperty(CustomerOrderLineItem.DerShiIteActive); return this; } }
        public CustomerOrderLineItemBuilder DerTotCost { get { AddProperty(CustomerOrderLineItem.TotalCost); return this; } }
        public CustomerOrderLineItemBuilder DerTotExtended { get { AddProperty(CustomerOrderLineItem.DerTotExtended); return this; } }
        public CustomerOrderLineItemBuilder DerTotQtyToInvoice { get { AddProperty(CustomerOrderLineItem.DerTotQtyToInvoice); return this; } }
        public CustomerOrderLineItemBuilder DerUomConvFactor { get { AddProperty(CustomerOrderLineItem.DerUomConvFactor); return this; } }
        public CustomerOrderLineItemBuilder DerVovhdExtended { get { AddProperty(CustomerOrderLineItem.DerVovhdExtended); return this; } }
        public CustomerOrderLineItemBuilder Description { get { AddProperty(CustomerOrderLineItem.Description); return this; } }
        public CustomerOrderLineItemBuilder Disc { get { AddProperty(CustomerOrderLineItem.Disc); return this; } }
        public CustomerOrderLineItemBuilder DltDescription { get { AddProperty(CustomerOrderLineItem.DltDescription); return this; } }
        public CustomerOrderLineItemBuilder DoLine { get { AddProperty(CustomerOrderLineItem.DoLine); return this; } }
        public CustomerOrderLineItemBuilder DueDate { get { AddProperty(CustomerOrderLineItem.DueDate); return this; } }
        public CustomerOrderLineItemBuilder EcCode { get { AddProperty(CustomerOrderLineItem.EcCode); return this; } }
        public CustomerOrderLineItemBuilder ExportValue { get { AddProperty(CustomerOrderLineItem.ExportValue); return this; } }
        public CustomerOrderLineItemBuilder ExtendedCost { get { AddProperty(CustomerOrderLineItem.ExtendedCost); return this; } }
        public CustomerOrderLineItemBuilder ExtendedPrice { get { AddProperty(CustomerOrderLineItem.ExtendedPrice); return this; } }
        public CustomerOrderLineItemBuilder ExternalReservationRef { get { AddProperty(CustomerOrderLineItem.ExternalReservationRef); return this; } }
        public CustomerOrderLineItemBuilder FeatStr { get { AddProperty(CustomerOrderLineItem.FeatStr); return this; } }
        public CustomerOrderLineItemBuilder FovhdCost { get { AddProperty(CustomerOrderLineItem.FovhdCost); return this; } }
        public CustomerOrderLineItemBuilder FovhdCostConv { get { AddProperty(CustomerOrderLineItem.FovhdCostConv); return this; } }
        public CustomerOrderLineItemBuilder InvFreq { get { AddProperty(CustomerOrderLineItem.InvFreq); return this; } }
        public CustomerOrderLineItemBuilder InWorkflow { get { AddProperty(CustomerOrderLineItem.InWorkflow); return this; } }
        public CustomerOrderLineItemBuilder ItAutoJob { get { AddProperty(CustomerOrderLineItem.ItAutoJob); return this; } }
        public CustomerOrderLineItemBuilder ItAutoPost { get { AddProperty(CustomerOrderLineItem.ItAutoPost); return this; } }
        public CustomerOrderLineItemBuilder ItCfgModel { get { AddProperty(CustomerOrderLineItem.ItCfgModel); return this; } }
        public CustomerOrderLineItemBuilder ItCoPostConfig { get { AddProperty(CustomerOrderLineItem.ItCoPostConfig); return this; } }
        public CustomerOrderLineItemBuilder ItDescription { get { AddProperty(CustomerOrderLineItem.ItDescription); return this; } } 
        public CustomerOrderLineItemBuilder IteWhsQtyOnHand { get { AddProperty(CustomerOrderLineItem.IteWhsQtyOnHand); return this; } }
        public CustomerOrderLineItemBuilder ItKit { get { AddProperty(CustomerOrderLineItem.ItKit); return this; } }
        public CustomerOrderLineItemBuilder ItLotTracked { get { AddProperty(CustomerOrderLineItem.ItLotTracked); return this; } }
        public CustomerOrderLineItemBuilder ItOrderConfigurable { get { AddProperty(CustomerOrderLineItem.ItOrderConfigurable); return this; } }
        public CustomerOrderLineItemBuilder ItPlanFlag { get { AddProperty(CustomerOrderLineItem.ItPlanFlag); return this; } }
        public CustomerOrderLineItemBuilder ItReservable { get { AddProperty(CustomerOrderLineItem.ItReservable); return this; } }
        public CustomerOrderLineItemBuilder ItSerialTracked { get { AddProperty(CustomerOrderLineItem.ItSerialTracked); return this; } }
        public CustomerOrderLineItemBuilder ItSupplySite { get { AddProperty(CustomerOrderLineItem.ItSupplySite); return this; } }
        public CustomerOrderLineItemBuilder ItUM { get { AddProperty(CustomerOrderLineItem.ItUM); return this; } }
        public CustomerOrderLineItemBuilder ItUWsPrice { get { AddProperty(CustomerOrderLineItem.ItUWsPrice); return this; } }
        public CustomerOrderLineItemBuilder LbrCost { get { AddProperty(CustomerOrderLineItem.LbrCost); return this; } }
        public CustomerOrderLineItemBuilder LbrCostConv { get { AddProperty(CustomerOrderLineItem.LbrCostConv); return this; } }
        public CustomerOrderLineItemBuilder Margin { get { AddProperty(CustomerOrderLineItem.Margin); return this; } }
        public CustomerOrderLineItemBuilder MarginPercent { get { AddProperty(CustomerOrderLineItem.MarginPercent); return this; } }
        public CustomerOrderLineItemBuilder MatlCost { get { AddProperty(CustomerOrderLineItem.MatlCost); return this; } }
        public CustomerOrderLineItemBuilder MatlCostConv { get { AddProperty(CustomerOrderLineItem.MatlCostConv); return this; } }
        public CustomerOrderLineItemBuilder NoteExistsFlag { get { AddProperty(CustomerOrderLineItem.NoteExistsFlag); return this; } }
        public CustomerOrderLineItemBuilder Origin { get { AddProperty(CustomerOrderLineItem.Origin); return this; } }
        public CustomerOrderLineItemBuilder OutCost { get { AddProperty(CustomerOrderLineItem.OutCost); return this; } }
        public CustomerOrderLineItemBuilder OutCostConv { get { AddProperty(CustomerOrderLineItem.OutCostConv); return this; } }
        public CustomerOrderLineItemBuilder Packed { get { AddProperty(CustomerOrderLineItem.Packed); return this; } }
        public CustomerOrderLineItemBuilder ParCfgConfigGid { get { AddProperty(CustomerOrderLineItem.ParCfgConfigGid); return this; } }
        public CustomerOrderLineItemBuilder PickDate { get { AddProperty(CustomerOrderLineItem.PickDate); return this; } }
        public CustomerOrderLineItemBuilder PrgBillApp { get { AddProperty(CustomerOrderLineItem.PrgBillApp); return this; } }
        public CustomerOrderLineItemBuilder PrgBillTot { get { AddProperty(CustomerOrderLineItem.PrgBillTot); return this; } }
        public CustomerOrderLineItemBuilder Price { get { AddProperty(CustomerOrderLineItem.Price); return this; } }
        public CustomerOrderLineItemBuilder Pricecode { get { AddProperty(CustomerOrderLineItem.Pricecode); return this; } }
        public CustomerOrderLineItemBuilder PricecodeDesc { get { AddProperty(CustomerOrderLineItem.PricecodeDesc); return this; } }
        public CustomerOrderLineItemBuilder PriceConv { get { AddProperty(CustomerOrderLineItem.PriceConv); return this; } }
        public CustomerOrderLineItemBuilder PrintKitComponents { get { AddProperty(CustomerOrderLineItem.PrintKitComponents); return this; } }
        public CustomerOrderLineItemBuilder ProcessInd { get { AddProperty(CustomerOrderLineItem.ProcessInd); return this; } }
        public CustomerOrderLineItemBuilder ProCompany { get { AddProperty(CustomerOrderLineItem.ProCompany); return this; } }
        public CustomerOrderLineItemBuilder ProCurrCode { get { AddProperty(CustomerOrderLineItem.ProCurrCode); return this; } }
        public CustomerOrderLineItemBuilder ProjectedDate { get { AddProperty(CustomerOrderLineItem.ProjectedDate); return this; } }
        public CustomerOrderLineItemBuilder PromiseDate { get { AddProperty(CustomerOrderLineItem.PromiseDate); return this; } }
        public CustomerOrderLineItemBuilder ProspectId { get { AddProperty(CustomerOrderLineItem.ProspectId); return this; } }
        public CustomerOrderLineItemBuilder QtyInvoiced { get { AddProperty(CustomerOrderLineItem.QtyInvoiced); return this; } }
        public CustomerOrderLineItemBuilder QtyOrdered { get { AddProperty(CustomerOrderLineItem.QtyOrdered); return this; } }
        public CustomerOrderLineItemBuilder QtyOrderedConv { get { AddProperty(CustomerOrderLineItem.QtyOrderedConv); return this; } }
        public CustomerOrderLineItemBuilder QtyPacked { get { AddProperty(CustomerOrderLineItem.QtyPacked); return this; } }
        public CustomerOrderLineItemBuilder QtyReady { get { AddProperty(CustomerOrderLineItem.QtyReady); return this; } }
        public CustomerOrderLineItemBuilder QtyReturned { get { AddProperty(CustomerOrderLineItem.QtyReturned); return this; } }
        public CustomerOrderLineItemBuilder QtyRsvd { get { AddProperty(CustomerOrderLineItem.QtyRsvd); return this; } }
        public CustomerOrderLineItemBuilder QtyShipped { get { AddProperty(CustomerOrderLineItem.QtyShipped); return this; } }
        public CustomerOrderLineItemBuilder RecordDate { get { AddProperty(CustomerOrderLineItem.RecordDate); return this; } }
        public CustomerOrderLineItemBuilder RefLineSuf { get { AddProperty(CustomerOrderLineItem.RefLineSuf); return this; } }
        public CustomerOrderLineItemBuilder RefNum { get { AddProperty(CustomerOrderLineItem.RefNum); return this; } }
        public CustomerOrderLineItemBuilder RefRelease { get { AddProperty(CustomerOrderLineItem.RefRelease); return this; } }
        public CustomerOrderLineItemBuilder RefType { get { AddProperty(CustomerOrderLineItem.RefType); return this; } }
        public CustomerOrderLineItemBuilder ReleaseDate { get { AddProperty(CustomerOrderLineItem.ReleaseDate); return this; } }
        public CustomerOrderLineItemBuilder Reprice { get { AddProperty(CustomerOrderLineItem.Reprice); return this; } }
        public CustomerOrderLineItemBuilder RmaLine { get { AddProperty(CustomerOrderLineItem.RmaLine); return this; } }
        public CustomerOrderLineItemBuilder RmaNum { get { AddProperty(CustomerOrderLineItem.RmaNum); return this; } }
        public CustomerOrderLineItemBuilder RowPointer { get { AddProperty(CustomerOrderLineItem.RowPointer); return this; } }
        public CustomerOrderLineItemBuilder ShiIteActive { get { AddProperty(CustomerOrderLineItem.ShiIteActive); return this; } }
        public CustomerOrderLineItemBuilder ShipDate { get { AddProperty(CustomerOrderLineItem.ShipDate); return this; } }
        public CustomerOrderLineItemBuilder ShipSite { get { AddProperty(CustomerOrderLineItem.ShipSite); return this; } }
        public CustomerOrderLineItemBuilder ShowInDropDownList { get { AddProperty(CustomerOrderLineItem.ShowInDropDownList); return this; } }
        public CustomerOrderLineItemBuilder SLProgbills { get { AddProperty(CustomerOrderLineItem.SLProgbills); return this; } }
        public CustomerOrderLineItemBuilder SLRsvdInvs { get { AddProperty(CustomerOrderLineItem.SLRsvdInvs); return this; } }
        public CustomerOrderLineItemBuilder SLSerials { get { AddProperty(CustomerOrderLineItem.SLSerials); return this; } } 
        public CustomerOrderLineItemBuilder Summarize { get { AddProperty(CustomerOrderLineItem.Summarize); return this; } }
        public CustomerOrderLineItemBuilder SupplQtyConvFactor { get { AddProperty(CustomerOrderLineItem.SupplQtyConvFactor); return this; } }
        public CustomerOrderLineItemBuilder SyncReqd { get { AddProperty(CustomerOrderLineItem.SyncReqd); return this; } }
        public CustomerOrderLineItemBuilder TaxCode1 { get { AddProperty(CustomerOrderLineItem.TaxCode1); return this; } }
        public CustomerOrderLineItemBuilder TaxCode2 { get { AddProperty(CustomerOrderLineItem.TaxCode2); return this; } }
        public CustomerOrderLineItemBuilder Tc1Description { get { AddProperty(CustomerOrderLineItem.Tc1Description); return this; } }
        public CustomerOrderLineItemBuilder Tc2Description { get { AddProperty(CustomerOrderLineItem.Tc2Description); return this; } }
        public CustomerOrderLineItemBuilder TermsDescription { get { AddProperty(CustomerOrderLineItem.TermsDescription); return this; } }
        public CustomerOrderLineItemBuilder TransNat { get { AddProperty(CustomerOrderLineItem.TransNat); return this; } }
        public CustomerOrderLineItemBuilder TransNat2 { get { AddProperty(CustomerOrderLineItem.TransNat2); return this; } }
        public CustomerOrderLineItemBuilder TransNat2Description { get { AddProperty(CustomerOrderLineItem.TransNat2Description); return this; } }
        public CustomerOrderLineItemBuilder Transport { get { AddProperty(CustomerOrderLineItem.Transport); return this; } }
        public CustomerOrderLineItemBuilder TrnDescription { get { AddProperty(CustomerOrderLineItem.TrnDescription); return this; } }
        public CustomerOrderLineItemBuilder UbDispMsg { get { AddProperty(CustomerOrderLineItem.UbDispMsg); return this; } }
        public CustomerOrderLineItemBuilder UbDispXRefMsg { get { AddProperty(CustomerOrderLineItem.UbDispXRefMsg); return this; } }
        public CustomerOrderLineItemBuilder UbGenerateQty { get { AddProperty(CustomerOrderLineItem.UbGenerateQty); return this; } }
        public CustomerOrderLineItemBuilder UbIncrPrice { get { AddProperty(CustomerOrderLineItem.UbIncrPrice); return this; } }
        public CustomerOrderLineItemBuilder UbItem { get { AddProperty(CustomerOrderLineItem.UbItem); return this; } }
        public CustomerOrderLineItemBuilder UbItemCustAdd { get { AddProperty(CustomerOrderLineItem.UbItemCustAdd); return this; } }
        public CustomerOrderLineItemBuilder UbItemCustUpdate { get { AddProperty(CustomerOrderLineItem.UbItemCustUpdate); return this; } }
        public CustomerOrderLineItemBuilder UbNetAdjust { get { AddProperty(CustomerOrderLineItem.UbNetAdjust); return this; } }
        public CustomerOrderLineItemBuilder UbNewDisc { get { AddProperty(CustomerOrderLineItem.UbNewDisc); return this; } }
        public CustomerOrderLineItemBuilder UbNewNet { get { AddProperty(CustomerOrderLineItem.UbNewNet); return this; } }
        public CustomerOrderLineItemBuilder UbNewPrice { get { AddProperty(CustomerOrderLineItem.UbNewPrice); return this; } }
        public CustomerOrderLineItemBuilder UbOldNet { get { AddProperty(CustomerOrderLineItem.UbOldNet); return this; } }
        public CustomerOrderLineItemBuilder UbPackNum { get { AddProperty(CustomerOrderLineItem.UbPackNum); return this; } }
        public CustomerOrderLineItemBuilder UbPlanOnSave { get { AddProperty(CustomerOrderLineItem.UbPlanOnSave); return this; } }
        public CustomerOrderLineItemBuilder UbProgBillAmount { get { AddProperty(CustomerOrderLineItem.UbProgBillAmount); return this; } }
        public CustomerOrderLineItemBuilder UbQtyToAdjust { get { AddProperty(CustomerOrderLineItem.UbQtyToAdjust); return this; } }
        public CustomerOrderLineItemBuilder UbRangeQty { get { AddProperty(CustomerOrderLineItem.UbRangeQty); return this; } }
        public CustomerOrderLineItemBuilder UbSelect { get { AddProperty(CustomerOrderLineItem.UbSelect); return this; } }
        public CustomerOrderLineItemBuilder UbSelectedQty { get { AddProperty(CustomerOrderLineItem.UbSelectedQty); return this; } }
        public CustomerOrderLineItemBuilder UbSetItemCust { get { AddProperty(CustomerOrderLineItem.UbSetItemCust); return this; } }
        public CustomerOrderLineItemBuilder UbTargetQty { get { AddProperty(CustomerOrderLineItem.UbTargetQty); return this; } }
        public CustomerOrderLineItemBuilder UM { get { AddProperty(CustomerOrderLineItem.UM); return this; } }
        public CustomerOrderLineItemBuilder UnitWeight { get { AddProperty(CustomerOrderLineItem.UnitWeight); return this; } }
        public CustomerOrderLineItemBuilder VovhdCost { get { AddProperty(CustomerOrderLineItem.VovhdCost); return this; } }
        public CustomerOrderLineItemBuilder VovhdCostConv { get { AddProperty(CustomerOrderLineItem.VovhdCostConv); return this; } } 
        public CustomerOrderLineItemBuilder WksBasis { get { AddProperty(CustomerOrderLineItem.WksBasis); return this; } }
        public CustomerOrderLineItemBuilder WksValue { get { AddProperty(CustomerOrderLineItem.WksValue); return this; } } 
    }

    public class CustomerOrderLineItemFilterExpressionBuilder : FilterExpressionBuilder<CustomerOrderLineItemBuilder>
    {
        public FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder> OrderNumber
        {
            get { return new FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder>(_builder, CustomerOrderLineItem.OrderNumber); }
        }

        public FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder> ReleaseNumber
        {
            get { return new FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder>(_builder, CustomerOrderLineItem.ReleaseNumber); }
        }
        public FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder> LineNumber
        {
            get { return new FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder>(_builder, CustomerOrderLineItem.LineNumber); }
        }


        public FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder> QtyOrdered
        {
            get { return new FilterExpression<CustomerOrderLineItemBuilder, CustomerOrderLineItemFilterExpressionBuilder>(_builder, CustomerOrderLineItem.QtyOrdered ); }
        }
    }
}