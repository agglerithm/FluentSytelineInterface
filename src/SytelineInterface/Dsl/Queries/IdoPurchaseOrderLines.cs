using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class IdoPurchaseOrderLines : IdoConstants
    {
        public const string IDO_NAME = "SLPoItems";
        public const string CommCode = "CommCode";
        public const string ComSupplQtyReq = "ComSupplQtyReq";
        public const string ConsNum = "ConsNum";
        public const string CostType = "CostType";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCode = "CurrCode";
        public const string CurrCodeDesc = "CurrCodeDesc";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string Delterm = "Delterm";
        public const string DeltermDesc = "DeltermDesc";
        public const string DerASPSearch = "DerASPSearch";
        public const string DerBrokerageCurrCode = "DerBrokerageCurrCode";
        public const string DerBrokerageCurrCodeDesc = "DerBrokerageCurrCodeDesc";
        public const string DerBrokerageRate = "DerBrokerageRate";
        public const string DerDefaultLoc = "DerDefaultLoc";
        public const string DerDutyCurrCode = "DerDutyCurrCode";
        public const string DerDutyCurrCodeDesc = "DerDutyCurrCodeDesc";
        public const string DerDutyRate = "DerDutyRate";
        public const string DerExtItemCostConv = "DerExtItemCostConv";
        public const string DerExtPlanCostConv = "DerExtPlanCostConv";
        public const string DerFreightCurrCode = "DerFreightCurrCode";
        public const string DerFreightCurrCodeDesc = "DerFreightCurrCodeDesc";
        public const string DerFreightRate = "DerFreightRate";
        public const string DerGrnLine = "DerGrnLine";
        public const string DerGrnLineExists = "DerGrnLineExists";
        public const string DerGrnNum = "DerGrnNum";
        public const string DerInsuranceCurrCode = "DerInsuranceCurrCode";
        public const string DerInsuranceCurrCodeDesc = "DerInsuranceCurrCodeDesc";
        public const string DerInsuranceRate = "DerInsuranceRate";
        public const string DerItemExists = "DerItemExists";
        public const string DerLoc = "DerLoc";
        public const string DerLocFrtCurrCode = "DerLocFrtCurrCode";
        public const string DerLocFrtCurrCodeDesc = "DerLocFrtCurrCodeDesc";
        public const string DerLocFrtRate = "DerLocFrtRate";
        public const string DerLUnitBrokerageCost = "DerLUnitBrokerageCost";
        public const string DerLUnitDutyCost = "DerLUnitDutyCost";
        public const string DerLUnitFreightCost = "DerLUnitFreightCost";
        public const string DerLUnitInsuranceCost = "DerLUnitInsuranceCost";
        public const string DerLUnitLocFrtCost = "DerLUnitLocFrtCost";
        public const string DerMessage = "DerMessage";
        public const string DerNeedsPostReceiveWIP = "DerNeedsPostReceiveWIP";
        public const string DerNewStat = "DerNewStat";
        public const string DerPoChangeNum = "DerPoChangeNum";
        public const string DerPOChangeRowPointer = "DerPOChangeRowPointer";
        public const string DerPoChangeStat = "DerPoChangeStat";
        public const string DerQtyReceivedConv = "DerQtyReceivedConv";
        public const string DerQtyRejectedConv = "DerQtyRejectedConv";
        public const string DerQtyVoucherConv = "DerQtyVoucherConv";
        public const string DerReadOnlyRecordFlag = "DerReadOnlyRecordFlag";
        public const string DerRefDescription = "DerRefDescription";
        public const string DerShipToAddr = "DerShipToAddr";
        public const string DerStatFormatted = "DerStatFormatted";
        public const string DerTotalRcvdCost = "DerTotalRcvdCost";
        public const string DerTotQtyOrderedConv = "DerTotQtyOrderedConv";
        public const string DerUMDescription = "DerUMDescription";
        public const string Description = "Description";
        public const string DrawingNbr = "DrawingNbr";
        public const string DropSeq = "DropSeq";
        public const string DropShipNo = "DropShipNo";
        public const string DueDate = "DueDate";
        public const string EcCode = "EcCode";
        public const string Expedited = "Expedited";
        public const string ExportValue = "ExportValue";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItemCost = "ItemCost";
        public const string ItemCostConv = "ItemCostConv";
        public const string ItemPOToleranceOver = "ItemPOToleranceOver";
        public const string ItemPOToleranceUnder = "ItemPOToleranceUnder";
        public const string ItemType = "ItemType";
        public const string ItmDescription = "ItmDescription";
        public const string ItmLotPrefix = "ItmLotPrefix";
        public const string ItmLotTracked = "ItmLotTracked";
        public const string ItmSerialPrefix = "ItmSerialPrefix";
        public const string ItmSerialTracked = "ItmSerialTracked";
        public const string ItmTaxFreeMatl = "ItmTaxFreeMatl";
        public const string ItmUnitBrokerageCost = "ItmUnitBrokerageCost";
        public const string LcOverride = "LcOverride";
        public const string NonInvAccessUnit1 = "NonInvAccessUnit1";
        public const string NonInvAccessUnit2 = "NonInvAccessUnit2";
        public const string NonInvAccessUnit3 = "NonInvAccessUnit3";
        public const string NonInvAccessUnit4 = "NonInvAccessUnit4";
        public const string NonInvAcct = "NonInvAcct";
        public const string NonInvAcctDesc = "NonInvAcctDesc";
        public const string NonInvAcctUnit1 = "NonInvAcctUnit1";
        public const string NonInvAcctUnit2 = "NonInvAcctUnit2";
        public const string NonInvAcctUnit3 = "NonInvAcctUnit3";
        public const string NonInvAcctUnit4 = "NonInvAcctUnit4";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string Origin = "Origin";
        public const string PlanCost = "PlanCost";
        public const string PlanCostConv = "PlanCostConv";
        public const string PoBlnBlanketQtyConv = "PoBlnBlanketQtyConv";
        public const string PoBlnDescription = "PoBlnDescription";
        public const string PoBlnDrawingNbr = "PoBlnDrawingNbr";
        public const string PoBlnEffDate = "PoBlnEffDate";
        public const string PoBlnExpDate = "PoBlnExpDate";
        public const string PoBlnItem = "PoBlnItem";
        public const string PoBlnItemCostConv = "PoBlnItemCostConv";
        public const string PoBlnPlanCostConv = "PoBlnPlanCostConv";
        public const string PoBlnPoLine = "PoBlnPoLine";
        public const string PoBlnRevision = "PoBlnRevision";
        public const string PoBlnStat = "PoBlnStat";
        public const string PoBlnUM = "PoBlnUM";
        public const string PoBlnVendItem = "PoBlnVendItem";
        public const string PoBuilderPoNum = "PoBuilderPoNum";
        public const string PoBuilderPoOrigSite = "PoBuilderPoOrigSite";
        public const string PoContainsOnlyTaxFreeMatls = "PoContainsOnlyTaxFreeMatls";
        public const string PoExchRate = "PoExchRate";
        public const string POIncludeTaxInCost = "POIncludeTaxInCost";
        public const string PoLine = "PoLine";
        public const string PoNum = "PoNum";
        public const string PoOrderDate = "PoOrderDate";
        public const string PoRelease = "PoRelease";
        public const string PoStat = "PoStat";
        public const string PoTaxCode1 = "PoTaxCode1";
        public const string PoTaxCode2 = "PoTaxCode2";
        public const string PoType = "PoType";
        public const string PoVendNum = "PoVendNum";
        public const string PoVendorPo = "PoVendorPo";
        public const string ProcessInd = "ProcessInd";
        public const string PromiseDate = "PromiseDate";
        public const string QtyOrdered = "QtyOrdered";
        public const string QtyOrderedConv = "QtyOrderedConv";
        public const string QtyReceived = "QtyReceived";
        public const string QtyRejected = "QtyRejected";
        public const string QtyReturned = "QtyReturned";
        public const string QtyVoucher = "QtyVoucher";
        public const string RcvdDate = "RcvdDate";
        public const string RecordDate = "RecordDate";
        public const string RefLineSuf = "RefLineSuf";
        public const string RefNum = "RefNum";
        public const string RefRelease = "RefRelease";
        public const string RefType = "RefType";
        public const string ReleaseDate = "ReleaseDate";
        public const string ReqLine = "ReqLine";
        public const string ReqNum = "ReqNum";
        public const string Revision = "Revision";
        public const string RootJob = "RootJob";
        public const string RootSuf = "RootSuf";
        public const string RowPointer = "RowPointer";
        public const string ShipAddr = "ShipAddr";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string SLPochanges = "SLPochanges";
        public const string SLSerials = "SLSerials";
        public const string Stat = "Stat";
        public const string SupplQtyConvFactor = "SupplQtyConvFactor";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode1Desc = "TaxCode1Desc";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxCode2Desc = "TaxCode2Desc";
        public const string TransNat = "TransNat";
        public const string TransNat2 = "TransNat2";
        public const string TransNat2Desc = "TransNat2Desc";
        public const string TransNatDesc = "TransNatDesc";
        public const string Transport = "Transport";
        public const string UbAddProjMatl = "UbAddProjMatl";
        public const string UbByCons = "UbByCons";
        public const string UbCostCode = "UbCostCode";
        public const string UbCostsChanged = "UbCostsChanged";
        public const string UbDispMsg = "UbDispMsg";
        public const string UbDispXRefMsg = "UbDispXRefMsg";
        public const string UbDRRt = "UbDRRt";
        public const string UbErrorStatus = "UbErrorStatus";
        public const string UbGrnExists = "UbGrnExists";
        public const string UbImportDocId = "UbImportDocId";
        public const string UbItemVendAdd = "UbItemVendAdd";
        public const string UbItemVendUpdate = "UbItemVendUpdate";
        public const string UbLocation = "UbLocation";
        public const string UbLot = "UbLot";
        public const string UbPackNum = "UbPackNum";
        public const string UbPoChangeIup = "UbPoChangeIup";
        public const string UbQtyReceived = "UbQtyReceived";
        public const string UbQtyReceivedConv = "UbQtyReceivedConv";
        public const string UbQtyReturned = "UbQtyReturned";
        public const string UbQtyReturnedConv = "UbQtyReturnedConv";
        public const string UbReasonCode = "UbReasonCode";
        public const string UbSelectedReceiving = "UbSelectedReceiving";
        public const string UbSequence = "UbSequence";
        public const string UbSerNumGenerateQty = "UbSerNumGenerateQty";
        public const string UbSerNumRangeQty = "UbSerNumRangeQty";
        public const string UbSerNumSelected = "UbSerNumSelected";
        public const string UbSerNumStatLinkBy = "UbSerNumStatLinkBy";
        public const string UbSImportDocId = "UbSImportDocId";
        public const string UbSLocation = "UbSLocation";
        public const string UbSLot = "UbSLot";
        public const string UbTotQtyReceived = "UbTotQtyReceived";
        public const string UbTotQtyReturned = "UbTotQtyReturned";
        public const string UbTransDate = "UbTransDate";
        public const string UbUnReceiveFlag = "UbUnReceiveFlag";
        public const string UbUpdateJobMatlUnitCost = "UbUpdateJobMatlUnitCost";
        public const string UbWorkKey = "UbWorkKey";
        public const string UM = "UM";
        public const string UnitBrokerageCost = "UnitBrokerageCost";
        public const string UnitBrokerageCostConv = "UnitBrokerageCostConv";
        public const string UnitDutyCost = "UnitDutyCost";
        public const string UnitDutyCostConv = "UnitDutyCostConv";
        public const string UnitFreightCost = "UnitFreightCost";
        public const string UnitFreightCostConv = "UnitFreightCostConv";
        public const string UnitInsuranceCost = "UnitInsuranceCost";
        public const string UnitInsuranceCostConv = "UnitInsuranceCostConv";
        public const string UnitLocFrtCost = "UnitLocFrtCost";
        public const string UnitLocFrtCostConv = "UnitLocFrtCostConv";
        public const string UnitMatCost = "UnitMatCost";
        public const string UnitMatCostConv = "UnitMatCostConv";
        public const string UnitWeight = "UnitWeight";
        public const string UnlinkedXref = "UnlinkedXref";
        public const string VenadrName = "VenadrName";
        public const string VendItem = "VendItem";
        public const string VendorCountry = "VendorCountry";
        public const string VendPriceBy = "VendPriceBy";
        public const string VoucherCost = "VoucherCost";
        public const string Whse = "Whse";


    }

    public class IdoPurchaseOrderLinesBuilder
        : IdoQueryBuilder<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>
    {
        public IdoPurchaseOrderLinesBuilder(IExpressionInterpreter interpreter) : base(IdoPurchaseOrderLines.IDO_NAME, interpreter) { }

        public IdoPurchaseOrderLinesBuilder CommCode { get { AddProperty(IdoPurchaseOrderLines.CommCode); return this; } }
        public IdoPurchaseOrderLinesBuilder ComSupplQtyReq { get { AddProperty(IdoPurchaseOrderLines.ComSupplQtyReq); return this; } }
        public IdoPurchaseOrderLinesBuilder ConsNum { get { AddProperty(IdoPurchaseOrderLines.ConsNum); return this; } }
        public IdoPurchaseOrderLinesBuilder CostType { get { AddProperty(IdoPurchaseOrderLines.CostType); return this; } }
        public IdoPurchaseOrderLinesBuilder CurrAmtTotFormat { get { AddProperty(IdoPurchaseOrderLines.CurrAmtTotFormat); return this; } }
        public IdoPurchaseOrderLinesBuilder CurrCode { get { AddProperty(IdoPurchaseOrderLines.CurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder CurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.CurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder CurrCstPrcFormat { get { AddProperty(IdoPurchaseOrderLines.CurrCstPrcFormat); return this; } }
        public IdoPurchaseOrderLinesBuilder Delterm { get { AddProperty(IdoPurchaseOrderLines.Delterm); return this; } }
        public IdoPurchaseOrderLinesBuilder DeltermDesc { get { AddProperty(IdoPurchaseOrderLines.DeltermDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerASPSearch { get { AddProperty(IdoPurchaseOrderLines.DerASPSearch); return this; } }
        public IdoPurchaseOrderLinesBuilder DerBrokerageCurrCode { get { AddProperty(IdoPurchaseOrderLines.DerBrokerageCurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder DerBrokerageCurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.DerBrokerageCurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerBrokerageRate { get { AddProperty(IdoPurchaseOrderLines.DerBrokerageRate); return this; } }
        public IdoPurchaseOrderLinesBuilder DerDefaultLoc { get { AddProperty(IdoPurchaseOrderLines.DerDefaultLoc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerDutyCurrCode { get { AddProperty(IdoPurchaseOrderLines.DerDutyCurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder DerDutyCurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.DerDutyCurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerDutyRate { get { AddProperty(IdoPurchaseOrderLines.DerDutyRate); return this; } }
        public IdoPurchaseOrderLinesBuilder DerExtItemCostConv { get { AddProperty(IdoPurchaseOrderLines.DerExtItemCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerExtPlanCostConv { get { AddProperty(IdoPurchaseOrderLines.DerExtPlanCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerFreightCurrCode { get { AddProperty(IdoPurchaseOrderLines.DerFreightCurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder DerFreightCurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.DerFreightCurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerFreightRate { get { AddProperty(IdoPurchaseOrderLines.DerFreightRate); return this; } }
        public IdoPurchaseOrderLinesBuilder DerGrnLine { get { AddProperty(IdoPurchaseOrderLines.DerGrnLine); return this; } }
        public IdoPurchaseOrderLinesBuilder DerGrnLineExists { get { AddProperty(IdoPurchaseOrderLines.DerGrnLineExists); return this; } }
        public IdoPurchaseOrderLinesBuilder DerGrnNum { get { AddProperty(IdoPurchaseOrderLines.DerGrnNum); return this; } }
        public IdoPurchaseOrderLinesBuilder DerInsuranceCurrCode { get { AddProperty(IdoPurchaseOrderLines.DerInsuranceCurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder DerInsuranceCurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.DerInsuranceCurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerInsuranceRate { get { AddProperty(IdoPurchaseOrderLines.DerInsuranceRate); return this; } }
        public IdoPurchaseOrderLinesBuilder DerItemExists { get { AddProperty(IdoPurchaseOrderLines.DerItemExists); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLoc { get { AddProperty(IdoPurchaseOrderLines.DerLoc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLocFrtCurrCode { get { AddProperty(IdoPurchaseOrderLines.DerLocFrtCurrCode); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLocFrtCurrCodeDesc { get { AddProperty(IdoPurchaseOrderLines.DerLocFrtCurrCodeDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLocFrtRate { get { AddProperty(IdoPurchaseOrderLines.DerLocFrtRate); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLUnitBrokerageCost { get { AddProperty(IdoPurchaseOrderLines.DerLUnitBrokerageCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLUnitDutyCost { get { AddProperty(IdoPurchaseOrderLines.DerLUnitDutyCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLUnitFreightCost { get { AddProperty(IdoPurchaseOrderLines.DerLUnitFreightCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLUnitInsuranceCost { get { AddProperty(IdoPurchaseOrderLines.DerLUnitInsuranceCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerLUnitLocFrtCost { get { AddProperty(IdoPurchaseOrderLines.DerLUnitLocFrtCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerMessage { get { AddProperty(IdoPurchaseOrderLines.DerMessage); return this; } }
        public IdoPurchaseOrderLinesBuilder DerNeedsPostReceiveWIP { get { AddProperty(IdoPurchaseOrderLines.DerNeedsPostReceiveWIP); return this; } }
        public IdoPurchaseOrderLinesBuilder DerNewStat { get { AddProperty(IdoPurchaseOrderLines.DerNewStat); return this; } }
        public IdoPurchaseOrderLinesBuilder DerPoChangeNum { get { AddProperty(IdoPurchaseOrderLines.DerPoChangeNum); return this; } }
        public IdoPurchaseOrderLinesBuilder DerPOChangeRowPointer { get { AddProperty(IdoPurchaseOrderLines.DerPOChangeRowPointer); return this; } }
        public IdoPurchaseOrderLinesBuilder DerPoChangeStat { get { AddProperty(IdoPurchaseOrderLines.DerPoChangeStat); return this; } }
        public IdoPurchaseOrderLinesBuilder DerQtyReceivedConv { get { AddProperty(IdoPurchaseOrderLines.DerQtyReceivedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerQtyRejectedConv { get { AddProperty(IdoPurchaseOrderLines.DerQtyRejectedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerQtyVoucherConv { get { AddProperty(IdoPurchaseOrderLines.DerQtyVoucherConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerReadOnlyRecordFlag { get { AddProperty(IdoPurchaseOrderLines.DerReadOnlyRecordFlag); return this; } }
        public IdoPurchaseOrderLinesBuilder DerRefDescription { get { AddProperty(IdoPurchaseOrderLines.DerRefDescription); return this; } }
        public IdoPurchaseOrderLinesBuilder DerShipToAddr { get { AddProperty(IdoPurchaseOrderLines.DerShipToAddr); return this; } }
        public IdoPurchaseOrderLinesBuilder DerStatFormatted { get { AddProperty(IdoPurchaseOrderLines.DerStatFormatted); return this; } }
        public IdoPurchaseOrderLinesBuilder DerTotalRcvdCost { get { AddProperty(IdoPurchaseOrderLines.DerTotalRcvdCost); return this; } }
        public IdoPurchaseOrderLinesBuilder DerTotQtyOrderedConv { get { AddProperty(IdoPurchaseOrderLines.DerTotQtyOrderedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder DerUMDescription { get { AddProperty(IdoPurchaseOrderLines.DerUMDescription); return this; } }
        public IdoPurchaseOrderLinesBuilder Description { get { AddProperty(IdoPurchaseOrderLines.Description); return this; } }
        public IdoPurchaseOrderLinesBuilder DrawingNbr { get { AddProperty(IdoPurchaseOrderLines.DrawingNbr); return this; } }
        public IdoPurchaseOrderLinesBuilder DropSeq { get { AddProperty(IdoPurchaseOrderLines.DropSeq); return this; } }
        public IdoPurchaseOrderLinesBuilder DropShipNo { get { AddProperty(IdoPurchaseOrderLines.DropShipNo); return this; } }
        public IdoPurchaseOrderLinesBuilder DueDate { get { AddProperty(IdoPurchaseOrderLines.DueDate); return this; } }
        public IdoPurchaseOrderLinesBuilder EcCode { get { AddProperty(IdoPurchaseOrderLines.EcCode); return this; } }
        public IdoPurchaseOrderLinesBuilder Expedited { get { AddProperty(IdoPurchaseOrderLines.Expedited); return this; } }
        public IdoPurchaseOrderLinesBuilder ExportValue { get { AddProperty(IdoPurchaseOrderLines.ExportValue); return this; } }
        public IdoPurchaseOrderLinesBuilder InWorkflow { get { AddProperty(IdoPurchaseOrderLines.InWorkflow); return this; } }
        public IdoPurchaseOrderLinesBuilder Item { get { AddProperty(IdoPurchaseOrderLines.Item); return this; } }
        public IdoPurchaseOrderLinesBuilder ItemCost { get { AddProperty(IdoPurchaseOrderLines.ItemCost); return this; } }
        public IdoPurchaseOrderLinesBuilder ItemCostConv { get { AddProperty(IdoPurchaseOrderLines.ItemCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder ItemPOToleranceOver { get { AddProperty(IdoPurchaseOrderLines.ItemPOToleranceOver); return this; } }
        public IdoPurchaseOrderLinesBuilder ItemPOToleranceUnder { get { AddProperty(IdoPurchaseOrderLines.ItemPOToleranceUnder); return this; } }
        public IdoPurchaseOrderLinesBuilder ItemType { get { AddProperty(IdoPurchaseOrderLines.ItemType); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmDescription { get { AddProperty(IdoPurchaseOrderLines.ItmDescription); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmLotPrefix { get { AddProperty(IdoPurchaseOrderLines.ItmLotPrefix); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmLotTracked { get { AddProperty(IdoPurchaseOrderLines.ItmLotTracked); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmSerialPrefix { get { AddProperty(IdoPurchaseOrderLines.ItmSerialPrefix); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmSerialTracked { get { AddProperty(IdoPurchaseOrderLines.ItmSerialTracked); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmTaxFreeMatl { get { AddProperty(IdoPurchaseOrderLines.ItmTaxFreeMatl); return this; } }
        public IdoPurchaseOrderLinesBuilder ItmUnitBrokerageCost { get { AddProperty(IdoPurchaseOrderLines.ItmUnitBrokerageCost); return this; } }
        public IdoPurchaseOrderLinesBuilder LcOverride { get { AddProperty(IdoPurchaseOrderLines.LcOverride); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAccessUnit1 { get { AddProperty(IdoPurchaseOrderLines.NonInvAccessUnit1); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAccessUnit2 { get { AddProperty(IdoPurchaseOrderLines.NonInvAccessUnit2); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAccessUnit3 { get { AddProperty(IdoPurchaseOrderLines.NonInvAccessUnit3); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAccessUnit4 { get { AddProperty(IdoPurchaseOrderLines.NonInvAccessUnit4); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcct { get { AddProperty(IdoPurchaseOrderLines.NonInvAcct); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcctDesc { get { AddProperty(IdoPurchaseOrderLines.NonInvAcctDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcctUnit1 { get { AddProperty(IdoPurchaseOrderLines.NonInvAcctUnit1); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcctUnit2 { get { AddProperty(IdoPurchaseOrderLines.NonInvAcctUnit2); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcctUnit3 { get { AddProperty(IdoPurchaseOrderLines.NonInvAcctUnit3); return this; } }
        public IdoPurchaseOrderLinesBuilder NonInvAcctUnit4 { get { AddProperty(IdoPurchaseOrderLines.NonInvAcctUnit4); return this; } }
        public IdoPurchaseOrderLinesBuilder NoteExistsFlag { get { AddProperty(IdoPurchaseOrderLines.NoteExistsFlag); return this; } }
        public IdoPurchaseOrderLinesBuilder Origin { get { AddProperty(IdoPurchaseOrderLines.Origin); return this; } }
        public IdoPurchaseOrderLinesBuilder PlanCost { get { AddProperty(IdoPurchaseOrderLines.PlanCost); return this; } }
        public IdoPurchaseOrderLinesBuilder PlanCostConv { get { AddProperty(IdoPurchaseOrderLines.PlanCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnBlanketQtyConv { get { AddProperty(IdoPurchaseOrderLines.PoBlnBlanketQtyConv); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnDescription { get { AddProperty(IdoPurchaseOrderLines.PoBlnDescription); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnDrawingNbr { get { AddProperty(IdoPurchaseOrderLines.PoBlnDrawingNbr); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnEffDate { get { AddProperty(IdoPurchaseOrderLines.PoBlnEffDate); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnExpDate { get { AddProperty(IdoPurchaseOrderLines.PoBlnExpDate); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnItem { get { AddProperty(IdoPurchaseOrderLines.PoBlnItem); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnItemCostConv { get { AddProperty(IdoPurchaseOrderLines.PoBlnItemCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnPlanCostConv { get { AddProperty(IdoPurchaseOrderLines.PoBlnPlanCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnPoLine { get { AddProperty(IdoPurchaseOrderLines.PoBlnPoLine); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnRevision { get { AddProperty(IdoPurchaseOrderLines.PoBlnRevision); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnStat { get { AddProperty(IdoPurchaseOrderLines.PoBlnStat); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnUM { get { AddProperty(IdoPurchaseOrderLines.PoBlnUM); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBlnVendItem { get { AddProperty(IdoPurchaseOrderLines.PoBlnVendItem); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBuilderPoNum { get { AddProperty(IdoPurchaseOrderLines.PoBuilderPoNum); return this; } }
        public IdoPurchaseOrderLinesBuilder PoBuilderPoOrigSite { get { AddProperty(IdoPurchaseOrderLines.PoBuilderPoOrigSite); return this; } }
        public IdoPurchaseOrderLinesBuilder PoContainsOnlyTaxFreeMatls { get { AddProperty(IdoPurchaseOrderLines.PoContainsOnlyTaxFreeMatls); return this; } }
        public IdoPurchaseOrderLinesBuilder PoExchRate { get { AddProperty(IdoPurchaseOrderLines.PoExchRate); return this; } }
        public IdoPurchaseOrderLinesBuilder POIncludeTaxInCost { get { AddProperty(IdoPurchaseOrderLines.POIncludeTaxInCost); return this; } }
        public IdoPurchaseOrderLinesBuilder PoLine { get { AddProperty(IdoPurchaseOrderLines.PoLine); return this; } }
        public IdoPurchaseOrderLinesBuilder PoNum { get { AddProperty(IdoPurchaseOrderLines.PoNum); return this; } }
        public IdoPurchaseOrderLinesBuilder PoOrderDate { get { AddProperty(IdoPurchaseOrderLines.PoOrderDate); return this; } }
        public IdoPurchaseOrderLinesBuilder PoRelease { get { AddProperty(IdoPurchaseOrderLines.PoRelease); return this; } }
        public IdoPurchaseOrderLinesBuilder PoStat { get { AddProperty(IdoPurchaseOrderLines.PoStat); return this; } }
        public IdoPurchaseOrderLinesBuilder PoTaxCode1 { get { AddProperty(IdoPurchaseOrderLines.PoTaxCode1); return this; } }
        public IdoPurchaseOrderLinesBuilder PoTaxCode2 { get { AddProperty(IdoPurchaseOrderLines.PoTaxCode2); return this; } }
        public IdoPurchaseOrderLinesBuilder PoType { get { AddProperty(IdoPurchaseOrderLines.PoType); return this; } }
        public IdoPurchaseOrderLinesBuilder PoVendNum { get { AddProperty(IdoPurchaseOrderLines.PoVendNum); return this; } }
        public IdoPurchaseOrderLinesBuilder PoVendorPo { get { AddProperty(IdoPurchaseOrderLines.PoVendorPo); return this; } }
        public IdoPurchaseOrderLinesBuilder ProcessInd { get { AddProperty(IdoPurchaseOrderLines.ProcessInd); return this; } }
        public IdoPurchaseOrderLinesBuilder PromiseDate { get { AddProperty(IdoPurchaseOrderLines.PromiseDate); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyOrdered { get { AddProperty(IdoPurchaseOrderLines.QtyOrdered); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyOrderedConv { get { AddProperty(IdoPurchaseOrderLines.QtyOrderedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyReceived { get { AddProperty(IdoPurchaseOrderLines.QtyReceived); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyRejected { get { AddProperty(IdoPurchaseOrderLines.QtyRejected); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyReturned { get { AddProperty(IdoPurchaseOrderLines.QtyReturned); return this; } }
        public IdoPurchaseOrderLinesBuilder QtyVoucher { get { AddProperty(IdoPurchaseOrderLines.QtyVoucher); return this; } }
        public IdoPurchaseOrderLinesBuilder RcvdDate { get { AddProperty(IdoPurchaseOrderLines.RcvdDate); return this; } }
        public IdoPurchaseOrderLinesBuilder RecordDate { get { AddProperty(IdoPurchaseOrderLines.RecordDate); return this; } }
        public IdoPurchaseOrderLinesBuilder RefLineSuf { get { AddProperty(IdoPurchaseOrderLines.RefLineSuf); return this; } }
        public IdoPurchaseOrderLinesBuilder RefNum { get { AddProperty(IdoPurchaseOrderLines.RefNum); return this; } }
        public IdoPurchaseOrderLinesBuilder RefRelease { get { AddProperty(IdoPurchaseOrderLines.RefRelease); return this; } }
        public IdoPurchaseOrderLinesBuilder RefType { get { AddProperty(IdoPurchaseOrderLines.RefType); return this; } }
        public IdoPurchaseOrderLinesBuilder ReleaseDate { get { AddProperty(IdoPurchaseOrderLines.ReleaseDate); return this; } }
        public IdoPurchaseOrderLinesBuilder ReqLine { get { AddProperty(IdoPurchaseOrderLines.ReqLine); return this; } }
        public IdoPurchaseOrderLinesBuilder ReqNum { get { AddProperty(IdoPurchaseOrderLines.ReqNum); return this; } }
        public IdoPurchaseOrderLinesBuilder Revision { get { AddProperty(IdoPurchaseOrderLines.Revision); return this; } }
        public IdoPurchaseOrderLinesBuilder RootJob { get { AddProperty(IdoPurchaseOrderLines.RootJob); return this; } }
        public IdoPurchaseOrderLinesBuilder RootSuf { get { AddProperty(IdoPurchaseOrderLines.RootSuf); return this; } }
        public IdoPurchaseOrderLinesBuilder RowPointer { get { AddProperty(IdoPurchaseOrderLines.RowPointer); return this; } }
        public IdoPurchaseOrderLinesBuilder ShipAddr { get { AddProperty(IdoPurchaseOrderLines.ShipAddr); return this; } }
        public IdoPurchaseOrderLinesBuilder ShowInDropDownList { get { AddProperty(IdoPurchaseOrderLines.ShowInDropDownList); return this; } }
        public IdoPurchaseOrderLinesBuilder SLPochanges { get { AddProperty(IdoPurchaseOrderLines.SLPochanges); return this; } }
        public IdoPurchaseOrderLinesBuilder SLSerials { get { AddProperty(IdoPurchaseOrderLines.SLSerials); return this; } }
        public IdoPurchaseOrderLinesBuilder Stat { get { AddProperty(IdoPurchaseOrderLines.Stat); return this; } }
        public IdoPurchaseOrderLinesBuilder SupplQtyConvFactor { get { AddProperty(IdoPurchaseOrderLines.SupplQtyConvFactor); return this; } }
        public IdoPurchaseOrderLinesBuilder TaxCode1 { get { AddProperty(IdoPurchaseOrderLines.TaxCode1); return this; } }
        public IdoPurchaseOrderLinesBuilder TaxCode1Desc { get { AddProperty(IdoPurchaseOrderLines.TaxCode1Desc); return this; } }
        public IdoPurchaseOrderLinesBuilder TaxCode2 { get { AddProperty(IdoPurchaseOrderLines.TaxCode2); return this; } }
        public IdoPurchaseOrderLinesBuilder TaxCode2Desc { get { AddProperty(IdoPurchaseOrderLines.TaxCode2Desc); return this; } }
        public IdoPurchaseOrderLinesBuilder TransNat { get { AddProperty(IdoPurchaseOrderLines.TransNat); return this; } }
        public IdoPurchaseOrderLinesBuilder TransNat2 { get { AddProperty(IdoPurchaseOrderLines.TransNat2); return this; } }
        public IdoPurchaseOrderLinesBuilder TransNat2Desc { get { AddProperty(IdoPurchaseOrderLines.TransNat2Desc); return this; } }
        public IdoPurchaseOrderLinesBuilder TransNatDesc { get { AddProperty(IdoPurchaseOrderLines.TransNatDesc); return this; } }
        public IdoPurchaseOrderLinesBuilder Transport { get { AddProperty(IdoPurchaseOrderLines.Transport); return this; } }
        public IdoPurchaseOrderLinesBuilder UbAddProjMatl { get { AddProperty(IdoPurchaseOrderLines.UbAddProjMatl); return this; } }
        public IdoPurchaseOrderLinesBuilder UbByCons { get { AddProperty(IdoPurchaseOrderLines.UbByCons); return this; } }
        public IdoPurchaseOrderLinesBuilder UbCostCode { get { AddProperty(IdoPurchaseOrderLines.UbCostCode); return this; } }
        public IdoPurchaseOrderLinesBuilder UbCostsChanged { get { AddProperty(IdoPurchaseOrderLines.UbCostsChanged); return this; } }
        public IdoPurchaseOrderLinesBuilder UbDispMsg { get { AddProperty(IdoPurchaseOrderLines.UbDispMsg); return this; } }
        public IdoPurchaseOrderLinesBuilder UbDispXRefMsg { get { AddProperty(IdoPurchaseOrderLines.UbDispXRefMsg); return this; } }
        public IdoPurchaseOrderLinesBuilder UbDRRt { get { AddProperty(IdoPurchaseOrderLines.UbDRRt); return this; } }
        public IdoPurchaseOrderLinesBuilder UbErrorStatus { get { AddProperty(IdoPurchaseOrderLines.UbErrorStatus); return this; } }
        public IdoPurchaseOrderLinesBuilder UbGrnExists { get { AddProperty(IdoPurchaseOrderLines.UbGrnExists); return this; } }
        public IdoPurchaseOrderLinesBuilder UbImportDocId { get { AddProperty(IdoPurchaseOrderLines.UbImportDocId); return this; } }
        public IdoPurchaseOrderLinesBuilder UbItemVendAdd { get { AddProperty(IdoPurchaseOrderLines.UbItemVendAdd); return this; } }
        public IdoPurchaseOrderLinesBuilder UbItemVendUpdate { get { AddProperty(IdoPurchaseOrderLines.UbItemVendUpdate); return this; } }
        public IdoPurchaseOrderLinesBuilder UbLocation { get { AddProperty(IdoPurchaseOrderLines.UbLocation); return this; } }
        public IdoPurchaseOrderLinesBuilder UbLot { get { AddProperty(IdoPurchaseOrderLines.UbLot); return this; } }
        public IdoPurchaseOrderLinesBuilder UbPackNum { get { AddProperty(IdoPurchaseOrderLines.UbPackNum); return this; } }
        public IdoPurchaseOrderLinesBuilder UbPoChangeIup { get { AddProperty(IdoPurchaseOrderLines.UbPoChangeIup); return this; } }
        public IdoPurchaseOrderLinesBuilder UbQtyReceived { get { AddProperty(IdoPurchaseOrderLines.UbQtyReceived); return this; } }
        public IdoPurchaseOrderLinesBuilder UbQtyReceivedConv { get { AddProperty(IdoPurchaseOrderLines.UbQtyReceivedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UbQtyReturned { get { AddProperty(IdoPurchaseOrderLines.UbQtyReturned); return this; } }
        public IdoPurchaseOrderLinesBuilder UbQtyReturnedConv { get { AddProperty(IdoPurchaseOrderLines.UbQtyReturnedConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UbReasonCode { get { AddProperty(IdoPurchaseOrderLines.UbReasonCode); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSelectedReceiving { get { AddProperty(IdoPurchaseOrderLines.UbSelectedReceiving); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSequence { get { AddProperty(IdoPurchaseOrderLines.UbSequence); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSerNumGenerateQty { get { AddProperty(IdoPurchaseOrderLines.UbSerNumGenerateQty); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSerNumRangeQty { get { AddProperty(IdoPurchaseOrderLines.UbSerNumRangeQty); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSerNumSelected { get { AddProperty(IdoPurchaseOrderLines.UbSerNumSelected); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSerNumStatLinkBy { get { AddProperty(IdoPurchaseOrderLines.UbSerNumStatLinkBy); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSImportDocId { get { AddProperty(IdoPurchaseOrderLines.UbSImportDocId); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSLocation { get { AddProperty(IdoPurchaseOrderLines.UbSLocation); return this; } }
        public IdoPurchaseOrderLinesBuilder UbSLot { get { AddProperty(IdoPurchaseOrderLines.UbSLot); return this; } }
        public IdoPurchaseOrderLinesBuilder UbTotQtyReceived { get { AddProperty(IdoPurchaseOrderLines.UbTotQtyReceived); return this; } }
        public IdoPurchaseOrderLinesBuilder UbTotQtyReturned { get { AddProperty(IdoPurchaseOrderLines.UbTotQtyReturned); return this; } }
        public IdoPurchaseOrderLinesBuilder UbTransDate { get { AddProperty(IdoPurchaseOrderLines.UbTransDate); return this; } }
        public IdoPurchaseOrderLinesBuilder UbUnReceiveFlag { get { AddProperty(IdoPurchaseOrderLines.UbUnReceiveFlag); return this; } }
        public IdoPurchaseOrderLinesBuilder UbUpdateJobMatlUnitCost { get { AddProperty(IdoPurchaseOrderLines.UbUpdateJobMatlUnitCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UbWorkKey { get { AddProperty(IdoPurchaseOrderLines.UbWorkKey); return this; } }
        public IdoPurchaseOrderLinesBuilder UM { get { AddProperty(IdoPurchaseOrderLines.UM); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitBrokerageCost { get { AddProperty(IdoPurchaseOrderLines.UnitBrokerageCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitBrokerageCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitBrokerageCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitDutyCost { get { AddProperty(IdoPurchaseOrderLines.UnitDutyCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitDutyCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitDutyCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitFreightCost { get { AddProperty(IdoPurchaseOrderLines.UnitFreightCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitFreightCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitFreightCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitInsuranceCost { get { AddProperty(IdoPurchaseOrderLines.UnitInsuranceCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitInsuranceCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitInsuranceCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitLocFrtCost { get { AddProperty(IdoPurchaseOrderLines.UnitLocFrtCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitLocFrtCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitLocFrtCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitMatCost { get { AddProperty(IdoPurchaseOrderLines.UnitMatCost); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitMatCostConv { get { AddProperty(IdoPurchaseOrderLines.UnitMatCostConv); return this; } }
        public IdoPurchaseOrderLinesBuilder UnitWeight { get { AddProperty(IdoPurchaseOrderLines.UnitWeight); return this; } }
        public IdoPurchaseOrderLinesBuilder UnlinkedXref { get { AddProperty(IdoPurchaseOrderLines.UnlinkedXref); return this; } }
        public IdoPurchaseOrderLinesBuilder VenadrName { get { AddProperty(IdoPurchaseOrderLines.VenadrName); return this; } }
        public IdoPurchaseOrderLinesBuilder VendItem { get { AddProperty(IdoPurchaseOrderLines.VendItem); return this; } }
        public IdoPurchaseOrderLinesBuilder VendorCountry { get { AddProperty(IdoPurchaseOrderLines.VendorCountry); return this; } }
        public IdoPurchaseOrderLinesBuilder VendPriceBy { get { AddProperty(IdoPurchaseOrderLines.VendPriceBy); return this; } }
        public IdoPurchaseOrderLinesBuilder VoucherCost { get { AddProperty(IdoPurchaseOrderLines.VoucherCost); return this; } }
        public IdoPurchaseOrderLinesBuilder Whse { get { AddProperty(IdoPurchaseOrderLines.Whse); return this; } }


    }

    public class SLPoItemsFilterExpressionBuilder
        : FilterExpressionBuilder<IdoPurchaseOrderLinesBuilder>
    {
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CommCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CommCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ComSupplQtyReq
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ComSupplQtyReq); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ConsNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ConsNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CostType
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CostType); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CurrAmtTotFormat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> CurrCstPrcFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.CurrCstPrcFormat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Delterm
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Delterm); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DeltermDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DeltermDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerASPSearch
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerASPSearch); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerBrokerageCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerBrokerageCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerBrokerageCurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerBrokerageCurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerBrokerageRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerBrokerageRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerDefaultLoc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerDefaultLoc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerDutyCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerDutyCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerDutyCurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerDutyCurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerDutyRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerDutyRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerExtItemCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerExtItemCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerExtPlanCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerExtPlanCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerFreightCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerFreightCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerFreightCurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerFreightCurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerFreightRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerFreightRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerGrnLine
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerGrnLine); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerGrnLineExists
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerGrnLineExists); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerGrnNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerGrnNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerInsuranceCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerInsuranceCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerInsuranceCurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerInsuranceCurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerInsuranceRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerInsuranceRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerItemExists
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerItemExists); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLoc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLoc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLocFrtCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLocFrtCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLocFrtCurrCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLocFrtCurrCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLocFrtRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLocFrtRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLUnitBrokerageCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLUnitBrokerageCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLUnitDutyCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLUnitDutyCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLUnitFreightCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLUnitFreightCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLUnitInsuranceCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLUnitInsuranceCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerLUnitLocFrtCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerLUnitLocFrtCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerMessage
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerMessage); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerNeedsPostReceiveWIP
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerNeedsPostReceiveWIP); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerNewStat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerNewStat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerPoChangeNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerPoChangeNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerPOChangeRowPointer
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerPOChangeRowPointer); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerPoChangeStat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerPoChangeStat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerQtyReceivedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerQtyReceivedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerQtyRejectedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerQtyRejectedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerQtyVoucherConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerQtyVoucherConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerReadOnlyRecordFlag
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerReadOnlyRecordFlag); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerRefDescription
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerRefDescription); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerShipToAddr
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerShipToAddr); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerStatFormatted
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerStatFormatted); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerTotalRcvdCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerTotalRcvdCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerTotQtyOrderedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerTotQtyOrderedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DerUMDescription
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DerUMDescription); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Description
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Description); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DrawingNbr
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DrawingNbr); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DropSeq
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DropSeq); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DropShipNo
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DropShipNo); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> DueDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.DueDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> EcCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.EcCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Expedited
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Expedited); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ExportValue
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ExportValue); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.InWorkflow); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Item); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItemCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItemCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItemCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItemCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItemPOToleranceOver
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItemPOToleranceOver); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItemPOToleranceUnder
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItemPOToleranceUnder); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItemType
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItemType); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmDescription
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmDescription); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmLotPrefix
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmLotPrefix); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmLotTracked
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmLotTracked); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmSerialPrefix
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmSerialPrefix); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmSerialTracked
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmSerialTracked); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmTaxFreeMatl
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmTaxFreeMatl); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ItmUnitBrokerageCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ItmUnitBrokerageCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> LcOverride
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.LcOverride); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAccessUnit1
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAccessUnit1); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAccessUnit2
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAccessUnit2); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAccessUnit3
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAccessUnit3); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAccessUnit4
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAccessUnit4); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcct
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcct); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcctDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcctDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcctUnit1
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcctUnit1); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcctUnit2
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcctUnit2); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcctUnit3
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcctUnit3); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NonInvAcctUnit4
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NonInvAcctUnit4); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.NoteExistsFlag); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Origin
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Origin); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PlanCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PlanCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PlanCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PlanCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnBlanketQtyConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnBlanketQtyConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnDescription
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnDescription); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnDrawingNbr
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnDrawingNbr); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnEffDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnEffDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnExpDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnExpDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnItem
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnItem); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnItemCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnItemCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnPlanCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnPlanCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnPoLine
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnPoLine); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnRevision
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnRevision); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnStat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnStat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnUM
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnUM); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBlnVendItem
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBlnVendItem); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBuilderPoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBuilderPoNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoBuilderPoOrigSite
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoBuilderPoOrigSite); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoContainsOnlyTaxFreeMatls
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoContainsOnlyTaxFreeMatls); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoExchRate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoExchRate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> POIncludeTaxInCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.POIncludeTaxInCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoLine
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoLine); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoOrderDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoOrderDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoRelease
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoRelease); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoStat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoStat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoTaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoTaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoTaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoTaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoType
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoType); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PoVendorPo
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PoVendorPo); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ProcessInd
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ProcessInd); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> PromiseDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.PromiseDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyOrdered
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyOrdered); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyOrderedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyOrderedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyReceived
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyReceived); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyRejected
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyRejected); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyReturned
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyReturned); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> QtyVoucher
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.QtyVoucher); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RcvdDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RcvdDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RecordDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RefLineSuf
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RefLineSuf); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RefNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RefNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RefRelease
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RefRelease); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RefType
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RefType); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ReleaseDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ReleaseDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ReqLine
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ReqLine); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ReqNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ReqNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Revision
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Revision); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RootJob
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RootJob); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RootSuf
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RootSuf); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.RowPointer); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ShipAddr
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ShipAddr); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> ShowInDropDownList
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.ShowInDropDownList); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> SLPochanges
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.SLPochanges); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> SLSerials
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.SLSerials); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Stat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Stat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> SupplQtyConvFactor
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.SupplQtyConvFactor); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TaxCode1Desc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TaxCode1Desc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TaxCode2Desc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TaxCode2Desc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TransNat
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TransNat); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TransNat2
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TransNat2); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TransNat2Desc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TransNat2Desc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> TransNatDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.TransNatDesc); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Transport
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Transport); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbAddProjMatl
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbAddProjMatl); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbByCons
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbByCons); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbCostCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbCostCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbCostsChanged
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbCostsChanged); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbDispMsg
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbDispMsg); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbDispXRefMsg
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbDispXRefMsg); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbDRRt
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbDRRt); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbErrorStatus
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbErrorStatus); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbGrnExists
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbGrnExists); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbImportDocId
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbImportDocId); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbItemVendAdd
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbItemVendAdd); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbItemVendUpdate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbItemVendUpdate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbLocation
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbLocation); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbLot
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbLot); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbPackNum
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbPackNum); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbPoChangeIup
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbPoChangeIup); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbQtyReceived
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbQtyReceived); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbQtyReceivedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbQtyReceivedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbQtyReturned
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbQtyReturned); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbQtyReturnedConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbQtyReturnedConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbReasonCode
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbReasonCode); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSelectedReceiving
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSelectedReceiving); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSequence
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSequence); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSerNumGenerateQty
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSerNumGenerateQty); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSerNumRangeQty
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSerNumRangeQty); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSerNumSelected
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSerNumSelected); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSerNumStatLinkBy
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSerNumStatLinkBy); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSImportDocId
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSImportDocId); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSLocation
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSLocation); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbSLot
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbSLot); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbTotQtyReceived
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbTotQtyReceived); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbTotQtyReturned
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbTotQtyReturned); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbTransDate
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbTransDate); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbUnReceiveFlag
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbUnReceiveFlag); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbUpdateJobMatlUnitCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbUpdateJobMatlUnitCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UbWorkKey
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UbWorkKey); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UM
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UM); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitBrokerageCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitBrokerageCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitBrokerageCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitBrokerageCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitDutyCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitDutyCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitDutyCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitDutyCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitFreightCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitFreightCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitFreightCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitFreightCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitInsuranceCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitInsuranceCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitInsuranceCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitInsuranceCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitLocFrtCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitLocFrtCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitLocFrtCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitLocFrtCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitMatCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitMatCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitMatCostConv
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitMatCostConv); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnitWeight
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnitWeight); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> UnlinkedXref
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.UnlinkedXref); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> VenadrName
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.VenadrName); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> VendItem
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.VendItem); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> VendorCountry
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.VendorCountry); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> VendPriceBy
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.VendPriceBy); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> VoucherCost
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.VoucherCost); }
        }
        public FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<IdoPurchaseOrderLinesBuilder, SLPoItemsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLines.Whse); }
        }


    }
}
