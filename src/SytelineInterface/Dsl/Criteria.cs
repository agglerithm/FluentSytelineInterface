using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl
{

    public class FieldName : Attribute
    {
        private readonly string _name;

        public FieldName(string name)
        {
            _name = name;
        }

        public override string  ToString()
        {
                    return _name;
        }
    }


    public class PullItemCriteria : IdoCriteria
    {
        public PullItemCriteria()
            : base(PullItem.IDO_NAME)
        {
        }
        [FieldName(PullItem.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(PullItem.Item)]
        public string Item { get; set; }
        [FieldName(PullItem.TriggerPoint)]
        public string TriggerPoint { get; set; }
        [FieldName(PullItem.Warehouse)]
        public string Warehouse { get; set; }
    }
    public class IdoArTransactionCriteria : IdoCriteria
    {
        public IdoArTransactionCriteria()
            : base(IdoArTransaction.IDO_NAME)
        {
        }
        [FieldName(IdoArTransaction.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoArTransaction.Acct)]
        public string Acct { get; set; }
        [FieldName(IdoArTransaction.AcctUnit1)]
        public string AcctUnit1 { get; set; }
        [FieldName(IdoArTransaction.AcctUnit2)]
        public string AcctUnit2 { get; set; }
        [FieldName(IdoArTransaction.AcctUnit3)]
        public string AcctUnit3 { get; set; }
        [FieldName(IdoArTransaction.AcctUnit4)]
        public string AcctUnit4 { get; set; }
        [FieldName(IdoArTransaction.Active)]
        public string Active { get; set; }
        [FieldName(IdoArTransaction.Amount)]
        public string Amount { get; set; }
        [FieldName(IdoArTransaction.ApplyToInvNum)]
        public string ApplyToInvNum { get; set; }
        [FieldName(IdoArTransaction.BankCode)]
        public string BankCode { get; set; }
        [FieldName(IdoArTransaction.CadCurrCode)]
        public string CadCurrCode { get; set; }
        [FieldName(IdoArTransaction.CadName)]
        public string CadName { get; set; }
        [FieldName(IdoArTransaction.CheckSeq)]
        public string CheckSeq { get; set; }
        [FieldName(IdoArTransaction.CoNum)]
        public string CoNum { get; set; }
        [FieldName(IdoArTransaction.CorpCust)]
        public string CorpCust { get; set; }
        [FieldName(IdoArTransaction.CustNum)]
        public string CustNum { get; set; }
        [FieldName(IdoArTransaction.DerCustName)]
        public string DerCustName { get; set; }
        [FieldName(IdoArTransaction.DerInvNum)]
        public string DerInvNum { get; set; }
        [FieldName(IdoArTransaction.DerLangCode)]
        public string DerLangCode { get; set; }
        [FieldName(IdoArTransaction.DerNdAmount)]
        public string DerNdAmount { get; set; }
        [FieldName(IdoArTransaction.DerNewAmount)]
        public string DerNewAmount { get; set; }
        [FieldName(IdoArTransaction.DerOdAmount)]
        public string DerOdAmount { get; set; }
        [FieldName(IdoArTransaction.DerOldAmount)]
        public string DerOldAmount { get; set; }
        [FieldName(IdoArTransaction.DerTotalDifference)]
        public string DerTotalDifference { get; set; }
        [FieldName(IdoArTransaction.DerTypeDescription)]
        public string DerTypeDescription { get; set; }
        [FieldName(IdoArTransaction.Description)]
        public string Description { get; set; }
        [FieldName(IdoArTransaction.DiscAmt)]
        public string DiscAmt { get; set; }
        [FieldName(IdoArTransaction.DiscDate)]
        public DateTime DiscDate { get; set; }
        [FieldName(IdoArTransaction.DoNum)]
        public string DoNum { get; set; }
        [FieldName(IdoArTransaction.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoArTransaction.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoArTransaction.FixedRate)]
        public string FixedRate { get; set; }
        [FieldName(IdoArTransaction.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoArTransaction.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(IdoArTransaction.InvNum)]
        public string InvNum { get; set; }
        [FieldName(IdoArTransaction.InvSeq)]
        public string InvSeq { get; set; }
        [FieldName(IdoArTransaction.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoArTransaction.IssueDate)]
        public DateTime IssueDate { get; set; }
        [FieldName(IdoArTransaction.MiscCharges)]
        public string MiscCharges { get; set; }
        [FieldName(IdoArTransaction.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoArTransaction.PayType)]
        public string PayType { get; set; }
        [FieldName(IdoArTransaction.PostFromCo)]
        public string PostFromCo { get; set; }
        [FieldName(IdoArTransaction.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoArTransaction.Ref)]
        public string Ref { get; set; }
        [FieldName(IdoArTransaction.Rma)]
        public string Rma { get; set; }
        [FieldName(IdoArTransaction.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoArTransaction.SalesTax)]
        public string SalesTax { get; set; }
        [FieldName(IdoArTransaction.SalesTax2)]
        public string SalesTax2 { get; set; }
        [FieldName(IdoArTransaction.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoArTransaction.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoArTransaction.Type)]
        public string Type { get; set; }
    }
    public class WarehousesCriteria : IdoCriteria
    {
        public WarehousesCriteria()
            : base(Warehouses.IDO_NAME)
        {
        }
        [FieldName(Warehouses.Site)]
        public string Site { get; set; }
        [FieldName(Warehouses.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Warehouses.Warehouse)]
        public string Warehouse { get; set; }
        [FieldName(Warehouses.Name)]
        public string Name { get; set; }
        [FieldName(Warehouses.City)]
        public string City { get; set; }
        [FieldName(Warehouses.State)]
        public string State { get; set; }
        [FieldName(Warehouses.Addr1)]
        public string Addr1 { get; set; }
        [FieldName(Warehouses.Addr2)]
        public string Addr2 { get; set; }
        [FieldName(Warehouses.Addr3)]
        public string Addr3 { get; set; }
        [FieldName(Warehouses.Zip)]
        public string Zip { get; set; }
    }
    public class IdoPurchaseOrderLineHistoryCriteria : IdoCriteria
    {
        public IdoPurchaseOrderLineHistoryCriteria()
            : base(IdoPurchaseOrderLineHistory.IDO_NAME)
        {
        }
        [FieldName(IdoPurchaseOrderLineHistory.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CommCode)]
        public string CommCode { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ComSupplQtyReq)]
        public string ComSupplQtyReq { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ConsNum)]
        public string ConsNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CostType)]
        public string CostType { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CurrCodeDesc)]
        public string CurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DeltermDesc)]
        public string DeltermDesc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerExtItemCostConv)]
        public string DerExtItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerExtPlanCostConv)]
        public string DerExtPlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerGrnLineExists)]
        public string DerGrnLineExists { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerHistoryTrue)]
        public string DerHistoryTrue { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerItemExists)]
        public string DerItemExists { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerLoc)]
        public string DerLoc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerNewStat)]
        public string DerNewStat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerPoChangeNum)]
        public string DerPoChangeNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerPoChangeStat)]
        public string DerPoChangeStat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerQtyReceivedConv)]
        public string DerQtyReceivedConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerQtyRejectedConv)]
        public string DerQtyRejectedConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerQtyVoucherConv)]
        public string DerQtyVoucherConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerReadOnlyRecord)]
        public string DerReadOnlyRecord { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerRefDescription)]
        public string DerRefDescription { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerShipToAddr)]
        public string DerShipToAddr { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerTotalRcvdCost)]
        public string DerTotalRcvdCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerTotQtyOrderedConv)]
        public string DerTotQtyOrderedConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DerUMDescription)]
        public string DerUMDescription { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Description)]
        public string Description { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DrawingNbr)]
        public string DrawingNbr { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DropSeq)]
        public string DropSeq { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DropShipNo)]
        public string DropShipNo { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.EcCode)]
        public string EcCode { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Expedited)]
        public string Expedited { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ExportValue)]
        public string ExportValue { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.GrnlnGrnLine)]
        public string GrnlnGrnLine { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.GrnlnGrnNum)]
        public string GrnlnGrnNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Item)]
        public string Item { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItemCost)]
        public string ItemCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItemCostConv)]
        public string ItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItemType)]
        public string ItemType { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmDescription)]
        public string ItmDescription { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmLotPrefix)]
        public string ItmLotPrefix { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmLotTracked)]
        public string ItmLotTracked { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmSerialPrefix)]
        public string ItmSerialPrefix { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmSerialTracked)]
        public string ItmSerialTracked { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ItmUnitBrokerageCost)]
        public string ItmUnitBrokerageCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAccessUnit1)]
        public string NonInvAccessUnit1 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAccessUnit2)]
        public string NonInvAccessUnit2 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAccessUnit3)]
        public string NonInvAccessUnit3 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAccessUnit4)]
        public string NonInvAccessUnit4 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcct)]
        public string NonInvAcct { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcctDesc)]
        public string NonInvAcctDesc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcctUnit1)]
        public string NonInvAcctUnit1 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcctUnit2)]
        public string NonInvAcctUnit2 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcctUnit3)]
        public string NonInvAcctUnit3 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NonInvAcctUnit4)]
        public string NonInvAcctUnit4 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Origin)]
        public string Origin { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PlanCost)]
        public string PlanCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PlanCostConv)]
        public string PlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnBlanketQtyConv)]
        public string PoBlnBlanketQtyConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnDescription)]
        public string PoBlnDescription { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnDrawingNbr)]
        public string PoBlnDrawingNbr { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnEffDate)]
        public DateTime PoBlnEffDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnExpDate)]
        public DateTime PoBlnExpDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnItem)]
        public string PoBlnItem { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnItemCostConv)]
        public string PoBlnItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnPlanCostConv)]
        public string PoBlnPlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnPoLine)]
        public string PoBlnPoLine { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnRevision)]
        public string PoBlnRevision { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnStat)]
        public string PoBlnStat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnUM)]
        public string PoBlnUM { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoBlnVendItem)]
        public string PoBlnVendItem { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoExchRate)]
        public decimal PoExchRate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoLine)]
        public string PoLine { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoOrderDate)]
        public DateTime PoOrderDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoRelease)]
        public string PoRelease { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoStat)]
        public string PoStat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoTaxCode1)]
        public string PoTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoTaxCode2)]
        public string PoTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoType)]
        public string PoType { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoVendNum)]
        public string PoVendNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PoVendorPo)]
        public string PoVendorPo { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.PromiseDate)]
        public DateTime PromiseDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyOrdered)]
        public string QtyOrdered { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyOrderedConv)]
        public string QtyOrderedConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyReceived)]
        public string QtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyRejected)]
        public string QtyRejected { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyReturned)]
        public string QtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.QtyVoucher)]
        public string QtyVoucher { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RcvdDate)]
        public DateTime RcvdDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RefNum)]
        public string RefNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RefType)]
        public string RefType { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ReleaseDate)]
        public DateTime ReleaseDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ReqLine)]
        public string ReqLine { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ReqNum)]
        public string ReqNum { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Revision)]
        public string Revision { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RootJob)]
        public string RootJob { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RootSuf)]
        public string RootSuf { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.ShipAddr)]
        public string ShipAddr { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.SLPochanges)]
        public string SLPochanges { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.SupplQtyConvFactor)]
        public string SupplQtyConvFactor { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TaxCode1Desc)]
        public string TaxCode1Desc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TaxCode2Desc)]
        public string TaxCode2Desc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TransNat2Desc)]
        public string TransNat2Desc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.TransNatDesc)]
        public string TransNatDesc { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Transport)]
        public string Transport { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbAddProjMatl)]
        public string UbAddProjMatl { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbByCons)]
        public string UbByCons { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbCostCode)]
        public string UbCostCode { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbErrorStatus)]
        public string UbErrorStatus { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbGrnExists)]
        public string UbGrnExists { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbItemVendAdd)]
        public string UbItemVendAdd { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbItemVendUpdate)]
        public string UbItemVendUpdate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbLocation)]
        public string UbLocation { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbLot)]
        public string UbLot { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbPoChangeIup)]
        public string UbPoChangeIup { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbQtyReceived)]
        public string UbQtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbQtyReturned)]
        public string UbQtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbReasonCode)]
        public string UbReasonCode { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbSLocation)]
        public string UbSLocation { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbSLot)]
        public string UbSLot { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbTotQtyReceived)]
        public string UbTotQtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbTotQtyReturned)]
        public string UbTotQtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbTransDate)]
        public DateTime UbTransDate { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbUpdateJobMatlUnitCost)]
        public string UbUpdateJobMatlUnitCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UbWorkKey)]
        public string UbWorkKey { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UM)]
        public string UM { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitBrokerageCost)]
        public string UnitBrokerageCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitBrokerageCostConv)]
        public string UnitBrokerageCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitDutyCost)]
        public string UnitDutyCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitDutyCostConv)]
        public string UnitDutyCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitFreightCost)]
        public string UnitFreightCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitFreightCostConv)]
        public string UnitFreightCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitInsuranceCost)]
        public string UnitInsuranceCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitInsuranceCostConv)]
        public string UnitInsuranceCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitLocFrtCost)]
        public string UnitLocFrtCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitLocFrtCostConv)]
        public string UnitLocFrtCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitMatCost)]
        public string UnitMatCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitMatCostConv)]
        public string UnitMatCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.UnitWeight)]
        public string UnitWeight { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.VenadrName)]
        public string VenadrName { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.VenCurrCode)]
        public string VenCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.VendItem)]
        public string VendItem { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.VenPriceBy)]
        public string VenPriceBy { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.VoucherCost)]
        public string VoucherCost { get; set; }
        [FieldName(IdoPurchaseOrderLineHistory.Whse)]
        public string Whse { get; set; }
    }
    public class ShippedCustomerOrderLineItemCriteria : IdoCriteria
    {
        public ShippedCustomerOrderLineItemCriteria()
            : base(ShippedCustomerOrderLineItem.IDO_NAME)
        {
        }
        [FieldName(ShippedCustomerOrderLineItem.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.CustomerID)]
        public string CustomerID { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.CustomerPo)]
        public string CustomerPo { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.CustomerPartNumber)]
        public string CustomerPartNumber { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.Description)]
        public string Description { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.ItemID)]
        public string ItemID { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.LineNumber)]
        public string LineNumber { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.Cost)]
        public decimal Cost { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.CoType)]
        public string CoType { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.DoLine)]
        public string DoLine { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.DoNum)]
        public string DoNum { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.DoSeq)]
        public string DoSeq { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.Price)]
        public decimal Price { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.QtyShipped)]
        public int QtyShipped { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.ShipDate)]
        public DateTime ShipDate { get; set; }
        [FieldName(ShippedCustomerOrderLineItem.ShipperNum)]
        public string ShipperNum { get; set; }
    }
    public class ShippedCustomerOrderCriteria : IdoCriteria
    {
        public ShippedCustomerOrderCriteria()
            : base(ShippedCustomerOrder.IDO_NAME)
        {
        }
        [FieldName(ShippedCustomerOrder.IDO_NAME)]
        public string IDO_NAME { get; set; }
        //[FieldName(ShippedCustomerOrder.Active)]
        //public string Active { get; set; }
        //[FieldName(ShippedCustomerOrder.BOL)]
        //public string BOL { get; set; }
        //[FieldName(ShippedCustomerOrder.ShipCode)]
        //public string ShipCode { get; set; }
        [FieldName(ShippedCustomerOrder.LineNumber)]
        public string Lines { get; set; }
        [FieldName(ShippedCustomerOrder.DeliveryOrderNumber)]
        public string DeliveryOrderNumber { get; set; }
        //[FieldName(ShippedCustomerOrder.ShipCodeDescription)]
        //public string ShipCodeDescription { get; set; }
        [FieldName(ShippedCustomerOrder.CustomerNumber)]
        public string CustomerNumber { get; set; }
        [FieldName(ShippedCustomerOrder.OrderDate)]
        public DateTime OrderDate { get; set; } 
        //[FieldName(ShippedCustomerOrder.ShipToCode)]
        //public string ShipToCode { get; set; }
        //[FieldName(ShippedCustomerOrder.OrderType)]
        //public string OrderType { get; set; }
        [FieldName(ShippedCustomerOrder.Status)]
        public string Status { get; set; }
        //[FieldName(ShippedCustomerOrder.Invoiced)]
        //public string Invoiced { get; set; }
        //[FieldName(ShippedCustomerOrder.Picked)]
        //public string Picked { get; set; }
        //[FieldName(ShippedCustomerOrder.Shipped)]
        //public string Shipped { get; set; }
        //[FieldName(ShippedCustomerOrder.ShipToName)]
        //public string ShipToName { get; set; }
        //[FieldName(ShippedCustomerOrder.BatchId)]
        //public string BatchId { get; set; }
        //[FieldName(ShippedCustomerOrder.BolAcceptDefaults)]
        //public string BolAcceptDefaults { get; set; }
        //[FieldName(ShippedCustomerOrder.Contact)]
        //public string Contact { get; set; }
        //[FieldName(ShippedCustomerOrder.CoLcrNum)]
        //public string CoLcrNum { get; set; }
        //[FieldName(ShippedCustomerOrder.CoPhone)]
        //public string CoPhone { get; set; }
        //[FieldName(ShippedCustomerOrder.CoShipEarly)]
        //public string CoShipEarly { get; set; }
        //[FieldName(ShippedCustomerOrder.CoShipPartial)]
        //public string CoShipPartial { get; set; }
        //[FieldName(ShippedCustomerOrder.CoUseExchRate)]
        //public decimal CoUseExchRate { get; set; }
        [FieldName(ShippedCustomerOrder.CustSeq)]
        public string CustSeq { get; set; }
        //[FieldName(ShippedCustomerOrder.InvoiceAcceptDefaults)]
        //public string InvoiceAcceptDefaults { get; set; }
        //[FieldName(ShippedCustomerOrder.InWorkflow)]
        //public string InWorkflow { get; set; }
        //[FieldName(ShippedCustomerOrder.NoteExistsFlag)]
        //public string NoteExistsFlag { get; set; }
        //[FieldName(ShippedCustomerOrder.PackAcceptDefaults)]
        //public string PackAcceptDefaults { get; set; }
        //[FieldName(ShippedCustomerOrder.PickAcceptDefaults)]
        //public string PickAcceptDefaults { get; set; }
        //[FieldName(ShippedCustomerOrder.ReadyToProcess)]
        //public string ReadyToProcess { get; set; }
        [FieldName(ShippedCustomerOrder.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ShippedCustomerOrder.RowPointer)]
        public string RowPointer { get; set; }
        //[FieldName(ShippedCustomerOrder.ShipAcceptDefaults)]
        //public string ShipAcceptDefaults { get; set; }
        //[FieldName(ShippedCustomerOrder.CreditAmt)]
        //public decimal CreditAmt { get; set; }
        //[FieldName(ShippedCustomerOrder.CreditOk)]
        //public string CreditOk { get; set; }
        [FieldName(ShippedCustomerOrder.CustomerPo)]
        public string CustomerPo { get; set; }
        [FieldName(ShippedCustomerOrder.CustomerPartNumber)]
        public string CustomerPartNumber { get; set; }
        [FieldName(ShippedCustomerOrder.Description)]
        public string Description { get; set; }
        [FieldName(ShippedCustomerOrder.ItemID)]
        public string ItemID { get; set; }
        [FieldName(ShippedCustomerOrder.LineNumber)]
        public string LineNumber { get; set; }
        [FieldName(ShippedCustomerOrder.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(ShippedCustomerOrder.Cost)]
        public decimal Cost { get; set; }
        [FieldName(ShippedCustomerOrder.CoType)]
        public string CoType { get; set; }
        [FieldName(ShippedCustomerOrder.DoLine)]
        public string DoLine { get; set; }
        [FieldName(ShippedCustomerOrder.DoNum)]
        public string DoNum { get; set; }
        [FieldName(ShippedCustomerOrder.DoSeq)]
        public string DoSeq { get; set; }
        [FieldName(ShippedCustomerOrder.Price)]
        public decimal Price { get; set; }
        [FieldName(ShippedCustomerOrder.QtyShipped)]
        public int QtyShipped { get; set; }
        [FieldName(ShippedCustomerOrder.ShipDate)]
        public DateTime ShipDate { get; set; }
        [FieldName(ShippedCustomerOrder.ShipperNum)]
        public string ShipperNum { get; set; }
    }

    public class ARPaymentDetailCriteria : IdoCriteria
    {
        public ARPaymentDetailCriteria()
            : base(ARPaymentDetail.IDO_NAME)
        {
        }
        [FieldName(ARPaymentDetail.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ARPaymentDetail.AlChtAccessUnit1)]
        public string AlChtAccessUnit1 { get; set; }
        [FieldName(ARPaymentDetail.AlChtAccessUnit2)]
        public string AlChtAccessUnit2 { get; set; }
        [FieldName(ARPaymentDetail.AlChtAccessUnit3)]
        public string AlChtAccessUnit3 { get; set; }
        [FieldName(ARPaymentDetail.AlChtAccessUnit4)]
        public string AlChtAccessUnit4 { get; set; }
        [FieldName(ARPaymentDetail.AlChtDescription)]
        public string AlChtDescription { get; set; }
        [FieldName(ARPaymentDetail.AllowAcct)]
        public string AllowAcct { get; set; }
        [FieldName(ARPaymentDetail.AllowAcctUnit1)]
        public string AllowAcctUnit1 { get; set; }
        [FieldName(ARPaymentDetail.AllowAcctUnit2)]
        public string AllowAcctUnit2 { get; set; }
        [FieldName(ARPaymentDetail.AllowAcctUnit3)]
        public string AllowAcctUnit3 { get; set; }
        [FieldName(ARPaymentDetail.AllowAcctUnit4)]
        public string AllowAcctUnit4 { get; set; }
        [FieldName(ARPaymentDetail.CheckAmt)]
        public string CheckAmt { get; set; }
        [FieldName(ARPaymentDetail.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(ARPaymentDetail.RecptDate)]
        public DateTime RecptDate { get; set; }
        [FieldName(ARPaymentDetail.ParentRowPointer)]
        public string ParentRowPointer { get; set; }
        [FieldName(ARPaymentDetail.BankCode)]
        public string BankCode { get; set; }
        [FieldName(ARPaymentDetail.CheckNum)]
        public string CheckNum { get; set; }
        [FieldName(ARPaymentDetail.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(ARPaymentDetail.CreditMemoNum)]
        public string CreditMemoNum { get; set; }
        [FieldName(ARPaymentDetail.DecimalPlaces)]
        public string DecimalPlaces { get; set; }
        [FieldName(ARPaymentDetail.CustomerName)]
        public string CustomerName { get; set; }
        [FieldName(ARPaymentDetail.CustNum)]
        public string CustNum { get; set; }
        [FieldName(ARPaymentDetail.BalMethod)]
        public string BalMethod { get; set; }
        [FieldName(ARPaymentDetail.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(ARPaymentDetail.DeChtAccessUnit1)]
        public string DeChtAccessUnit1 { get; set; }
        [FieldName(ARPaymentDetail.DeChtAccessUnit2)]
        public string DeChtAccessUnit2 { get; set; }
        [FieldName(ARPaymentDetail.DeChtAccessUnit3)]
        public string DeChtAccessUnit3 { get; set; }
        [FieldName(ARPaymentDetail.DeChtAccessUnit4)]
        public string DeChtAccessUnit4 { get; set; }
        [FieldName(ARPaymentDetail.DeChtDescription)]
        public string DeChtDescription { get; set; }
        [FieldName(ARPaymentDetail.DepositAcct)]
        public string DepositAcct { get; set; }
        [FieldName(ARPaymentDetail.DepositAcctUnit1)]
        public string DepositAcctUnit1 { get; set; }
        [FieldName(ARPaymentDetail.DepositAcctUnit2)]
        public string DepositAcctUnit2 { get; set; }
        [FieldName(ARPaymentDetail.DepositAcctUnit3)]
        public string DepositAcctUnit3 { get; set; }
        [FieldName(ARPaymentDetail.DepositAcctUnit4)]
        public string DepositAcctUnit4 { get; set; }
        [FieldName(ARPaymentDetail.PayTypeCode)]
        public string PayTypeCode { get; set; }
        [FieldName(ARPaymentDetail.DerAvailCustDrft)]
        public string DerAvailCustDrft { get; set; }
        [FieldName(ARPaymentDetail.DerCorpCust)]
        public string DerCorpCust { get; set; }
        [FieldName(ARPaymentDetail.DerDefaultType)]
        public string DerDefaultType { get; set; }
        [FieldName(ARPaymentDetail.AmtBalance)]
        public decimal AmtBalance { get; set; }
        [FieldName(ARPaymentDetail.AmtRemaining)]
        public decimal AmtRemaining { get; set; }
        [FieldName(ARPaymentDetail.AllowAmt)]
        public decimal AllowAmt { get; set; }
        [FieldName(ARPaymentDetail.AmtApplied)]
        public decimal AmtApplied { get; set; }
        [FieldName(ARPaymentDetail.DerOrigForAllowAmt)]
        public string DerOrigForAllowAmt { get; set; }
        [FieldName(ARPaymentDetail.DerUpdateRate)]
        public decimal DerUpdateRate { get; set; }
        [FieldName(ARPaymentDetail.DiChtAccessUnit1)]
        public string DiChtAccessUnit1 { get; set; }
        [FieldName(ARPaymentDetail.DiChtAccessUnit2)]
        public string DiChtAccessUnit2 { get; set; }
        [FieldName(ARPaymentDetail.DiChtAccessUnit3)]
        public string DiChtAccessUnit3 { get; set; }
        [FieldName(ARPaymentDetail.DiChtAccessUnit4)]
        public string DiChtAccessUnit4 { get; set; }
        [FieldName(ARPaymentDetail.DiChtDescription)]
        public string DiChtDescription { get; set; }
        [FieldName(ARPaymentDetail.DiscAcct)]
        public string DiscAcct { get; set; }
        [FieldName(ARPaymentDetail.DiscAcctUnit1)]
        public string DiscAcctUnit1 { get; set; }
        [FieldName(ARPaymentDetail.DiscAcctUnit2)]
        public string DiscAcctUnit2 { get; set; }
        [FieldName(ARPaymentDetail.DiscAcctUnit3)]
        public string DiscAcctUnit3 { get; set; }
        [FieldName(ARPaymentDetail.DiscAcctUnit4)]
        public string DiscAcctUnit4 { get; set; }
        [FieldName(ARPaymentDetail.DiscountAmount)]
        public string DiscountAmount { get; set; }
        [FieldName(ARPaymentDetail.Tax1)]
        public string Tax1 { get; set; }
        [FieldName(ARPaymentDetail.Tax2)]
        public string Tax2 { get; set; }
        [FieldName(ARPaymentDetail.DoNum)]
        public string DoNum { get; set; }
        [FieldName(ARPaymentDetail.InvNum)]
        public string InvNum { get; set; }
        [FieldName(ARPaymentDetail.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(ARPaymentDetail.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(ARPaymentDetail.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ARPaymentDetail.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(ARPaymentDetail.Site)]
        public string Site { get; set; }
    }

    public class InvoicedOrdersCriteria : IdoCriteria
    {
        public InvoicedOrdersCriteria()
            : base(InvoicedOrders.IDO_NAME)
        {
        }
        [FieldName(InvoicedOrders.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(InvoicedOrders.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(InvoicedOrders.DeliveryNumber)]
        public string DeliveryNumber { get; set; }
        [FieldName(InvoicedOrders.CustomerPo)]
        public string CustomerPo { get; set; }
        [FieldName(InvoicedOrders.BillType)]
        public string BillType { get; set; }
        [FieldName(InvoicedOrders.CustomerID)]
        public string CustomerID { get; set; }
        [FieldName(InvoicedOrders.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(InvoicedOrders.Slsman)]
        public string Slsman { get; set; }
        [FieldName(InvoicedOrders.InvNum)]
        public string InvNum { get; set; }
        [FieldName(InvoicedOrders.InvSeq)]
        public string InvSeq { get; set; }
        [FieldName(InvoicedOrders.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(InvoicedOrders.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(InvoicedOrders.Freight)]
        public string Freight { get; set; }
        [FieldName(InvoicedOrders.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(InvoicedOrders.Amount)]
        public decimal Amount { get; set; }
    }

    public class JobRoutesCriteria : IdoCriteria
    {
        public JobRoutesCriteria()
            : base(JobRoutes.IDO_NAME)
        {
        }
        [FieldName(JobRoutes.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(JobRoutes.BflushType)]
        public string BflushType { get; set; }
        [FieldName(JobRoutes.CdrCustSeq)]
        public string CdrCustSeq { get; set; }
        [FieldName(JobRoutes.CntrlPoint)]
        public string CntrlPoint { get; set; }
        [FieldName(JobRoutes.Complete)]
        public string Complete { get; set; }
        [FieldName(JobRoutes.DerAnyCanAdd)]
        public string DerAnyCanAdd { get; set; }
        [FieldName(JobRoutes.DerAnyCanDelete)]
        public string DerAnyCanDelete { get; set; }
        [FieldName(JobRoutes.DerAnyCanUpdate)]
        public string DerAnyCanUpdate { get; set; }
        [FieldName(JobRoutes.DerApsRoutedId)]
        public string DerApsRoutedId { get; set; }
        [FieldName(JobRoutes.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(JobRoutes.DerAvailableJrtItem)]
        public string DerAvailableJrtItem { get; set; }
        [FieldName(JobRoutes.DerCompletedUM)]
        public string DerCompletedUM { get; set; }
        [FieldName(JobRoutes.DerHasXRef)]
        public string DerHasXRef { get; set; }
        [FieldName(JobRoutes.DerJob)]
        public string DerJob { get; set; }
        [FieldName(JobRoutes.DerMovedUM)]
        public string DerMovedUM { get; set; }
        [FieldName(JobRoutes.DerOperNum)]
        public string DerOperNum { get; set; }
        [FieldName(JobRoutes.DerPSReleaseLbrPosted)]
        public string DerPSReleaseLbrPosted { get; set; }
        [FieldName(JobRoutes.DerReadOnlyFlagForStdOper)]
        public string DerReadOnlyFlagForStdOper { get; set; }
        [FieldName(JobRoutes.DerReadOnlyForPSOper)]
        public string DerReadOnlyForPSOper { get; set; }
        [FieldName(JobRoutes.DerReadOnlyForTypeJ)]
        public string DerReadOnlyForTypeJ { get; set; }
        [FieldName(JobRoutes.DerReadOnlyRecordFlag)]
        public string DerReadOnlyRecordFlag { get; set; }
        [FieldName(JobRoutes.DerReceivedUM)]
        public string DerReceivedUM { get; set; }
        [FieldName(JobRoutes.DerRunLbrHrs)]
        public string DerRunLbrHrs { get; set; }
        [FieldName(JobRoutes.DerRunMchHrs)]
        public string DerRunMchHrs { get; set; }
        [FieldName(JobRoutes.DerScrappedUM)]
        public string DerScrappedUM { get; set; }
        [FieldName(JobRoutes.DerSuffix)]
        public string DerSuffix { get; set; }
        [FieldName(JobRoutes.DerTotLbrPct)]
        public string DerTotLbrPct { get; set; }
        [FieldName(JobRoutes.DerTotMachPct)]
        public string DerTotMachPct { get; set; }
        [FieldName(JobRoutes.DerTotMatPct)]
        public string DerTotMatPct { get; set; }
        [FieldName(JobRoutes.EffectDate)]
        public DateTime EffectDate { get; set; }
        [FieldName(JobRoutes.Efficiency)]
        public string Efficiency { get; set; }
        [FieldName(JobRoutes.FixovhdRate)]
        public decimal FixovhdRate { get; set; }
        [FieldName(JobRoutes.FixovhdTLbr)]
        public string FixovhdTLbr { get; set; }
        [FieldName(JobRoutes.FixovhdTMch)]
        public string FixovhdTMch { get; set; }
        [FieldName(JobRoutes.FovhdRateMch)]
        public string FovhdRateMch { get; set; }
        [FieldName(JobRoutes.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(JobRoutes.ItmDescription)]
        public string ItmDescription { get; set; }
        [FieldName(JobRoutes.ItmItem)]
        public string ItmItem { get; set; }
        [FieldName(JobRoutes.ItmjrtDescription)]
        public string ItmjrtDescription { get; set; }
        [FieldName(JobRoutes.ItmjrtItem)]
        public string ItmjrtItem { get; set; }
        [FieldName(JobRoutes.ItmjrtTrackEcn)]
        public string ItmjrtTrackEcn { get; set; }
        [FieldName(JobRoutes.ItmpsDescription)]
        public string ItmpsDescription { get; set; }
        [FieldName(JobRoutes.JbhEndDate)]
        public DateTime JbhEndDate { get; set; }
        [FieldName(JobRoutes.Job)]
        public string Job { get; set; }
        [FieldName(JobRoutes.JobCoProductMix)]
        public string JobCoProductMix { get; set; }
        [FieldName(JobRoutes.JobDescription)]
        public string JobDescription { get; set; }
        [FieldName(JobRoutes.JobItem)]
        public string JobItem { get; set; }
        [FieldName(JobRoutes.JobJob)]
        public string JobJob { get; set; }
        [FieldName(JobRoutes.JobQtyReleased)]
        public string JobQtyReleased { get; set; }
        [FieldName(JobRoutes.JobStat)]
        public string JobStat { get; set; }
        [FieldName(JobRoutes.JobSuffix)]
        public string JobSuffix { get; set; }
        [FieldName(JobRoutes.JobType)]
        public string JobType { get; set; }
        [FieldName(JobRoutes.JshAllowReallocation)]
        public string JshAllowReallocation { get; set; }
        [FieldName(JobRoutes.JshCrsBrkRule)]
        public string JshCrsBrkRule { get; set; }
        [FieldName(JobRoutes.JshEndDate)]
        public DateTime JshEndDate { get; set; }
        [FieldName(JobRoutes.JshFinishHrs)]
        public string JshFinishHrs { get; set; }
        [FieldName(JobRoutes.JshMatrixType)]
        public string JshMatrixType { get; set; }
        [FieldName(JobRoutes.JshMoveHrs)]
        public string JshMoveHrs { get; set; }
        [FieldName(JobRoutes.JshOffsetHrs)]
        public string JshOffsetHrs { get; set; }
        [FieldName(JobRoutes.JshPcsPerLbrHr)]
        public string JshPcsPerLbrHr { get; set; }
        [FieldName(JobRoutes.JshPcsPerMchHr)]
        public string JshPcsPerMchHr { get; set; }
        [FieldName(JobRoutes.JshPlannerstep)]
        public string JshPlannerstep { get; set; }
        [FieldName(JobRoutes.JshQueueHrs)]
        public string JshQueueHrs { get; set; }
        [FieldName(JobRoutes.JshRunLbrHrs)]
        public string JshRunLbrHrs { get; set; }
        [FieldName(JobRoutes.JshRunMchHrs)]
        public string JshRunMchHrs { get; set; }
        [FieldName(JobRoutes.JshSchedDrv)]
        public string JshSchedDrv { get; set; }
        [FieldName(JobRoutes.JshSchedHrs)]
        public string JshSchedHrs { get; set; }
        [FieldName(JobRoutes.JshSchedStepRule)]
        public string JshSchedStepRule { get; set; }
        [FieldName(JobRoutes.JshSchedTicks)]
        public string JshSchedTicks { get; set; }
        [FieldName(JobRoutes.JshSetupHrs)]
        public string JshSetupHrs { get; set; }
        [FieldName(JobRoutes.JshSetuprgid)]
        public string JshSetuprgid { get; set; }
        [FieldName(JobRoutes.JshSetuprule)]
        public string JshSetuprule { get; set; }
        [FieldName(JobRoutes.JshSplitSize)]
        public string JshSplitSize { get; set; }
        [FieldName(JobRoutes.JshStartDate)]
        public DateTime JshStartDate { get; set; }
        [FieldName(JobRoutes.JshTabid)]
        public string JshTabid { get; set; }
        [FieldName(JobRoutes.JshWhenRule)]
        public string JshWhenRule { get; set; }
        [FieldName(JobRoutes.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(JobRoutes.ObsDate)]
        public DateTime ObsDate { get; set; }
        [FieldName(JobRoutes.OperNum)]
        public string OperNum { get; set; }
        [FieldName(JobRoutes.PitmItem)]
        public string PitmItem { get; set; }
        [FieldName(JobRoutes.PrevEffectDate)]
        public DateTime PrevEffectDate { get; set; }
        [FieldName(JobRoutes.PrevObsDate)]
        public DateTime PrevObsDate { get; set; }
        [FieldName(JobRoutes.PsPsNum)]
        public string PsPsNum { get; set; }
        [FieldName(JobRoutes.PsStat)]
        public string PsStat { get; set; }
        [FieldName(JobRoutes.QtyComplete)]
        public string QtyComplete { get; set; }
        [FieldName(JobRoutes.QtyMoved)]
        public string QtyMoved { get; set; }
        [FieldName(JobRoutes.QtyReceived)]
        public string QtyReceived { get; set; }
        [FieldName(JobRoutes.QtyScrapped)]
        public string QtyScrapped { get; set; }
        [FieldName(JobRoutes.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(JobRoutes.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(JobRoutes.RunBasisLbr)]
        public string RunBasisLbr { get; set; }
        [FieldName(JobRoutes.RunBasisMch)]
        public string RunBasisMch { get; set; }
        [FieldName(JobRoutes.RunCostTLbr)]
        public string RunCostTLbr { get; set; }
        [FieldName(JobRoutes.RunDur)]
        public string RunDur { get; set; }
        [FieldName(JobRoutes.RunHrsTLbr)]
        public string RunHrsTLbr { get; set; }
        [FieldName(JobRoutes.RunHrsTMch)]
        public string RunHrsTMch { get; set; }
        [FieldName(JobRoutes.RunHrsVLbr)]
        public string RunHrsVLbr { get; set; }
        [FieldName(JobRoutes.RunHrsVMch)]
        public string RunHrsVMch { get; set; }
        [FieldName(JobRoutes.RunRateLbr)]
        public string RunRateLbr { get; set; }
        [FieldName(JobRoutes.ScheduleDriver)]
        public string ScheduleDriver { get; set; }
        [FieldName(JobRoutes.SetupCostT)]
        public string SetupCostT { get; set; }
        [FieldName(JobRoutes.SetupHrsT)]
        public string SetupHrsT { get; set; }
        [FieldName(JobRoutes.SetupHrsV)]
        public string SetupHrsV { get; set; }
        [FieldName(JobRoutes.SetupRate)]
        public string SetupRate { get; set; }
        [FieldName(JobRoutes.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(JobRoutes.SLJrtItems)]
        public string SLJrtItems { get; set; }
        [FieldName(JobRoutes.SLJrtResourceGroups)]
        public string SLJrtResourceGroups { get; set; }
        [FieldName(JobRoutes.SLWcResourceGroups)]
        public string SLWcResourceGroups { get; set; }
        [FieldName(JobRoutes.Suffix)]
        public string Suffix { get; set; }
        [FieldName(JobRoutes.Type)]
        public string Type { get; set; }
        [FieldName(JobRoutes.UbCurrOperOldRowPtr)]
        public string UbCurrOperOldRowPtr { get; set; }
        [FieldName(JobRoutes.UbJobOperOldRowPtr)]
        public string UbJobOperOldRowPtr { get; set; }
        [FieldName(JobRoutes.UBPrevJshEndDate)]
        public DateTime UBPrevJshEndDate { get; set; }
        [FieldName(JobRoutes.UBPrevJshStartDate)]
        public DateTime UBPrevJshStartDate { get; set; }
        [FieldName(JobRoutes.UbProcessId)]
        public string UbProcessId { get; set; }
        [FieldName(JobRoutes.UBUpdateResourceGroupFrom)]
        public string UBUpdateResourceGroupFrom { get; set; }
        [FieldName(JobRoutes.UseFixedSchedule)]
        public string UseFixedSchedule { get; set; }
        [FieldName(JobRoutes.UseOffsetHrs)]
        public string UseOffsetHrs { get; set; }
        [FieldName(JobRoutes.VarovhdRate)]
        public string VarovhdRate { get; set; }
        [FieldName(JobRoutes.VarovhdTLbr)]
        public string VarovhdTLbr { get; set; }
        [FieldName(JobRoutes.VarovhdTMch)]
        public string VarovhdTMch { get; set; }
        [FieldName(JobRoutes.VovhdRateMch)]
        public string VovhdRateMch { get; set; }
        [FieldName(JobRoutes.Wc)]
        public string Wc { get; set; }
        [FieldName(JobRoutes.WcDescription)]
        public string WcDescription { get; set; }
        [FieldName(JobRoutes.WcOutside)]
        public string WcOutside { get; set; }
        [FieldName(JobRoutes.WcStatus)]
        public string WcStatus { get; set; }
        [FieldName(JobRoutes.WipAmt)]
        public string WipAmt { get; set; }
        [FieldName(JobRoutes.WipFovhdAmt)]
        public string WipFovhdAmt { get; set; }
        [FieldName(JobRoutes.WipLbrAmt)]
        public string WipLbrAmt { get; set; }
        [FieldName(JobRoutes.WipMatlAmt)]
        public string WipMatlAmt { get; set; }
        [FieldName(JobRoutes.WipOutAmt)]
        public string WipOutAmt { get; set; }
        [FieldName(JobRoutes.WipVovhdAmt)]
        public string WipVovhdAmt { get; set; }
    }

    public class ConnectionInformationsCriteria : IdoCriteria
    {
        public ConnectionInformationsCriteria()
            : base(ConnectionInformations.IDO_NAME)
        {
        }
        [FieldName(ConnectionInformations.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ConnectionInformations.ConnectionID)]
        public string ConnectionID { get; set; }
        [FieldName(ConnectionInformations.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(ConnectionInformations.CreatedBy)]
        public string CreatedBy { get; set; }
        [FieldName(ConnectionInformations.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(ConnectionInformations.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(ConnectionInformations.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ConnectionInformations.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(ConnectionInformations.UbSelected)]
        public string UbSelected { get; set; }
        [FieldName(ConnectionInformations.UpdatedBy)]
        public string UpdatedBy { get; set; }
        [FieldName(ConnectionInformations.UserName)]
        public string UserName { get; set; }
    }
    public class CustomerOrderLineItemCriteria : IdoCriteria
    {
        public CustomerOrderLineItemCriteria()
            : base(CustomerOrderLineItem.IDO_NAME)
        {
        }
        [FieldName(CustomerOrderLineItem.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(CustomerOrderLineItem.Item)]
        public string Item { get; set; }
        [FieldName(CustomerOrderLineItem.CustomerPartNumber)]
        public string CustomerPartNumber { get; set; }
        [FieldName(CustomerOrderLineItem.CustomerNumber)]
        public string CustomerNumber { get; set; }
        [FieldName(CustomerOrderLineItem.QtyOrdered)]
        public int QtyOrdered { get; set; }
        [FieldName(CustomerOrderLineItem.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(CustomerOrderLineItem.LineNumber)]
        public string LineNumber { get; set; }
        [FieldName(CustomerOrderLineItem.ReleaseNumber)]
        public string ReleaseNumber { get; set; }
        [FieldName(CustomerOrderLineItem.Status)]
        public string Status { get; set; }
        [FieldName(CustomerOrderLineItem.Description)]
        public string Description { get; set; }
        [FieldName(CustomerOrderLineItem.UnitOfMeasure)]
        public string UnitOfMeasure { get; set; }
        [FieldName(CustomerOrderLineItem.Price)]
        public decimal Price { get; set; }
        [FieldName(CustomerOrderLineItem.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(CustomerOrderLineItem.ShipSite)]
        public string ShipSite { get; set; }
        [FieldName(CustomerOrderLineItem.Warehouse)]
        public string Warehouse { get; set; }
        [FieldName(CustomerOrderLineItem.InventoryFrequency)]
        public string InventoryFrequency { get; set; }
        [FieldName(CustomerOrderLineItem.Address1)]
        public string Address1 { get; set; }
        [FieldName(CustomerOrderLineItem.Address2)]
        public string Address2 { get; set; }
        [FieldName(CustomerOrderLineItem.AddressCity)]
        public string AddressCity { get; set; }
        [FieldName(CustomerOrderLineItem.AddressName)]
        public string AddressName { get; set; }
        [FieldName(CustomerOrderLineItem.AddressState)]
        public string AddressState { get; set; }
        [FieldName(CustomerOrderLineItem.AddressZip)]
        public string AddressZip { get; set; }
        [FieldName(CustomerOrderLineItem.Adr01CreditHold)]
        public string Adr01CreditHold { get; set; }
        [FieldName(CustomerOrderLineItem.Adr0CorpCred)]
        public string Adr0CorpCred { get; set; }
        [FieldName(CustomerOrderLineItem.Adr0CorpCust)]
        public string Adr0CorpCust { get; set; }
        [FieldName(CustomerOrderLineItem.Adr0CreditHold)]
        public string Adr0CreditHold { get; set; }
        [FieldName(CustomerOrderLineItem.Adr0Name)]
        public string Adr0Name { get; set; }
        [FieldName(CustomerOrderLineItem.AdrAddr_1)]
        public string AdrAddr_1 { get; set; }
        [FieldName(CustomerOrderLineItem.AdrAddr_2)]
        public string AdrAddr_2 { get; set; }
        [FieldName(CustomerOrderLineItem.AdrAddr_3)]
        public string AdrAddr_3 { get; set; }
        [FieldName(CustomerOrderLineItem.AdrAddr_4)]
        public string AdrAddr_4 { get; set; }
        [FieldName(CustomerOrderLineItem.AdrCity)]
        public string AdrCity { get; set; }
        [FieldName(CustomerOrderLineItem.AdrCountry)]
        public string AdrCountry { get; set; }
        [FieldName(CustomerOrderLineItem.AdrCreditHold)]
        public string AdrCreditHold { get; set; }
        [FieldName(CustomerOrderLineItem.AdrCurrCode)]
        public string AdrCurrCode { get; set; }
        [FieldName(CustomerOrderLineItem.AdrCurrdescription)]
        public string AdrCurrdescription { get; set; }
        [FieldName(CustomerOrderLineItem.AdrFaxNum)]
        public string AdrFaxNum { get; set; }
        [FieldName(CustomerOrderLineItem.AdrName)]
        public string AdrName { get; set; }
        [FieldName(CustomerOrderLineItem.AdrState)]
        public string AdrState { get; set; }
        [FieldName(CustomerOrderLineItem.AdrZip)]
        public string AdrZip { get; set; }
        [FieldName(CustomerOrderLineItem.BatchId)]
        public string BatchId { get; set; }
        [FieldName(CustomerOrderLineItem.Bol)]
        public string Bol { get; set; }
        [FieldName(CustomerOrderLineItem.BrkQty_1)]
        public string BrkQty_1 { get; set; }
        [FieldName(CustomerOrderLineItem.BrkQty_2)]
        public string BrkQty_2 { get; set; }
        [FieldName(CustomerOrderLineItem.BrkQty_3)]
        public string BrkQty_3 { get; set; }
        [FieldName(CustomerOrderLineItem.BrkQty_4)]
        public string BrkQty_4 { get; set; }
        [FieldName(CustomerOrderLineItem.BrkQty_5)]
        public string BrkQty_5 { get; set; }
        [FieldName(CustomerOrderLineItem.CblBlanketQtyConv)]
        public string CblBlanketQtyConv { get; set; }
        [FieldName(CustomerOrderLineItem.CblCoLine)]
        public string CblCoLine { get; set; }
        [FieldName(CustomerOrderLineItem.CblContPriceConv)]
        public string CblContPriceConv { get; set; }
        [FieldName(CustomerOrderLineItem.CblEffDate)]
        public DateTime CblEffDate { get; set; }
        [FieldName(CustomerOrderLineItem.CblExpDate)]
        public DateTime CblExpDate { get; set; }
        [FieldName(CustomerOrderLineItem.CblItem)]
        public string CblItem { get; set; }
        [FieldName(CustomerOrderLineItem.CblShipSite)]
        public string CblShipSite { get; set; }
        [FieldName(CustomerOrderLineItem.CblStat)]
        public string CblStat { get; set; }
        [FieldName(CustomerOrderLineItem.CblUM)]
        public string CblUM { get; set; }
        [FieldName(CustomerOrderLineItem.CfgMainConfigGid)]
        public string CfgMainConfigGid { get; set; }
        [FieldName(CustomerOrderLineItem.CfgMainConfigModel)]
        public string CfgMainConfigModel { get; set; }
        [FieldName(CustomerOrderLineItem.CfgMainConfigStatus)]
        public string CfgMainConfigStatus { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotal)]
        public string CgsTotal { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotalFovhd)]
        public string CgsTotalFovhd { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotalLbr)]
        public string CgsTotalLbr { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotalMatl)]
        public string CgsTotalMatl { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotalOut)]
        public string CgsTotalOut { get; set; }
        [FieldName(CustomerOrderLineItem.CgsTotalVovhd)]
        public string CgsTotalVovhd { get; set; }
        [FieldName(CustomerOrderLineItem.CoCloseDate)]
        public string CoCloseDate { get; set; }
        [FieldName(CustomerOrderLineItem.CoCoCustNum)]
        public string CoCoCustNum { get; set; }
        [FieldName(CustomerOrderLineItem.CoConsolidate)]
        public string CoConsolidate { get; set; }
        [FieldName(CustomerOrderLineItem.CoCost)]
        public decimal CoCost { get; set; }
        [FieldName(CustomerOrderLineItem.CoCreditHold)]
        public string CoCreditHold { get; set; }
        [FieldName(CustomerOrderLineItem.CoCustNum)]
        public string CoCustNum { get; set; }
        [FieldName(CustomerOrderLineItem.CoCustPo)]
        public string CoCustPo { get; set; }
        [FieldName(CustomerOrderLineItem.CoEdiOrder)]
        public string CoEdiOrder { get; set; }
        [FieldName(CustomerOrderLineItem.CoExchRate)]
        public decimal CoExchRate { get; set; }
        [FieldName(CustomerOrderLineItem.CoExportType)]
        public string CoExportType { get; set; }
        [FieldName(CustomerOrderLineItem.CoiiCoNum)]
        public string CoiiCoNum { get; set; }
        [FieldName(CustomerOrderLineItem.CoInvFreq)]
        public string CoInvFreq { get; set; }
        [FieldName(CustomerOrderLineItem.CoLine)]
        public string CoLine { get; set; }
        [FieldName(CustomerOrderLineItem.CommCode)]
        public string CommCode { get; set; }
        [FieldName(CustomerOrderLineItem.ComSupplQtyReq)]
        public string ComSupplQtyReq { get; set; }
        [FieldName(CustomerOrderLineItem.ConfigID)]
        public string ConfigID { get; set; }
        [FieldName(CustomerOrderLineItem.ConsNum)]
        public string ConsNum { get; set; }
        [FieldName(CustomerOrderLineItem.Consolidate)]
        public string Consolidate { get; set; }
        [FieldName(CustomerOrderLineItem.CoNum)]
        public string CoNum { get; set; }
        [FieldName(CustomerOrderLineItem.CoOrderDate)]
        public DateTime CoOrderDate { get; set; }
        [FieldName(CustomerOrderLineItem.CoOrigSite)]
        public string CoOrigSite { get; set; }
        [FieldName(CustomerOrderLineItem.CoPrice)]
        public string CoPrice { get; set; }
        [FieldName(CustomerOrderLineItem.CoRelease)]
        public string CoRelease { get; set; }
        [FieldName(CustomerOrderLineItem.CosDoLine)]
        public string CosDoLine { get; set; }
        [FieldName(CustomerOrderLineItem.CosDoNum)]
        public string CosDoNum { get; set; }
        [FieldName(CustomerOrderLineItem.CosDoSeq)]
        public string CosDoSeq { get; set; }
        [FieldName(CustomerOrderLineItem.CosQtyInvoiced)]
        public string CosQtyInvoiced { get; set; }
        [FieldName(CustomerOrderLineItem.CosQtyReturned)]
        public string CosQtyReturned { get; set; }
        [FieldName(CustomerOrderLineItem.CosQtyShipped)]
        public int CosQtyShipped { get; set; }
        [FieldName(CustomerOrderLineItem.Cost)]
        public string Cost { get; set; }
        [FieldName(CustomerOrderLineItem.CoStat)]
        public string CoStat { get; set; }
        [FieldName(CustomerOrderLineItem.CostConv)]
        public string CostConv { get; set; }
        [FieldName(CustomerOrderLineItem.CoTaxCode1)]
        public string CoTaxCode1 { get; set; }
        [FieldName(CustomerOrderLineItem.CoTaxCode2)]
        public string CoTaxCode2 { get; set; }
        [FieldName(CustomerOrderLineItem.CoTermsCode)]
        public string CoTermsCode { get; set; }
        [FieldName(CustomerOrderLineItem.OrderType)]
        public string OrderType { get; set; }
        [FieldName(CustomerOrderLineItem.CoUseExchRate)]
        public decimal CoUseExchRate { get; set; }
        [FieldName(CustomerOrderLineItem.CoWhse)]
        public string CoWhse { get; set; }
        [FieldName(CustomerOrderLineItem.CurrencyAmtFormat)]
        public string CurrencyAmtFormat { get; set; }
        [FieldName(CustomerOrderLineItem.CurrencyCstPrcFormat)]
        public string CurrencyCstPrcFormat { get; set; }
        [FieldName(CustomerOrderLineItem.CurrencyPlaces)]
        public string CurrencyPlaces { get; set; }
        [FieldName(CustomerOrderLineItem.CusContact_2)]
        public string CusContact_2 { get; set; }
        [FieldName(CustomerOrderLineItem.CusCustType)]
        public string CusCustType { get; set; }
        [FieldName(CustomerOrderLineItem.CusDoInvoice)]
        public string CusDoInvoice { get; set; }
        [FieldName(CustomerOrderLineItem.CusPhone_2)]
        public string CusPhone_2 { get; set; }
        [FieldName(CustomerOrderLineItem.CustItem)]
        public string CustItem { get; set; }
        [FieldName(CustomerOrderLineItem.CustNum)]
        public string CustNum { get; set; }
        [FieldName(CustomerOrderLineItem.CustPo)]
        public string CustPo { get; set; }
        [FieldName(CustomerOrderLineItem.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(CustomerOrderLineItem.CusUseExchRate)]
        public decimal CusUseExchRate { get; set; }
        [FieldName(CustomerOrderLineItem.Delterm)]
        public string Delterm { get; set; }
        [FieldName(CustomerOrderLineItem.DerAllowOverCreditLimit)]
        public string DerAllowOverCreditLimit { get; set; }
        [FieldName(CustomerOrderLineItem.DerApsOrderID)]
        public string DerApsOrderID { get; set; }
        [FieldName(CustomerOrderLineItem.DerCanChangeItem)]
        public string DerCanChangeItem { get; set; }
        [FieldName(CustomerOrderLineItem.DerCanChgShipSite)]
        public string DerCanChgShipSite { get; set; }
        [FieldName(CustomerOrderLineItem.DerCfgJobIsConfigurable)]
        public string DerCfgJobIsConfigurable { get; set; }
        [FieldName(CustomerOrderLineItem.DerCoverSheetCompany)]
        public string DerCoverSheetCompany { get; set; }
        [FieldName(CustomerOrderLineItem.DerCoverSheetContact)]
        public string DerCoverSheetContact { get; set; }
        [FieldName(CustomerOrderLineItem.DerCurrCode)]
        public string DerCurrCode { get; set; }
        [FieldName(CustomerOrderLineItem.DerCurrencyPlaces)]
        public string DerCurrencyPlaces { get; set; }
        [FieldName(CustomerOrderLineItem.DerDropShipAddress)]
        public string DerDropShipAddress { get; set; }
        [FieldName(CustomerOrderLineItem.DerDropShipCustAddr)]
        public string DerDropShipCustAddr { get; set; }
        [FieldName(CustomerOrderLineItem.DerDropShipFlag)]
        public string DerDropShipFlag { get; set; }
        [FieldName(CustomerOrderLineItem.DerExtPrice)]
        public string DerExtPrice { get; set; }
        [FieldName(CustomerOrderLineItem.DerFovhdCostConv)]
        public string DerFovhdCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerFovhdExtended)]
        public string DerFovhdExtended { get; set; }
        [FieldName(CustomerOrderLineItem.DerInfobar)]
        public string DerInfobar { get; set; }
        [FieldName(CustomerOrderLineItem.DerItemFeatTempl)]
        public string DerItemFeatTempl { get; set; }
        [FieldName(CustomerOrderLineItem.DerItExist)]
        public string DerItExist { get; set; }
        [FieldName(CustomerOrderLineItem.DerLbrExtended)]
        public string DerLbrExtended { get; set; }
        [FieldName(CustomerOrderLineItem.DerLoc)]
        public string DerLoc { get; set; }
        [FieldName(CustomerOrderLineItem.DerLot)]
        public string DerLot { get; set; }
        [FieldName(CustomerOrderLineItem.DerMatlExtended)]
        public string DerMatlExtended { get; set; }
        [FieldName(CustomerOrderLineItem.DerMaxQtyToPackConv)]
        public string DerMaxQtyToPackConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(CustomerOrderLineItem.DerNetPrice)]
        public string DerNetPrice { get; set; }
        [FieldName(CustomerOrderLineItem.DerOldCoLine)]
        public string DerOldCoLine { get; set; }
        [FieldName(CustomerOrderLineItem.DerOldCoNum)]
        public string DerOldCoNum { get; set; }
        [FieldName(CustomerOrderLineItem.DerOldStat)]
        public string DerOldStat { get; set; }
        [FieldName(CustomerOrderLineItem.DerOrigQtyOrderedConv)]
        public string DerOrigQtyOrderedConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerOutExtended)]
        public string DerOutExtended { get; set; }
        [FieldName(CustomerOrderLineItem.DerProgBillTotalBilled)]
        public string DerProgBillTotalBilled { get; set; }
        [FieldName(CustomerOrderLineItem.DerProgBillTotalInvoiced)]
        public string DerProgBillTotalInvoiced { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyInvoicedConv)]
        public string DerQtyInvoicedConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyPackedConv)]
        public string DerQtyPackedConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyPicked)]
        public string DerQtyPicked { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyReady)]
        public string DerQtyReady { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyReadyConv)]
        public string DerQtyReadyConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyRsvdConv)]
        public string DerQtyRsvdConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyShippedConv)]
        public string DerQtyShippedConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyToInvoice)]
        public string DerQtyToInvoice { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyToPack)]
        public string DerQtyToPack { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyToPackConv)]
        public string DerQtyToPackConv { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyToPick)]
        public string DerQtyToPick { get; set; }
        [FieldName(CustomerOrderLineItem.DerQtyToShip)]
        public string DerQtyToShip { get; set; }
        [FieldName(CustomerOrderLineItem.DerSelected)]
        public string DerSelected { get; set; }
        [FieldName(CustomerOrderLineItem.DerSerialPrefix)]
        public string DerSerialPrefix { get; set; }
        [FieldName(CustomerOrderLineItem.DerShiIteActive)]
        public string DerShiIteActive { get; set; }
        [FieldName(CustomerOrderLineItem.TotalCost)]
        public string TotalCost { get; set; }
        [FieldName(CustomerOrderLineItem.DerTotExtended)]
        public string DerTotExtended { get; set; }
        [FieldName(CustomerOrderLineItem.DerTotQtyToInvoice)]
        public string DerTotQtyToInvoice { get; set; }
        [FieldName(CustomerOrderLineItem.DerUomConvFactor)]
        public string DerUomConvFactor { get; set; }
        [FieldName(CustomerOrderLineItem.DerVovhdExtended)]
        public string DerVovhdExtended { get; set; }
        [FieldName(CustomerOrderLineItem.Disc)]
        public string Disc { get; set; }
        [FieldName(CustomerOrderLineItem.DltDescription)]
        public string DltDescription { get; set; }
        [FieldName(CustomerOrderLineItem.DoLine)]
        public string DoLine { get; set; }
        [FieldName(CustomerOrderLineItem.EcCode)]
        public string EcCode { get; set; }
        [FieldName(CustomerOrderLineItem.ExportValue)]
        public string ExportValue { get; set; }
        [FieldName(CustomerOrderLineItem.ExtendedCost)]
        public string ExtendedCost { get; set; }
        [FieldName(CustomerOrderLineItem.ExtendedPrice)]
        public string ExtendedPrice { get; set; }
        [FieldName(CustomerOrderLineItem.ExternalReservationRef)]
        public string ExternalReservationRef { get; set; }
        [FieldName(CustomerOrderLineItem.FeatStr)]
        public string FeatStr { get; set; }
        [FieldName(CustomerOrderLineItem.FovhdCost)]
        public string FovhdCost { get; set; }
        [FieldName(CustomerOrderLineItem.FovhdCostConv)]
        public string FovhdCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.InvFreq)]
        public string InvFreq { get; set; }
        [FieldName(CustomerOrderLineItem.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(CustomerOrderLineItem.ItAutoJob)]
        public string ItAutoJob { get; set; }
        [FieldName(CustomerOrderLineItem.ItAutoPost)]
        public string ItAutoPost { get; set; }
        [FieldName(CustomerOrderLineItem.ItCfgModel)]
        public string ItCfgModel { get; set; }
        [FieldName(CustomerOrderLineItem.ItCoPostConfig)]
        public string ItCoPostConfig { get; set; }
        [FieldName(CustomerOrderLineItem.ItDescription)]
        public string ItDescription { get; set; }
        [FieldName(CustomerOrderLineItem.IteWhsQtyOnHand)]
        public string IteWhsQtyOnHand { get; set; }
        [FieldName(CustomerOrderLineItem.ItKit)]
        public string ItKit { get; set; }
        [FieldName(CustomerOrderLineItem.ItLotTracked)]
        public string ItLotTracked { get; set; }
        [FieldName(CustomerOrderLineItem.ItOrderConfigurable)]
        public string ItOrderConfigurable { get; set; }
        [FieldName(CustomerOrderLineItem.ItPlanFlag)]
        public string ItPlanFlag { get; set; }
        [FieldName(CustomerOrderLineItem.ItReservable)]
        public string ItReservable { get; set; }
        [FieldName(CustomerOrderLineItem.ItSerialTracked)]
        public string ItSerialTracked { get; set; }
        [FieldName(CustomerOrderLineItem.ItSupplySite)]
        public string ItSupplySite { get; set; }
        [FieldName(CustomerOrderLineItem.ItUM)]
        public string ItUM { get; set; }
        [FieldName(CustomerOrderLineItem.ItUWsPrice)]
        public string ItUWsPrice { get; set; }
        [FieldName(CustomerOrderLineItem.LbrCost)]
        public string LbrCost { get; set; }
        [FieldName(CustomerOrderLineItem.LbrCostConv)]
        public string LbrCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.Margin)]
        public string Margin { get; set; }
        [FieldName(CustomerOrderLineItem.MarginPercent)]
        public string MarginPercent { get; set; }
        [FieldName(CustomerOrderLineItem.MatlCost)]
        public string MatlCost { get; set; }
        [FieldName(CustomerOrderLineItem.MatlCostConv)]
        public string MatlCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(CustomerOrderLineItem.Origin)]
        public string Origin { get; set; }
        [FieldName(CustomerOrderLineItem.OutCost)]
        public string OutCost { get; set; }
        [FieldName(CustomerOrderLineItem.OutCostConv)]
        public string OutCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.Packed)]
        public string Packed { get; set; }
        [FieldName(CustomerOrderLineItem.ParCfgConfigGid)]
        public string ParCfgConfigGid { get; set; }
        [FieldName(CustomerOrderLineItem.PickDate)]
        public DateTime PickDate { get; set; }
        [FieldName(CustomerOrderLineItem.PrgBillApp)]
        public string PrgBillApp { get; set; }
        [FieldName(CustomerOrderLineItem.PrgBillTot)]
        public string PrgBillTot { get; set; }
        [FieldName(CustomerOrderLineItem.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(CustomerOrderLineItem.PricecodeDesc)]
        public string PricecodeDesc { get; set; }
        [FieldName(CustomerOrderLineItem.PriceConv)]
        public string PriceConv { get; set; }
        [FieldName(CustomerOrderLineItem.PrintKitComponents)]
        public string PrintKitComponents { get; set; }
        [FieldName(CustomerOrderLineItem.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(CustomerOrderLineItem.ProCompany)]
        public string ProCompany { get; set; }
        [FieldName(CustomerOrderLineItem.ProCurrCode)]
        public string ProCurrCode { get; set; }
        [FieldName(CustomerOrderLineItem.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(CustomerOrderLineItem.PromiseDate)]
        public DateTime PromiseDate { get; set; }
        [FieldName(CustomerOrderLineItem.ProspectId)]
        public string ProspectId { get; set; }
        [FieldName(CustomerOrderLineItem.QtyInvoiced)]
        public int QtyInvoiced { get; set; }
        [FieldName(CustomerOrderLineItem.QtyOrderedConv)]
        public string QtyOrderedConv { get; set; }
        [FieldName(CustomerOrderLineItem.QtyPacked)]
        public int QtyPacked { get; set; }
        [FieldName(CustomerOrderLineItem.QtyReady)]
        public int QtyReady { get; set; }
        [FieldName(CustomerOrderLineItem.QtyReturned)]
        public int QtyReturned { get; set; }
        [FieldName(CustomerOrderLineItem.QtyRsvd)]
        public int QtyRsvd { get; set; }
        [FieldName(CustomerOrderLineItem.QtyShipped)]
        public int QtyShipped { get; set; }
        [FieldName(CustomerOrderLineItem.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(CustomerOrderLineItem.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(CustomerOrderLineItem.RefNum)]
        public string RefNum { get; set; }
        [FieldName(CustomerOrderLineItem.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(CustomerOrderLineItem.RefType)]
        public string RefType { get; set; }
        [FieldName(CustomerOrderLineItem.ReleaseDate)]
        public DateTime ReleaseDate { get; set; }
        [FieldName(CustomerOrderLineItem.Reprice)]
        public string Reprice { get; set; }
        [FieldName(CustomerOrderLineItem.RmaLine)]
        public string RmaLine { get; set; }
        [FieldName(CustomerOrderLineItem.RmaNum)]
        public string RmaNum { get; set; }
        [FieldName(CustomerOrderLineItem.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(CustomerOrderLineItem.ShiIteActive)]
        public string ShiIteActive { get; set; }
        [FieldName(CustomerOrderLineItem.ShipDate)]
        public DateTime ShipDate { get; set; }
        [FieldName(CustomerOrderLineItem.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(CustomerOrderLineItem.SLProgbills)]
        public string SLProgbills { get; set; }
        [FieldName(CustomerOrderLineItem.SLRsvdInvs)]
        public string SLRsvdInvs { get; set; }
        [FieldName(CustomerOrderLineItem.SLSerials)]
        public string SLSerials { get; set; }
        [FieldName(CustomerOrderLineItem.Summarize)]
        public string Summarize { get; set; }
        [FieldName(CustomerOrderLineItem.SupplQtyConvFactor)]
        public string SupplQtyConvFactor { get; set; }
        [FieldName(CustomerOrderLineItem.SyncReqd)]
        public string SyncReqd { get; set; }
        [FieldName(CustomerOrderLineItem.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(CustomerOrderLineItem.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(CustomerOrderLineItem.Tc1Description)]
        public string Tc1Description { get; set; }
        [FieldName(CustomerOrderLineItem.Tc2Description)]
        public string Tc2Description { get; set; }
        [FieldName(CustomerOrderLineItem.TermsDescription)]
        public string TermsDescription { get; set; }
        [FieldName(CustomerOrderLineItem.TransNat)]
        public string TransNat { get; set; }
        [FieldName(CustomerOrderLineItem.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(CustomerOrderLineItem.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(CustomerOrderLineItem.Transport)]
        public string Transport { get; set; }
        [FieldName(CustomerOrderLineItem.TrnDescription)]
        public string TrnDescription { get; set; }
        [FieldName(CustomerOrderLineItem.UbDispMsg)]
        public string UbDispMsg { get; set; }
        [FieldName(CustomerOrderLineItem.UbDispXRefMsg)]
        public string UbDispXRefMsg { get; set; }
        [FieldName(CustomerOrderLineItem.UbGenerateQty)]
        public string UbGenerateQty { get; set; }
        [FieldName(CustomerOrderLineItem.UbIncrPrice)]
        public string UbIncrPrice { get; set; }
        [FieldName(CustomerOrderLineItem.UbItem)]
        public string UbItem { get; set; }
        [FieldName(CustomerOrderLineItem.UbItemCustAdd)]
        public string UbItemCustAdd { get; set; }
        [FieldName(CustomerOrderLineItem.UbItemCustUpdate)]
        public string UbItemCustUpdate { get; set; }
        [FieldName(CustomerOrderLineItem.UbNetAdjust)]
        public string UbNetAdjust { get; set; }
        [FieldName(CustomerOrderLineItem.UbNewDisc)]
        public string UbNewDisc { get; set; }
        [FieldName(CustomerOrderLineItem.UbNewNet)]
        public string UbNewNet { get; set; }
        [FieldName(CustomerOrderLineItem.UbNewPrice)]
        public string UbNewPrice { get; set; }
        [FieldName(CustomerOrderLineItem.UbOldNet)]
        public string UbOldNet { get; set; }
        [FieldName(CustomerOrderLineItem.UbPackNum)]
        public string UbPackNum { get; set; }
        [FieldName(CustomerOrderLineItem.UbPlanOnSave)]
        public string UbPlanOnSave { get; set; }
        [FieldName(CustomerOrderLineItem.UbProgBillAmount)]
        public string UbProgBillAmount { get; set; }
        [FieldName(CustomerOrderLineItem.UbQtyToAdjust)]
        public string UbQtyToAdjust { get; set; }
        [FieldName(CustomerOrderLineItem.UbRangeQty)]
        public string UbRangeQty { get; set; }
        [FieldName(CustomerOrderLineItem.UbSelect)]
        public string UbSelect { get; set; }
        [FieldName(CustomerOrderLineItem.UbSelectedQty)]
        public string UbSelectedQty { get; set; }
        [FieldName(CustomerOrderLineItem.UbSetItemCust)]
        public string UbSetItemCust { get; set; }
        [FieldName(CustomerOrderLineItem.UbTargetQty)]
        public string UbTargetQty { get; set; }
        [FieldName(CustomerOrderLineItem.UM)]
        public string UM { get; set; }
        [FieldName(CustomerOrderLineItem.UnitWeight)]
        public decimal UnitWeight { get; set; }
        [FieldName(CustomerOrderLineItem.VovhdCost)]
        public string VovhdCost { get; set; }
        [FieldName(CustomerOrderLineItem.VovhdCostConv)]
        public string VovhdCostConv { get; set; }
        [FieldName(CustomerOrderLineItem.WksBasis)]
        public string WksBasis { get; set; }
        [FieldName(CustomerOrderLineItem.WksValue)]
        public string WksValue { get; set; }
    }

    public class CustomersCriteria : IdoCriteria
    {
        public CustomersCriteria()
            : base(Customers.IDO_NAME)
        {
        }
        [FieldName(Customers.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Customers.Address1)]
        public string Address1 { get; set; }
        [FieldName(Customers.Address2)]
        public string Address2 { get; set; }
        [FieldName(Customers.BalMethod)]
        public string BalMethod { get; set; }
        [FieldName(Customers.BankCode)]
        public string BankCode { get; set; }
        [FieldName(Customers.BranchId)]
        public string BranchId { get; set; }
        [FieldName(Customers.City)]
        public string City { get; set; }
        [FieldName(Customers.Contact)]
        public string Contact { get; set; }
        [FieldName(Customers.Contact2)]
        public string Contact2 { get; set; }
        [FieldName(Customers.Country)]
        public string Country { get; set; }
        [FieldName(Customers.County)]
        public string County { get; set; }
        [FieldName(Customers.Currency)]
        public string Currency { get; set; }
        [FieldName(Customers.CustomerNumber)]
        public string CustomerNumber { get; set; }
        [FieldName(Customers.CustomerSequence)]
        public string CustomerSequence { get; set; }
        [FieldName(Customers.CustType)]
        public string CustType { get; set; }
        [FieldName(Customers.Delterm)]
        public string Delterm { get; set; }
        [FieldName(Customers.DoInvoice)]
        public string DoInvoice { get; set; }
        [FieldName(Customers.EndUserType)]
        public string EndUserType { get; set; }
        [FieldName(Customers.InvCategory)]
        public string InvCategory { get; set; }
        [FieldName(Customers.InvFreq)]
        public string InvFreq { get; set; }
        [FieldName(Customers.Name)]
        public string Name { get; set; }
        [FieldName(Customers.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(Customers.Slsman)]
        public string Slsman { get; set; }
        [FieldName(Customers.State)]
        public string State { get; set; }
        [FieldName(Customers.TaxCode)]
        public string TaxCode { get; set; }
        [FieldName(Customers.TaxRegNum)]
        public string TaxRegNum { get; set; }
        [FieldName(Customers.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(Customers.TerritoryCode)]
        public string TerritoryCode { get; set; }
        [FieldName(Customers.Whse)]
        public string Whse { get; set; }
        [FieldName(Customers.Zip)]
        public string Zip { get; set; }
        [FieldName(Customers.Address3)]
        public string Address3 { get; set; }
        [FieldName(Customers.Address4)]
        public string Address4 { get; set; }
        [FieldName(Customers.AdrRecordDate)]
        public DateTime AdrRecordDate { get; set; }
        [FieldName(Customers.AdrRowPointer)]
        public string AdrRowPointer { get; set; }
        [FieldName(Customers.AmtOverInvAmt)]
        public decimal AmtOverInvAmt { get; set; }
        [FieldName(Customers.ApsPullUp)]
        public string ApsPullUp { get; set; }
        [FieldName(Customers.AvgBalOs)]
        public string AvgBalOs { get; set; }
        [FieldName(Customers.AvgDaysOs)]
        public string AvgDaysOs { get; set; }
        [FieldName(Customers.BillToCountry)]
        public string BillToCountry { get; set; }
        [FieldName(Customers.BillToEmail)]
        public string BillToEmail { get; set; }
        [FieldName(Customers.CalcDate)]
        public DateTime CalcDate { get; set; }
        [FieldName(Customers.CcContact_2)]
        public string CcContact_2 { get; set; }
        [FieldName(Customers.CcExportType)]
        public string CcExportType { get; set; }
        [FieldName(Customers.CcPhone_2)]
        public string CcPhone_2 { get; set; }
        [FieldName(Customers.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(Customers.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(Customers.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(Customers.CompanyRevenue)]
        public string CompanyRevenue { get; set; }
        [FieldName(Customers.Consolidate)]
        public string Consolidate { get; set; }
        [FieldName(Customers.Contact_1)]
        public string Contact_1 { get; set; }
        [FieldName(Customers.Contact_2)]
        public string Contact_2 { get; set; }
        [FieldName(Customers.Contact_3)]
        public string Contact_3 { get; set; }
        [FieldName(Customers.CorpAddress)]
        public string CorpAddress { get; set; }
        [FieldName(Customers.CorpadrAddr_1)]
        public string CorpadrAddr_1 { get; set; }
        [FieldName(Customers.CorpadrAddr_2)]
        public string CorpadrAddr_2 { get; set; }
        [FieldName(Customers.CorpadrAddr_3)]
        public string CorpadrAddr_3 { get; set; }
        [FieldName(Customers.CorpadrAddr_4)]
        public string CorpadrAddr_4 { get; set; }
        [FieldName(Customers.CorpadrCity)]
        public string CorpadrCity { get; set; }
        [FieldName(Customers.CorpadrCountry)]
        public string CorpadrCountry { get; set; }
        [FieldName(Customers.CorpadrCounty)]
        public string CorpadrCounty { get; set; }
        [FieldName(Customers.CorpadrCreditHold)]
        public string CorpadrCreditHold { get; set; }
        [FieldName(Customers.CorpadrCurrCode)]
        public string CorpadrCurrCode { get; set; }
        [FieldName(Customers.CorpadrFaxNum)]
        public string CorpadrFaxNum { get; set; }
        [FieldName(Customers.CorpadrName)]
        public string CorpadrName { get; set; }
        [FieldName(Customers.CorpadrState)]
        public string CorpadrState { get; set; }
        [FieldName(Customers.CorpadrZip)]
        public string CorpadrZip { get; set; }
        [FieldName(Customers.CorpCred)]
        public string CorpCred { get; set; }
        [FieldName(Customers.CorpCust)]
        public string CorpCust { get; set; }
        [FieldName(Customers.CorpDisplayAddress)]
        public string CorpDisplayAddress { get; set; }
        [FieldName(Customers.CouExpDocReqd)]
        public string CouExpDocReqd { get; set; }
        [FieldName(Customers.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(Customers.CreditHold)]
        public string CreditHold { get; set; }
        [FieldName(Customers.CreditHoldDate)]
        public DateTime CreditHoldDate { get; set; }
        [FieldName(Customers.CreditHoldDescription)]
        public string CreditHoldDescription { get; set; }
        [FieldName(Customers.CreditHoldReason)]
        public string CreditHoldReason { get; set; }
        [FieldName(Customers.CreditHoldUser)]
        public string CreditHoldUser { get; set; }
        [FieldName(Customers.CreditLimit)]
        public string CreditLimit { get; set; }
        [FieldName(Customers.CrmGuid)]
        public string CrmGuid { get; set; }
        [FieldName(Customers.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(Customers.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(Customers.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(Customers.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(Customers.CustBank)]
        public string CustBank { get; set; }
        [FieldName(Customers.CustNum)]
        public string CustNum { get; set; }
        [FieldName(Customers.CustNum_1)]
        public string CustNum_1 { get; set; }
        [FieldName(Customers.CustomerEmailAddr)]
        public string CustomerEmailAddr { get; set; }
        [FieldName(Customers.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(Customers.CustSeq_1)]
        public string CustSeq_1 { get; set; }
        [FieldName(Customers.Datefld)]
        public string Datefld { get; set; }
        [FieldName(Customers.DaysOverInvDueDate)]
        public string DaysOverInvDueDate { get; set; }
        [FieldName(Customers.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(Customers.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(Customers.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(Customers.DeltermDescription)]
        public string DeltermDescription { get; set; }
        [FieldName(Customers.DerBillToAddress)]
        public string DerBillToAddress { get; set; }
        [FieldName(Customers.DerCreditHold)]
        public string DerCreditHold { get; set; }
        [FieldName(Customers.DerCustNum)]
        public string DerCustNum { get; set; }
        [FieldName(Customers.DerDiscLstYr)]
        public string DerDiscLstYr { get; set; }
        [FieldName(Customers.DerDiscYtd)]
        public string DerDiscYtd { get; set; }
        [FieldName(Customers.DerGlobal)]
        public string DerGlobal { get; set; }
        [FieldName(Customers.DerOrderBal)]
        public string DerOrderBal { get; set; }
        [FieldName(Customers.DerPostedBal)]
        public string DerPostedBal { get; set; }
        [FieldName(Customers.DerSalesLstYr)]
        public string DerSalesLstYr { get; set; }
        [FieldName(Customers.DerSalesPtd)]
        public string DerSalesPtd { get; set; }
        [FieldName(Customers.DerSalesYtd)]
        public string DerSalesYtd { get; set; }
        [FieldName(Customers.DerShipToAddress)]
        public string DerShipToAddress { get; set; }
        [FieldName(Customers.DiscLstYr)]
        public string DiscLstYr { get; set; }
        [FieldName(Customers.DiscYtd)]
        public string DiscYtd { get; set; }
        [FieldName(Customers.DraftPrintFlag)]
        public string DraftPrintFlag { get; set; }
        [FieldName(Customers.EcCode)]
        public string EcCode { get; set; }
        [FieldName(Customers.EdiCust)]
        public string EdiCust { get; set; }
        [FieldName(Customers.Einvoice)]
        public string Einvoice { get; set; }
        [FieldName(Customers.EndUserTypeDesc)]
        public string EndUserTypeDesc { get; set; }
        [FieldName(Customers.EtpArAcct)]
        public string EtpArAcct { get; set; }
        [FieldName(Customers.EtpArAcctUnit1)]
        public string EtpArAcctUnit1 { get; set; }
        [FieldName(Customers.EtpArAcctUnit2)]
        public string EtpArAcctUnit2 { get; set; }
        [FieldName(Customers.EtpArAcctUnit3)]
        public string EtpArAcctUnit3 { get; set; }
        [FieldName(Customers.EtpArAcctUnit4)]
        public string EtpArAcctUnit4 { get; set; }
        [FieldName(Customers.ExportType)]
        public string ExportType { get; set; }
        [FieldName(Customers.ExternalEmailAddr)]
        public string ExternalEmailAddr { get; set; }
        [FieldName(Customers.FaxNum)]
        public string FaxNum { get; set; }
        [FieldName(Customers.FinChg)]
        public string FinChg { get; set; }
        [FieldName(Customers.HistDaysOs)]
        public string HistDaysOs { get; set; }
        [FieldName(Customers.IncludeTaxInPrice)]
        public string IncludeTaxInPrice { get; set; }
        [FieldName(Customers.InternalEmailAddr)]
        public string InternalEmailAddr { get; set; }
        [FieldName(Customers.InternetUrl)]
        public string InternetUrl { get; set; }
        [FieldName(Customers.InvCategoryDescription)]
        public string InvCategoryDescription { get; set; }
        [FieldName(Customers.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Customers.LangCode)]
        public string LangCode { get; set; }
        [FieldName(Customers.LargDaysOs)]
        public string LargDaysOs { get; set; }
        [FieldName(Customers.LargeBalOs)]
        public string LargeBalOs { get; set; }
        [FieldName(Customers.LastBalOs)]
        public string LastBalOs { get; set; }
        [FieldName(Customers.LastDaysOs)]
        public string LastDaysOs { get; set; }
        [FieldName(Customers.LastFinChg)]
        public string LastFinChg { get; set; }
        [FieldName(Customers.LastInv)]
        public string LastInv { get; set; }
        [FieldName(Customers.LastPaid)]
        public string LastPaid { get; set; }
        [FieldName(Customers.LcrReqd)]
        public string LcrReqd { get; set; }
        [FieldName(Customers.Logifld)]
        public string Logifld { get; set; }
        [FieldName(Customers.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Customers.NumberOfEmployees)]
        public string NumberOfEmployees { get; set; }
        [FieldName(Customers.NumInvoices)]
        public string NumInvoices { get; set; }
        [FieldName(Customers.NumPeriods)]
        public string NumPeriods { get; set; }
        [FieldName(Customers.OnePackInv)]
        public string OnePackInv { get; set; }
        [FieldName(Customers.PayDay)]
        public string PayDay { get; set; }
        [FieldName(Customers.PayDayEndTime_1)]
        public string PayDayEndTime_1 { get; set; }
        [FieldName(Customers.PayDayEndTime_2)]
        public string PayDayEndTime_2 { get; set; }
        [FieldName(Customers.PayDayStartTime_1)]
        public string PayDayStartTime_1 { get; set; }
        [FieldName(Customers.PayDayStartTime_2)]
        public string PayDayStartTime_2 { get; set; }
        [FieldName(Customers.PayType)]
        public string PayType { get; set; }
        [FieldName(Customers.Phone_1)]
        public string Phone_1 { get; set; }
        [FieldName(Customers.Phone_2)]
        public string Phone_2 { get; set; }
        [FieldName(Customers.Phone_3)]
        public string Phone_3 { get; set; }
        [FieldName(Customers.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(Customers.PricecodeDescription)]
        public string PricecodeDescription { get; set; }
        [FieldName(Customers.PrintPackInv)]
        public string PrintPackInv { get; set; }
        [FieldName(Customers.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(Customers.RcvInternalEmail)]
        public string RcvInternalEmail { get; set; }
        [FieldName(Customers.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Customers.RevisionDay)]
        public string RevisionDay { get; set; }
        [FieldName(Customers.RevisionDayEndTime_1)]
        public string RevisionDayEndTime_1 { get; set; }
        [FieldName(Customers.RevisionDayEndTime_2)]
        public string RevisionDayEndTime_2 { get; set; }
        [FieldName(Customers.RevisionDayStartTime_1)]
        public string RevisionDayStartTime_1 { get; set; }
        [FieldName(Customers.RevisionDayStartTime_2)]
        public string RevisionDayStartTime_2 { get; set; }
        [FieldName(Customers.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Customers.SalesLstYr)]
        public string SalesLstYr { get; set; }
        [FieldName(Customers.SalesPtd)]
        public string SalesPtd { get; set; }
        [FieldName(Customers.SalesYtd)]
        public string SalesYtd { get; set; }
        [FieldName(Customers.SendCustomerEmail)]
        public string SendCustomerEmail { get; set; }
        [FieldName(Customers.ShipCodeDescription)]
        public string ShipCodeDescription { get; set; }
        [FieldName(Customers.ShipEarly)]
        public string ShipEarly { get; set; }
        [FieldName(Customers.ShipPartial)]
        public string ShipPartial { get; set; }
        [FieldName(Customers.ShipSite)]
        public string ShipSite { get; set; }
        [FieldName(Customers.ShipToEmail)]
        public string ShipToEmail { get; set; }
        [FieldName(Customers.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(Customers.ShowInShipToDropDownList)]
        public string ShowInShipToDropDownList { get; set; }
        [FieldName(Customers.SICCode)]
        public string SICCode { get; set; }
        [FieldName(Customers.SLCoitems)]
        public string SLCoitems { get; set; }
        [FieldName(Customers.SLCoitemsEstimates)]
        public string SLCoitemsEstimates { get; set; }
        [FieldName(Customers.SLCoitemsEstimatesFiltered)]
        public string SLCoitemsEstimatesFiltered { get; set; }
        [FieldName(Customers.SLCoitemsFiltered)]
        public string SLCoitemsFiltered { get; set; }
        [FieldName(Customers.SLCos)]
        public string SLCos { get; set; }
        [FieldName(Customers.SLCosEstimates)]
        public string SLCosEstimates { get; set; }
        [FieldName(Customers.SLCustlogs)]
        public string SLCustlogs { get; set; }
        [FieldName(Customers.SLCustomerContacts)]
        public string SLCustomerContacts { get; set; }
        [FieldName(Customers.SLDoSeqs)]
        public string SLDoSeqs { get; set; }
        [FieldName(Customers.SLItemcusts)]
        public string SLItemcusts { get; set; }
        [FieldName(Customers.StateCycle)]
        public string StateCycle { get; set; }
        [FieldName(Customers.Summarize)]
        public string Summarize { get; set; }
        [FieldName(Customers.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(Customers.TaxCode1Description)]
        public string TaxCode1Description { get; set; }
        [FieldName(Customers.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(Customers.TaxCode2Description)]
        public string TaxCode2Description { get; set; }
        [FieldName(Customers.TaxRegNum1)]
        public string TaxRegNum1 { get; set; }
        [FieldName(Customers.TaxRegNum2)]
        public string TaxRegNum2 { get; set; }
        [FieldName(Customers.TelexNum)]
        public string TelexNum { get; set; }
        [FieldName(Customers.TermDescription)]
        public string TermDescription { get; set; }
        [FieldName(Customers.TerrDescription)]
        public string TerrDescription { get; set; }
        [FieldName(Customers.TransNat)]
        public string TransNat { get; set; }
        [FieldName(Customers.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(Customers.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(Customers.TransNatDescription)]
        public string TransNatDescription { get; set; }
        [FieldName(Customers.UBRowPointer)]
        public string UBRowPointer { get; set; }
        [FieldName(Customers.UseExchRate)]
        public string UseExchRate { get; set; }
        [FieldName(Customers.UseRevisionPayDays)]
        public string UseRevisionPayDays { get; set; }
    }

    public class JobsCriteria : IdoCriteria
    {
        public JobsCriteria()
            : base(Jobs.IDO_NAME)
        {
        }
        [FieldName(Jobs.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Jobs.CfgMainConfigGid)]
        public string CfgMainConfigGid { get; set; }
        [FieldName(Jobs.CfgMainConfigStatus)]
        public string CfgMainConfigStatus { get; set; }
        [FieldName(Jobs.ChFovAccessUnit1)]
        public string ChFovAccessUnit1 { get; set; }
        [FieldName(Jobs.ChFovAccessUnit2)]
        public string ChFovAccessUnit2 { get; set; }
        [FieldName(Jobs.ChFovAccessUnit3)]
        public string ChFovAccessUnit3 { get; set; }
        [FieldName(Jobs.ChFovAccessUnit4)]
        public string ChFovAccessUnit4 { get; set; }
        [FieldName(Jobs.ChFovDescription)]
        public string ChFovDescription { get; set; }
        [FieldName(Jobs.ChJcbAccessUnit1)]
        public string ChJcbAccessUnit1 { get; set; }
        [FieldName(Jobs.ChJcbAccessUnit2)]
        public string ChJcbAccessUnit2 { get; set; }
        [FieldName(Jobs.ChJcbAccessUnit3)]
        public string ChJcbAccessUnit3 { get; set; }
        [FieldName(Jobs.ChJcbAccessUnit4)]
        public string ChJcbAccessUnit4 { get; set; }
        [FieldName(Jobs.ChJcbDescription)]
        public string ChJcbDescription { get; set; }
        [FieldName(Jobs.ChLbrAccessUnit1)]
        public string ChLbrAccessUnit1 { get; set; }
        [FieldName(Jobs.ChLbrAccessUnit2)]
        public string ChLbrAccessUnit2 { get; set; }
        [FieldName(Jobs.ChLbrAccessUnit3)]
        public string ChLbrAccessUnit3 { get; set; }
        [FieldName(Jobs.ChLbrAccessUnit4)]
        public string ChLbrAccessUnit4 { get; set; }
        [FieldName(Jobs.ChLbrDescription)]
        public string ChLbrDescription { get; set; }
        [FieldName(Jobs.ChOutAccessUnit1)]
        public string ChOutAccessUnit1 { get; set; }
        [FieldName(Jobs.ChOutAccessUnit2)]
        public string ChOutAccessUnit2 { get; set; }
        [FieldName(Jobs.ChOutAccessUnit3)]
        public string ChOutAccessUnit3 { get; set; }
        [FieldName(Jobs.ChOutAccessUnit4)]
        public string ChOutAccessUnit4 { get; set; }
        [FieldName(Jobs.ChOutDescription)]
        public string ChOutDescription { get; set; }
        [FieldName(Jobs.ChVovAccessUnit1)]
        public string ChVovAccessUnit1 { get; set; }
        [FieldName(Jobs.ChVovAccessUnit2)]
        public string ChVovAccessUnit2 { get; set; }
        [FieldName(Jobs.ChVovAccessUnit3)]
        public string ChVovAccessUnit3 { get; set; }
        [FieldName(Jobs.ChVovAccessUnit4)]
        public string ChVovAccessUnit4 { get; set; }
        [FieldName(Jobs.ChVovDescription)]
        public string ChVovDescription { get; set; }
        [FieldName(Jobs.ChWipAccessUnit1)]
        public string ChWipAccessUnit1 { get; set; }
        [FieldName(Jobs.ChWipAccessUnit2)]
        public string ChWipAccessUnit2 { get; set; }
        [FieldName(Jobs.ChWipAccessUnit3)]
        public string ChWipAccessUnit3 { get; set; }
        [FieldName(Jobs.ChWipAccessUnit4)]
        public string ChWipAccessUnit4 { get; set; }
        [FieldName(Jobs.ChWipDescription)]
        public string ChWipDescription { get; set; }
        [FieldName(Jobs.ConfigId)]
        public string ConfigId { get; set; }
        [FieldName(Jobs.CoProductMix)]
        public string CoProductMix { get; set; }
        [FieldName(Jobs.CustNum)]
        public string CustNum { get; set; }
        [FieldName(Jobs.DerApsOrderID)]
        public string DerApsOrderID { get; set; }
        [FieldName(Jobs.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(Jobs.DerCriticalRatio)]
        public string DerCriticalRatio { get; set; }
        [FieldName(Jobs.DerCurrentBOMExists)]
        public string DerCurrentBOMExists { get; set; }
        [FieldName(Jobs.DerCustName)]
        public string DerCustName { get; set; }
        [FieldName(Jobs.DerCustNum)]
        public string DerCustNum { get; set; }
        [FieldName(Jobs.DerDaysRem)]
        public string DerDaysRem { get; set; }
        [FieldName(Jobs.DerDueDate)]
        public DateTime DerDueDate { get; set; }
        [FieldName(Jobs.DerEcnPending)]
        public string DerEcnPending { get; set; }
        [FieldName(Jobs.DerECNTracked)]
        public string DerECNTracked { get; set; }
        [FieldName(Jobs.DerEnableCoProductMix)]
        public string DerEnableCoProductMix { get; set; }
        [FieldName(Jobs.DerEnableItem)]
        public string DerEnableItem { get; set; }
        [FieldName(Jobs.DerEndDueDate)]
        public DateTime DerEndDueDate { get; set; }
        [FieldName(Jobs.DerHasXRef)]
        public string DerHasXRef { get; set; }
        [FieldName(Jobs.DerIsScheduled)]
        public string DerIsScheduled { get; set; }
        [FieldName(Jobs.DerJobDate)]
        public DateTime DerJobDate { get; set; }
        [FieldName(Jobs.DerJobFormatted)]
        public string DerJobFormatted { get; set; }
        [FieldName(Jobs.DerJobrouteExists)]
        public string DerJobrouteExists { get; set; }
        [FieldName(Jobs.DerJobSuffix)]
        public string DerJobSuffix { get; set; }
        [FieldName(Jobs.DerMessageText)]
        public string DerMessageText { get; set; }
        [FieldName(Jobs.DerNewCost)]
        public string DerNewCost { get; set; }
        [FieldName(Jobs.DerNewStatus)]
        public string DerNewStatus { get; set; }
        [FieldName(Jobs.DerOldCost)]
        public string DerOldCost { get; set; }
        [FieldName(Jobs.DerOldStat)]
        public string DerOldStat { get; set; }
        [FieldName(Jobs.DerOrderDate)]
        public DateTime DerOrderDate { get; set; }
        [FieldName(Jobs.DerOrderQty)]
        public int DerOrderQty { get; set; }
        [FieldName(Jobs.DerPriority)]
        public string DerPriority { get; set; }
        [FieldName(Jobs.DerProspectId)]
        public string DerProspectId { get; set; }
        [FieldName(Jobs.DerPsDesc)]
        public string DerPsDesc { get; set; }
        [FieldName(Jobs.DerPsItemBOMExists)]
        public string DerPsItemBOMExists { get; set; }
        [FieldName(Jobs.DerPsItemRelBOMExists)]
        public string DerPsItemRelBOMExists { get; set; }
        [FieldName(Jobs.DerQtyRemaining)]
        public string DerQtyRemaining { get; set; }
        [FieldName(Jobs.DerRework)]
        public string DerRework { get; set; }
        [FieldName(Jobs.DerStandardBOMExists)]
        public string DerStandardBOMExists { get; set; }
        [FieldName(Jobs.DerStatFormatted)]
        public string DerStatFormatted { get; set; }
        [FieldName(Jobs.DerStdJobExists)]
        public string DerStdJobExists { get; set; }
        [FieldName(Jobs.DerSubJobExists)]
        public string DerSubJobExists { get; set; }
        [FieldName(Jobs.DerWorkRem)]
        public string DerWorkRem { get; set; }
        [FieldName(Jobs.Description)]
        public string Description { get; set; }
        [FieldName(Jobs.EffectDate)]
        public DateTime EffectDate { get; set; }
        [FieldName(Jobs.EstJob)]
        public string EstJob { get; set; }
        [FieldName(Jobs.EstSuf)]
        public string EstSuf { get; set; }
        [FieldName(Jobs.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Jobs.Item)]
        public string Item { get; set; }
        [FieldName(Jobs.ItemAutoPost)]
        public string ItemAutoPost { get; set; }
        [FieldName(Jobs.ItemCfgModel)]
        public string ItemCfgModel { get; set; }
        [FieldName(Jobs.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(Jobs.ItemEcnTracked)]
        public string ItemEcnTracked { get; set; }
        [FieldName(Jobs.ItemJobConfigurable)]
        public string ItemJobConfigurable { get; set; }
        [FieldName(Jobs.ItemJobPostConfig)]
        public string ItemJobPostConfig { get; set; }
        [FieldName(Jobs.ItemLotTracked)]
        public string ItemLotTracked { get; set; }
        [FieldName(Jobs.ItemPlanFlag)]
        public string ItemPlanFlag { get; set; }
        [FieldName(Jobs.ItemSerialPrefix)]
        public string ItemSerialPrefix { get; set; }
        [FieldName(Jobs.ItemSerialTracked)]
        public string ItemSerialTracked { get; set; }
        [FieldName(Jobs.ItemStat)]
        public string ItemStat { get; set; }
        [FieldName(Jobs.ItemTaxFreeMatl)]
        public string ItemTaxFreeMatl { get; set; }
        [FieldName(Jobs.JcbAcct)]
        public string JcbAcct { get; set; }
        [FieldName(Jobs.JcbAcctUnit1)]
        public string JcbAcctUnit1 { get; set; }
        [FieldName(Jobs.JcbAcctUnit2)]
        public string JcbAcctUnit2 { get; set; }
        [FieldName(Jobs.JcbAcctUnit3)]
        public string JcbAcctUnit3 { get; set; }
        [FieldName(Jobs.JcbAcctUnit4)]
        public string JcbAcctUnit4 { get; set; }
        [FieldName(Jobs.Job)]
        public string Job { get; set; }
        [FieldName(Jobs.JobDate)]
        public DateTime JobDate { get; set; }
        [FieldName(Jobs.JobDescription)]
        public string JobDescription { get; set; }
        [FieldName(Jobs.JschCompdate)]
        public DateTime JschCompdate { get; set; }
        [FieldName(Jobs.JschEndDate)]
        public DateTime JschEndDate { get; set; }
        [FieldName(Jobs.JschEndTick)]
        public string JschEndTick { get; set; }
        [FieldName(Jobs.JschPrfreeze)]
        public string JschPrfreeze { get; set; }
        [FieldName(Jobs.JschPriority)]
        public string JschPriority { get; set; }
        [FieldName(Jobs.JschRecordDate)]
        public DateTime JschRecordDate { get; set; }
        [FieldName(Jobs.JschRowPointer)]
        public string JschRowPointer { get; set; }
        [FieldName(Jobs.JschStartDate)]
        public DateTime JschStartDate { get; set; }
        [FieldName(Jobs.JschStartTick)]
        public string JschStartTick { get; set; }
        [FieldName(Jobs.LowLevel)]
        public string LowLevel { get; set; }
        [FieldName(Jobs.LstTrxDate)]
        public DateTime LstTrxDate { get; set; }
        [FieldName(Jobs.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Jobs.OrdLine)]
        public string OrdLine { get; set; }
        [FieldName(Jobs.OrdNum)]
        public string OrdNum { get; set; }
        [FieldName(Jobs.OrdRelease)]
        public string OrdRelease { get; set; }
        [FieldName(Jobs.OrdType)]
        public string OrdType { get; set; }
        [FieldName(Jobs.ParCfgConfigGid)]
        public string ParCfgConfigGid { get; set; }
        [FieldName(Jobs.Picked)]
        public string Picked { get; set; }
        [FieldName(Jobs.ProCompany)]
        public string ProCompany { get; set; }
        [FieldName(Jobs.ProdMix)]
        public string ProdMix { get; set; }
        [FieldName(Jobs.ProspectId)]
        public string ProspectId { get; set; }
        [FieldName(Jobs.PsNum)]
        public string PsNum { get; set; }
        [FieldName(Jobs.QtyComplete)]
        public string QtyComplete { get; set; }
        [FieldName(Jobs.QtyReleased)]
        public string QtyReleased { get; set; }
        [FieldName(Jobs.QtyScrapped)]
        public string QtyScrapped { get; set; }
        [FieldName(Jobs.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Jobs.RefJob)]
        public string RefJob { get; set; }
        [FieldName(Jobs.RefOper)]
        public string RefOper { get; set; }
        [FieldName(Jobs.RefSeq)]
        public string RefSeq { get; set; }
        [FieldName(Jobs.RefSuf)]
        public string RefSuf { get; set; }
        [FieldName(Jobs.Revision)]
        public string Revision { get; set; }
        [FieldName(Jobs.Rework)]
        public string Rework { get; set; }
        [FieldName(Jobs.RollupDate)]
        public DateTime RollupDate { get; set; }
        [FieldName(Jobs.RootJob)]
        public string RootJob { get; set; }
        [FieldName(Jobs.RootSuf)]
        public string RootSuf { get; set; }
        [FieldName(Jobs.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Jobs.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(Jobs.SLJobmatlJobs)]
        public string SLJobmatlJobs { get; set; }
        [FieldName(Jobs.SLJobmatlPos)]
        public string SLJobmatlPos { get; set; }
        [FieldName(Jobs.SLJobmatlReqs)]
        public string SLJobmatlReqs { get; set; }
        [FieldName(Jobs.SLJobmatls)]
        public string SLJobmatls { get; set; }
        [FieldName(Jobs.SLJobmatlTrns)]
        public string SLJobmatlTrns { get; set; }
        [FieldName(Jobs.SLJobRoutes)]
        public string SLJobRoutes { get; set; }
        [FieldName(Jobs.Stat)]
        public string Stat { get; set; }
        [FieldName(Jobs.Suffix)]
        public string Suffix { get; set; }
        [FieldName(Jobs.Type)]
        public string Type { get; set; }
        [FieldName(Jobs.UbCopyBOM)]
        public string UbCopyBOM { get; set; }
        [FieldName(Jobs.UbDispXRefMsg)]
        public string UbDispXRefMsg { get; set; }
        [FieldName(Jobs.UbDispXRefMsg1)]
        public string UbDispXRefMsg1 { get; set; }
        [FieldName(Jobs.UbItem)]
        public string UbItem { get; set; }
        [FieldName(Jobs.UbJob)]
        public string UbJob { get; set; }
        [FieldName(Jobs.UBPerformSubJobDateRecalc)]
        public string UBPerformSubJobDateRecalc { get; set; }
        [FieldName(Jobs.UBPlanOnSave)]
        public string UBPlanOnSave { get; set; }
        [FieldName(Jobs.UBViewType)]
        public string UBViewType { get; set; }
        [FieldName(Jobs.UnlinkedXref)]
        public string UnlinkedXref { get; set; }
        [FieldName(Jobs.Whse)]
        public string Whse { get; set; }
        [FieldName(Jobs.WipAcct)]
        public string WipAcct { get; set; }
        [FieldName(Jobs.WipAcctUnit1)]
        public string WipAcctUnit1 { get; set; }
        [FieldName(Jobs.WipAcctUnit2)]
        public string WipAcctUnit2 { get; set; }
        [FieldName(Jobs.WipAcctUnit3)]
        public string WipAcctUnit3 { get; set; }
        [FieldName(Jobs.WipAcctUnit4)]
        public string WipAcctUnit4 { get; set; }
        [FieldName(Jobs.WipComplete)]
        public string WipComplete { get; set; }
        [FieldName(Jobs.WipFovhdAcct)]
        public string WipFovhdAcct { get; set; }
        [FieldName(Jobs.WipFovhdAcctUnit1)]
        public string WipFovhdAcctUnit1 { get; set; }
        [FieldName(Jobs.WipFovhdAcctUnit2)]
        public string WipFovhdAcctUnit2 { get; set; }
        [FieldName(Jobs.WipFovhdAcctUnit3)]
        public string WipFovhdAcctUnit3 { get; set; }
        [FieldName(Jobs.WipFovhdAcctUnit4)]
        public string WipFovhdAcctUnit4 { get; set; }
        [FieldName(Jobs.WipFovhdComp)]
        public string WipFovhdComp { get; set; }
        [FieldName(Jobs.WipFovhdTotal)]
        public string WipFovhdTotal { get; set; }
        [FieldName(Jobs.WipLbrAcct)]
        public string WipLbrAcct { get; set; }
        [FieldName(Jobs.WipLbrAcctUnit1)]
        public string WipLbrAcctUnit1 { get; set; }
        [FieldName(Jobs.WipLbrAcctUnit2)]
        public string WipLbrAcctUnit2 { get; set; }
        [FieldName(Jobs.WipLbrAcctUnit3)]
        public string WipLbrAcctUnit3 { get; set; }
        [FieldName(Jobs.WipLbrAcctUnit4)]
        public string WipLbrAcctUnit4 { get; set; }
        [FieldName(Jobs.WipLbrComp)]
        public string WipLbrComp { get; set; }
        [FieldName(Jobs.WipLbrTotal)]
        public string WipLbrTotal { get; set; }
        [FieldName(Jobs.WipMatlComp)]
        public string WipMatlComp { get; set; }
        [FieldName(Jobs.WipMatlTotal)]
        public string WipMatlTotal { get; set; }
        [FieldName(Jobs.WipOutAcct)]
        public string WipOutAcct { get; set; }
        [FieldName(Jobs.WipOutAcctUnit1)]
        public string WipOutAcctUnit1 { get; set; }
        [FieldName(Jobs.WipOutAcctUnit2)]
        public string WipOutAcctUnit2 { get; set; }
        [FieldName(Jobs.WipOutAcctUnit3)]
        public string WipOutAcctUnit3 { get; set; }
        [FieldName(Jobs.WipOutAcctUnit4)]
        public string WipOutAcctUnit4 { get; set; }
        [FieldName(Jobs.WipOutComp)]
        public string WipOutComp { get; set; }
        [FieldName(Jobs.WipOutTotal)]
        public string WipOutTotal { get; set; }
        [FieldName(Jobs.WipSpecial)]
        public string WipSpecial { get; set; }
        [FieldName(Jobs.WipTotal)]
        public string WipTotal { get; set; }
        [FieldName(Jobs.WipVovhdAcct)]
        public string WipVovhdAcct { get; set; }
        [FieldName(Jobs.WipVovhdAcctUnit1)]
        public string WipVovhdAcctUnit1 { get; set; }
        [FieldName(Jobs.WipVovhdAcctUnit2)]
        public string WipVovhdAcctUnit2 { get; set; }
        [FieldName(Jobs.WipVovhdAcctUnit3)]
        public string WipVovhdAcctUnit3 { get; set; }
        [FieldName(Jobs.WipVovhdAcctUnit4)]
        public string WipVovhdAcctUnit4 { get; set; }
        [FieldName(Jobs.WipVovhdComp)]
        public string WipVovhdComp { get; set; }
        [FieldName(Jobs.WipVovhdTotal)]
        public string WipVovhdTotal { get; set; }
    }
    public class SitesCriteria : IdoCriteria
    {
        public SitesCriteria( ) : base(Sites.IDO_NAME)
        {
        }

        [FieldName(Sites.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Sites.Site)]
        public string Site { get; set; }
        [FieldName(Sites.SiteName)]
        public string SiteName { get; set; }
        [FieldName(Sites.Description)]
        public string Description { get; set; }
    }

    public class CustomerAddressesCriteria : IdoCriteria
    {
        public CustomerAddressesCriteria()
            : base(CustomerAddresses.IDO_NAME)
        {
        }
        [FieldName(CustomerAddresses.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(CustomerAddresses.Address1)]
        public string Address1 { get; set; }
        [FieldName(CustomerAddresses.Address2)]
        public string Address2 { get; set; }
        [FieldName(CustomerAddresses.Address3)]
        public string Address3 { get; set; }
        [FieldName(CustomerAddresses.Address4)]
        public string Address4 { get; set; }
        [FieldName(CustomerAddresses.AmtOverInvAmt)]
        public string AmtOverInvAmt { get; set; }
        [FieldName(CustomerAddresses.ArparmsAgeDesc_1)]
        public string ArparmsAgeDesc_1 { get; set; }
        [FieldName(CustomerAddresses.ArparmsAgeDesc_2)]
        public string ArparmsAgeDesc_2 { get; set; }
        [FieldName(CustomerAddresses.ArparmsAgeDesc_3)]
        public string ArparmsAgeDesc_3 { get; set; }
        [FieldName(CustomerAddresses.ArparmsAgeDesc_4)]
        public string ArparmsAgeDesc_4 { get; set; }
        [FieldName(CustomerAddresses.ArparmsAgeDesc_5)]
        public string ArparmsAgeDesc_5 { get; set; }
        [FieldName(CustomerAddresses.BalMethod)]
        public string BalMethod { get; set; }
        [FieldName(CustomerAddresses.BillToEmail)]
        public string BillToEmail { get; set; }
        [FieldName(CustomerAddresses.City)]
        public string City { get; set; }
        [FieldName(CustomerAddresses.CorpAddress)]
        public string CorpAddress { get; set; }
        [FieldName(CustomerAddresses.CorpCred)]
        public string CorpCred { get; set; }
        [FieldName(CustomerAddresses.CorpCust)]
        public string CorpCust { get; set; }
        [FieldName(CustomerAddresses.Country)]
        public string Country { get; set; }
        [FieldName(CustomerAddresses.County)]
        public string County { get; set; }
        [FieldName(CustomerAddresses.CreditHold)]
        public string CreditHold { get; set; }
        [FieldName(CustomerAddresses.CreditHoldDate)]
        public DateTime CreditHoldDate { get; set; }
        [FieldName(CustomerAddresses.CreditHoldReason)]
        public string CreditHoldReason { get; set; }
        [FieldName(CustomerAddresses.CreditHoldUser)]
        public string CreditHoldUser { get; set; }
        [FieldName(CustomerAddresses.CreditLimit)]
        public string CreditLimit { get; set; }
        [FieldName(CustomerAddresses.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(CustomerAddresses.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(CustomerAddresses.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(CustomerAddresses.CustNum)]
        public string CustNum { get; set; }
        [FieldName(CustomerAddresses.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(CustomerAddresses.CustTpTpCode)]
        public string CustTpTpCode { get; set; }
        [FieldName(CustomerAddresses.DaysOverInvDueDate)]
        public int DaysOverInvDueDate { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal1)]
        public string DerAgeBal1 { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal2)]
        public string DerAgeBal2 { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal3)]
        public string DerAgeBal3 { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal4)]
        public string DerAgeBal4 { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal5)]
        public string DerAgeBal5 { get; set; }
        [FieldName(CustomerAddresses.DerAgeBal6)]
        public string DerAgeBal6 { get; set; }
        [FieldName(CustomerAddresses.DerBillToAddress)]
        public string DerBillToAddress { get; set; }
        [FieldName(CustomerAddresses.DerCustomerShipToExists)]
        public string DerCustomerShipToExists { get; set; }
        [FieldName(CustomerAddresses.DerEarth)]
        public string DerEarth { get; set; }
        [FieldName(CustomerAddresses.DerOrderBal)]
        public string DerOrderBal { get; set; }
        [FieldName(CustomerAddresses.DerPostedBal)]
        public string DerPostedBal { get; set; }
        [FieldName(CustomerAddresses.DerShipToAddress)]
        public string DerShipToAddress { get; set; }
        [FieldName(CustomerAddresses.ExternalEmailAddr)]
        public string ExternalEmailAddr { get; set; }
        [FieldName(CustomerAddresses.FaxNum)]
        public string FaxNum { get; set; }
        [FieldName(CustomerAddresses.InternalEmailAddr)]
        public string InternalEmailAddr { get; set; }
        [FieldName(CustomerAddresses.InternetUrl)]
        public string InternetUrl { get; set; }
        [FieldName(CustomerAddresses.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(CustomerAddresses.Name)]
        public string Name { get; set; }
        [FieldName(CustomerAddresses.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(CustomerAddresses.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(CustomerAddresses.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(CustomerAddresses.ShipToEmail)]
        public string ShipToEmail { get; set; }
        [FieldName(CustomerAddresses.SLArtranAlls)]
        public string SLArtranAlls { get; set; }
        [FieldName(CustomerAddresses.State)]
        public string State { get; set; }
        [FieldName(CustomerAddresses.TelexNum)]
        public string TelexNum { get; set; }
        [FieldName(CustomerAddresses.Zip)]
        public string Zip { get; set; }
    }


    public class ARPaymentsCriteria : IdoCriteria
    {
        public ARPaymentsCriteria()
            : base(ARPayments.IDO_NAME)
        {
        }
        [FieldName(ARPayments.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ARPayments.BankCode)]
        public string BankCode { get; set; }
        [FieldName(ARPayments.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(ARPayments.BalMethod)]
        public string BalMethod { get; set; }
        [FieldName(ARPayments.CustomerName)]
        public string CustomerName { get; set; }
        [FieldName(ARPayments.CheckNum)]
        public string CheckNum { get; set; }
        [FieldName(ARPayments.CreditMemoNum)]
        public string CreditMemoNum { get; set; }
        [FieldName(ARPayments.DecimalPlaces)]
        public string DecimalPlaces { get; set; }
        [FieldName(ARPayments.PayTypeCode)]
        public string PayTypeCode { get; set; }
        [FieldName(ARPayments.CustNum)]
        public string CustNum { get; set; }
        [FieldName(ARPayments.DepositDate)]
        public DateTime DepositDate { get; set; }
        [FieldName(ARPayments.RemainingAmt)]
        public string RemainingAmt { get; set; }
        [FieldName(ARPayments.EnablePrepaidAmt)]
        public string EnablePrepaidAmt { get; set; }
        [FieldName(ARPayments.AppliedAmt)]
        public string AppliedAmt { get; set; }
        [FieldName(ARPayments.Message)]
        public string Message { get; set; }
        [FieldName(ARPayments.PayTypeDescription)]
        public string PayTypeDescription { get; set; }
        [FieldName(ARPayments.Description)]
        public string Description { get; set; }
        [FieldName(ARPayments.DomesticCheckAmt)]
        public decimal CheckAmt { get; set; }
        [FieldName(ARPayments.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(ARPayments.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(ARPayments.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(ARPayments.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ARPayments.RecptDate)]
        public DateTime RecptDate { get; set; }
        [FieldName(ARPayments.Ref)]
        public string Ref { get; set; }
        [FieldName(ARPayments.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(ARPayments.TransferCash)]
        public string TransferCash { get; set; }
    }

    public class IdoCustomerOrderItemLogsCriteria : IdoCriteria
    {
        public IdoCustomerOrderItemLogsCriteria()
            : base(IdoCustomerOrderItemLogs.IDO_NAME)
        {
        }
        [FieldName(IdoCustomerOrderItemLogs.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.ActivityDate)]
        public DateTime ActivityDate { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.ActivitySeq)]
        public string ActivitySeq { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.CoDiscChg)]
        public string CoDiscChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.CoLine)]
        public string CoLine { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.CoNum)]
        public string CoNum { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.CoRelease)]
        public string CoRelease { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerCoDiscChg)]
        public string DerCoDiscChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerDiscChg)]
        public string DerDiscChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerNetValue)]
        public string DerNetValue { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerPriceAdj)]
        public string DerPriceAdj { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerPriceChg)]
        public string DerPriceChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerPriceChgConv)]
        public string DerPriceChgConv { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerQtyChg)]
        public string DerQtyChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DerQtyChgConv)]
        public string DerQtyChgConv { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DiscChg)]
        public string DiscChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.Item)]
        public string Item { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.PriceChg)]
        public string PriceChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.PriceChgConv)]
        public string PriceChgConv { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.QtyChg)]
        public string QtyChg { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.QtyChgConv)]
        public string QtyChgConv { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.TransAmt)]
        public string TransAmt { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.TransDisc)]
        public string TransDisc { get; set; }
        [FieldName(IdoCustomerOrderItemLogs.UM)]
        public string UM { get; set; }
    }

    public class IdoPurchaseOrderHistoryCriteria : IdoCriteria
    {
        public IdoPurchaseOrderHistoryCriteria()
            : base(IdoPurchaseOrderHistory.IDO_NAME)
        {
        }
        [FieldName(IdoPurchaseOrderHistory.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ActBrokerage)]
        public string ActBrokerage { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ActDuty)]
        public string ActDuty { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ActFreight)]
        public string ActFreight { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ActInsurance)]
        public string ActInsurance { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ActLocalFreight)]
        public string ActLocalFreight { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrkAllocMeth)]
        public string BrkAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrkAllocPercent)]
        public string BrkAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrkAllocType)]
        public string BrkAllocType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrkVendCurrCode)]
        public string BrkVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrokerageAmt)]
        public string BrokerageAmt { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrokerageAmtT)]
        public string BrokerageAmtT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrokerageVendName)]
        public string BrokerageVendName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BrokerageVendNum)]
        public string BrokerageVendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BuilderPoNum)]
        public string BuilderPoNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.BuilderPoOrigSite)]
        public string BuilderPoOrigSite { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Buyer)]
        public string Buyer { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ContainsTaxFreeMatls)]
        public string ContainsTaxFreeMatls { get; set; }
        [FieldName(IdoPurchaseOrderHistory.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Datefld)]
        public string Datefld { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DelTermDesc)]
        public string DelTermDesc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerExistLine)]
        public string DerExistLine { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerExistRelease)]
        public string DerExistRelease { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerNULLValue)]
        public string DerNULLValue { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerPchChgNum)]
        public string DerPchChgNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerPchStat)]
        public string DerPchStat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerPoChgNum)]
        public string DerPoChgNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DerReadOnlyRecord)]
        public string DerReadOnlyRecord { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DistDate)]
        public DateTime DistDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DropSeq)]
        public string DropSeq { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DropShipNo)]
        public string DropShipNo { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyAllocMeth)]
        public string DutyAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyAllocPercent)]
        public string DutyAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyAllocType)]
        public string DutyAllocType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyAmt)]
        public string DutyAmt { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyAmtT)]
        public string DutyAmtT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyVendCurrCode)]
        public string DutyVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyVendName)]
        public string DutyVendName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.DutyVendNum)]
        public string DutyVendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EffDate)]
        public DateTime EffDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EstBrokerage)]
        public string EstBrokerage { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EstDuty)]
        public string EstDuty { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EstFreight)]
        public string EstFreight { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EstInsurance)]
        public string EstInsurance { get; set; }
        [FieldName(IdoPurchaseOrderHistory.EstLocalFreight)]
        public string EstLocalFreight { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ExpDate)]
        public DateTime ExpDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FixedRate)]
        public decimal FixedRate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Fob)]
        public string Fob { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FormatedShipToAddress)]
        public string FormatedShipToAddress { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FormatedVendAddress)]
        public string FormatedVendAddress { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FreightT)]
        public string FreightT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FreightVendName)]
        public string FreightVendName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FreightVendNum)]
        public string FreightVendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtAllocMeth)]
        public string FrtAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtAllocPercent)]
        public string FrtAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtAllocType)]
        public string FrtAllocType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtTaxCode1)]
        public string FrtTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtTaxCode2)]
        public string FrtTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.FrtVendCurrCode)]
        public string FrtVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Ftx1Description)]
        public string Ftx1Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Ftx2Description)]
        public string Ftx2Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.IncludeTaxInCost)]
        public string IncludeTaxInCost { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsAllocMeth)]
        public string InsAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsAllocPercent)]
        public string InsAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsAllocType)]
        public string InsAllocType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsuranceAmt)]
        public string InsuranceAmt { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsuranceAmtT)]
        public string InsuranceAmtT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsVendCurrCode)]
        public string InsVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsVendName)]
        public string InsVendName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InsVendNum)]
        public string InsVendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InvNum)]
        public string InvNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocalFreightAmt)]
        public string LocalFreightAmt { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocalFreightAmtT)]
        public string LocalFreightAmtT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtAllocMeth)]
        public string LocFrtAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtAllocPercent)]
        public string LocFrtAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtAllocType)]
        public string LocFrtAllocType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtVendCurrCode)]
        public string LocFrtVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtVendName)]
        public string LocFrtVendName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.LocFrtVendNum)]
        public string LocFrtVendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Logifld)]
        public string Logifld { get; set; }
        [FieldName(IdoPurchaseOrderHistory.MChargesT)]
        public string MChargesT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.MiscCharges)]
        public string MiscCharges { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Msc1Description)]
        public string Msc1Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Msc2Description)]
        public string Msc2Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.MscTaxCode1)]
        public string MscTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.MscTaxCode2)]
        public string MscTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoPurchaseOrderHistory.OrderDate)]
        public DateTime OrderDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PchChgNum)]
        public string PchChgNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PchStat)]
        public string PchStat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PoCost)]
        public string PoCost { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PrepaidAmt)]
        public string PrepaidAmt { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PrepaidT)]
        public string PrepaidT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.PrintPrice)]
        public string PrintPrice { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoPurchaseOrderHistory.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ReqNum)]
        public string ReqNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoPurchaseOrderHistory.SalesTax)]
        public string SalesTax { get; set; }
        [FieldName(IdoPurchaseOrderHistory.SalesTax2)]
        public string SalesTax2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.SalesTaxT)]
        public string SalesTaxT { get; set; }
        [FieldName(IdoPurchaseOrderHistory.SalesTaxT2)]
        public string SalesTaxT2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ShipAddr)]
        public string ShipAddr { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.ShipCodeDesc)]
        public string ShipCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.SupplyWebPoStat)]
        public string SupplyWebPoStat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TermsCodeDesc)]
        public string TermsCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TransNat2Desc)]
        public string TransNat2Desc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.TransNatDesc)]
        public string TransNatDesc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Tx1Description)]
        public string Tx1Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Tx2Description)]
        public string Tx2Description { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Type)]
        public string Type { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VadName)]
        public string VadName { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendCatDesc)]
        public string VendCatDesc { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendCategory)]
        public string VendCategory { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendContact)]
        public string VendContact { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendCurrCode)]
        public string VendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendFaxNum)]
        public string VendFaxNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendLcrNum)]
        public string VendLcrNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendNum)]
        public string VendNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendOrder)]
        public string VendOrder { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendPhone)]
        public string VendPhone { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendTelexNum)]
        public string VendTelexNum { get; set; }
        [FieldName(IdoPurchaseOrderHistory.VendType)]
        public string VendType { get; set; }
        [FieldName(IdoPurchaseOrderHistory.Whse)]
        public string Whse { get; set; }
        [FieldName(IdoPurchaseOrderHistory.WhsName)]
        public string WhsName { get; set; }
    }
    public class IdoCustomerOrderHistoryCriteria : IdoCriteria
    {
        public IdoCustomerOrderHistoryCriteria()
            : base(IdoCustomerOrderHistory.IDO_NAME)
        {
        }
        [FieldName(IdoCustomerOrderHistory.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoCustomerOrderHistory.ApsPullUp)]
        public string ApsPullUp { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cad01Name)]
        public string Cad01Name { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cad0CorpAddress)]
        public string Cad0CorpAddress { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cad0CorpCust)]
        public string Cad0CorpCust { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cad0CurrCode)]
        public string Cad0CurrCode { get; set; }
        [FieldName(IdoCustomerOrderHistory.CadCurrCode)]
        public string CadCurrCode { get; set; }
        [FieldName(IdoCustomerOrderHistory.CadName)]
        public string CadName { get; set; }
        [FieldName(IdoCustomerOrderHistory.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.CloseDate)]
        public DateTime CloseDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.ConfigId)]
        public string ConfigId { get; set; }
        [FieldName(IdoCustomerOrderHistory.Contact)]
        public string Contact { get; set; }
        [FieldName(IdoCustomerOrderHistory.CoNum)]
        public string CoNum { get; set; }
        [FieldName(IdoCustomerOrderHistory.ConvertType)]
        public string ConvertType { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cost)]
        public string Cost { get; set; }
        [FieldName(IdoCustomerOrderHistory.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cus01Contact3)]
        public string Cus01Contact3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cus01Phone3)]
        public string Cus01Phone3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cus0Contact3)]
        public string Cus0Contact3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Cus0Phone3)]
        public string Cus0Phone3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.CusContact2)]
        public string CusContact2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.CusPhone2)]
        public string CusPhone2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.CustNum)]
        public string CustNum { get; set; }
        [FieldName(IdoCustomerOrderHistory.CustPo)]
        public string CustPo { get; set; }
        [FieldName(IdoCustomerOrderHistory.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(IdoCustomerOrderHistory.CustType)]
        public string CustType { get; set; }
        [FieldName(IdoCustomerOrderHistory.Datefld)]
        public string Datefld { get; set; }
        [FieldName(IdoCustomerOrderHistory.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(IdoCustomerOrderHistory.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoCustomerOrderHistory.Disc)]
        public string Disc { get; set; }
        [FieldName(IdoCustomerOrderHistory.DltDescription)]
        public string DltDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.EdiOrder)]
        public string EdiOrder { get; set; }
        [FieldName(IdoCustomerOrderHistory.EffDate)]
        public DateTime EffDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.EndUserType)]
        public string EndUserType { get; set; }
        [FieldName(IdoCustomerOrderHistory.EntDescription)]
        public string EntDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.EstNum)]
        public string EstNum { get; set; }
        [FieldName(IdoCustomerOrderHistory.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoCustomerOrderHistory.ExpDate)]
        public DateTime ExpDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.ExportType)]
        public string ExportType { get; set; }
        [FieldName(IdoCustomerOrderHistory.ExternalConfirmationRef)]
        public string ExternalConfirmationRef { get; set; }
        [FieldName(IdoCustomerOrderHistory.FixedRate)]
        public string FixedRate { get; set; }
        [FieldName(IdoCustomerOrderHistory.FormatBillToAddress)]
        public string FormatBillToAddress { get; set; }
        [FieldName(IdoCustomerOrderHistory.FormatShipToAddress)]
        public string FormatShipToAddress { get; set; }
        [FieldName(IdoCustomerOrderHistory.FovhdCostT)]
        public string FovhdCostT { get; set; }
        [FieldName(IdoCustomerOrderHistory.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoCustomerOrderHistory.FrtTaxCode1)]
        public string FrtTaxCode1 { get; set; }
        [FieldName(IdoCustomerOrderHistory.FrtTaxCode1Desc)]
        public string FrtTaxCode1Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.FrtTaxCode2)]
        public string FrtTaxCode2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.FrtTaxCode2Desc)]
        public string FrtTaxCode2Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.IncludeTaxInPrice)]
        public string IncludeTaxInPrice { get; set; }
        [FieldName(IdoCustomerOrderHistory.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoCustomerOrderHistory.IsExternal)]
        public string IsExternal { get; set; }
        [FieldName(IdoCustomerOrderHistory.LbrCostT)]
        public string LbrCostT { get; set; }
        [FieldName(IdoCustomerOrderHistory.LcrNum)]
        public string LcrNum { get; set; }
        [FieldName(IdoCustomerOrderHistory.Logifld)]
        public string Logifld { get; set; }
        [FieldName(IdoCustomerOrderHistory.MatlCostT)]
        public string MatlCostT { get; set; }
        [FieldName(IdoCustomerOrderHistory.MiscCharges)]
        public string MiscCharges { get; set; }
        [FieldName(IdoCustomerOrderHistory.MscTaxCode1)]
        public string MscTaxCode1 { get; set; }
        [FieldName(IdoCustomerOrderHistory.MscTaxCode1Desc)]
        public string MscTaxCode1Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.MscTaxCode2)]
        public string MscTaxCode2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.MscTaxCode2Desc)]
        public string MscTaxCode2Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoCustomerOrderHistory.OrderDate)]
        public DateTime OrderDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.OrderSource)]
        public string OrderSource { get; set; }
        [FieldName(IdoCustomerOrderHistory.OrigSite)]
        public string OrigSite { get; set; }
        [FieldName(IdoCustomerOrderHistory.OutCostT)]
        public string OutCostT { get; set; }
        [FieldName(IdoCustomerOrderHistory.Phone)]
        public string Phone { get; set; }
        [FieldName(IdoCustomerOrderHistory.PrcDescription)]
        public string PrcDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.PrepaidAmt)]
        public string PrepaidAmt { get; set; }
        [FieldName(IdoCustomerOrderHistory.Price)]
        public decimal Price { get; set; }
        [FieldName(IdoCustomerOrderHistory.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(IdoCustomerOrderHistory.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoCustomerOrderHistory.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.QtyPackages)]
        public string QtyPackages { get; set; }
        [FieldName(IdoCustomerOrderHistory.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoCustomerOrderHistory.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoCustomerOrderHistory.SalesTax)]
        public decimal SalesTax { get; set; }
        [FieldName(IdoCustomerOrderHistory.SalesTax2)]
        public decimal SalesTax2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.ShcDescription)]
        public string ShcDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(IdoCustomerOrderHistory.ShipEarly)]
        public string ShipEarly { get; set; }
        [FieldName(IdoCustomerOrderHistory.ShipPartial)]
        public string ShipPartial { get; set; }
        [FieldName(IdoCustomerOrderHistory.SLCoSlsComms)]
        public string SLCoSlsComms { get; set; }
        [FieldName(IdoCustomerOrderHistory.Slsman)]
        public string Slsman { get; set; }
        [FieldName(IdoCustomerOrderHistory.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoCustomerOrderHistory.TakenBy)]
        public string TakenBy { get; set; }
        [FieldName(IdoCustomerOrderHistory.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoCustomerOrderHistory.TaxCode1Desc)]
        public string TaxCode1Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.TaxCode2Desc)]
        public string TaxCode2Desc { get; set; }
        [FieldName(IdoCustomerOrderHistory.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(IdoCustomerOrderHistory.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoCustomerOrderHistory.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoCustomerOrderHistory.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(IdoCustomerOrderHistory.TrmDescription)]
        public string TrmDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.TrnDescription)]
        public string TrnDescription { get; set; }
        [FieldName(IdoCustomerOrderHistory.Type)]
        public string Type { get; set; }
        [FieldName(IdoCustomerOrderHistory.UseExchRate)]
        public string UseExchRate { get; set; }
        [FieldName(IdoCustomerOrderHistory.VovhdCostT)]
        public string VovhdCostT { get; set; }
        [FieldName(IdoCustomerOrderHistory.Weight)]
        public decimal Weight { get; set; }
        [FieldName(IdoCustomerOrderHistory.Whse)]
        public string Whse { get; set; }
    }
    public class IdoCustomerOrderLinesHistoryCriteria : IdoCriteria
    {
        public IdoCustomerOrderLinesHistoryCriteria()
            : base(IdoCustomerOrderLinesHistory.IDO_NAME)
        {
        }
        [FieldName(IdoCustomerOrderLinesHistory.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.AdrCreditHold)]
        public string AdrCreditHold { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.AdrCurrCode)]
        public string AdrCurrCode { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.AdrCurrdescription)]
        public string AdrCurrdescription { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.AdrName)]
        public string AdrName { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.BrkQty_1)]
        public string BrkQty_1 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.BrkQty_2)]
        public string BrkQty_2 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.BrkQty_3)]
        public string BrkQty_3 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.BrkQty_4)]
        public string BrkQty_4 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.BrkQty_5)]
        public string BrkQty_5 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblBlanketQtyConv)]
        public string CblBlanketQtyConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblCoLine)]
        public string CblCoLine { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblContPriceConv)]
        public string CblContPriceConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblEffDate)]
        public DateTime CblEffDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblExpDate)]
        public DateTime CblExpDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblItem)]
        public string CblItem { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CblUM)]
        public string CblUM { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotal)]
        public string CgsTotal { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotalFovhd)]
        public string CgsTotalFovhd { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotalLbr)]
        public string CgsTotalLbr { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotalMatl)]
        public string CgsTotalMatl { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotalOut)]
        public string CgsTotalOut { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CgsTotalVovhd)]
        public string CgsTotalVovhd { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoCloseDate)]
        public DateTime CoCloseDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoCost)]
        public decimal CoCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoCustPo)]
        public string CoCustPo { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoEdiOrder)]
        public string CoEdiOrder { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoExchRate)]
        public decimal CoExchRate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoLine)]
        public string CoLine { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CommCode)]
        public string CommCode { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ComSupplQtyReq)]
        public string ComSupplQtyReq { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ConfigId)]
        public string ConfigId { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ConsNum)]
        public string ConsNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoNum)]
        public string CoNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoOrderDate)]
        public DateTime CoOrderDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoOrigSite)]
        public string CoOrigSite { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoPrice)]
        public decimal CoPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoRelease)]
        public string CoRelease { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CosDoNum)]
        public string CosDoNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CosQtyInvoiced)]
        public string CosQtyInvoiced { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CosQtyReturned)]
        public string CosQtyReturned { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CosQtyShipped)]
        public string CosQtyShipped { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Cost)]
        public decimal Cost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoStat)]
        public string CoStat { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CostConv)]
        public string CostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoTaxCode2)]
        public string CoTaxCode2 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoTermsCode)]
        public string CoTermsCode { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoType)]
        public string CoType { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CoUseExchRate)]
        public string CoUseExchRate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CurrencyPlaces)]
        public string CurrencyPlaces { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CusCustType)]
        public string CusCustType { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CustItem)]
        public string CustItem { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CustNum)]
        public string CustNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CustPo)]
        public string CustPo { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.CusUseExchRate)]
        public string CusUseExchRate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerCanChgShipSite)]
        public string DerCanChgShipSite { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerDropShipAddress)]
        public string DerDropShipAddress { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerDropShipCustAddr)]
        public string DerDropShipCustAddr { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerExtPrice)]
        public string DerExtPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerFovhdCostConv)]
        public string DerFovhdCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerFovhdExtended)]
        public string DerFovhdExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerLbrExtended)]
        public string DerLbrExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerMatlExtended)]
        public string DerMatlExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerNetPrice)]
        public decimal DerNetPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerOrigQtyOrderedConv)]
        public string DerOrigQtyOrderedConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerOutExtended)]
        public string DerOutExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerProgBillTotalBilled)]
        public string DerProgBillTotalBilled { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerProgBillTotalInvoiced)]
        public string DerProgBillTotalInvoiced { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerQtyInvoicedConv)]
        public string DerQtyInvoicedConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerQtyShippedConv)]
        public string DerQtyShippedConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerQtyToInvoice)]
        public string DerQtyToInvoice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerQtyToShip)]
        public string DerQtyToShip { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerReadOnlyRecord)]
        public string DerReadOnlyRecord { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerShiIteActive)]
        public string DerShiIteActive { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerTotCost)]
        public decimal DerTotCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerTotExtended)]
        public decimal DerTotExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DerVovhdExtended)]
        public string DerVovhdExtended { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Description)]
        public string Description { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Disc)]
        public string Disc { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DltDescription)]
        public string DltDescription { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.EcCode)]
        public string EcCode { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ExportValue)]
        public decimal ExportValue { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ExtendedCost)]
        public decimal ExtendedCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ExtendedPrice)]
        public decimal ExtendedPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ExternalReservationRef)]
        public string ExternalReservationRef { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.FeatStr)]
        public string FeatStr { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.FovhdCost)]
        public string FovhdCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.FovhdCostConv)]
        public string FovhdCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItDescription)]
        public string ItDescription { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Item)]
        public string Item { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.IteWhsQtyOnHand)]
        public string IteWhsQtyOnHand { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItKit)]
        public string ItKit { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItLotTracked)]
        public string ItLotTracked { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItPlanFlag)]
        public string ItPlanFlag { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItSerialTracked)]
        public string ItSerialTracked { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItUM)]
        public string ItUM { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ItUWsPrice)]
        public decimal ItUWsPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.LbrCost)]
        public decimal LbrCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.LbrCostConv)]
        public string LbrCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Margin)]
        public string Margin { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.MarginPercent)]
        public string MarginPercent { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.MatlCost)]
        public string MatlCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.MatlCostConv)]
        public string MatlCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Origin)]
        public string Origin { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.OutCost)]
        public decimal OutCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.OutCostConv)]
        public string OutCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PickDate)]
        public DateTime PickDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PrgBillApp)]
        public string PrgBillApp { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PrgBillTot)]
        public string PrgBillTot { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Price)]
        public decimal Price { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PricecodeDesc)]
        public string PricecodeDesc { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PriceConv)]
        public string PriceConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PrintKitComponents)]
        public string PrintKitComponents { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.PromiseDate)]
        public DateTime PromiseDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyInvoiced)]
        public int QtyInvoiced { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyOrdered)]
        public int QtyOrdered { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyOrderedConv)]
        public string QtyOrderedConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyPacked)]
        public int QtyPacked { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyReady)]
        public int QtyReady { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyReturned)]
        public int QtyReturned { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.QtyShipped)]
        public int QtyShipped { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RefNum)]
        public string RefNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RefType)]
        public string RefType { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ReleaseDate)]
        public DateTime ReleaseDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Reprice)]
        public string Reprice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RmaLine)]
        public string RmaLine { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RmaNum)]
        public string RmaNum { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ShiIteActive)]
        public string ShiIteActive { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ShipDate)]
        public DateTime ShipDate { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.ShipSite)]
        public string ShipSite { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.SLProgbills)]
        public string SLProgbills { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.SLRsvdInvs)]
        public string SLRsvdInvs { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.SupplQtyConvFactor)]
        public string SupplQtyConvFactor { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.SyncReqd)]
        public string SyncReqd { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Tc1Description)]
        public string Tc1Description { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Tc2Description)]
        public string Tc2Description { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TermsDescription)]
        public string TermsDescription { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Transport)]
        public string Transport { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.TrnDescription)]
        public string TrnDescription { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbNetAdjust)]
        public string UbNetAdjust { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbNewDisc)]
        public string UbNewDisc { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbNewNet)]
        public string UbNewNet { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbNewPrice)]
        public string UbNewPrice { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbOldNet)]
        public string UbOldNet { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbProgBillAmount)]
        public string UbProgBillAmount { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbQtyToAdjust)]
        public string UbQtyToAdjust { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbSelect)]
        public string UbSelect { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UbSetItemCust)]
        public string UbSetItemCust { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UM)]
        public string UM { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.UnitWeight)]
        public decimal UnitWeight { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.VovhdCost)]
        public decimal VovhdCost { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.VovhdCostConv)]
        public string VovhdCostConv { get; set; }
        [FieldName(IdoCustomerOrderLinesHistory.Whse)]
        public string Whse { get; set; }
    }
    public class IdoApTransactionsCriteria : IdoCriteria
    {
        public IdoApTransactionsCriteria()
            : base(IdoApTransactions.IDO_NAME)
        {
        }
        [FieldName(IdoApTransactions.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoApTransactions.ApAcct)]
        public string ApAcct { get; set; }
        [FieldName(IdoApTransactions.ApAcctUnit1)]
        public string ApAcctUnit1 { get; set; }
        [FieldName(IdoApTransactions.ApAcctUnit2)]
        public string ApAcctUnit2 { get; set; }
        [FieldName(IdoApTransactions.ApAcctUnit3)]
        public string ApAcctUnit3 { get; set; }
        [FieldName(IdoApTransactions.ApAcctUnit4)]
        public string ApAcctUnit4 { get; set; }
        [FieldName(IdoApTransactions.Authorizer)]
        public string Authorizer { get; set; }
        [FieldName(IdoApTransactions.AuthStatus)]
        public string AuthStatus { get; set; }
        [FieldName(IdoApTransactions.BrokerageAmt)]
        public string BrokerageAmt { get; set; }
        [FieldName(IdoApTransactions.BuilderPoNum)]
        public string BuilderPoNum { get; set; }
        [FieldName(IdoApTransactions.BuilderPoOrigSite)]
        public string BuilderPoOrigSite { get; set; }
        [FieldName(IdoApTransactions.BuilderVoucher)]
        public string BuilderVoucher { get; set; }
        [FieldName(IdoApTransactions.BuilderVoucherOrigSite)]
        public string BuilderVoucherOrigSite { get; set; }
        [FieldName(IdoApTransactions.ChaAccessUnit1)]
        public string ChaAccessUnit1 { get; set; }
        [FieldName(IdoApTransactions.ChaAccessUnit2)]
        public string ChaAccessUnit2 { get; set; }
        [FieldName(IdoApTransactions.ChaAccessUnit3)]
        public string ChaAccessUnit3 { get; set; }
        [FieldName(IdoApTransactions.ChaAccessUnit4)]
        public string ChaAccessUnit4 { get; set; }
        [FieldName(IdoApTransactions.ChaDescription)]
        public string ChaDescription { get; set; }
        [FieldName(IdoApTransactions.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoApTransactions.CurrPlaces)]
        public string CurrPlaces { get; set; }
        [FieldName(IdoApTransactions.DerDistExists)]
        public string DerDistExists { get; set; }
        [FieldName(IdoApTransactions.DiscAmt)]
        public string DiscAmt { get; set; }
        [FieldName(IdoApTransactions.DiscDate)]
        public DateTime DiscDate { get; set; }
        [FieldName(IdoApTransactions.DiscDays)]
        public int DiscDays { get; set; }
        [FieldName(IdoApTransactions.DiscPct)]
        public decimal DiscPct { get; set; }
        [FieldName(IdoApTransactions.DistDate)]
        public DateTime DistDate { get; set; }
        [FieldName(IdoApTransactions.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoApTransactions.DueDays)]
        public string DueDays { get; set; }
        [FieldName(IdoApTransactions.DutyAmt)]
        public decimal DutyAmt { get; set; }
        [FieldName(IdoApTransactions.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoApTransactions.FixedRate)]
        public decimal FixedRate { get; set; }
        [FieldName(IdoApTransactions.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoApTransactions.GrnNum)]
        public string GrnNum { get; set; }
        [FieldName(IdoApTransactions.IncludesTax)]
        public string IncludesTax { get; set; }
        [FieldName(IdoApTransactions.IncludeTaxInCost)]
        public string IncludeTaxInCost { get; set; }
        [FieldName(IdoApTransactions.InsuranceAmt)]
        public decimal InsuranceAmt { get; set; }
        [FieldName(IdoApTransactions.InvAmt)]
        public decimal InvAmt { get; set; }
        [FieldName(IdoApTransactions.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(IdoApTransactions.InvNum)]
        public string InvNum { get; set; }
        [FieldName(IdoApTransactions.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoApTransactions.LocFrtAmt)]
        public string LocFrtAmt { get; set; }
        [FieldName(IdoApTransactions.MiscCharges)]
        public decimal MiscCharges { get; set; }
        [FieldName(IdoApTransactions.NonDiscAmt)]
        public decimal NonDiscAmt { get; set; }
        [FieldName(IdoApTransactions.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoApTransactions.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoApTransactions.PostFromPo)]
        public string PostFromPo { get; set; }
        [FieldName(IdoApTransactions.PreRegister)]
        public string PreRegister { get; set; }
        [FieldName(IdoApTransactions.ProxCode)]
        public string ProxCode { get; set; }
        [FieldName(IdoApTransactions.ProxDay)]
        public string ProxDay { get; set; }
        [FieldName(IdoApTransactions.PurchAmt)]
        public decimal PurchAmt { get; set; }
        [FieldName(IdoApTransactions.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoApTransactions.Ref)]
        public string Ref { get; set; }
        [FieldName(IdoApTransactions.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoApTransactions.SalesTax)]
        public string SalesTax { get; set; }
        [FieldName(IdoApTransactions.SalesTax_2)]
        public string SalesTax_2 { get; set; }
        [FieldName(IdoApTransactions.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(IdoApTransactions.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoApTransactions.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoApTransactions.Tc1Description)]
        public string Tc1Description { get; set; }
        [FieldName(IdoApTransactions.Tc2Description)]
        public string Tc2Description { get; set; }
        [FieldName(IdoApTransactions.Txt)]
        public string Txt { get; set; }
        [FieldName(IdoApTransactions.Type)]
        public string Type { get; set; }
        [FieldName(IdoApTransactions.UbEnable)]
        public string UbEnable { get; set; }
        [FieldName(IdoApTransactions.UbEnableSalesTax)]
        public string UbEnableSalesTax { get; set; }
        [FieldName(IdoApTransactions.UbEnableSalesTax2)]
        public string UbEnableSalesTax2 { get; set; }
        [FieldName(IdoApTransactions.UbGenerateDistributions)]
        public string UbGenerateDistributions { get; set; }
        [FieldName(IdoApTransactions.UbToSite)]
        public string UbToSite { get; set; }
        [FieldName(IdoApTransactions.UbVendNum)]
        public string UbVendNum { get; set; }
        [FieldName(IdoApTransactions.VenCurrCode)]
        public string VenCurrCode { get; set; }
        [FieldName(IdoApTransactions.VendaddrName)]
        public string VendaddrName { get; set; }
        [FieldName(IdoApTransactions.VendNum)]
        public string VendNum { get; set; }
        [FieldName(IdoApTransactions.Voucher)]
        public string Voucher { get; set; }
    }
    public class ItemWarehouseCriteria : IdoCriteria
    {
        public ItemWarehouseCriteria()
            : base(ItemWarehouse.IDO_NAME)
        {
        }
        [FieldName(ItemWarehouse.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ItemWarehouse.Item)]
        public string Item { get; set; }
        [FieldName(ItemWarehouse.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(ItemWarehouse.QtyMrb)]
        public int QtyMrb { get; set; }
        [FieldName(ItemWarehouse.QtyOnHand)]
        public int QtyOnHand { get; set; }
        [FieldName(ItemWarehouse.QtyOrdered)]
        public int QtyOrdered { get; set; }
        [FieldName(ItemWarehouse.QtyPurchasedYtd)]
        public int QtyPurchasedYtd { get; set; }
        [FieldName(ItemWarehouse.QtyReorder)]
        public int QtyReorder { get; set; }
        [FieldName(ItemWarehouse.QtySoldYtd)]
        public int QtySoldYtd { get; set; }
        [FieldName(ItemWarehouse.QtyWip)]
        public int QtyWip { get; set; }
        [FieldName(ItemWarehouse.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ItemWarehouse.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(ItemWarehouse.SalesPtd)]
        public decimal SalesPtd { get; set; }
        [FieldName(ItemWarehouse.SalesYtd)]
        public decimal SalesYtd { get; set; }
        [FieldName(ItemWarehouse.TotalQtyOnHand)]
        public int TotalQtyOnHand { get; set; }
        [FieldName(ItemWarehouse.TotalQtyReserved)]
        public int TotalQtyReserved { get; set; }
        [FieldName(ItemWarehouse.UM)]
        public string UM { get; set; }
        [FieldName(ItemWarehouse.Whse)]
        public string Whse { get; set; }
        [FieldName(ItemWarehouse.WhseName)]
        public string WhseName { get; set; }
        [FieldName(ItemWarehouse.ItemSuffix)]
        public string ItemSuffix { get; set; }
    }
    public class InvoiceLineItemAllsCriteria : IdoCriteria
    {
        public InvoiceLineItemAllsCriteria()
            : base(InvoiceLineItemAlls.IDO_NAME)
        {
        }
        [FieldName(InvoiceLineItemAlls.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(InvoiceLineItemAlls.OrderLine)]
        public string OrderLine { get; set; }
        [FieldName(InvoiceLineItemAlls.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(InvoiceLineItemAlls.OrderRelease)]
        public string OrderRelease { get; set; }
        [FieldName(InvoiceLineItemAlls.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(InvoiceLineItemAlls.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(InvoiceLineItemAlls.CustaddrCurrCode)]
        public string CustaddrCurrCode { get; set; }
        [FieldName(InvoiceLineItemAlls.CustaddrCustNum)]
        public string CustaddrCustNum { get; set; }
        [FieldName(InvoiceLineItemAlls.CustomerPo)]
        public string CustomerPo { get; set; }
        [FieldName(InvoiceLineItemAlls.DerCoNum)]
        public string DerCoNum { get; set; }
        [FieldName(InvoiceLineItemAlls.Description)]
        public string Description { get; set; }
        [FieldName(InvoiceLineItemAlls.ExtendedPrice)]
        public string ExtendedPrice { get; set; }
        [FieldName(InvoiceLineItemAlls.InvoiceDate)]
        public DateTime InvoiceDate { get; set; }
        [FieldName(InvoiceLineItemAlls.DerInvNum)]
        public string DerInvNum { get; set; }
        [FieldName(InvoiceLineItemAlls.InvhdrBillType)]
        public string InvhdrBillType { get; set; }
        [FieldName(InvoiceLineItemAlls.InvhdrCoNum)]
        public string InvhdrCoNum { get; set; }
        [FieldName(InvoiceLineItemAlls.CustNum)]
        public string CustNum { get; set; }
        [FieldName(InvoiceLineItemAlls.InvhdrExchRate)]
        public string InvhdrExchRate { get; set; }
        [FieldName(InvoiceLineItemAlls.TotalPrice)]
        public decimal TotalPrice { get; set; }
        [FieldName(InvoiceLineItemAlls.InvhdrSiteRef)]
        public string InvhdrSiteRef { get; set; }
        [FieldName(InvoiceLineItemAlls.Slsman)]
        public string Slsman { get; set; }
        [FieldName(InvoiceLineItemAlls.InvoiceLine)]
        public string InvoiceLine { get; set; }
        [FieldName(InvoiceLineItemAlls.InvoiceNumber)]
        public string InvoiceNumber { get; set; }
        [FieldName(InvoiceLineItemAlls.InvSeq)]
        public string InvSeq { get; set; }
        [FieldName(InvoiceLineItemAlls.Item)]
        public string Item { get; set; }
        [FieldName(InvoiceLineItemAlls.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(InvoiceLineItemAlls.Price)]
        public decimal Price { get; set; }
        [FieldName(InvoiceLineItemAlls.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(InvoiceLineItemAlls.QtyInvoiced)]
        public int QtyInvoiced { get; set; }
        [FieldName(InvoiceLineItemAlls.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(InvoiceLineItemAlls.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(InvoiceLineItemAlls.SiteRef)]
        public string SiteRef { get; set; }
    }
    public class CustomerPartNumbersCriteria : IdoCriteria
    {
        public CustomerPartNumbersCriteria()
            : base(CustomerPartNumbers.IDO_NAME)
        {
        }
        [FieldName(CustomerPartNumbers.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(CustomerPartNumbers.Item)]
        public string Item { get; set; }
        [FieldName(CustomerPartNumbers.CustomerNumber)]
        public string CustomerNumber { get; set; }
        [FieldName(CustomerPartNumbers.CustomerPartNumber)]
        public string CustomerPartNumber { get; set; }
    }
    public class JobMaterialsCriteria : IdoCriteria
    {
        public JobMaterialsCriteria()
            : base(JobMaterials.IDO_NAME)
        {
        }
        [FieldName(JobMaterials.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(JobMaterials.ACost)]
        public decimal ACost { get; set; }
        [FieldName(JobMaterials.AFovhdCost)]
        public decimal AFovhdCost { get; set; }
        [FieldName(JobMaterials.ALbrCost)]
        public decimal ALbrCost { get; set; }
        [FieldName(JobMaterials.AltGroup)]
        public string AltGroup { get; set; }
        [FieldName(JobMaterials.AltGroupRank)]
        public string AltGroupRank { get; set; }
        [FieldName(JobMaterials.AMatlCost)]
        public decimal AMatlCost { get; set; }
        [FieldName(JobMaterials.AOutCost)]
        public decimal AOutCost { get; set; }
        [FieldName(JobMaterials.AVovhdCost)]
        public decimal AVovhdCost { get; set; }
        [FieldName(JobMaterials.Backflush)]
        public string Backflush { get; set; }
        [FieldName(JobMaterials.BflushLoc)]
        public string BflushLoc { get; set; }
        [FieldName(JobMaterials.BomSeq)]
        public string BomSeq { get; set; }
        [FieldName(JobMaterials.Cost)]
        public decimal Cost { get; set; }
        [FieldName(JobMaterials.CostConv)]
        public string CostConv { get; set; }
        [FieldName(JobMaterials.DerAltGroupRankText)]
        public string DerAltGroupRankText { get; set; }
        [FieldName(JobMaterials.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(JobMaterials.DerBflushLocRequired)]
        public string DerBflushLocRequired { get; set; }
        [FieldName(JobMaterials.DerByProduct)]
        public string DerByProduct { get; set; }
        [FieldName(JobMaterials.DerCostCode)]
        public string DerCostCode { get; set; }
        [FieldName(JobMaterials.DerDelete)]
        public string DerDelete { get; set; }
        [FieldName(JobMaterials.DerExtScrap)]
        public string DerExtScrap { get; set; }
        [FieldName(JobMaterials.DerIsPSLbrPosted)]
        public string DerIsPSLbrPosted { get; set; }
        [FieldName(JobMaterials.DerItemDescription)]
        public string DerItemDescription { get; set; }
        [FieldName(JobMaterials.DerItemExist)]
        public string DerItemExist { get; set; }
        [FieldName(JobMaterials.DerItemIssueBy)]
        public string DerItemIssueBy { get; set; }
        [FieldName(JobMaterials.DerItemLotTracked)]
        public string DerItemLotTracked { get; set; }
        [FieldName(JobMaterials.DerItemRowPointer)]
        public string DerItemRowPointer { get; set; }
        [FieldName(JobMaterials.DerItemSerialTracked)]
        public string DerItemSerialTracked { get; set; }
        [FieldName(JobMaterials.DerItemTaxFreeMatl)]
        public string DerItemTaxFreeMatl { get; set; }
        [FieldName(JobMaterials.DerItemUM)]
        public string DerItemUM { get; set; }
        [FieldName(JobMaterials.DerItemUMConvFactor)]
        public string DerItemUMConvFactor { get; set; }
        [FieldName(JobMaterials.DerJobmatlRowPointer)]
        public string DerJobmatlRowPointer { get; set; }
        [FieldName(JobMaterials.DerJobRowPointer)]
        public string DerJobRowPointer { get; set; }
        [FieldName(JobMaterials.DerJobSuffix)]
        public string DerJobSuffix { get; set; }
        [FieldName(JobMaterials.DerLevel)]
        public string DerLevel { get; set; }
        [FieldName(JobMaterials.DerLoc)]
        public string DerLoc { get; set; }
        [FieldName(JobMaterials.DerLot)]
        public string DerLot { get; set; }
        [FieldName(JobMaterials.DerMatlExist)]
        public string DerMatlExist { get; set; }
        [FieldName(JobMaterials.DerMatlLotTracked)]
        public string DerMatlLotTracked { get; set; }
        [FieldName(JobMaterials.DerMatlQtyRequired)]
        public string DerMatlQtyRequired { get; set; }
        [FieldName(JobMaterials.DerMatlSerialTracked)]
        public string DerMatlSerialTracked { get; set; }
        [FieldName(JobMaterials.DerMatlSuffix)]
        public string DerMatlSuffix { get; set; }
        [FieldName(JobMaterials.DerMatlTransQty)]
        public string DerMatlTransQty { get; set; }
        [FieldName(JobMaterials.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(JobMaterials.DerOrdType)]
        public string DerOrdType { get; set; }
        [FieldName(JobMaterials.DerPlanCost)]
        public string DerPlanCost { get; set; }
        [FieldName(JobMaterials.DerPlanCostConv)]
        public string DerPlanCostConv { get; set; }
        [FieldName(JobMaterials.DerPMTCode)]
        public string DerPMTCode { get; set; }
        [FieldName(JobMaterials.DerPoVendNum)]
        public string DerPoVendNum { get; set; }
        [FieldName(JobMaterials.DerQty)]
        public int DerQty { get; set; }
        [FieldName(JobMaterials.DerQtyConv)]
        public decimal DerQtyConv { get; set; }
        [FieldName(JobMaterials.DerQtyIssuedConv)]
        public decimal DerQtyIssuedConv { get; set; }
        [FieldName(JobMaterials.DerQtyOnHand)]
        public string DerQtyOnHand { get; set; }
        [FieldName(JobMaterials.DerQtyOnHandConv)]
        public decimal DerQtyOnHandConv { get; set; }
        [FieldName(JobMaterials.DerQtyPicked)]
        public int DerQtyPicked { get; set; }
        [FieldName(JobMaterials.DerQtyToPick)]
        public int DerQtyToPick { get; set; }
        [FieldName(JobMaterials.DerReqQty)]
        public int DerReqQty { get; set; }
        [FieldName(JobMaterials.DerReqQtyConv)]
        public decimal DerReqQtyConv { get; set; }
        [FieldName(JobMaterials.DerSelected)]
        public string DerSelected { get; set; }
        [FieldName(JobMaterials.DerSequence)]
        public string DerSequence { get; set; }
        [FieldName(JobMaterials.DerSerialPrefix)]
        public string DerSerialPrefix { get; set; }
        [FieldName(JobMaterials.DerStartDate)]
        public DateTime DerStartDate { get; set; }
        [FieldName(JobMaterials.DerTransDate)]
        public DateTime DerTransDate { get; set; }
        [FieldName(JobMaterials.DerUM)]
        public string DerUM { get; set; }
        [FieldName(JobMaterials.DerUOMConvFactor)]
        public string DerUOMConvFactor { get; set; }
        [FieldName(JobMaterials.DerWC)]
        public string DerWC { get; set; }
        [FieldName(JobMaterials.DerWhse)]
        public string DerWhse { get; set; }
        [FieldName(JobMaterials.Description)]
        public string Description { get; set; }
        [FieldName(JobMaterials.EffectDate)]
        public DateTime EffectDate { get; set; }
        [FieldName(JobMaterials.Feature)]
        public string Feature { get; set; }
        [FieldName(JobMaterials.FixovhdT)]
        public string FixovhdT { get; set; }
        [FieldName(JobMaterials.Fmatlovhd)]
        public string Fmatlovhd { get; set; }
        [FieldName(JobMaterials.FovhdCost)]
        public string FovhdCost { get; set; }
        [FieldName(JobMaterials.FovhdCostConv)]
        public string FovhdCostConv { get; set; }
        [FieldName(JobMaterials.IncPrice)]
        public decimal IncPrice { get; set; }
        [FieldName(JobMaterials.IncPriceConv)]
        public decimal IncPriceConv { get; set; }
        [FieldName(JobMaterials.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(JobMaterials.Item)]
        public string Item { get; set; }
        [FieldName(JobMaterials.ItmDescription)]
        public string ItmDescription { get; set; }
        [FieldName(JobMaterials.ItmEcnTracked)]
        public string ItmEcnTracked { get; set; }
        [FieldName(JobMaterials.ItmFovhdCost)]
        public decimal ItmFovhdCost { get; set; }
        [FieldName(JobMaterials.ItmIssueBy)]
        public string ItmIssueBy { get; set; }
        [FieldName(JobMaterials.ItmItem)]
        public string ItmItem { get; set; }
        [FieldName(JobMaterials.ItmLbrCost)]
        public decimal ItmLbrCost { get; set; }
        [FieldName(JobMaterials.ItmLotTracked)]
        public string ItmLotTracked { get; set; }
        [FieldName(JobMaterials.ItmLowLevel)]
        public string ItmLowLevel { get; set; }
        [FieldName(JobMaterials.ItmMatlCost)]
        public decimal ItmMatlCost { get; set; }
        [FieldName(JobMaterials.ItmOutCost)]
        public decimal ItmOutCost { get; set; }
        [FieldName(JobMaterials.ItmPhantomFlag)]
        public string ItmPhantomFlag { get; set; }
        [FieldName(JobMaterials.ItmPlanFlag)]
        public string ItmPlanFlag { get; set; }
        [FieldName(JobMaterials.ItmPMTCode)]
        public string ItmPMTCode { get; set; }
        [FieldName(JobMaterials.ItmProductCode)]
        public string ItmProductCode { get; set; }
        [FieldName(JobMaterials.ItmRevision)]
        public string ItmRevision { get; set; }
        [FieldName(JobMaterials.ItmSerialTracked)]
        public string ItmSerialTracked { get; set; }
        [FieldName(JobMaterials.ItmTaxFreeMatl)]
        public string ItmTaxFreeMatl { get; set; }
        [FieldName(JobMaterials.ItmUM)]
        public string ItmUM { get; set; }
        [FieldName(JobMaterials.ItmVovhdCost)]
        public string ItmVovhdCost { get; set; }
        [FieldName(JobMaterials.JbrWc)]
        public string JbrWc { get; set; }
        [FieldName(JobMaterials.JbsJob)]
        public string JbsJob { get; set; }
        [FieldName(JobMaterials.JbsSuffix)]
        public string JbsSuffix { get; set; }
        [FieldName(JobMaterials.JitemDescription)]
        public string JitemDescription { get; set; }
        [FieldName(JobMaterials.JitemLowLevel)]
        public string JitemLowLevel { get; set; }
        [FieldName(JobMaterials.JitemPhantomFlag)]
        public string JitemPhantomFlag { get; set; }
        [FieldName(JobMaterials.JitemPlanFlag)]
        public string JitemPlanFlag { get; set; }
        [FieldName(JobMaterials.JitemTrackEcn)]
        public string JitemTrackEcn { get; set; }
        [FieldName(JobMaterials.Job)]
        public string Job { get; set; }
        [FieldName(JobMaterials.JobDescription)]
        public string JobDescription { get; set; }
        [FieldName(JobMaterials.JobExportType)]
        public string JobExportType { get; set; }
        [FieldName(JobMaterials.JobItem)]
        public string JobItem { get; set; }
        [FieldName(JobMaterials.JobJobDate)]
        public DateTime JobJobDate { get; set; }
        [FieldName(JobMaterials.JobStat)]
        public string JobStat { get; set; }
        [FieldName(JobMaterials.JobType)]
        public string JobType { get; set; }
        [FieldName(JobMaterials.JshEndDate)]
        public DateTime JshEndDate { get; set; }
        [FieldName(JobMaterials.LbrCost)]
        public decimal LbrCost { get; set; }
        [FieldName(JobMaterials.LbrCostConv)]
        public decimal LbrCostConv { get; set; }
        [FieldName(JobMaterials.MatlBflushLoc)]
        public string MatlBflushLoc { get; set; }
        [FieldName(JobMaterials.MatlCost)]
        public decimal MatlCost { get; set; }
        [FieldName(JobMaterials.MatlCostConv)]
        public decimal MatlCostConv { get; set; }
        [FieldName(JobMaterials.MatlDescription)]
        public string MatlDescription { get; set; }
        [FieldName(JobMaterials.MatlJob)]
        public string MatlJob { get; set; }
        [FieldName(JobMaterials.MatlKit)]
        public string MatlKit { get; set; }
        [FieldName(JobMaterials.MatlLotTracked)]
        public string MatlLotTracked { get; set; }
        [FieldName(JobMaterials.MatlLowLevel)]
        public string MatlLowLevel { get; set; }
        [FieldName(JobMaterials.MatlPhantomFlag)]
        public string MatlPhantomFlag { get; set; }
        [FieldName(JobMaterials.MatlPMTCode)]
        public string MatlPMTCode { get; set; }
        [FieldName(JobMaterials.MatlQty)]
        public int MatlQty { get; set; }
        [FieldName(JobMaterials.MatlQtyConv)]
        public decimal MatlQtyConv { get; set; }
        [FieldName(JobMaterials.MatlRevision)]
        public string MatlRevision { get; set; }
        [FieldName(JobMaterials.MatlSerialTracked)]
        public string MatlSerialTracked { get; set; }
        [FieldName(JobMaterials.MatlStat)]
        public string MatlStat { get; set; }
        [FieldName(JobMaterials.MatlSuffix)]
        public string MatlSuffix { get; set; }
        [FieldName(JobMaterials.MatlType)]
        public string MatlType { get; set; }
        [FieldName(JobMaterials.MatlUM)]
        public string MatlUM { get; set; }
        [FieldName(JobMaterials.NewSequence)]
        public string NewSequence { get; set; }
        [FieldName(JobMaterials.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(JobMaterials.ObsDate)]
        public DateTime ObsDate { get; set; }
        [FieldName(JobMaterials.OperNum)]
        public string OperNum { get; set; }
        [FieldName(JobMaterials.OptCode)]
        public string OptCode { get; set; }
        [FieldName(JobMaterials.OrdType)]
        public string OrdType { get; set; }
        [FieldName(JobMaterials.OutCost)]
        public decimal OutCost { get; set; }
        [FieldName(JobMaterials.OutCostConv)]
        public decimal OutCostConv { get; set; }
        [FieldName(JobMaterials.PickDate)]
        public DateTime PickDate { get; set; }
        [FieldName(JobMaterials.PitmDescription)]
        public string PitmDescription { get; set; }
        [FieldName(JobMaterials.PlannedAlternate)]
        public string PlannedAlternate { get; set; }
        [FieldName(JobMaterials.PoUnitCost)]
        public decimal PoUnitCost { get; set; }
        [FieldName(JobMaterials.Probable)]
        public string Probable { get; set; }
        [FieldName(JobMaterials.PsiItem)]
        public string PsiItem { get; set; }
        [FieldName(JobMaterials.PsiPsNum)]
        public string PsiPsNum { get; set; }
        [FieldName(JobMaterials.PsStat)]
        public string PsStat { get; set; }
        [FieldName(JobMaterials.QtyIssued)]
        public int QtyIssued { get; set; }
        [FieldName(JobMaterials.QtyReleased)]
        public int QtyReleased { get; set; }
        [FieldName(JobMaterials.QtyVar)]
        public int QtyVar { get; set; }
        [FieldName(JobMaterials.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(JobMaterials.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(JobMaterials.RefNum)]
        public string RefNum { get; set; }
        [FieldName(JobMaterials.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(JobMaterials.RefType)]
        public string RefType { get; set; }
        [FieldName(JobMaterials.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(JobMaterials.ScrapFact)]
        public string ScrapFact { get; set; }
        [FieldName(JobMaterials.Sequence)]
        public string Sequence { get; set; }
        [FieldName(JobMaterials.SLJobRefs)]
        public string SLJobRefs { get; set; }
        [FieldName(JobMaterials.SLSerials)]
        public string SLSerials { get; set; }
        [FieldName(JobMaterials.Suffix)]
        public string Suffix { get; set; }
        [FieldName(JobMaterials.UbAcct)]
        public string UbAcct { get; set; }
        [FieldName(JobMaterials.UbAcctAccessUnit1)]
        public string UbAcctAccessUnit1 { get; set; }
        [FieldName(JobMaterials.UbAcctAccessUnit2)]
        public string UbAcctAccessUnit2 { get; set; }
        [FieldName(JobMaterials.UbAcctAccessUnit3)]
        public string UbAcctAccessUnit3 { get; set; }
        [FieldName(JobMaterials.UbAcctAccessUnit4)]
        public string UbAcctAccessUnit4 { get; set; }
        [FieldName(JobMaterials.UbAcctUnit1)]
        public string UbAcctUnit1 { get; set; }
        [FieldName(JobMaterials.UbAcctUnit2)]
        public string UbAcctUnit2 { get; set; }
        [FieldName(JobMaterials.UbAcctUnit3)]
        public string UbAcctUnit3 { get; set; }
        [FieldName(JobMaterials.UbAcctUnit4)]
        public string UbAcctUnit4 { get; set; }
        [FieldName(JobMaterials.UbCopyJobRef)]
        public string UbCopyJobRef { get; set; }
        [FieldName(JobMaterials.UbCreate)]
        public string UbCreate { get; set; }
        [FieldName(JobMaterials.UbCurrMatlOldRowPtr)]
        public string UbCurrMatlOldRowPtr { get; set; }
        [FieldName(JobMaterials.UbDelTempSer)]
        public string UbDelTempSer { get; set; }
        [FieldName(JobMaterials.UbDispXRefMsg)]
        public string UbDispXRefMsg { get; set; }
        [FieldName(JobMaterials.UbEmpName)]
        public string UbEmpName { get; set; }
        [FieldName(JobMaterials.UbEmpNum)]
        public string UbEmpNum { get; set; }
        [FieldName(JobMaterials.UbGenerateQty)]
        public string UbGenerateQty { get; set; }
        [FieldName(JobMaterials.UbImportDocId)]
        public string UbImportDocId { get; set; }
        [FieldName(JobMaterials.UbItmItem)]
        public string UbItmItem { get; set; }
        [FieldName(JobMaterials.UbItmLowLevel)]
        public string UbItmLowLevel { get; set; }
        [FieldName(JobMaterials.UbJobMatlOldRowPtr)]
        public string UbJobMatlOldRowPtr { get; set; }
        [FieldName(JobMaterials.UbJobType)]
        public string UbJobType { get; set; }
        [FieldName(JobMaterials.UbLoc)]
        public string UbLoc { get; set; }
        [FieldName(JobMaterials.UbLocQty)]
        public int UbLocQty { get; set; }
        [FieldName(JobMaterials.UbLot)]
        public string UbLot { get; set; }
        [FieldName(JobMaterials.UbNonInvItem)]
        public string UbNonInvItem { get; set; }
        [FieldName(JobMaterials.UbNotInInventory)]
        public string UbNotInInventory { get; set; }
        [FieldName(JobMaterials.UbPlanCostConv)]
        public decimal UbPlanCostConv { get; set; }
        [FieldName(JobMaterials.UbProcessId)]
        public string UbProcessId { get; set; }
        [FieldName(JobMaterials.UbProductCode)]
        public string UbProductCode { get; set; }
        [FieldName(JobMaterials.UbQty)]
        public int UbQty { get; set; }
        [FieldName(JobMaterials.UbQtyConv)]
        public decimal UbQtyConv { get; set; }
        [FieldName(JobMaterials.UbQtyOnHand)]
        public int UbQtyOnHand { get; set; }
        [FieldName(JobMaterials.UbQtyOnHandConv)]
        public decimal UbQtyOnHandConv { get; set; }
        [FieldName(JobMaterials.UbQtyRequired)]
        public int UbQtyRequired { get; set; }
        [FieldName(JobMaterials.UbQtyRequiredConv)]
        public decimal UbQtyRequiredConv { get; set; }
        [FieldName(JobMaterials.UbRangeQty)]
        public string UbRangeQty { get; set; }
        [FieldName(JobMaterials.UbSelect)]
        public string UbSelect { get; set; }
        [FieldName(JobMaterials.UbSelectedQty)]
        public string UbSelectedQty { get; set; }
        [FieldName(JobMaterials.UbSerialPrefix)]
        public string UbSerialPrefix { get; set; }
        [FieldName(JobMaterials.UbTargetQty)]
        public int UbTargetQty { get; set; }
        [FieldName(JobMaterials.UbTotalCost)]
        public decimal UbTotalCost { get; set; }
        [FieldName(JobMaterials.UbTransDate)]
        public DateTime UbTransDate { get; set; }
        [FieldName(JobMaterials.UbUmConvFactor)]
        public decimal UbUmConvFactor { get; set; }
        [FieldName(JobMaterials.UbWc)]
        public string UbWc { get; set; }
        [FieldName(JobMaterials.UbWhse)]
        public string UbWhse { get; set; }
        [FieldName(JobMaterials.UM)]
        public string UM { get; set; }
        [FieldName(JobMaterials.Units)]
        public string Units { get; set; }
        [FieldName(JobMaterials.VarovhdT)]
        public string VarovhdT { get; set; }
        [FieldName(JobMaterials.Vmatlovhd)]
        public string Vmatlovhd { get; set; }
        [FieldName(JobMaterials.VovhdCost)]
        public string VovhdCost { get; set; }
        [FieldName(JobMaterials.VovhdCostConv)]
        public decimal VovhdCostConv { get; set; }
        [FieldName(JobMaterials.WcDescription)]
        public string WcDescription { get; set; }
        [FieldName(JobMaterials.WcOutside)]
        public string WcOutside { get; set; }
    }
    public class IdoApPostedTransactionsCriteria : IdoCriteria
    {
        public IdoApPostedTransactionsCriteria()
            : base(IdoApPostedTransactions.IDO_NAME)
        {
        }
        [FieldName(IdoApPostedTransactions.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoApPostedTransactions.Active)]
        public string Active { get; set; }
        [FieldName(IdoApPostedTransactions.AmtDisc)]
        public string AmtDisc { get; set; }
        [FieldName(IdoApPostedTransactions.AmtPaid)]
        public decimal AmtPaid { get; set; }
        [FieldName(IdoApPostedTransactions.ApAcct)]
        public string ApAcct { get; set; }
        [FieldName(IdoApPostedTransactions.ApAcctUnit1)]
        public string ApAcctUnit1 { get; set; }
        [FieldName(IdoApPostedTransactions.ApAcctUnit2)]
        public string ApAcctUnit2 { get; set; }
        [FieldName(IdoApPostedTransactions.ApAcctUnit3)]
        public string ApAcctUnit3 { get; set; }
        [FieldName(IdoApPostedTransactions.ApAcctUnit4)]
        public string ApAcctUnit4 { get; set; }
        [FieldName(IdoApPostedTransactions.BrokerageAmt)]
        public string BrokerageAmt { get; set; }
        [FieldName(IdoApPostedTransactions.BuilderPoNum)]
        public string BuilderPoNum { get; set; }
        [FieldName(IdoApPostedTransactions.BuilderPoOrigSite)]
        public string BuilderPoOrigSite { get; set; }
        [FieldName(IdoApPostedTransactions.BuilderVoucher)]
        public string BuilderVoucher { get; set; }
        [FieldName(IdoApPostedTransactions.BuilderVoucherOrigSite)]
        public string BuilderVoucherOrigSite { get; set; }
        [FieldName(IdoApPostedTransactions.ChartAccessUnit1)]
        public string ChartAccessUnit1 { get; set; }
        [FieldName(IdoApPostedTransactions.ChartAccessUnit2)]
        public string ChartAccessUnit2 { get; set; }
        [FieldName(IdoApPostedTransactions.ChartAccessUnit3)]
        public string ChartAccessUnit3 { get; set; }
        [FieldName(IdoApPostedTransactions.ChartAccessUnit4)]
        public string ChartAccessUnit4 { get; set; }
        [FieldName(IdoApPostedTransactions.ChartAcct)]
        public string ChartAcct { get; set; }
        [FieldName(IdoApPostedTransactions.ChartDescription)]
        public string ChartDescription { get; set; }
        [FieldName(IdoApPostedTransactions.ChartEffDate)]
        public DateTime ChartEffDate { get; set; }
        [FieldName(IdoApPostedTransactions.ChartNoteExistsFlag)]
        public string ChartNoteExistsFlag { get; set; }
        [FieldName(IdoApPostedTransactions.ChartObsDate)]
        public DateTime ChartObsDate { get; set; }
        [FieldName(IdoApPostedTransactions.ChartRecordDate)]
        public DateTime ChartRecordDate { get; set; }
        [FieldName(IdoApPostedTransactions.ChartReportsToAcct)]
        public string ChartReportsToAcct { get; set; }
        [FieldName(IdoApPostedTransactions.ChartRowPointer)]
        public string ChartRowPointer { get; set; }
        [FieldName(IdoApPostedTransactions.ChartTransMethod)]
        public string ChartTransMethod { get; set; }
        [FieldName(IdoApPostedTransactions.ChartType)]
        public string ChartType { get; set; }
        [FieldName(IdoApPostedTransactions.ChartUseBuyRate)]
        public string ChartUseBuyRate { get; set; }
        [FieldName(IdoApPostedTransactions.CheckNum)]
        public string CheckNum { get; set; }
        [FieldName(IdoApPostedTransactions.DerAmtBal)]
        public string DerAmtBal { get; set; }
        [FieldName(IdoApPostedTransactions.DerInvAdj)]
        public string DerInvAdj { get; set; }
        [FieldName(IdoApPostedTransactions.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(IdoApPostedTransactions.DerTypeDescription)]
        public string DerTypeDescription { get; set; }
        [FieldName(IdoApPostedTransactions.DiscAmt)]
        public decimal DiscAmt { get; set; }
        [FieldName(IdoApPostedTransactions.DiscDate)]
        public DateTime DiscDate { get; set; }
        [FieldName(IdoApPostedTransactions.DiscDays)]
        public string DiscDays { get; set; }
        [FieldName(IdoApPostedTransactions.DiscPct)]
        public decimal DiscPct { get; set; }
        [FieldName(IdoApPostedTransactions.DistDate)]
        public DateTime DistDate { get; set; }
        [FieldName(IdoApPostedTransactions.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoApPostedTransactions.DueDays)]
        public int DueDays { get; set; }
        [FieldName(IdoApPostedTransactions.DutyAmt)]
        public decimal DutyAmt { get; set; }
        [FieldName(IdoApPostedTransactions.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoApPostedTransactions.FixedRate)]
        public decimal FixedRate { get; set; }
        [FieldName(IdoApPostedTransactions.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoApPostedTransactions.GrnNum)]
        public string GrnNum { get; set; }
        [FieldName(IdoApPostedTransactions.HoldFlag)]
        public string HoldFlag { get; set; }
        [FieldName(IdoApPostedTransactions.InvAmt)]
        public decimal InvAmt { get; set; }
        [FieldName(IdoApPostedTransactions.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(IdoApPostedTransactions.InvNum)]
        public string InvNum { get; set; }
        [FieldName(IdoApPostedTransactions.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoApPostedTransactions.MiscCharges)]
        public string MiscCharges { get; set; }
        [FieldName(IdoApPostedTransactions.NonDiscAmt)]
        public string NonDiscAmt { get; set; }
        [FieldName(IdoApPostedTransactions.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoApPostedTransactions.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoApPostedTransactions.ProxDay)]
        public string ProxDay { get; set; }
        [FieldName(IdoApPostedTransactions.PurchAmt)]
        public decimal PurchAmt { get; set; }
        [FieldName(IdoApPostedTransactions.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoApPostedTransactions.Ref)]
        public string Ref { get; set; }
        [FieldName(IdoApPostedTransactions.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoApPostedTransactions.SalesTax)]
        public decimal SalesTax { get; set; }
        [FieldName(IdoApPostedTransactions.SalesTax_2)]
        public decimal SalesTax_2 { get; set; }
        [FieldName(IdoApPostedTransactions.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoApPostedTransactions.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoApPostedTransactions.Txt)]
        public string Txt { get; set; }
        [FieldName(IdoApPostedTransactions.Type)]
        public string Type { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrAddr_1)]
        public string VendaddrAddr_1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrAddr_2)]
        public string VendaddrAddr_2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrAddr_3)]
        public string VendaddrAddr_3 { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrAddr_4)]
        public string VendaddrAddr_4 { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrCity)]
        public string VendaddrCity { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrCountry)]
        public string VendaddrCountry { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrCounty)]
        public string VendaddrCounty { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrExternalEmailAddr)]
        public string VendaddrExternalEmailAddr { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrFaxNum)]
        public string VendaddrFaxNum { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrInternalEmailAddr)]
        public string VendaddrInternalEmailAddr { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrInternetUrl)]
        public string VendaddrInternetUrl { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrName)]
        public string VendaddrName { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrNoteExistsFlag)]
        public string VendaddrNoteExistsFlag { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrPayHold)]
        public string VendaddrPayHold { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrPayHoldDate)]
        public string VendaddrPayHoldDate { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrPayHoldReason)]
        public string VendaddrPayHoldReason { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrPayHoldUser)]
        public string VendaddrPayHoldUser { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrRecordDate)]
        public DateTime VendaddrRecordDate { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrRowPointer)]
        public string VendaddrRowPointer { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrState)]
        public string VendaddrState { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrTelexNum)]
        public string VendaddrTelexNum { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrVendNum)]
        public string VendaddrVendNum { get; set; }
        [FieldName(IdoApPostedTransactions.VendaddrZip)]
        public string VendaddrZip { get; set; }
        [FieldName(IdoApPostedTransactions.VendNum)]
        public string VendNum { get; set; }
        [FieldName(IdoApPostedTransactions.VendorBankCode)]
        public string VendorBankCode { get; set; }
        [FieldName(IdoApPostedTransactions.VendorBranchId)]
        public string VendorBranchId { get; set; }
        [FieldName(IdoApPostedTransactions.VendorCategory)]
        public string VendorCategory { get; set; }
        [FieldName(IdoApPostedTransactions.VendorCharfld1)]
        public string VendorCharfld1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorCharfld2)]
        public string VendorCharfld2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorCharfld3)]
        public string VendorCharfld3 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorContact)]
        public string VendorContact { get; set; }
        [FieldName(IdoApPostedTransactions.VendorCurrCode)]
        public string VendorCurrCode { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDatefld)]
        public string VendorDatefld { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDecifld1)]
        public string VendorDecifld1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDecifld2)]
        public string VendorDecifld2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDecifld3)]
        public string VendorDecifld3 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDelterm)]
        public string VendorDelterm { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDiscLstYr)]
        public string VendorDiscLstYr { get; set; }
        [FieldName(IdoApPostedTransactions.VendorDiscYtd)]
        public string VendorDiscYtd { get; set; }
        [FieldName(IdoApPostedTransactions.VendorEdiVend)]
        public string VendorEdiVend { get; set; }
        [FieldName(IdoApPostedTransactions.VendorFob)]
        public string VendorFob { get; set; }
        [FieldName(IdoApPostedTransactions.VendorLangCode)]
        public string VendorLangCode { get; set; }
        [FieldName(IdoApPostedTransactions.VendorLastPaid)]
        public string VendorLastPaid { get; set; }
        [FieldName(IdoApPostedTransactions.VendorLastPurch)]
        public string VendorLastPurch { get; set; }
        [FieldName(IdoApPostedTransactions.VendorLcrReqd)]
        public string VendorLcrReqd { get; set; }
        [FieldName(IdoApPostedTransactions.VendorLogifld)]
        public string VendorLogifld { get; set; }
        [FieldName(IdoApPostedTransactions.VendorNoteExistsFlag)]
        public string VendorNoteExistsFlag { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPayLstYr)]
        public string VendorPayLstYr { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPayType)]
        public string VendorPayType { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPayYtd)]
        public string VendorPayYtd { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPhone)]
        public string VendorPhone { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPrintPrice)]
        public string VendorPrintPrice { get; set; }
        [FieldName(IdoApPostedTransactions.VendorProcessInd)]
        public string VendorProcessInd { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurAcct)]
        public string VendorPurAcct { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurAcctUnit1)]
        public string VendorPurAcctUnit1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurAcctUnit2)]
        public string VendorPurAcctUnit2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurAcctUnit3)]
        public string VendorPurAcctUnit3 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurAcctUnit4)]
        public string VendorPurAcctUnit4 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurchLstYr)]
        public decimal VendorPurchLstYr { get; set; }
        [FieldName(IdoApPostedTransactions.VendorPurchYtd)]
        public decimal VendorPurchYtd { get; set; }
        [FieldName(IdoApPostedTransactions.VendorRecordDate)]
        public DateTime VendorRecordDate { get; set; }
        [FieldName(IdoApPostedTransactions.VendorRowPointer)]
        public string VendorRowPointer { get; set; }
        [FieldName(IdoApPostedTransactions.VendorShipCode)]
        public string VendorShipCode { get; set; }
        [FieldName(IdoApPostedTransactions.VendorStat)]
        public string VendorStat { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTaxCode1)]
        public string VendorTaxCode1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTaxCode2)]
        public string VendorTaxCode2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTaxRegNum1)]
        public string VendorTaxRegNum1 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTaxRegNum2)]
        public string VendorTaxRegNum2 { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTermsCode)]
        public string VendorTermsCode { get; set; }
        [FieldName(IdoApPostedTransactions.VendorTransNat)]
        public string VendorTransNat { get; set; }
        [FieldName(IdoApPostedTransactions.VendorUserId)]
        public string VendorUserId { get; set; }
        [FieldName(IdoApPostedTransactions.VendorVendNum)]
        public string VendorVendNum { get; set; }
        [FieldName(IdoApPostedTransactions.VendorVendRemit)]
        public string VendorVendRemit { get; set; }
        [FieldName(IdoApPostedTransactions.VendorVendType)]
        public string VendorVendType { get; set; }
        [FieldName(IdoApPostedTransactions.VendorWhse)]
        public string VendorWhse { get; set; }
        [FieldName(IdoApPostedTransactions.VenTermsCode)]
        public string VenTermsCode { get; set; }
        [FieldName(IdoApPostedTransactions.Voucher)]
        public string Voucher { get; set; }
        [FieldName(IdoApPostedTransactions.VouchSeq)]
        public string VouchSeq { get; set; }
    }
    
    public class ItemPriceCriteria : IdoCriteria
    {
        public ItemPriceCriteria()
            : base(ItemPrice.IDO_NAME)
        {
        }
        [FieldName(ItemPrice.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ItemPrice.UnitPrice)]
        public decimal UnitPrice { get; set; }
        [FieldName(ItemPrice.Item)]
        public string Item { get; set; }
        [FieldName(ItemPrice.EffectiveDate)]
        public DateTime EffectiveDate { get; set; }
    }
 
    public class ItemsCriteria : IdoCriteria
    {
        public ItemsCriteria()
            : base(Items.IDO_NAME)
        {
        }
        [FieldName(Items.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Items.AbcCode)]
        public string AbcCode { get; set; }
        [FieldName(Items.AcceptReq)]
        public string AcceptReq { get; set; }
        [FieldName(Items.ActiveForDataIntegration)]
        public string ActiveForDataIntegration { get; set; }
        [FieldName(Items.AltItem)]
        public string AltItem { get; set; }
        [FieldName(Items.AsmFixed)]
        public string AsmFixed { get; set; }
        [FieldName(Items.AsmFixture)]
        public string AsmFixture { get; set; }
        [FieldName(Items.AsmMatl)]
        public string AsmMatl { get; set; }
        [FieldName(Items.AsmOther)]
        public string AsmOther { get; set; }
        [FieldName(Items.AsmOutside)]
        public string AsmOutside { get; set; }
        [FieldName(Items.AsmRun)]
        public string AsmRun { get; set; }
        [FieldName(Items.AsmSetup)]
        public string AsmSetup { get; set; }
        [FieldName(Items.AsmTool)]
        public string AsmTool { get; set; }
        [FieldName(Items.AsmVar)]
        public string AsmVar { get; set; }
        [FieldName(Items.AutoJob)]
        public string AutoJob { get; set; }
        [FieldName(Items.AvgFovhdCost)]
        public decimal AvgFovhdCost { get; set; }
        [FieldName(Items.AvgLbrCost)]
        public decimal AvgLbrCost { get; set; }
        [FieldName(Items.AvgMatlCost)]
        public decimal AvgMatlCost { get; set; }
        [FieldName(Items.AvgOutCost)]
        public decimal AvgOutCost { get; set; }
        [FieldName(Items.AvgUCost)]
        public decimal AvgUCost { get; set; }
        [FieldName(Items.AvgVovhdCost)]
        public decimal AvgVovhdCost { get; set; }
        [FieldName(Items.Backflush)]
        public string Backflush { get; set; }
        [FieldName(Items.BflushLoc)]
        public string BflushLoc { get; set; }
        [FieldName(Items.Buyer)]
        public string Buyer { get; set; }
        [FieldName(Items.CfgModel)]
        public string CfgModel { get; set; }
        [FieldName(Items.ChangeDate)]
        public DateTime ChangeDate { get; set; }
        [FieldName(Items.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(Items.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(Items.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(Items.Charfld4)]
        public string Charfld4 { get; set; }
        [FieldName(Items.ChgDate)]
        public DateTime ChgDate { get; set; }
        [FieldName(Items.CntryCountry)]
        public string CntryCountry { get; set; }
        [FieldName(Items.CommodityCode)]
        public string CommodityCode { get; set; }
        [FieldName(Items.CommCodeDescription)]
        public string CommCodeDescription { get; set; }
        [FieldName(Items.CompFixed)]
        public string CompFixed { get; set; }
        [FieldName(Items.CompFixture)]
        public string CompFixture { get; set; }
        [FieldName(Items.CompMatl)]
        public string CompMatl { get; set; }
        [FieldName(Items.CompOther)]
        public string CompOther { get; set; }
        [FieldName(Items.CompOutside)]
        public string CompOutside { get; set; }
        [FieldName(Items.CompRun)]
        public string CompRun { get; set; }
        [FieldName(Items.CompSetup)]
        public string CompSetup { get; set; }
        [FieldName(Items.CompTool)]
        public string CompTool { get; set; }
        [FieldName(Items.CompVar)]
        public string CompVar { get; set; }
        [FieldName(Items.ControlledByExternalIcs)]
        public string ControlledByExternalIcs { get; set; }
        [FieldName(Items.CoPostConfig)]
        public string CoPostConfig { get; set; }
        [FieldName(Items.CostMethod)]
        public string CostMethod { get; set; }
        [FieldName(Items.CostType)]
        public string CostType { get; set; }
        [FieldName(Items.CurBrokerageCost)]
        public string CurBrokerageCost { get; set; }
        [FieldName(Items.CurDutyCost)]
        public decimal CurDutyCost { get; set; }
        [FieldName(Items.CurFovhdCost)]
        public decimal CurFovhdCost { get; set; }
        [FieldName(Items.CurFreightCost)]
        public decimal CurFreightCost { get; set; }
        [FieldName(Items.CurInsuranceCost)]
        public decimal CurInsuranceCost { get; set; }
        [FieldName(Items.CurLbrCost)]
        public decimal CurLbrCost { get; set; }
        [FieldName(Items.CurLocFrtCost)]
        public decimal CurLocFrtCost { get; set; }
        [FieldName(Items.CurMatCost)]
        public decimal CurMatCost { get; set; }
        [FieldName(Items.CurMatlCost)]
        public decimal CurMatlCost { get; set; }
        [FieldName(Items.CurOutCost)]
        public decimal CurOutCost { get; set; }
        [FieldName(Items.CurUCost)]
        public decimal CurUCost { get; set; }
        [FieldName(Items.CurVovhdCost)]
        public string CurVovhdCost { get; set; }
        [FieldName(Items.Datefld)]
        public string Datefld { get; set; }
        [FieldName(Items.DaysSupply)]
        public int DaysSupply { get; set; }
        [FieldName(Items.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(Items.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(Items.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(Items.DerAccumValue)]
        public decimal DerAccumValue { get; set; }
        [FieldName(Items.DerBOMExist)]
        public string DerBOMExist { get; set; }
        [FieldName(Items.DerCanChangeKit)]
        public string DerCanChangeKit { get; set; }
        [FieldName(Items.DerCanChangeKit1)]
        public string DerCanChangeKit1 { get; set; }
        [FieldName(Items.DerCanChangeKit2)]
        public string DerCanChangeKit2 { get; set; }
        [FieldName(Items.DerCanChangeRev)]
        public string DerCanChangeRev { get; set; }
        [FieldName(Items.DerCanLotSerial)]
        public string DerCanLotSerial { get; set; }
        [FieldName(Items.DerCanPromptCost1)]
        public string DerCanPromptCost1 { get; set; }
        [FieldName(Items.DerCanPromptCost2)]
        public string DerCanPromptCost2 { get; set; }
        [FieldName(Items.DerCanUpdateCosts)]
        public string DerCanUpdateCosts { get; set; }
        [FieldName(Items.DerCanUpdateCur)]
        public string DerCanUpdateCur { get; set; }
        [FieldName(Items.DerChangePosted)]
        public string DerChangePosted { get; set; }
        [FieldName(Items.DerCumPct)]
        public string DerCumPct { get; set; }
        [FieldName(Items.DerDisplayUnitCosts)]
        public string DerDisplayUnitCosts { get; set; }
        [FieldName(Items.DerEcnTracked)]
        public string DerEcnTracked { get; set; }
        [FieldName(Items.DerFrzAsmSubtotal)]
        public decimal DerFrzAsmSubtotal { get; set; }
        [FieldName(Items.DerFrzAsmTotal)]
        public decimal DerFrzAsmTotal { get; set; }
        [FieldName(Items.DerFrzCompTotal)]
        public decimal DerFrzCompTotal { get; set; }
        [FieldName(Items.DerFrzcostExist)]
        public string DerFrzcostExist { get; set; }
        [FieldName(Items.DerHasRsvdInv)]
        public string DerHasRsvdInv { get; set; }
        [FieldName(Items.DerItemPct)]
        public decimal DerItemPct { get; set; }
        [FieldName(Items.DerItmAsmSubtotal)]
        public decimal DerItmAsmSubtotal { get; set; }
        [FieldName(Items.DerItmAsmTotal)]
        public decimal DerItmAsmTotal { get; set; }
        [FieldName(Items.DerItmCompTotal)]
        public decimal DerItmCompTotal { get; set; }
        [FieldName(Items.DerMatCurCost)]
        public decimal DerMatCurCost { get; set; }
        [FieldName(Items.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(Items.DerNewAbcCode)]
        public string DerNewAbcCode { get; set; }
        [FieldName(Items.DerNewStat)]
        public string DerNewStat { get; set; }
        [FieldName(Items.DerNonNettableStock)]
        public string DerNonNettableStock { get; set; }
        [FieldName(Items.DerNotRsvdOnHand)]
        public string DerNotRsvdOnHand { get; set; }
        [FieldName(Items.DerPurCurCost)]
        public decimal DerPurCurCost { get; set; }
        [FieldName(Items.DerQtyAllocCo)]
        public string DerQtyAllocCo { get; set; }
        [FieldName(Items.DerQtyOnHand)]
        public int DerQtyOnHand { get; set; }
        [FieldName(Items.DerQtyOrdered)]
        public int DerQtyOrdered { get; set; }
        [FieldName(Items.DerQtyPurYtd)]
        public int DerQtyPurYtd { get; set; }
        [FieldName(Items.DerQtyReorder)]
        public int DerQtyReorder { get; set; }
        [FieldName(Items.DerQtyRsvdCo)]
        public int DerQtyRsvdCo { get; set; }
        [FieldName(Items.DerQtySoldYtd)]
        public int DerQtySoldYtd { get; set; }
        [FieldName(Items.DerQtyWip)]
        public int DerQtyWip { get; set; }
        [FieldName(Items.DerRecursive)]
        public string DerRecursive { get; set; }
        [FieldName(Items.DerRefType)]
        public string DerRefType { get; set; }
        [FieldName(Items.DerSafetyStock)]
        public string DerSafetyStock { get; set; }
        [FieldName(Items.DerSSDate)]
        public DateTime DerSSDate { get; set; }
        [FieldName(Items.DerTotCost)]
        public string DerTotCost { get; set; }
        [FieldName(Items.DerVariance)]
        public string DerVariance { get; set; }
        [FieldName(Items.Description)]
        public string Description { get; set; }
        [FieldName(Items.DockTime)]
        public string DockTime { get; set; }
        [FieldName(Items.DrawingNbr)]
        public string DrawingNbr { get; set; }
        [FieldName(Items.DuePeriod)]
        public string DuePeriod { get; set; }
        [FieldName(Items.EarliestPlannedPoReceipt)]
        public string EarliestPlannedPoReceipt { get; set; }
        [FieldName(Items.ExpLeadTime)]
        public string ExpLeadTime { get; set; }
        [FieldName(Items.ProductCategory)]
        public string ProductCategory { get; set; }
        [FieldName(Items.FeatStr)]
        public string FeatStr { get; set; }
        [FieldName(Items.FeatTempl)]
        public string FeatTempl { get; set; }
        [FieldName(Items.FeatType)]
        public string FeatType { get; set; }
        [FieldName(Items.FixedOrderQty)]
        public string FixedOrderQty { get; set; }
        [FieldName(Items.FovhdCost)]
        public string FovhdCost { get; set; }
        [FieldName(Items.FrzAsmFixed)]
        public string FrzAsmFixed { get; set; }
        [FieldName(Items.FrzAsmFixture)]
        public string FrzAsmFixture { get; set; }
        [FieldName(Items.FrzAsmMatl)]
        public string FrzAsmMatl { get; set; }
        [FieldName(Items.FrzAsmOther)]
        public string FrzAsmOther { get; set; }
        [FieldName(Items.FrzAsmOutside)]
        public string FrzAsmOutside { get; set; }
        [FieldName(Items.FrzAsmRun)]
        public string FrzAsmRun { get; set; }
        [FieldName(Items.FrzAsmSetup)]
        public string FrzAsmSetup { get; set; }
        [FieldName(Items.FrzAsmTool)]
        public string FrzAsmTool { get; set; }
        [FieldName(Items.FrzAsmVar)]
        public string FrzAsmVar { get; set; }
        [FieldName(Items.FrzCompFixed)]
        public string FrzCompFixed { get; set; }
        [FieldName(Items.FrzCompFixture)]
        public string FrzCompFixture { get; set; }
        [FieldName(Items.FrzCompMatl)]
        public string FrzCompMatl { get; set; }
        [FieldName(Items.FrzCompOther)]
        public string FrzCompOther { get; set; }
        [FieldName(Items.FrzCompOutside)]
        public string FrzCompOutside { get; set; }
        [FieldName(Items.FrzCompRun)]
        public string FrzCompRun { get; set; }
        [FieldName(Items.FrzCompSetup)]
        public string FrzCompSetup { get; set; }
        [FieldName(Items.FrzCompTool)]
        public string FrzCompTool { get; set; }
        [FieldName(Items.FrzCompVar)]
        public string FrzCompVar { get; set; }
        [FieldName(Items.FrzFreezeDate)]
        public DateTime FrzFreezeDate { get; set; }
        [FieldName(Items.FrzSubMatl)]
        public string FrzSubMatl { get; set; }
        [FieldName(Items.IncludeInNetChangePlanning)]
        public string IncludeInNetChangePlanning { get; set; }
        [FieldName(Items.InfinitePart)]
        public string InfinitePart { get; set; }
        [FieldName(Items.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Items.IssueBy)]
        public string IssueBy { get; set; }
        [FieldName(Items.Item)]
        public string Item { get; set; }
        [FieldName(Items.ItemChangeDate)]
        public DateTime ItemChangeDate { get; set; }
        [FieldName(Items.Job)]
        public string Job { get; set; }
        [FieldName(Items.JobConfigurable)]
        public string JobConfigurable { get; set; }
        [FieldName(Items.JobPostConfig)]
        public string JobPostConfig { get; set; }
        [FieldName(Items.JobRollupDate)]
        public DateTime JobRollupDate { get; set; }
        [FieldName(Items.Kit)]
        public string Kit { get; set; }
        [FieldName(Items.LastInv)]
        public string LastInv { get; set; }
        [FieldName(Items.LbrCost)]
        public string LbrCost { get; set; }
        [FieldName(Items.LeadTime)]
        public string LeadTime { get; set; }
        [FieldName(Items.Logifld)]
        public string Logifld { get; set; }
        [FieldName(Items.LotGenExp)]
        public string LotGenExp { get; set; }
        [FieldName(Items.LotPrefix)]
        public string LotPrefix { get; set; }
        [FieldName(Items.LotSize)]
        public string LotSize { get; set; }
        [FieldName(Items.LotTracked)]
        public string LotTracked { get; set; }
        [FieldName(Items.LowLevel)]
        public string LowLevel { get; set; }
        [FieldName(Items.LstLotSize)]
        public string LstLotSize { get; set; }
        [FieldName(Items.LstUCost)]
        public string LstUCost { get; set; }
        [FieldName(Items.MatlCost)]
        public string MatlCost { get; set; }
        [FieldName(Items.MatlType)]
        public string MatlType { get; set; }
        [FieldName(Items.MfgSupplySwitchingActive)]
        public string MfgSupplySwitchingActive { get; set; }
        [FieldName(Items.MpsFlag)]
        public string MpsFlag { get; set; }
        [FieldName(Items.MpsPlanFence)]
        public string MpsPlanFence { get; set; }
        [FieldName(Items.MrpPart)]
        public string MrpPart { get; set; }
        [FieldName(Items.NextConfig)]
        public string NextConfig { get; set; }
        [FieldName(Items.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Items.OrderConfigurable)]
        public string OrderConfigurable { get; set; }
        [FieldName(Items.OrderMax)]
        public string OrderMax { get; set; }
        [FieldName(Items.OrderMin)]
        public string OrderMin { get; set; }
        [FieldName(Items.OrderMultiple)]
        public decimal OrderMultiple { get; set; }
        [FieldName(Items.Origin)]
        public string Origin { get; set; }
        [FieldName(Items.OutCost)]
        public decimal OutCost { get; set; }
        [FieldName(Items.PaperTime)]
        public string PaperTime { get; set; }
        [FieldName(Items.ParmCurrCode)]
        public string ParmCurrCode { get; set; }
        [FieldName(Items.PassReq)]
        public string PassReq { get; set; }
        [FieldName(Items.PhantomFlag)]
        public string PhantomFlag { get; set; }
        [FieldName(Items.PlanCode)]
        public string PlanCode { get; set; }
        [FieldName(Items.PlanFlag)]
        public string PlanFlag { get; set; }
        [FieldName(Items.PMTCode)]
        public string PMTCode { get; set; }
        [FieldName(Items.PrintKitComponents)]
        public string PrintKitComponents { get; set; }
        [FieldName(Items.PriUnitPrice1)]
        public string PriUnitPrice1 { get; set; }
        [FieldName(Items.PriUnitPrice2)]
        public string PriUnitPrice2 { get; set; }
        [FieldName(Items.PriUnitPrice3)]
        public string PriUnitPrice3 { get; set; }
        [FieldName(Items.PriUnitPrice4)]
        public string PriUnitPrice4 { get; set; }
        [FieldName(Items.PriUnitPrice5)]
        public string PriUnitPrice5 { get; set; }
        [FieldName(Items.PriUnitPrice6)]
        public string PriUnitPrice6 { get; set; }
        [FieldName(Items.ProdMix)]
        public string ProdMix { get; set; }
        [FieldName(Items.ProdType)]
        public string ProdType { get; set; }
        [FieldName(Items.ProductCode)]
        public string ProductCode { get; set; }
        [FieldName(Items.QtyAllocjob)]
        public string QtyAllocjob { get; set; }
        [FieldName(Items.QtyMfgYtd)]
        public int QtyMfgYtd { get; set; }
        [FieldName(Items.QtyUsedYtd)]
        public int QtyUsedYtd { get; set; }
        [FieldName(Items.RatePerDay)]
        public decimal RatePerDay { get; set; }
        [FieldName(Items.RcvdOverPoQtyTolerance)]
        public string RcvdOverPoQtyTolerance { get; set; }
        [FieldName(Items.RcvdUnderPoQtyTolerance)]
        public string RcvdUnderPoQtyTolerance { get; set; }
        [FieldName(Items.ReasonCode)]
        public string ReasonCode { get; set; }
        [FieldName(Items.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Items.ReorderPoint)]
        public string ReorderPoint { get; set; }
        [FieldName(Items.Reservable)]
        public string Reservable { get; set; }
        [FieldName(Items.ItemRevision)]
        public string ItemRevision { get; set; }
        [FieldName(Items.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Items.SafetyStockPercent)]
        public string SafetyStockPercent { get; set; }
        [FieldName(Items.SerialLength)]
        public string SerialLength { get; set; }
        [FieldName(Items.SerialPrefix)]
        public string SerialPrefix { get; set; }
        [FieldName(Items.SerialTracked)]
        public string SerialTracked { get; set; }
        [FieldName(Items.Setupgroup)]
        public string Setupgroup { get; set; }
        [FieldName(Items.ShelfLife)]
        public string ShelfLife { get; set; }
        [FieldName(Items.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(Items.ShrinkFact)]
        public string ShrinkFact { get; set; }
        [FieldName(Items.SLCfgUis)]
        public string SLCfgUis { get; set; }
        [FieldName(Items.SLJobmatls)]
        public string SLJobmatls { get; set; }
        [FieldName(Items.SLJobRoutes)]
        public string SLJobRoutes { get; set; }
        [FieldName(Items.SLSupDems)]
        public string SLSupDems { get; set; }
        [FieldName(Items.SSDATE)]
        public DateTime SSDATE { get; set; }
        [FieldName(Items.Status)]
        public string Status { get; set; }
        [FieldName(Items.StatusChgUserCode)]
        public string StatusChgUserCode { get; set; }
        [FieldName(Items.Stocked)]
        public string Stocked { get; set; }
        [FieldName(Items.SubMatl)]
        public string SubMatl { get; set; }
        [FieldName(Items.ItemSuffix)]
        public string ItemSuffix { get; set; }
        [FieldName(Items.SupplySite)]
        public string SupplySite { get; set; }
        [FieldName(Items.SupplyToleranceHrs)]
        public string SupplyToleranceHrs { get; set; }
        [FieldName(Items.SupplyWhse)]
        public string SupplyWhse { get; set; }
        [FieldName(Items.TariffClassification)]
        public string TariffClassification { get; set; }
        [FieldName(Items.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(Items.TaxCode1Description)]
        public string TaxCode1Description { get; set; }
        [FieldName(Items.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(Items.TaxCode2Description)]
        public string TaxCode2Description { get; set; }
        [FieldName(Items.TaxFreeDays)]
        public string TaxFreeDays { get; set; }
        [FieldName(Items.TaxFreeMatl)]
        public string TaxFreeMatl { get; set; }
        [FieldName(Items.Taxsys1TaxMode)]
        public string Taxsys1TaxMode { get; set; }
        [FieldName(Items.Taxsys2TaxMode)]
        public string Taxsys2TaxMode { get; set; }
        [FieldName(Items.TimeFenceRule)]
        public string TimeFenceRule { get; set; }
        [FieldName(Items.TimeFenceValue)]
        public string TimeFenceValue { get; set; }
        [FieldName(Items.TrackEcn)]
        public string TrackEcn { get; set; }
        [FieldName(Items.UbSelect)]
        public string UbSelect { get; set; }
        [FieldName(Items.UBViewType)]
        public string UBViewType { get; set; }
        [FieldName(Items.UoM)]
        public string UoM { get; set; }
        [FieldName(Items.UnitBrokerageCost)]
        public string UnitBrokerageCost { get; set; }
        [FieldName(Items.UnitCost)]
        public decimal UnitCost { get; set; }
        [FieldName(Items.UnitDutyCost)]
        public decimal UnitDutyCost { get; set; }
        [FieldName(Items.UnitFreightCost)]
        public decimal UnitFreightCost { get; set; }
        [FieldName(Items.UnitInsuranceCost)]
        public decimal UnitInsuranceCost { get; set; }
        [FieldName(Items.UnitLocFrtCost)]
        public decimal UnitLocFrtCost { get; set; }
        [FieldName(Items.UnitMatCost)]
        public decimal UnitMatCost { get; set; }
        [FieldName(Items.UnitWeight)]
        public decimal UnitWeight { get; set; }
        [FieldName(Items.UseReorderPoint)]
        public string UseReorderPoint { get; set; }
        [FieldName(Items.UnitPrice)]
        public decimal UnitPrice { get; set; }
        [FieldName(Items.VarExpLead)]
        public string VarExpLead { get; set; }
        [FieldName(Items.VarLead)]
        public string VarLead { get; set; }
        [FieldName(Items.VovhdCost)]
        public string VovhdCost { get; set; }
        [FieldName(Items.WeightUnits)]
        public string WeightUnits { get; set; }
    }


    public class CustomerOrderCriteria : IdoCriteria
    {
        public CustomerOrderCriteria()
            : base(CustomerOrder.IDO_NAME)
        {
        }
        [FieldName(CustomerOrder.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(CustomerOrder.BillToAddress1)]
        public string BillToAddress1 { get; set; }
        [FieldName(CustomerOrder.BillToAddress2)]
        public string BillToAddress2 { get; set; }
        [FieldName(CustomerOrder.BillToCity)]
        public string BillToCity { get; set; }
        [FieldName(CustomerOrder.BillToContact)]
        public string BillToContact { get; set; }
        [FieldName(CustomerOrder.BillToName)]
        public string BillToName { get; set; }
        [FieldName(CustomerOrder.BillToState)]
        public string BillToState { get; set; }
        [FieldName(CustomerOrder.BillToZip)]
        public string BillToZip { get; set; }
        [FieldName(CustomerOrder.CustomerNumber)]
        public string CustomerNumber { get; set; }
        [FieldName(CustomerOrder.CustSeq)]
        public string CustSeq { get; set; }
        [FieldName(CustomerOrder.OrderDate)]
        public DateTime OrderDate { get; set; }
        [FieldName(CustomerOrder.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(CustomerOrder.Site)]
        public string Site { get; set; }
        [FieldName(CustomerOrder.Warehouse)]
        public string Warehouse { get; set; }
        [FieldName(CustomerOrder.ShipToCode)]
        public string ShipToCode { get; set; }
        [FieldName(CustomerOrder.OrderType)]
        public string OrderType { get; set; }
        [FieldName(CustomerOrder.PONumber)]
        public string PONumber { get; set; }
        [FieldName(CustomerOrder.Status)]
        public string Status { get; set; }
        [FieldName(CustomerOrder.Salesman)]
        public string Salesman { get; set; }
        [FieldName(CustomerOrder.EndUserType)]
        public string EndUserType { get; set; }
        [FieldName(CustomerOrder.Discount)]
        public decimal Discount { get; set; }
        [FieldName(CustomerOrder.TaxCode)]
        public string TaxCode { get; set; }  
        [FieldName(CustomerOrder.ShipToAddr1)]
        public string ShipToAddr1 { get; set; }
        [FieldName(CustomerOrder.ShipToAddr2)]
        public string ShipToAddr2 { get; set; }
        [FieldName(CustomerOrder.ShipToCity)]
        public string ShipToCity { get; set; }
        [FieldName(CustomerOrder.ShipToState)]
        public string ShipToState { get; set; }
        [FieldName(CustomerOrder.ShipToZip)]
        public string ShipToZip { get; set; }
        [FieldName(CustomerOrder.ShipToCountry)]
        public string ShipToCountry { get; set; }
        [FieldName(CustomerOrder.ShipToName)]
        public string ShipToName { get; set; }
        [FieldName(CustomerOrder.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(CustomerOrder.TermsCodeDesc)]
        public string TermsCodeDesc { get; set; }
        [FieldName(CustomerOrder.TermsCodeDiscDays)]
        public int TermsCodeDiscDays { get; set; }
        [FieldName(CustomerOrder.TermsCodeDiscPct)]
        public decimal TermsCodeDiscPct { get; set; }
        [FieldName(CustomerOrder.TermsCodeDueDays)]
        public int TermsCodeDueDays { get; set; }  
        [FieldName(CustomerOrder.DiscountAmount)]
        public decimal DiscountAmount { get; set; }
        [FieldName(CustomerOrder.AckStat)]
        public string AckStat { get; set; }
        [FieldName(CustomerOrder.AdrName)]
        public string AdrName { get; set; }
        [FieldName(CustomerOrder.ApplyToInvNum)]
        public string ApplyToInvNum { get; set; }
        [FieldName(CustomerOrder.ApsPullUp)]
        public string ApsPullUp { get; set; }
        [FieldName(CustomerOrder.BillToCountry)]
        public string BillToCountry { get; set; }
        [FieldName(CustomerOrder.BillToEmailAddr)]
        public string BillToEmailAddr { get; set; }
        [FieldName(CustomerOrder.BillToFaxNum)]
        public string BillToFaxNum { get; set; }
        [FieldName(CustomerOrder.BillToPhone_3)]
        public string BillToPhone_3 { get; set; }
        [FieldName(CustomerOrder.Cad01CreditHold)]
        public string Cad01CreditHold { get; set; }
        [FieldName(CustomerOrder.Cad01Name)]
        public string Cad01Name { get; set; }
        [FieldName(CustomerOrder.Cad0CorpAddress)]
        public string Cad0CorpAddress { get; set; }
        [FieldName(CustomerOrder.Cad0CorpCred)]
        public string Cad0CorpCred { get; set; }
        [FieldName(CustomerOrder.Cad0CorpCust)]
        public string Cad0CorpCust { get; set; }
        [FieldName(CustomerOrder.Cad0CreditHold)]
        public string Cad0CreditHold { get; set; }
        [FieldName(CustomerOrder.Cad0CurrPlaces)]
        public string Cad0CurrPlaces { get; set; }
        [FieldName(CustomerOrder.Cad0Name)]
        public string Cad0Name { get; set; }
        [FieldName(CustomerOrder.CadrCurrCode)]
        public string CadrCurrCode { get; set; }
        [FieldName(CustomerOrder.CadrName)]
        public string CadrName { get; set; }
        [FieldName(CustomerOrder.CfgMainConfigGid)]
        public string CfgMainConfigGid { get; set; }
        [FieldName(CustomerOrder.CfgMainConfigModel)]
        public string CfgMainConfigModel { get; set; }
        [FieldName(CustomerOrder.CfgMainConfigStatus)]
        public string CfgMainConfigStatus { get; set; }
        [FieldName(CustomerOrder.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(CustomerOrder.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(CustomerOrder.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(CustomerOrder.CloseDate)]
        public DateTime CloseDate { get; set; }
        [FieldName(CustomerOrder.CoCreditHold)]
        public string CoCreditHold { get; set; }
        [FieldName(CustomerOrder.ConfigId)]
        public string ConfigId { get; set; }
        [FieldName(CustomerOrder.Consolidate)]
        public string Consolidate { get; set; }
        [FieldName(CustomerOrder.Contact)]
        public string Contact { get; set; }
        [FieldName(CustomerOrder.CoNum)]
        public string CoNum { get; set; }
        [FieldName(CustomerOrder.CoNumSort)]
        public string CoNumSort { get; set; }
        [FieldName(CustomerOrder.ConvertType)]
        public string ConvertType { get; set; }
        [FieldName(CustomerOrder.CorpCust)]
        public string CorpCust { get; set; }
        [FieldName(CustomerOrder.Cost)]
        public string Cost { get; set; }
        [FieldName(CustomerOrder.CreditHold)]
        public string CreditHold { get; set; }
        [FieldName(CustomerOrder.CreditHoldDate)]
        public DateTime CreditHoldDate { get; set; }
        [FieldName(CustomerOrder.CreditHoldReason)]
        public string CreditHoldReason { get; set; }
        [FieldName(CustomerOrder.CreditHoldReasonDesc)]
        public string CreditHoldReasonDesc { get; set; }
        [FieldName(CustomerOrder.CreditHoldUser)]
        public string CreditHoldUser { get; set; }
        [FieldName(CustomerOrder.Cur0AmtFormat)]
        public string Cur0AmtFormat { get; set; }
        [FieldName(CustomerOrder.Cur0CstPrcFormat)]
        public string Cur0CstPrcFormat { get; set; }
        [FieldName(CustomerOrder.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(CustomerOrder.CurrDescription)]
        public string CurrDescription { get; set; }
        [FieldName(CustomerOrder.Cus01Contact_3)]
        public string Cus01Contact_3 { get; set; }
        [FieldName(CustomerOrder.Cus01Phone_3)]
        public string Cus01Phone_3 { get; set; }
        [FieldName(CustomerOrder.CusCustType)]
        public string CusCustType { get; set; }
        [FieldName(CustomerOrder.CusLangCode)]
        public string CusLangCode { get; set; }
        [FieldName(CustomerOrder.CusLcrReqd)]
        public string CusLcrReqd { get; set; }
        [FieldName(CustomerOrder.CustNum)]
        public string CustNum { get; set; }
        [FieldName(CustomerOrder.CustPayType)]
        public string CustPayType { get; set; }
        [FieldName(CustomerOrder.CustPo)]
        public string CustPo { get; set; }
        [FieldName(CustomerOrder.CusTypTaxablePrice)]
        public string CusTypTaxablePrice { get; set; }
        [FieldName(CustomerOrder.CusUseExchRate)]
        public string CusUseExchRate { get; set; }
        [FieldName(CustomerOrder.Datefld)]
        public string Datefld { get; set; }
        [FieldName(CustomerOrder.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(CustomerOrder.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(CustomerOrder.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(CustomerOrder.Delterm)]
        public string Delterm { get; set; }
        [FieldName(CustomerOrder.DeltermDesc)]
        public string DeltermDesc { get; set; }
        [FieldName(CustomerOrder.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(CustomerOrder.DerBillToAddress)]
        public string DerBillToAddress { get; set; }
        [FieldName(CustomerOrder.DerCoNum)]
        public string DerCoNum { get; set; }
        [FieldName(CustomerOrder.DerCoverSheetCompany)]
        public string DerCoverSheetCompany { get; set; }
        [FieldName(CustomerOrder.DerCoverSheetContact)]
        public string DerCoverSheetContact { get; set; }
        [FieldName(CustomerOrder.DerCurrCode)]
        public string DerCurrCode { get; set; }
        [FieldName(CustomerOrder.DerCustProspect)]
        public string DerCustProspect { get; set; }
        [FieldName(CustomerOrder.DerCustProspectCompany)]
        public string DerCustProspectCompany { get; set; }
        [FieldName(CustomerOrder.DerDestination)]
        public string DerDestination { get; set; }
        [FieldName(CustomerOrder.DerDoLines)]
        public string DerDoLines { get; set; }
        [FieldName(CustomerOrder.DerHasXRef)]
        public string DerHasXRef { get; set; }
        [FieldName(CustomerOrder.DerLangCode)]
        public string DerLangCode { get; set; }
        [FieldName(CustomerOrder.DerLineExists)]
        public string DerLineExists { get; set; }
        [FieldName(CustomerOrder.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(CustomerOrder.DerMethod)]
        public string DerMethod { get; set; }
        [FieldName(CustomerOrder.DerNumCopies)]
        public string DerNumCopies { get; set; }
        [FieldName(CustomerOrder.DerNumPackages)]
        public string DerNumPackages { get; set; }
        [FieldName(CustomerOrder.DerOldStat)]
        public string DerOldStat { get; set; }
        [FieldName(CustomerOrder.DerOrderType)]
        public string DerOrderType { get; set; }
        [FieldName(CustomerOrder.DerPreviousStat)]
        public string DerPreviousStat { get; set; }
        [FieldName(CustomerOrder.DerProfileExists)]
        public string DerProfileExists { get; set; }
        [FieldName(CustomerOrder.DerRevaluedExchRate)]
        public string DerRevaluedExchRate { get; set; }
        [FieldName(CustomerOrder.DerSelect)]
        public string DerSelect { get; set; }
        [FieldName(CustomerOrder.DerShipToAddress)]
        public string DerShipToAddress { get; set; }
        [FieldName(CustomerOrder.DerShipVia)]
        public string DerShipVia { get; set; }
        [FieldName(CustomerOrder.DerSlsmanName)]
        public string DerSlsmanName { get; set; }
        [FieldName(CustomerOrder.DerStatFormatted)]
        public string DerStatFormatted { get; set; }
        [FieldName(CustomerOrder.DerTotalProgBillAmt)]
        public string DerTotalProgBillAmt { get; set; }
        [FieldName(CustomerOrder.DerWeight)]
        public string DerWeight { get; set; }
        [FieldName(CustomerOrder.Disc)]
        public string Disc { get; set; }
        [FieldName(CustomerOrder.DiscAmount)]
        public string DiscAmount { get; set; }
        [FieldName(CustomerOrder.DiscountType)]
        public string DiscountType { get; set; }
        [FieldName(CustomerOrder.EdiOrder)]
        public string EdiOrder { get; set; }
        [FieldName(CustomerOrder.EdiType)]
        public string EdiType { get; set; }
        [FieldName(CustomerOrder.EffDate)]
        public DateTime EffDate { get; set; }
        [FieldName(CustomerOrder.Einvoice)]
        public string Einvoice { get; set; }
        [FieldName(CustomerOrder.EndUserTypeDesc)]
        public string EndUserTypeDesc { get; set; }
        [FieldName(CustomerOrder.EstNum)]
        public string EstNum { get; set; }
        [FieldName(CustomerOrder.ExchRate)]
        public string ExchRate { get; set; }
        [FieldName(CustomerOrder.ExpDate)]
        public DateTime ExpDate { get; set; }
        [FieldName(CustomerOrder.ExportType)]
        public string ExportType { get; set; }
        [FieldName(CustomerOrder.ExternalConfirmationRef)]
        public string ExternalConfirmationRef { get; set; }
        [FieldName(CustomerOrder.FixedRate)]
        public string FixedRate { get; set; }
        [FieldName(CustomerOrder.FormatBillToAddress)]
        public string FormatBillToAddress { get; set; }
        [FieldName(CustomerOrder.FormatShipToAddress)]
        public string FormatShipToAddress { get; set; }
        [FieldName(CustomerOrder.FovhdCostT)]
        public string FovhdCostT { get; set; }
        [FieldName(CustomerOrder.Freight)]
        public string Freight { get; set; }
        [FieldName(CustomerOrder.FreightT)]
        public string FreightT { get; set; }
        [FieldName(CustomerOrder.FrtTaxCode1)]
        public string FrtTaxCode1 { get; set; }
        [FieldName(CustomerOrder.FrtTaxCode1Desc)]
        public string FrtTaxCode1Desc { get; set; }
        [FieldName(CustomerOrder.FrtTaxCode2)]
        public string FrtTaxCode2 { get; set; }
        [FieldName(CustomerOrder.FrtTaxCode2Desc)]
        public string FrtTaxCode2Desc { get; set; }
        [FieldName(CustomerOrder.IncludeTaxInPrice)]
        public string IncludeTaxInPrice { get; set; }
        [FieldName(CustomerOrder.InvFreq)]
        public string InvFreq { get; set; }
        [FieldName(CustomerOrder.Invoiced)]
        public string Invoiced { get; set; }
        [FieldName(CustomerOrder.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(CustomerOrder.IsExternal)]
        public string IsExternal { get; set; }
        [FieldName(CustomerOrder.LbrCostT)]
        public string LbrCostT { get; set; }
        [FieldName(CustomerOrder.LcrNum)]
        public string LcrNum { get; set; }
        [FieldName(CustomerOrder.Logifld)]
        public string Logifld { get; set; }
        [FieldName(CustomerOrder.MatlCostT)]
        public string MatlCostT { get; set; }
        [FieldName(CustomerOrder.MChargesT)]
        public string MChargesT { get; set; }
        [FieldName(CustomerOrder.MiscCharges)]
        public string MiscCharges { get; set; }
        [FieldName(CustomerOrder.MscTaxCode1)]
        public string MscTaxCode1 { get; set; }
        [FieldName(CustomerOrder.MscTaxCode1Desc)]
        public string MscTaxCode1Desc { get; set; }
        [FieldName(CustomerOrder.MscTaxCode2)]
        public string MscTaxCode2 { get; set; }
        [FieldName(CustomerOrder.MscTaxCode2Desc)]
        public string MscTaxCode2Desc { get; set; }
        [FieldName(CustomerOrder.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(CustomerOrder.OppId)]
        public string OppId { get; set; }
        [FieldName(CustomerOrder.OrderSource)]
        public string OrderSource { get; set; }
        [FieldName(CustomerOrder.OrigSite)]
        public string OrigSite { get; set; }
        [FieldName(CustomerOrder.OutCostT)]
        public string OutCostT { get; set; }
        [FieldName(CustomerOrder.Phone)]
        public string Phone { get; set; }
        [FieldName(CustomerOrder.PrepaidAmt)]
        public decimal PrepaidAmt { get; set; }
        [FieldName(CustomerOrder.PrepaidT)]
        public string PrepaidT { get; set; }
        [FieldName(CustomerOrder.Price)]
        public decimal Price { get; set; }
        [FieldName(CustomerOrder.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(CustomerOrder.PricecodeDesc)]
        public string PricecodeDesc { get; set; }
        [FieldName(CustomerOrder.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(CustomerOrder.ProCompany)]
        public string ProCompany { get; set; }
        [FieldName(CustomerOrder.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(CustomerOrder.ProspectCompany)]
        public string ProspectCompany { get; set; }
        [FieldName(CustomerOrder.ProspectId)]
        public string ProspectId { get; set; }
        [FieldName(CustomerOrder.QtyPackages)]
        public int QtyPackages { get; set; }
        [FieldName(CustomerOrder.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(CustomerOrder.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(CustomerOrder.SalesTax)]
        public decimal SalesTax { get; set; }
        [FieldName(CustomerOrder.SalesTax2)]
        public decimal SalesTax2 { get; set; }
        [FieldName(CustomerOrder.SalesTaxT)]
        public decimal SalesTaxT { get; set; }
        [FieldName(CustomerOrder.SalesTaxT2)]
        public decimal SalesTaxT2 { get; set; }
        [FieldName(CustomerOrder.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(CustomerOrder.ShipCodeDesc)]
        public string ShipCodeDesc { get; set; }
        [FieldName(CustomerOrder.ShipEarly)]
        public string ShipEarly { get; set; }
        [FieldName(CustomerOrder.ShipPartial)]
        public string ShipPartial { get; set; }
        [FieldName(CustomerOrder.ShipToContact_2)]
        public string ShipToContact_2 { get; set; }
        [FieldName(CustomerOrder.ShipToEmailAddr)]
        public string ShipToEmailAddr { get; set; }
        [FieldName(CustomerOrder.ShipToFaxNum)]
        public string ShipToFaxNum { get; set; }
        [FieldName(CustomerOrder.ShipToPhone_2)]
        public string ShipToPhone_2 { get; set; }
        [FieldName(CustomerOrder.SLCoBlns)]
        public string SLCoBlns { get; set; }
        [FieldName(CustomerOrder.SLCoitems)]
        public string SLCoitems { get; set; }
        [FieldName(CustomerOrder.SLCoShips)]
        public string SLCoShips { get; set; }
        [FieldName(CustomerOrder.SLCoSlsComms)]
        public string SLCoSlsComms { get; set; }
        [FieldName(CustomerOrder.SLRsvdInvs)]
        public string SLRsvdInvs { get; set; }
        [FieldName(CustomerOrder.Slsman)]
        public string Slsman { get; set; }
        [FieldName(CustomerOrder.SLXTaxes)]
        public string SLXTaxes { get; set; }
        [FieldName(CustomerOrder.Stat)]
        public string Stat { get; set; }
        [FieldName(CustomerOrder.Summarize)]
        public string Summarize { get; set; }
        [FieldName(CustomerOrder.SyncReqd)]
        public string SyncReqd { get; set; }
        [FieldName(CustomerOrder.TakenBy)]
        public string TakenBy { get; set; }
        [FieldName(CustomerOrder.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(CustomerOrder.TaxCode1Desc)]
        public string TaxCode1Desc { get; set; }
        [FieldName(CustomerOrder.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(CustomerOrder.TaxCode2Desc)]
        public string TaxCode2Desc { get; set; }
        [FieldName(CustomerOrder.TransNat)]
        public string TransNat { get; set; }
        [FieldName(CustomerOrder.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(CustomerOrder.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(CustomerOrder.TransNatDesc)]
        public string TransNatDesc { get; set; }
        [FieldName(CustomerOrder.Type)]
        public string Type { get; set; }
        [FieldName(CustomerOrder.UbEstSetLineStat)]
        public string UbEstSetLineStat { get; set; }
        [FieldName(CustomerOrder.UbPackNum)]
        public string UbPackNum { get; set; }
        [FieldName(CustomerOrder.UbProgBillBillingDate)]
        public DateTime UbProgBillBillingDate { get; set; }
        [FieldName(CustomerOrder.UbProgBillDescription)]
        public string UbProgBillDescription { get; set; }
        [FieldName(CustomerOrder.UbProgBillInvoiceFlag)]
        public string UbProgBillInvoiceFlag { get; set; }
        [FieldName(CustomerOrder.UbProgBillPercentToBill)]
        public string UbProgBillPercentToBill { get; set; }
        [FieldName(CustomerOrder.UseExchRate)]
        public decimal UseExchRate { get; set; }
        [FieldName(CustomerOrder.VovhdCostT)]
        public string VovhdCostT { get; set; }
        [FieldName(CustomerOrder.Weight)]
        public decimal Weight { get; set; }
    }

    public class IDOCollectionsCriteria : IdoCriteria
    {
        public IDOCollectionsCriteria()
            : base(IDOCollections.IDO_NAME)
        {
        }
        [FieldName(IDOCollections.CollectionName)]
        public string CollectionName { get; set; }
        [FieldName(IDOCollections.IDO_NAME)]
        public string IDO_NAME { get; set; }
    }
    public class IDOPropertiesCriteria : IdoCriteria
    {
        public IDOPropertiesCriteria()
            : base(IDOProperties.IDO_NAME)
        {
        }
        [FieldName(IDOProperties.CollectionName)]
        public string CollectionName { get; set; }
        [FieldName(IDOProperties.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IDOProperties.PropertyName)]
        public string PropertyName { get; set; }
    }
    public class IDOMethodsCriteria : IdoCriteria
    {
        public IDOMethodsCriteria()
            : base(IDOMethods.IDO_NAME)
        {
        }
        [FieldName(IDOMethods.CollectionName)]
        public string CollectionName { get; set; }
        [FieldName(IDOMethods.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IDOMethods.MethodName)]
        public string MethodName { get; set; }
        [FieldName(IDOMethods.MethodDescription)]
        public string MethodDescription { get; set; }
    }
    public class ItemForecastCriteria : IdoCriteria
    {
        public ItemForecastCriteria()
            : base(ItemForecast.IDO_NAME)
        {
        }
        [FieldName(ItemForecast.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ItemForecast.AvailQty)]
        public int AvailQty { get; set; }
        [FieldName(ItemForecast.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(ItemForecast.CreatedBy)]
        public string CreatedBy { get; set; }
        [FieldName(ItemForecast.ForecastDate)]
        public DateTime ForecastDate { get; set; }
        [FieldName(ItemForecast.InWorkflow)]
        public bool InWorkflow { get; set; }
        [FieldName(ItemForecast.Item)]
        public string Item { get; set; }
        [FieldName(ItemForecast.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(ItemForecast.ItemUOM)]
        public string ItemUOM { get; set; }
        [FieldName(ItemForecast.NoteExists)]
        public bool NoteExists { get; set; }
        [FieldName(ItemForecast.OrigQty)]
        public int OrigQty { get; set; }
        [FieldName(ItemForecast.ProjectedDate)]
        public DateTime ProjectedDate { get; set; }
        [FieldName(ItemForecast.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(ItemForecast.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(ItemForecast.Status)]
        public string Status { get; set; }
        [FieldName(ItemForecast.UpdatedBy)]
        public string UpdatedBy { get; set; }
    }
    public class InventoryTransactionsCriteria : IdoCriteria
    {
        public InventoryTransactionsCriteria()
            : base(InventoryTransactions.IDO_NAME)
        {
        }
        [FieldName(InventoryTransactions.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(InventoryTransactions.AwaitingEop)]
        public string AwaitingEop { get; set; }
        [FieldName(InventoryTransactions.Backflush)]
        public string Backflush { get; set; }
        [FieldName(InventoryTransactions.Cost)]
        public string Cost { get; set; }
        [FieldName(InventoryTransactions.CostCode)]
        public string CostCode { get; set; }
        [FieldName(InventoryTransactions.DerAcct)]
        public string DerAcct { get; set; }
        [FieldName(InventoryTransactions.DerAmt)]
        public string DerAmt { get; set; }
        [FieldName(InventoryTransactions.DerFovhdAcct)]
        public string DerFovhdAcct { get; set; }
        [FieldName(InventoryTransactions.DerFovhdAmt)]
        public decimal DerFovhdAmt { get; set; }
        [FieldName(InventoryTransactions.DerFrom)]
        public string DerFrom { get; set; }
        [FieldName(InventoryTransactions.DerLbrAcct)]
        public string DerLbrAcct { get; set; }
        [FieldName(InventoryTransactions.DerLbrAmt)]
        public decimal DerLbrAmt { get; set; }
        [FieldName(InventoryTransactions.DerMatlAcct)]
        public string DerMatlAcct { get; set; }
        [FieldName(InventoryTransactions.DerMatlAmt)]
        public decimal DerMatlAmt { get; set; }
        [FieldName(InventoryTransactions.DerMatltranCost)]
        public decimal DerMatltranCost { get; set; }
        [FieldName(InventoryTransactions.DerMatlTranViewTotalPosted)]
        public string DerMatlTranViewTotalPosted { get; set; }
        [FieldName(InventoryTransactions.DerOutAcct)]
        public string DerOutAcct { get; set; }
        [FieldName(InventoryTransactions.DerOutAmt)]
        public decimal DerOutAmt { get; set; }
        [FieldName(InventoryTransactions.DerTo)]
        public string DerTo { get; set; }
        [FieldName(InventoryTransactions.DerTotalPosted)]
        public string DerTotalPosted { get; set; }
        [FieldName(InventoryTransactions.DerTransSeq)]
        public string DerTransSeq { get; set; }
        [FieldName(InventoryTransactions.DerType)]
        public string DerType { get; set; }
        [FieldName(InventoryTransactions.DerVovhdAcct)]
        public string DerVovhdAcct { get; set; }
        [FieldName(InventoryTransactions.DerVovhdAmt)]
        public string DerVovhdAmt { get; set; }
        [FieldName(InventoryTransactions.DocumentNum)]
        public string DocumentNum { get; set; }
        [FieldName(InventoryTransactions.FovhdCost)]
        public string FovhdCost { get; set; }
        [FieldName(InventoryTransactions.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(InventoryTransactions.Item)]
        public string Item { get; set; }
        [FieldName(InventoryTransactions.ItmItemDesc)]
        public string ItmItemDesc { get; set; }
        [FieldName(InventoryTransactions.ItmUM)]
        public string ItmUM { get; set; }
        [FieldName(InventoryTransactions.LbrCost)]
        public string LbrCost { get; set; }
        [FieldName(InventoryTransactions.Loc)]
        public string Loc { get; set; }
        [FieldName(InventoryTransactions.Lot)]
        public string Lot { get; set; }
        [FieldName(InventoryTransactions.MatlCost)]
        public decimal MatlCost { get; set; }
        [FieldName(InventoryTransactions.MatlTranViewReasonDesc)]
        public string MatlTranViewReasonDesc { get; set; }
        [FieldName(InventoryTransactions.MatlTranViewTotalCost)]
        public string MatlTranViewTotalCost { get; set; }
        [FieldName(InventoryTransactions.MatlTranViewTotalPost)]
        public string MatlTranViewTotalPost { get; set; }
        [FieldName(InventoryTransactions.MatlTranViewTypeDesc)]
        public string MatlTranViewTypeDesc { get; set; }
        [FieldName(InventoryTransactions.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(InventoryTransactions.OutCost)]
        public decimal OutCost { get; set; }
        [FieldName(InventoryTransactions.Qty)]
        public int Qty { get; set; }
        [FieldName(InventoryTransactions.ReasonCode)]
        public string ReasonCode { get; set; }
        [FieldName(InventoryTransactions.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(InventoryTransactions.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(InventoryTransactions.RefNum)]
        public string RefNum { get; set; }
        [FieldName(InventoryTransactions.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(InventoryTransactions.RefType)]
        public string RefType { get; set; }
        [FieldName(InventoryTransactions.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(InventoryTransactions.SLMatltranAmts)]
        public string SLMatltranAmts { get; set; }
        [FieldName(InventoryTransactions.TransDate)]
        public DateTime TransDate { get; set; }
        [FieldName(InventoryTransactions.TransNum)]
        public string TransNum { get; set; }
        [FieldName(InventoryTransactions.TransType)]
        public string TransType { get; set; }
        [FieldName(InventoryTransactions.TrnFromSite)]
        public string TrnFromSite { get; set; }
        [FieldName(InventoryTransactions.UserCode)]
        public string UserCode { get; set; }
        [FieldName(InventoryTransactions.VovhdCost)]
        public decimal VovhdCost { get; set; }
        [FieldName(InventoryTransactions.Wc)]
        public string Wc { get; set; }
        [FieldName(InventoryTransactions.Whse)]
        public string Whse { get; set; }
    }
    public class IdoItemLocsCriteria : IdoCriteria
    {
        public IdoItemLocsCriteria()
            : base(IdoItemLocs.IDO_NAME)
        {
        }
        [FieldName(IdoItemLocs.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoItemLocs.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(IdoItemLocs.DerIWhseQtyOnHand)]
        public string DerIWhseQtyOnHand { get; set; }
        [FieldName(IdoItemLocs.DerIWhseTotalNonNetStock)]
        public string DerIWhseTotalNonNetStock { get; set; }
        [FieldName(IdoItemLocs.DerIWhseTotalRsvdCO)]
        public string DerIWhseTotalRsvdCO { get; set; }
        [FieldName(IdoItemLocs.DerTotalCost)]
        public decimal DerTotalCost { get; set; }
        [FieldName(IdoItemLocs.DerUM)]
        public string DerUM { get; set; }
        [FieldName(IdoItemLocs.FovaccAccessUnit1)]
        public string FovaccAccessUnit1 { get; set; }
        [FieldName(IdoItemLocs.FovaccAccessUnit2)]
        public string FovaccAccessUnit2 { get; set; }
        [FieldName(IdoItemLocs.FovaccAccessUnit3)]
        public string FovaccAccessUnit3 { get; set; }
        [FieldName(IdoItemLocs.FovaccAccessUnit4)]
        public string FovaccAccessUnit4 { get; set; }
        [FieldName(IdoItemLocs.FovaccDescription)]
        public string FovaccDescription { get; set; }
        [FieldName(IdoItemLocs.FovhdAcct)]
        public string FovhdAcct { get; set; }
        [FieldName(IdoItemLocs.FovhdAcctUnit1)]
        public string FovhdAcctUnit1 { get; set; }
        [FieldName(IdoItemLocs.FovhdAcctUnit2)]
        public string FovhdAcctUnit2 { get; set; }
        [FieldName(IdoItemLocs.FovhdAcctUnit3)]
        public string FovhdAcctUnit3 { get; set; }
        [FieldName(IdoItemLocs.FovhdAcctUnit4)]
        public string FovhdAcctUnit4 { get; set; }
        [FieldName(IdoItemLocs.FovhdCost)]
        public decimal FovhdCost { get; set; }
        [FieldName(IdoItemLocs.InvaccAccessUnit1)]
        public string InvaccAccessUnit1 { get; set; }
        [FieldName(IdoItemLocs.InvaccAccessUnit2)]
        public string InvaccAccessUnit2 { get; set; }
        [FieldName(IdoItemLocs.InvaccAccessUnit3)]
        public string InvaccAccessUnit3 { get; set; }
        [FieldName(IdoItemLocs.InvaccAccessUnit4)]
        public string InvaccAccessUnit4 { get; set; }
        [FieldName(IdoItemLocs.InvaccDescription)]
        public string InvaccDescription { get; set; }
        [FieldName(IdoItemLocs.InvAcct)]
        public string InvAcct { get; set; }
        [FieldName(IdoItemLocs.InvAcctUnit1)]
        public string InvAcctUnit1 { get; set; }
        [FieldName(IdoItemLocs.InvAcctUnit2)]
        public string InvAcctUnit2 { get; set; }
        [FieldName(IdoItemLocs.InvAcctUnit3)]
        public string InvAcctUnit3 { get; set; }
        [FieldName(IdoItemLocs.InvAcctUnit4)]
        public string InvAcctUnit4 { get; set; }
        [FieldName(IdoItemLocs.InvpBflushLoc)]
        public string InvpBflushLoc { get; set; }
        [FieldName(IdoItemLocs.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoItemLocs.Item)]
        public string Item { get; set; }
        [FieldName(IdoItemLocs.ItmBflushLoc)]
        public string ItmBflushLoc { get; set; }
        [FieldName(IdoItemLocs.ItmCostMethod)]
        public string ItmCostMethod { get; set; }
        [FieldName(IdoItemLocs.ItmCostType)]
        public string ItmCostType { get; set; }
        [FieldName(IdoItemLocs.ItmDescription)]
        public string ItmDescription { get; set; }
        [FieldName(IdoItemLocs.ItmIssueBy)]
        public string ItmIssueBy { get; set; }
        [FieldName(IdoItemLocs.ItmItem)]
        public string ItmItem { get; set; }
        [FieldName(IdoItemLocs.ItmLotTracked)]
        public string ItmLotTracked { get; set; }
        [FieldName(IdoItemLocs.ItmSerialTracked)]
        public string ItmSerialTracked { get; set; }
        [FieldName(IdoItemLocs.ItmUM)]
        public string ItmUM { get; set; }
        [FieldName(IdoItemLocs.ItmwhseQtyOnHand)]
        public string ItmwhseQtyOnHand { get; set; }
        [FieldName(IdoItemLocs.JmatlJob)]
        public string JmatlJob { get; set; }
        [FieldName(IdoItemLocs.LbraccAccessUnit1)]
        public string LbraccAccessUnit1 { get; set; }
        [FieldName(IdoItemLocs.LbraccAccessUnit2)]
        public string LbraccAccessUnit2 { get; set; }
        [FieldName(IdoItemLocs.LbraccAccessUnit3)]
        public string LbraccAccessUnit3 { get; set; }
        [FieldName(IdoItemLocs.LbraccAccessUnit4)]
        public string LbraccAccessUnit4 { get; set; }
        [FieldName(IdoItemLocs.LbraccDescription)]
        public string LbraccDescription { get; set; }
        [FieldName(IdoItemLocs.LbrAcct)]
        public string LbrAcct { get; set; }
        [FieldName(IdoItemLocs.LbrAcctUnit1)]
        public string LbrAcctUnit1 { get; set; }
        [FieldName(IdoItemLocs.LbrAcctUnit2)]
        public string LbrAcctUnit2 { get; set; }
        [FieldName(IdoItemLocs.LbrAcctUnit3)]
        public string LbrAcctUnit3 { get; set; }
        [FieldName(IdoItemLocs.LbrAcctUnit4)]
        public string LbrAcctUnit4 { get; set; }
        [FieldName(IdoItemLocs.LbrCost)]
        public decimal LbrCost { get; set; }
        [FieldName(IdoItemLocs.Loc)]
        public string Loc { get; set; }
        [FieldName(IdoItemLocs.LocDescription)]
        public string LocDescription { get; set; }
        [FieldName(IdoItemLocs.LocLoc)]
        public string LocLoc { get; set; }
        [FieldName(IdoItemLocs.LocType)]
        public string LocType { get; set; }
        [FieldName(IdoItemLocs.LocWc)]
        public string LocWc { get; set; }
        [FieldName(IdoItemLocs.MatlCost)]
        public decimal MatlCost { get; set; }
        [FieldName(IdoItemLocs.MrbFlag)]
        public string MrbFlag { get; set; }
        [FieldName(IdoItemLocs.NewRank)]
        public string NewRank { get; set; }
        [FieldName(IdoItemLocs.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoItemLocs.OutaccAccessUnit1)]
        public string OutaccAccessUnit1 { get; set; }
        [FieldName(IdoItemLocs.OutaccAccessUnit2)]
        public string OutaccAccessUnit2 { get; set; }
        [FieldName(IdoItemLocs.OutaccAccessUnit3)]
        public string OutaccAccessUnit3 { get; set; }
        [FieldName(IdoItemLocs.OutaccAccessUnit4)]
        public string OutaccAccessUnit4 { get; set; }
        [FieldName(IdoItemLocs.OutaccDescription)]
        public string OutaccDescription { get; set; }
        [FieldName(IdoItemLocs.OutAcct)]
        public string OutAcct { get; set; }
        [FieldName(IdoItemLocs.OutAcctUnit1)]
        public string OutAcctUnit1 { get; set; }
        [FieldName(IdoItemLocs.OutAcctUnit2)]
        public string OutAcctUnit2 { get; set; }
        [FieldName(IdoItemLocs.OutAcctUnit3)]
        public string OutAcctUnit3 { get; set; }
        [FieldName(IdoItemLocs.OutAcctUnit4)]
        public string OutAcctUnit4 { get; set; }
        [FieldName(IdoItemLocs.OutCost)]
        public string OutCost { get; set; }
        [FieldName(IdoItemLocs.PermFlag)]
        public string PermFlag { get; set; }
        [FieldName(IdoItemLocs.QtyOnHand)]
        public int QtyOnHand { get; set; }
        [FieldName(IdoItemLocs.QtyRsvd)]
        public int QtyRsvd { get; set; }
        [FieldName(IdoItemLocs.Rank)]
        public string Rank { get; set; }
        [FieldName(IdoItemLocs.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoItemLocs.RecordState)]
        public string RecordState { get; set; }
        [FieldName(IdoItemLocs.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoItemLocs.SLSerials)]
        public string SLSerials { get; set; }
        [FieldName(IdoItemLocs.UbToLoc)]
        public string UbToLoc { get; set; }
        [FieldName(IdoItemLocs.UBTrnDate)]
        public DateTime UBTrnDate { get; set; }
        [FieldName(IdoItemLocs.UBTrnDesc)]
        public string UBTrnDesc { get; set; }
        [FieldName(IdoItemLocs.UBTrnReasonCode)]
        public string UBTrnReasonCode { get; set; }
        [FieldName(IdoItemLocs.UBTrnType)]
        public string UBTrnType { get; set; }
        [FieldName(IdoItemLocs.UnitCost)]
        public decimal UnitCost { get; set; }
        [FieldName(IdoItemLocs.VovacctAccessUnit1)]
        public string VovacctAccessUnit1 { get; set; }
        [FieldName(IdoItemLocs.VovacctAccessUnit2)]
        public string VovacctAccessUnit2 { get; set; }
        [FieldName(IdoItemLocs.VovacctAccessUnit3)]
        public string VovacctAccessUnit3 { get; set; }
        [FieldName(IdoItemLocs.VovacctAccessUnit4)]
        public string VovacctAccessUnit4 { get; set; }
        [FieldName(IdoItemLocs.VovacctDescription)]
        public string VovacctDescription { get; set; }
        [FieldName(IdoItemLocs.VovhdAcct)]
        public string VovhdAcct { get; set; }
        [FieldName(IdoItemLocs.VovhdAcctUnit1)]
        public string VovhdAcctUnit1 { get; set; }
        [FieldName(IdoItemLocs.VovhdAcctUnit2)]
        public string VovhdAcctUnit2 { get; set; }
        [FieldName(IdoItemLocs.VovhdAcctUnit3)]
        public string VovhdAcctUnit3 { get; set; }
        [FieldName(IdoItemLocs.VovhdAcctUnit4)]
        public string VovhdAcctUnit4 { get; set; }
        [FieldName(IdoItemLocs.VovhdCost)]
        public decimal VovhdCost { get; set; }
        [FieldName(IdoItemLocs.Wc)]
        public string Wc { get; set; }
        [FieldName(IdoItemLocs.Whse)]
        public string Whse { get; set; }
        [FieldName(IdoItemLocs.WhsName)]
        public string WhsName { get; set; }
        [FieldName(IdoItemLocs.WhsWhse)]
        public string WhsWhse { get; set; }
    }

    public class IdoPurchaseOrderCriteria : IdoCriteria
    {
        public IdoPurchaseOrderCriteria()
            : base(IdoPurchaseOrder.IDO_NAME)
        {
        }
        [FieldName(IdoPurchaseOrder.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoPurchaseOrder.ActBrokerage)]
        public string ActBrokerage { get; set; }
        [FieldName(IdoPurchaseOrder.ActDuty)]
        public string ActDuty { get; set; }
        [FieldName(IdoPurchaseOrder.ActFreight)]
        public string ActFreight { get; set; }
        [FieldName(IdoPurchaseOrder.ActInsurance)]
        public string ActInsurance { get; set; }
        [FieldName(IdoPurchaseOrder.ActLocalFreight)]
        public string ActLocalFreight { get; set; }
        [FieldName(IdoPurchaseOrder.BrkAllocMeth)]
        public string BrkAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrder.BrkAllocPercent)]
        public string BrkAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrder.BrkAllocType)]
        public string BrkAllocType { get; set; }
        [FieldName(IdoPurchaseOrder.BrkVendCurrCode)]
        public string BrkVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.BrokerageAmt)]
        public decimal BrokerageAmt { get; set; }
        [FieldName(IdoPurchaseOrder.BrokerageAmtT)]
        public string BrokerageAmtT { get; set; }
        [FieldName(IdoPurchaseOrder.BrokerageVendName)]
        public string BrokerageVendName { get; set; }
        [FieldName(IdoPurchaseOrder.BrokerageVendNum)]
        public string BrokerageVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.BuilderPoNum)]
        public string BuilderPoNum { get; set; }
        [FieldName(IdoPurchaseOrder.BuilderPoOrigSite)]
        public string BuilderPoOrigSite { get; set; }
        [FieldName(IdoPurchaseOrder.BuilderPoPrinted)]
        public string BuilderPoPrinted { get; set; }
        [FieldName(IdoPurchaseOrder.Buyer)]
        public string Buyer { get; set; }
        [FieldName(IdoPurchaseOrder.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(IdoPurchaseOrder.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(IdoPurchaseOrder.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(IdoPurchaseOrder.ContainsOnlyTaxFreeMatls)]
        public string ContainsOnlyTaxFreeMatls { get; set; }
        [FieldName(IdoPurchaseOrder.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(IdoPurchaseOrder.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(IdoPurchaseOrder.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(IdoPurchaseOrder.Datefld)]
        public string Datefld { get; set; }
        [FieldName(IdoPurchaseOrder.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(IdoPurchaseOrder.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(IdoPurchaseOrder.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(IdoPurchaseOrder.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoPurchaseOrder.DelTermDescription)]
        public string DelTermDescription { get; set; }
        [FieldName(IdoPurchaseOrder.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(IdoPurchaseOrder.DerExistsLine)]
        public string DerExistsLine { get; set; }
        [FieldName(IdoPurchaseOrder.DerExistsPoBln)]
        public string DerExistsPoBln { get; set; }
        [FieldName(IdoPurchaseOrder.DerHasXref)]
        public string DerHasXref { get; set; }
        [FieldName(IdoPurchaseOrder.DerIsFixed)]
        public string DerIsFixed { get; set; }
        [FieldName(IdoPurchaseOrder.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(IdoPurchaseOrder.DerNewStat)]
        public string DerNewStat { get; set; }
        [FieldName(IdoPurchaseOrder.DerNULLValue)]
        public string DerNULLValue { get; set; }
        [FieldName(IdoPurchaseOrder.DerOldStat)]
        public string DerOldStat { get; set; }
        [FieldName(IdoPurchaseOrder.DerOldVendNum)]
        public string DerOldVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.DerPchChgNum)]
        public string DerPchChgNum { get; set; }
        [FieldName(IdoPurchaseOrder.DerPchStat)]
        public string DerPchStat { get; set; }
        [FieldName(IdoPurchaseOrder.DerPoNum)]
        public string DerPoNum { get; set; }
        [FieldName(IdoPurchaseOrder.DerStatFormatted)]
        public string DerStatFormatted { get; set; }
        [FieldName(IdoPurchaseOrder.DerUpdatable)]
        public string DerUpdatable { get; set; }
        [FieldName(IdoPurchaseOrder.DistDate)]
        public DateTime DistDate { get; set; }
        [FieldName(IdoPurchaseOrder.DropSeq)]
        public string DropSeq { get; set; }
        [FieldName(IdoPurchaseOrder.DropShipNo)]
        public string DropShipNo { get; set; }
        [FieldName(IdoPurchaseOrder.DutyAllocMeth)]
        public string DutyAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrder.DutyAllocPercent)]
        public string DutyAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrder.DutyAllocType)]
        public string DutyAllocType { get; set; }
        [FieldName(IdoPurchaseOrder.DutyAmt)]
        public string DutyAmt { get; set; }
        [FieldName(IdoPurchaseOrder.DutyAmtT)]
        public string DutyAmtT { get; set; }
        [FieldName(IdoPurchaseOrder.DutyVendCurrCode)]
        public string DutyVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.DutyVendName)]
        public string DutyVendName { get; set; }
        [FieldName(IdoPurchaseOrder.DutyVendNum)]
        public string DutyVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.EffDate)]
        public DateTime EffDate { get; set; }
        [FieldName(IdoPurchaseOrder.EstBrokerage)]
        public decimal EstBrokerage { get; set; }
        [FieldName(IdoPurchaseOrder.EstDuty)]
        public decimal EstDuty { get; set; }
        [FieldName(IdoPurchaseOrder.EstFreight)]
        public decimal EstFreight { get; set; }
        [FieldName(IdoPurchaseOrder.EstInsurance)]
        public decimal EstInsurance { get; set; }
        [FieldName(IdoPurchaseOrder.EstLocalFreight)]
        public decimal EstLocalFreight { get; set; }
        [FieldName(IdoPurchaseOrder.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(IdoPurchaseOrder.ExpDate)]
        public DateTime ExpDate { get; set; }
        [FieldName(IdoPurchaseOrder.FixedRate)]
        public string FixedRate { get; set; }
        [FieldName(IdoPurchaseOrder.FlagChangeStat)]
        public string FlagChangeStat { get; set; }
        [FieldName(IdoPurchaseOrder.FlagPochange)]
        public string FlagPochange { get; set; }
        [FieldName(IdoPurchaseOrder.Fob)]
        public string Fob { get; set; }
        [FieldName(IdoPurchaseOrder.FormatedShipToAddress)]
        public string FormatedShipToAddress { get; set; }
        [FieldName(IdoPurchaseOrder.FormatedVendAddress)]
        public string FormatedVendAddress { get; set; }
        [FieldName(IdoPurchaseOrder.Freight)]
        public string Freight { get; set; }
        [FieldName(IdoPurchaseOrder.FreightT)]
        public string FreightT { get; set; }
        [FieldName(IdoPurchaseOrder.FreightVendName)]
        public string FreightVendName { get; set; }
        [FieldName(IdoPurchaseOrder.FreightVendNum)]
        public string FreightVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.FrtAllocMeth)]
        public string FrtAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrder.FrtAllocPercent)]
        public decimal FrtAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrder.FrtAllocType)]
        public string FrtAllocType { get; set; }
        [FieldName(IdoPurchaseOrder.FrtTaxCode1)]
        public string FrtTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrder.FrtTaxCode2)]
        public string FrtTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrder.FrtVendCurrCode)]
        public string FrtVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.Ftx1Description)]
        public string Ftx1Description { get; set; }
        [FieldName(IdoPurchaseOrder.Ftx2Description)]
        public string Ftx2Description { get; set; }
        [FieldName(IdoPurchaseOrder.IncludeTaxInCost)]
        public string IncludeTaxInCost { get; set; }
        [FieldName(IdoPurchaseOrder.InsAllocMeth)]
        public string InsAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrder.InsAllocPercent)]
        public decimal InsAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrder.InsAllocType)]
        public string InsAllocType { get; set; }
        [FieldName(IdoPurchaseOrder.InsuranceAmt)]
        public decimal InsuranceAmt { get; set; }
        [FieldName(IdoPurchaseOrder.InsuranceAmtT)]
        public string InsuranceAmtT { get; set; }
        [FieldName(IdoPurchaseOrder.InsVendCurrCode)]
        public string InsVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.InsVendName)]
        public string InsVendName { get; set; }
        [FieldName(IdoPurchaseOrder.InsVendNum)]
        public string InsVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.InvDate)]
        public DateTime InvDate { get; set; }
        [FieldName(IdoPurchaseOrder.InvNum)]
        public string InvNum { get; set; }
        [FieldName(IdoPurchaseOrder.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoPurchaseOrder.LocalFreightAmt)]
        public decimal LocalFreightAmt { get; set; }
        [FieldName(IdoPurchaseOrder.LocalFreightAmtT)]
        public string LocalFreightAmtT { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtAllocMeth)]
        public string LocFrtAllocMeth { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtAllocPercent)]
        public decimal LocFrtAllocPercent { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtAllocType)]
        public string LocFrtAllocType { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtVendCurrCode)]
        public string LocFrtVendCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtVendName)]
        public string LocFrtVendName { get; set; }
        [FieldName(IdoPurchaseOrder.LocFrtVendNum)]
        public string LocFrtVendNum { get; set; }
        [FieldName(IdoPurchaseOrder.Logifld)]
        public string Logifld { get; set; }
        [FieldName(IdoPurchaseOrder.MChargesT)]
        public decimal MChargesT { get; set; }
        [FieldName(IdoPurchaseOrder.MiscCharges)]
        public decimal MiscCharges { get; set; }
        [FieldName(IdoPurchaseOrder.Msc1Description)]
        public string Msc1Description { get; set; }
        [FieldName(IdoPurchaseOrder.Msc2Description)]
        public string Msc2Description { get; set; }
        [FieldName(IdoPurchaseOrder.MscTaxCode1)]
        public string MscTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrder.MscTaxCode2)]
        public string MscTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrder.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoPurchaseOrder.OrderDate)]
        public DateTime OrderDate { get; set; }
        [FieldName(IdoPurchaseOrder.PchChgNum)]
        public string PchChgNum { get; set; }
        [FieldName(IdoPurchaseOrder.PchStat)]
        public string PchStat { get; set; }
        [FieldName(IdoPurchaseOrder.PoCost)]
        public decimal PoCost { get; set; }
        [FieldName(IdoPurchaseOrder.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoPurchaseOrder.PoparAmendPo)]
        public string PoparAmendPo { get; set; }
        [FieldName(IdoPurchaseOrder.PoparPoChange)]
        public string PoparPoChange { get; set; }
        [FieldName(IdoPurchaseOrder.PoparVendorRequired)]
        public string PoparVendorRequired { get; set; }
        [FieldName(IdoPurchaseOrder.PrepaidAmt)]
        public decimal PrepaidAmt { get; set; }
        [FieldName(IdoPurchaseOrder.PrepaidT)]
        public string PrepaidT { get; set; }
        [FieldName(IdoPurchaseOrder.PrintPrice)]
        public decimal PrintPrice { get; set; }
        [FieldName(IdoPurchaseOrder.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoPurchaseOrder.Received)]
        public string Received { get; set; }
        [FieldName(IdoPurchaseOrder.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoPurchaseOrder.ReqNum)]
        public string ReqNum { get; set; }
        [FieldName(IdoPurchaseOrder.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoPurchaseOrder.SalesTax)]
        public decimal SalesTax { get; set; }
        [FieldName(IdoPurchaseOrder.SalesTax2)]
        public decimal SalesTax2 { get; set; }
        [FieldName(IdoPurchaseOrder.SalesTaxT)]
        public decimal SalesTaxT { get; set; }
        [FieldName(IdoPurchaseOrder.SalesTaxT2)]
        public decimal SalesTaxT2 { get; set; }
        [FieldName(IdoPurchaseOrder.ShipAddr)]
        public string ShipAddr { get; set; }
        [FieldName(IdoPurchaseOrder.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(IdoPurchaseOrder.ShipCodeDesc)]
        public string ShipCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrder.SLPochanges)]
        public string SLPochanges { get; set; }
        [FieldName(IdoPurchaseOrder.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoPurchaseOrder.SupplyWebPoStat)]
        public string SupplyWebPoStat { get; set; }
        [FieldName(IdoPurchaseOrder.SynchronizedToBus)]
        public string SynchronizedToBus { get; set; }
        [FieldName(IdoPurchaseOrder.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrder.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrder.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(IdoPurchaseOrder.TermsCodeDesc)]
        public string TermsCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrder.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoPurchaseOrder.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoPurchaseOrder.TransNat2Desc)]
        public string TransNat2Desc { get; set; }
        [FieldName(IdoPurchaseOrder.TransNatDesc)]
        public string TransNatDesc { get; set; }
        [FieldName(IdoPurchaseOrder.Tx1Description)]
        public string Tx1Description { get; set; }
        [FieldName(IdoPurchaseOrder.Tx2Description)]
        public string Tx2Description { get; set; }
        [FieldName(IdoPurchaseOrder.Type)]
        public string Type { get; set; }
        [FieldName(IdoPurchaseOrder.VenCurrCode)]
        public string VenCurrCode { get; set; }
        [FieldName(IdoPurchaseOrder.VendCatDesc)]
        public string VendCatDesc { get; set; }
        [FieldName(IdoPurchaseOrder.VendCategory)]
        public string VendCategory { get; set; }
        [FieldName(IdoPurchaseOrder.VendContact)]
        public string VendContact { get; set; }
        [FieldName(IdoPurchaseOrder.VendCountry)]
        public string VendCountry { get; set; }
        [FieldName(IdoPurchaseOrder.VendFaxNum)]
        public string VendFaxNum { get; set; }
        [FieldName(IdoPurchaseOrder.VendLcrNum)]
        public string VendLcrNum { get; set; }
        [FieldName(IdoPurchaseOrder.VendNum)]
        public string VendNum { get; set; }
        [FieldName(IdoPurchaseOrder.VendOrder)]
        public string VendOrder { get; set; }
        [FieldName(IdoPurchaseOrder.VendorName)]
        public string VendorName { get; set; }
        [FieldName(IdoPurchaseOrder.VendPhone)]
        public string VendPhone { get; set; }
        [FieldName(IdoPurchaseOrder.VendTelexNum)]
        public string VendTelexNum { get; set; }
        [FieldName(IdoPurchaseOrder.VendType)]
        public string VendType { get; set; }
        [FieldName(IdoPurchaseOrder.VenLcrReqd)]
        public string VenLcrReqd { get; set; }
        [FieldName(IdoPurchaseOrder.Whse)]
        public string Whse { get; set; }
        [FieldName(IdoPurchaseOrder.WhsName)]
        public string WhsName { get; set; }
    }



    public class LotLocationCriteria : IdoCriteria
    {
        public LotLocationCriteria()
            : base(LotLocation.IDO_NAME)
        {
        }
        [FieldName(LotLocation.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(LotLocation.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(LotLocation.DerTotalCost)]
        public decimal DerTotalCost { get; set; }
        [FieldName(LotLocation.DerTotalItemWhseOnHand)]
        public int DerTotalItemWhseOnHand { get; set; }
        [FieldName(LotLocation.DerTotalItemWhseReserved)]
        public int DerTotalItemWhseReserved { get; set; }
        [FieldName(LotLocation.DerTotalNonNettableStock)]
        public int DerTotalNonNettableStock { get; set; }
        [FieldName(LotLocation.DerTotalUnitCost)]
        public decimal DerTotalUnitCost { get; set; }
        [FieldName(LotLocation.FovhdCost)]
        public decimal FovhdCost { get; set; }
        [FieldName(LotLocation.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(LotLocation.Item)]
        public string Item { get; set; }
        [FieldName(LotLocation.ItemCostMethod)]
        public string ItemCostMethod { get; set; }
        [FieldName(LotLocation.ItemCostType)]
        public string ItemCostType { get; set; }
        [FieldName(LotLocation.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(LotLocation.ItemIssueBy)]
        public string ItemIssueBy { get; set; }
        [FieldName(LotLocation.ItemLotTracked)]
        public string ItemLotTracked { get; set; }
        [FieldName(LotLocation.ItemSerialTracked)]
        public string ItemSerialTracked { get; set; }
        [FieldName(LotLocation.ItemUM)]
        public string ItemUM { get; set; }
        [FieldName(LotLocation.ItmlcLocType)]
        public string ItmlcLocType { get; set; }
        [FieldName(LotLocation.ItwCntInProc)]
        public string ItwCntInProc { get; set; }
        [FieldName(LotLocation.LbrCost)]
        public decimal LbrCost { get; set; }
        [FieldName(LotLocation.Loc)]
        public string Loc { get; set; }
        [FieldName(LotLocation.LocationDescription)]
        public string LocationDescription { get; set; }
        [FieldName(LotLocation.Lot)]
        public string Lot { get; set; }
        [FieldName(LotLocation.MatlCost)]
        public string MatlCost { get; set; }
        [FieldName(LotLocation.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(LotLocation.OutCost)]
        public decimal OutCost { get; set; }
        [FieldName(LotLocation.QtyOnHand)]
        public int QtyOnHand { get; set; }
        [FieldName(LotLocation.QtyRsvd)]
        public int QtyRsvd { get; set; }
        [FieldName(LotLocation.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(LotLocation.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(LotLocation.UnitCost)]
        public decimal UnitCost { get; set; }
        [FieldName(LotLocation.VovhdCost)]
        public string VovhdCost { get; set; }
        [FieldName(LotLocation.Whse)]
        public string Whse { get; set; }
        [FieldName(LotLocation.WhseName)]
        public string WhseName { get; set; }
        [FieldName(LotLocation.WhsePhyInvFlg)]
        public string WhsePhyInvFlg { get; set; }
    }


    public class ReceiptsCriteria : IdoCriteria
    {
        public ReceiptsCriteria()
            : base(Receipts.IDO_NAME)
        {
        }
        [FieldName(Receipts.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Receipts.ByCons)]
        public string ByCons { get; set; }
        [FieldName(Receipts.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(Receipts.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(Receipts.CurrDescription)]
        public string CurrDescription { get; set; }
        [FieldName(Receipts.CurrhAmtTotFormat)]
        public string CurrhAmtTotFormat { get; set; }
        [FieldName(Receipts.CurrhCstPrcFormat)]
        public string CurrhCstPrcFormat { get; set; }
        [FieldName(Receipts.CurrhDescription)]
        public string CurrhDescription { get; set; }
        [FieldName(Receipts.DateSeq)]
        public string DateSeq { get; set; }
        [FieldName(Receipts.DerHItemCostConv)]
        public decimal DerHItemCostConv { get; set; }
        [FieldName(Receipts.DerHPoitemTotalCost)]
        public decimal DerHPoitemTotalCost { get; set; }
        [FieldName(Receipts.DerHQtyReceivedConv)]
        public decimal DerHQtyReceivedConv { get; set; }
        [FieldName(Receipts.DerHQtyReturnedConv)]
        public decimal DerHQtyReturnedConv { get; set; }
        [FieldName(Receipts.DerHTotalCostConv)]
        public decimal DerHTotalCostConv { get; set; }
        [FieldName(Receipts.DerItemCostConv)]
        public decimal DerItemCostConv { get; set; }
        [FieldName(Receipts.PoitemTotalCost)]
        public decimal PoitemTotalCost { get; set; }
        [FieldName(Receipts.DerQtyReceivedConv)]
        public decimal DerQtyReceivedConv { get; set; }
        [FieldName(Receipts.DerQtyReturnedConv)]
        public decimal DerQtyReturnedConv { get; set; }
        [FieldName(Receipts.DerTotalCostConv)]
        public decimal DerTotalCostConv { get; set; }
        [FieldName(Receipts.ExchRate)]
        public decimal ExchRate { get; set; }
        [FieldName(Receipts.GrnLine)]
        public string GrnLine { get; set; }
        [FieldName(Receipts.GrnNum)]
        public string GrnNum { get; set; }
        [FieldName(Receipts.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Receipts.ItemCost)]
        public decimal ItemCost { get; set; }
        [FieldName(Receipts.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Receipts.PackNum)]
        public string PackNum { get; set; }
        [FieldName(Receipts.PohExchRate)]
        public decimal PohExchRate { get; set; }
        [FieldName(Receipts.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(Receipts.PoihDescription)]
        public string PoihDescription { get; set; }
        [FieldName(Receipts.PoihItem)]
        public string PoihItem { get; set; }
        [FieldName(Receipts.PoihItemCostConv)]
        public decimal PoihItemCostConv { get; set; }
        [FieldName(Receipts.PoihPlanCostConv)]
        public decimal PoihPlanCostConv { get; set; }
        [FieldName(Receipts.PoihQtyOrderedConv)]
        public decimal PoihQtyOrderedConv { get; set; }
        [FieldName(Receipts.PoiItemCostConv)]
        public decimal PoiItemCostConv { get; set; }
        [FieldName(Receipts.PoiPlanCostConv)]
        public decimal PoiPlanCostConv { get; set; }
        [FieldName(Receipts.PoiQtyOrdered)]
        public int PoiQtyOrdered { get; set; }
        [FieldName(Receipts.PoiQtyOrderedConv)]
        public decimal PoiQtyOrderedConv { get; set; }
        [FieldName(Receipts.Item)]
        public string Item { get; set; }
        [FieldName(Receipts.UM)]
        public string UM { get; set; }
        [FieldName(Receipts.PoLine)]
        public string PoLine { get; set; }
        [FieldName(Receipts.PoNum)]
        public string PoNum { get; set; }
        [FieldName(Receipts.PoOrderDate)]
        public DateTime PoOrderDate { get; set; }
        [FieldName(Receipts.PoRelease)]
        public string PoRelease { get; set; }
        [FieldName(Receipts.Status)]
        public string PoStat { get; set; }
        [FieldName(Receipts.PoVendNum)]
        public string PoVendNum { get; set; }
        [FieldName(Receipts.QtyReceived)]
        public int QtyReceived { get; set; }
        [FieldName(Receipts.QtyReturned)]
        public int QtyReturned { get; set; }
        [FieldName(Receipts.QtyVouchered)]
        public int QtyVouchered { get; set; }
        [FieldName(Receipts.RcvdDate)]
        public DateTime RcvdDate { get; set; }
        [FieldName(Receipts.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Receipts.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Receipts.SupplQty)]
        public int SupplQty { get; set; }
        [FieldName(Receipts.UbSelectedGrn)]
        public string UbSelectedGrn { get; set; }
        [FieldName(Receipts.UnitBrokerageCost)]
        public decimal UnitBrokerageCost { get; set; }
        [FieldName(Receipts.UnitDutyCost)]
        public decimal UnitDutyCost { get; set; }
        [FieldName(Receipts.UnitFreightCost)]
        public decimal UnitFreightCost { get; set; }
        [FieldName(Receipts.UnitMatCost)]
        public decimal UnitMatCost { get; set; }
        [FieldName(Receipts.UnitWeight)]
        public decimal UnitWeight { get; set; }
        [FieldName(Receipts.VenaddhName)]
        public string VenaddhName { get; set; }
        [FieldName(Receipts.VenaddName)]
        public string VenaddName { get; set; }
        [FieldName(Receipts.VendCurrCode)]
        public string VendCurrCode { get; set; }
        [FieldName(Receipts.VendhCurrCode)]
        public string VendhCurrCode { get; set; }
        [FieldName(Receipts.VendNum)]
        public string VendNum { get; set; }
    }

    public class UserSessionCriteria : IdoCriteria
    {
        public UserSessionCriteria ():base(UserSession.IDO_NAME){}
        [FieldName(UserSession.ConnectionID)]
        public string ConnectionID { get; set; }
        [FieldName(UserSession.UserName)]
        public string UserName { get; set; }
        [FieldName(UserSession.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(UserSession.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(UserSession.UpdatedBy)]
        public string UpdatedBy { get; set; }

    }

    public class ArInvoicesCriteria : IdoCriteria
    {
        public ArInvoicesCriteria(string idoName) : base(ArInvoices.IDO_NAME)
        {
        }
        [FieldName(ArInvoices.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(ArInvoices.InvoiceNumber)]
        public string InvoiceNumber { get; set; }

        [FieldName(ArInvoices.InvoiceDate)]
        public DateTime InvoiceDate { get; set; }

        [FieldName(ArInvoices.InvoiceTotal)]
        public decimal InvoiceTotal { get; set; }

        [FieldName(ArInvoices.Amount)]
        public decimal Amount { get; set; }

        [FieldName(ArInvoices.SalesTax)]
        public decimal SalesTax { get; set; }

        [FieldName(ArInvoices.CustID)]
        public string CustID { get; set; }

        [FieldName(ArInvoices.OrderNumber)]
        public string OrderNumber { get; set; }


    }
    public class VendorsCriteria : IdoCriteria
    {
        public VendorsCriteria()
            : base(Vendors.IDO_NAME)
        {
        }
        [FieldName(Vendors.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Vendors.Account)]
        public string Account { get; set; }
        [FieldName(Vendors.AccountName)]
        public string AccountName { get; set; }
        [FieldName(Vendors.ActiveForDataIntegration)]
        public string ActiveForDataIntegration { get; set; }
        [FieldName(Vendors.BankaAddr1)]
        public string BankaAddr1 { get; set; }
        [FieldName(Vendors.BankaAddr2)]
        public string BankaAddr2 { get; set; }
        [FieldName(Vendors.BankaAddr3)]
        public string BankaAddr3 { get; set; }
        [FieldName(Vendors.BankaAddr4)]
        public string BankaAddr4 { get; set; }
        [FieldName(Vendors.BankaCity)]
        public string BankaCity { get; set; }
        [FieldName(Vendors.BankaCountry)]
        public string BankaCountry { get; set; }
        [FieldName(Vendors.BankaState)]
        public string BankaState { get; set; }
        [FieldName(Vendors.BankaZip)]
        public string BankaZip { get; set; }
        [FieldName(Vendors.BankCode)]
        public string BankCode { get; set; }
        [FieldName(Vendors.BhName)]
        public string BhName { get; set; }
        [FieldName(Vendors.BranchId)]
        public string BranchId { get; set; }
        [FieldName(Vendors.Category)]
        public string Category { get; set; }
        [FieldName(Vendors.Charfld1)]
        public string Charfld1 { get; set; }
        [FieldName(Vendors.Charfld2)]
        public string Charfld2 { get; set; }
        [FieldName(Vendors.Charfld3)]
        public string Charfld3 { get; set; }
        [FieldName(Vendors.Contact)]
        public string Contact { get; set; }
        [FieldName(Vendors.CouEcCode)]
        public string CouEcCode { get; set; }
        [FieldName(Vendors.CurrAmtFormat)]
        public string CurrAmtFormat { get; set; }
        [FieldName(Vendors.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(Vendors.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(Vendors.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(Vendors.CurrDescription)]
        public string CurrDescription { get; set; }
        [FieldName(Vendors.CurrPartOfEuro)]
        public string CurrPartOfEuro { get; set; }
        [FieldName(Vendors.Datefld)]
        public string Datefld { get; set; }
        [FieldName(Vendors.Decifld1)]
        public string Decifld1 { get; set; }
        [FieldName(Vendors.Decifld2)]
        public string Decifld2 { get; set; }
        [FieldName(Vendors.Decifld3)]
        public string Decifld3 { get; set; }
        [FieldName(Vendors.Delterm)]
        public string Delterm { get; set; }
        [FieldName(Vendors.DelTermDescription)]
        public string DelTermDescription { get; set; }
        [FieldName(Vendors.Der1099OutData)]
        public string Der1099OutData { get; set; }
        [FieldName(Vendors.DerAgeBal1)]
        public string DerAgeBal1 { get; set; }
        [FieldName(Vendors.DerAgeBal2)]
        public string DerAgeBal2 { get; set; }
        [FieldName(Vendors.DerAgeBal3)]
        public string DerAgeBal3 { get; set; }
        [FieldName(Vendors.DerAgeBal4)]
        public string DerAgeBal4 { get; set; }
        [FieldName(Vendors.DerAgeBal5)]
        public string DerAgeBal5 { get; set; }
        [FieldName(Vendors.DerAgeBal6)]
        public string DerAgeBal6 { get; set; }
        [FieldName(Vendors.DerDiscLstYr)]
        public string DerDiscLstYr { get; set; }
        [FieldName(Vendors.DerDiscYtd)]
        public string DerDiscYtd { get; set; }
        [FieldName(Vendors.DerFormatAddress)]
        public string DerFormatAddress { get; set; }
        [FieldName(Vendors.DerNewAmount)]
        public decimal DerNewAmount { get; set; }
        [FieldName(Vendors.DerNewDomesticAmount)]
        public decimal DerNewDomesticAmount { get; set; }
        [FieldName(Vendors.DerOldAmount)]
        public decimal DerOldAmount { get; set; }
        [FieldName(Vendors.DerOldDomesticAmount)]
        public decimal DerOldDomesticAmount { get; set; }
        [FieldName(Vendors.DerPayFiscalYTD)]
        public decimal DerPayFiscalYTD { get; set; }
        [FieldName(Vendors.DerPayLastFiscalYr)]
        public decimal DerPayLastFiscalYr { get; set; }
        [FieldName(Vendors.DerPayLstYr)]
        public decimal DerPayLstYr { get; set; }
        [FieldName(Vendors.DerPayYTD)]
        public decimal DerPayYTD { get; set; }
        [FieldName(Vendors.DerPurchLstYr)]
        public string DerPurchLstYr { get; set; }
        [FieldName(Vendors.DerPurchYTD)]
        public string DerPurchYTD { get; set; }
        [FieldName(Vendors.DerRemoteAptrxpsCount)]
        public string DerRemoteAptrxpsCount { get; set; }
        [FieldName(Vendors.DerTotalDifference)]
        public decimal DerTotalDifference { get; set; }
        [FieldName(Vendors.DerType)]
        public string DerType { get; set; }
        [FieldName(Vendors.DerVendNum)]
        public string DerVendNum { get; set; }
        [FieldName(Vendors.DerVoucher)]
        public string DerVoucher { get; set; }
        [FieldName(Vendors.DiscLstYr)]
        public decimal DiscLstYr { get; set; }
        [FieldName(Vendors.DiscYtd)]
        public decimal DiscYtd { get; set; }
        [FieldName(Vendors.EdiVend)]
        public string EdiVend { get; set; }
        [FieldName(Vendors.EFTBankNum)]
        public string EFTBankNum { get; set; }
        [FieldName(Vendors.ExternalEmailAddr)]
        public string ExternalEmailAddr { get; set; }
        [FieldName(Vendors.Fob)]
        public string Fob { get; set; }
        [FieldName(Vendors.IncludeTaxInCost)]
        public string IncludeTaxInCost { get; set; }
        [FieldName(Vendors.InternalEmailAddr)]
        public string InternalEmailAddr { get; set; }
        [FieldName(Vendors.InternetUrl)]
        public string InternetUrl { get; set; }
        [FieldName(Vendors.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Vendors.LangCode)]
        public string LangCode { get; set; }
        [FieldName(Vendors.LastPaid)]
        public string LastPaid { get; set; }
        [FieldName(Vendors.LastPurch)]
        public string LastPurch { get; set; }
        [FieldName(Vendors.LcrReqd)]
        public string LcrReqd { get; set; }
        [FieldName(Vendors.Logifld)]
        public string Logifld { get; set; }
        [FieldName(Vendors.Name)]
        public string Name { get; set; }
        [FieldName(Vendors.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Vendors.PayFiscalYTD)]
        public string PayFiscalYTD { get; set; }
        [FieldName(Vendors.PayHoldDescription)]
        public string PayHoldDescription { get; set; }
        [FieldName(Vendors.PayHoldReasonClass)]
        public string PayHoldReasonClass { get; set; }
        [FieldName(Vendors.PayLastFiscalYr)]
        public decimal PayLastFiscalYr { get; set; }
        [FieldName(Vendors.PayLstYr)]
        public decimal PayLstYr { get; set; }
        [FieldName(Vendors.PayType)]
        public string PayType { get; set; }
        [FieldName(Vendors.PayYtd)]
        public decimal PayYtd { get; set; }
        [FieldName(Vendors.Phone)]
        public string Phone { get; set; }
        [FieldName(Vendors.PriceBy)]
        public string PriceBy { get; set; }
        [FieldName(Vendors.PrintPrice)]
        public string PrintPrice { get; set; }
        [FieldName(Vendors.PrintVATonPO)]
        public string PrintVATonPO { get; set; }
        [FieldName(Vendors.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(Vendors.PurAcct)]
        public string PurAcct { get; set; }
        [FieldName(Vendors.PurAcctUnit1)]
        public string PurAcctUnit1 { get; set; }
        [FieldName(Vendors.PurAcctUnit2)]
        public string PurAcctUnit2 { get; set; }
        [FieldName(Vendors.PurAcctUnit3)]
        public string PurAcctUnit3 { get; set; }
        [FieldName(Vendors.PurAcctUnit4)]
        public string PurAcctUnit4 { get; set; }
        [FieldName(Vendors.PurchLstYr)]
        public string PurchLstYr { get; set; }
        [FieldName(Vendors.PurChtAccessUnit1)]
        public string PurChtAccessUnit1 { get; set; }
        [FieldName(Vendors.PurChtAccessUnit2)]
        public string PurChtAccessUnit2 { get; set; }
        [FieldName(Vendors.PurChtAccessUnit3)]
        public string PurChtAccessUnit3 { get; set; }
        [FieldName(Vendors.PurChtAccessUnit4)]
        public string PurChtAccessUnit4 { get; set; }
        [FieldName(Vendors.PurChtDescription)]
        public string PurChtDescription { get; set; }
        [FieldName(Vendors.PurchYtd)]
        public string PurchYtd { get; set; }
        [FieldName(Vendors.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Vendors.RequestAcknowledgement)]
        public string RequestAcknowledgement { get; set; }
        [FieldName(Vendors.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Vendors.ShipCode)]
        public string ShipCode { get; set; }
        [FieldName(Vendors.ShipCodeDescription)]
        public string ShipCodeDescription { get; set; }
        [FieldName(Vendors.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(Vendors.SLApdraftts)]
        public string SLApdraftts { get; set; }
        [FieldName(Vendors.SLAptrxpAlls)]
        public string SLAptrxpAlls { get; set; }
        [FieldName(Vendors.SLAptrxps)]
        public string SLAptrxps { get; set; }
        [FieldName(Vendors.SLGrnHdrs)]
        public string SLGrnHdrs { get; set; }
        [FieldName(Vendors.SLGrnLines)]
        public string SLGrnLines { get; set; }
        [FieldName(Vendors.SLGrnLinesFiltered)]
        public string SLGrnLinesFiltered { get; set; }
        [FieldName(Vendors.SLItemvends)]
        public string SLItemvends { get; set; }
        [FieldName(Vendors.SLPoItems)]
        public string SLPoItems { get; set; }
        [FieldName(Vendors.SLPoItemsFiltered)]
        public string SLPoItemsFiltered { get; set; }
        [FieldName(Vendors.SLPos)]
        public string SLPos { get; set; }
        [FieldName(Vendors.SLVendlogs)]
        public string SLVendlogs { get; set; }
        [FieldName(Vendors.Status)]
        public string Status { get; set; }
        [FieldName(Vendors.SupplyWebVendor)]
        public string SupplyWebVendor { get; set; }
        [FieldName(Vendors.SynchronizedToBus)]
        public string SynchronizedToBus { get; set; }
        [FieldName(Vendors.Tax1Description)]
        public string Tax1Description { get; set; }
        [FieldName(Vendors.Tax2Description)]
        public string Tax2Description { get; set; }
        [FieldName(Vendors.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(Vendors.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(Vendors.TaxRegNum1)]
        public string TaxRegNum1 { get; set; }
        [FieldName(Vendors.TaxRegNum2)]
        public string TaxRegNum2 { get; set; }
        [FieldName(Vendors.TerDescription)]
        public string TerDescription { get; set; }
        [FieldName(Vendors.TermsCode)]
        public string TermsCode { get; set; }
        [FieldName(Vendors.Transit)]
        public string Transit { get; set; }
        [FieldName(Vendors.TransNat)]
        public string TransNat { get; set; }
        [FieldName(Vendors.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(Vendors.TransNat2Description)]
        public string TransNat2Description { get; set; }
        [FieldName(Vendors.TransNatDescription)]
        public string TransNatDescription { get; set; }
        [FieldName(Vendors.VadAddr_1)]
        public string VadAddr_1 { get; set; }
        [FieldName(Vendors.VadAddr_2)]
        public string VadAddr_2 { get; set; }
        [FieldName(Vendors.VadAddr_3)]
        public string VadAddr_3 { get; set; }
        [FieldName(Vendors.VadAddr_4)]
        public string VadAddr_4 { get; set; }
        [FieldName(Vendors.VadCity)]
        public string VadCity { get; set; }
        [FieldName(Vendors.VadCountry)]
        public string VadCountry { get; set; }
        [FieldName(Vendors.VadCounty)]
        public string VadCounty { get; set; }
        [FieldName(Vendors.VadFaxNum)]
        public string VadFaxNum { get; set; }
        [FieldName(Vendors.VadPayHold)]
        public string VadPayHold { get; set; }
        [FieldName(Vendors.VadPayHoldDate)]
        public string VadPayHoldDate { get; set; }
        [FieldName(Vendors.VadPayHoldReason)]
        public string VadPayHoldReason { get; set; }
        [FieldName(Vendors.VadPayHoldUser)]
        public string VadPayHoldUser { get; set; }
        [FieldName(Vendors.VadRAddr_1)]
        public string VadRAddr_1 { get; set; }
        [FieldName(Vendors.VadRAddr_2)]
        public string VadRAddr_2 { get; set; }
        [FieldName(Vendors.VadRAddr_3)]
        public string VadRAddr_3 { get; set; }
        [FieldName(Vendors.VadRAddr_4)]
        public string VadRAddr_4 { get; set; }
        [FieldName(Vendors.VadRCity)]
        public string VadRCity { get; set; }
        [FieldName(Vendors.VadRCountry)]
        public string VadRCountry { get; set; }
        [FieldName(Vendors.VadRCounty)]
        public string VadRCounty { get; set; }
        [FieldName(Vendors.VadRecordDate)]
        public string VadRecordDate { get; set; }
        [FieldName(Vendors.VadRName)]
        public string VadRName { get; set; }
        [FieldName(Vendors.VadRowPointer)]
        public string VadRowPointer { get; set; }
        [FieldName(Vendors.VadRState)]
        public string VadRState { get; set; }
        [FieldName(Vendors.VadRZip)]
        public string VadRZip { get; set; }
        [FieldName(Vendors.VadState)]
        public string VadState { get; set; }
        [FieldName(Vendors.VadTelexNum)]
        public string VadTelexNum { get; set; }
        [FieldName(Vendors.VadZip)]
        public string VadZip { get; set; }
        [FieldName(Vendors.VCDescription)]
        public string VCDescription { get; set; }
        [FieldName(Vendors.VchOverPoCostTolerance)]
        public string VchOverPoCostTolerance { get; set; }
        [FieldName(Vendors.VchUnderPoCostTolerance)]
        public string VchUnderPoCostTolerance { get; set; }
        [FieldName(Vendors.VendNum)]
        public string VendNum { get; set; }
        [FieldName(Vendors.VendRemit)]
        public string VendRemit { get; set; }
        [FieldName(Vendors.VendType)]
        public string VendType { get; set; }
        [FieldName(Vendors.Whse)]
        public string Whse { get; set; }
    }

    public class IdoJobRoutingSchedulesCriteria : IdoCriteria
    {
        public IdoJobRoutingSchedulesCriteria()
            : base(IdoJobRoutingSchedules.IDO_NAME)
        {
        }
        [FieldName(IdoJobRoutingSchedules.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoJobRoutingSchedules.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(IdoJobRoutingSchedules.CreatedBy)]
        public string CreatedBy { get; set; }
        [FieldName(IdoJobRoutingSchedules.Crsbrkrule)]
        public string Crsbrkrule { get; set; }
        [FieldName(IdoJobRoutingSchedules.EndDate)]
        public DateTime EndDate { get; set; }
        [FieldName(IdoJobRoutingSchedules.EndTick)]
        public string EndTick { get; set; }
        [FieldName(IdoJobRoutingSchedules.FinishHrs)]
        public string FinishHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.FreezeSch)]
        public string FreezeSch { get; set; }
        [FieldName(IdoJobRoutingSchedules.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoJobRoutingSchedules.Job)]
        public string Job { get; set; }
        [FieldName(IdoJobRoutingSchedules.Matrixtype)]
        public string Matrixtype { get; set; }
        [FieldName(IdoJobRoutingSchedules.MoveHrs)]
        public decimal MoveHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.MoveTicks)]
        public string MoveTicks { get; set; }
        [FieldName(IdoJobRoutingSchedules.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoJobRoutingSchedules.OffsetHrs)]
        public decimal OffsetHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.OperNum)]
        public string OperNum { get; set; }
        [FieldName(IdoJobRoutingSchedules.PcsPerLbrHr)]
        public decimal PcsPerLbrHr { get; set; }
        [FieldName(IdoJobRoutingSchedules.PcsPerMchHr)]
        public string PcsPerMchHr { get; set; }
        [FieldName(IdoJobRoutingSchedules.Plannerstep)]
        public string Plannerstep { get; set; }
        [FieldName(IdoJobRoutingSchedules.QueueHrs)]
        public decimal QueueHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.QueueTicks)]
        public string QueueTicks { get; set; }
        [FieldName(IdoJobRoutingSchedules.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoJobRoutingSchedules.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoJobRoutingSchedules.RunLbrHrs)]
        public string RunLbrHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.RunMchHrs)]
        public string RunMchHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.RunTicksLbr)]
        public string RunTicksLbr { get; set; }
        [FieldName(IdoJobRoutingSchedules.RunTicksMch)]
        public string RunTicksMch { get; set; }
        [FieldName(IdoJobRoutingSchedules.SchedDrv)]
        public string SchedDrv { get; set; }
        [FieldName(IdoJobRoutingSchedules.SchedHrs)]
        public string SchedHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.SchedOff)]
        public string SchedOff { get; set; }
        [FieldName(IdoJobRoutingSchedules.Schedsteprule)]
        public string Schedsteprule { get; set; }
        [FieldName(IdoJobRoutingSchedules.SchedTicks)]
        public string SchedTicks { get; set; }
        [FieldName(IdoJobRoutingSchedules.SetupHrs)]
        public string SetupHrs { get; set; }
        [FieldName(IdoJobRoutingSchedules.Setuprgid)]
        public string Setuprgid { get; set; }
        [FieldName(IdoJobRoutingSchedules.Setuprule)]
        public string Setuprule { get; set; }
        [FieldName(IdoJobRoutingSchedules.SetupTicks)]
        public string SetupTicks { get; set; }
        [FieldName(IdoJobRoutingSchedules.Splitsize)]
        public string Splitsize { get; set; }
        [FieldName(IdoJobRoutingSchedules.StartDate)]
        public DateTime StartDate { get; set; }
        [FieldName(IdoJobRoutingSchedules.StartTick)]
        public string StartTick { get; set; }
        [FieldName(IdoJobRoutingSchedules.Suffix)]
        public string Suffix { get; set; }
        [FieldName(IdoJobRoutingSchedules.Tabid)]
        public string Tabid { get; set; }
        [FieldName(IdoJobRoutingSchedules.UpdatedBy)]
        public string UpdatedBy { get; set; }
        [FieldName(IdoJobRoutingSchedules.Whenrule)]
        public string Whenrule { get; set; }
    }

    public class InventoryCriteria : IdoCriteria
    {
        public InventoryCriteria()
            : base(Inventory.IDO_NAME)
        {
        }
        [FieldName(Inventory.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Inventory.TotalQtyOnHand)]
        public int TotalQtyOnHand { get; set; }
        [FieldName(Inventory.Warehouse)]
        public string Warehouse { get; set; }
        [FieldName(Inventory.Item)]
        public string Item { get; set; }
        [FieldName(Inventory.AllocTrn)]
        public string AllocTrn { get; set; }
        [FieldName(Inventory.CntInProc)]
        public string CntInProc { get; set; }
        [FieldName(Inventory.CycleFlag)]
        public string CycleFlag { get; set; }
        [FieldName(Inventory.CycleFreq)]
        public string CycleFreq { get; set; }
        [FieldName(Inventory.CycleType)]
        public string CycleType { get; set; }
        [FieldName(Inventory.DerCycleTypeD)]
        public string DerCycleTypeD { get; set; }
        [FieldName(Inventory.DerCycleTypeI)]
        public string DerCycleTypeI { get; set; }
        [FieldName(Inventory.DerCycleTypeR)]
        public string DerCycleTypeR { get; set; }
        [FieldName(Inventory.DerCycleTypeZ)]
        public string DerCycleTypeZ { get; set; }
        [FieldName(Inventory.DerItemAvailQtyAlloc)]
        public string DerItemAvailQtyAlloc { get; set; }
        [FieldName(Inventory.DerItemAvailQtyAllocjob)]
        public string DerItemAvailQtyAllocjob { get; set; }
        [FieldName(Inventory.DerItemAvailQtyAvail)]
        public string DerItemAvailQtyAvail { get; set; }
        [FieldName(Inventory.DerItemAvailQtyOnHand)]
        public string DerItemAvailQtyOnHand { get; set; }
        [FieldName(Inventory.DerItemAvailReceipts)]
        public string DerItemAvailReceipts { get; set; }
        [FieldName(Inventory.DerItemAvailTotalQtyOnHand)]
        public string DerItemAvailTotalQtyOnHand { get; set; }
        [FieldName(Inventory.DerItmRecordDate)]
        public DateTime DerItmRecordDate { get; set; }
        [FieldName(Inventory.DerQtyMrb)]
        public string DerQtyMrb { get; set; }
        [FieldName(Inventory.DerQtyOnHand)]
        public string DerQtyOnHand { get; set; }
        [FieldName(Inventory.DerQtyRsvdCo)]
        public string DerQtyRsvdCo { get; set; }
        [FieldName(Inventory.DerWhse)]
        public string DerWhse { get; set; }
        [FieldName(Inventory.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Inventory.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(Inventory.ItemLotTracked)]
        public string ItemLotTracked { get; set; }
        [FieldName(Inventory.ItmAvgFovhdCost)]
        public string ItmAvgFovhdCost { get; set; }
        [FieldName(Inventory.ItmAvgLbrCost)]
        public string ItmAvgLbrCost { get; set; }
        [FieldName(Inventory.ItmAvgMatlCost)]
        public string ItmAvgMatlCost { get; set; }
        [FieldName(Inventory.ItmAvgOutCost)]
        public string ItmAvgOutCost { get; set; }
        [FieldName(Inventory.ItmAvgUCost)]
        public string ItmAvgUCost { get; set; }
        [FieldName(Inventory.ItmAvgVovhdCost)]
        public string ItmAvgVovhdCost { get; set; }
        [FieldName(Inventory.ItmCostMethod)]
        public string ItmCostMethod { get; set; }
        [FieldName(Inventory.ItmIssueBy)]
        public string ItmIssueBy { get; set; }
        [FieldName(Inventory.ItmLstUCost)]
        public string ItmLstUCost { get; set; }
        [FieldName(Inventory.ItmNextConfig)]
        public string ItmNextConfig { get; set; }
        [FieldName(Inventory.ItmQtyMfgYtd)]
        public string ItmQtyMfgYtd { get; set; }
        [FieldName(Inventory.ItmQtyUsedYtd)]
        public string ItmQtyUsedYtd { get; set; }
        [FieldName(Inventory.ItmReservable)]
        public string ItmReservable { get; set; }
        [FieldName(Inventory.ItmSerialTracked)]
        public string ItmSerialTracked { get; set; }
        [FieldName(Inventory.LastCycle)]
        public string LastCycle { get; set; }
        [FieldName(Inventory.Site)]
        public string Site { get; set; }
        [FieldName(Inventory.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Inventory.PhyInvDte)]
        public string PhyInvDte { get; set; }
        [FieldName(Inventory.PhyInvQty)]
        public string PhyInvQty { get; set; }
        [FieldName(Inventory.QtyAllocated)]
        public string QtyAllocated { get; set; }
        [FieldName(Inventory.QtyAllocjob)]
        public string QtyAllocjob { get; set; }
        [FieldName(Inventory.QtyMrb)]
        public string QtyMrb { get; set; }
        [FieldName(Inventory.QtyOnHand)]
        public string QtyOnHand { get; set; }
        [FieldName(Inventory.QtyOrdered)]
        public string QtyOrdered { get; set; }
        [FieldName(Inventory.QtyPurYtd)]
        public string QtyPurYtd { get; set; }
        [FieldName(Inventory.QtyReorder)]
        public string QtyReorder { get; set; }
        [FieldName(Inventory.QtyRsvdCo)]
        public string QtyRsvdCo { get; set; }
        [FieldName(Inventory.QtySoldYtd)]
        public string QtySoldYtd { get; set; }
        [FieldName(Inventory.QtyTrans)]
        public string QtyTrans { get; set; }
        [FieldName(Inventory.QtyWip)]
        public string QtyWip { get; set; }
        [FieldName(Inventory.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Inventory.ReplenPoNum)]
        public string ReplenPoNum { get; set; }
        [FieldName(Inventory.ReplenPsNum)]
        public string ReplenPsNum { get; set; }
        [FieldName(Inventory.ReplenTrnNum)]
        public string ReplenTrnNum { get; set; }
        [FieldName(Inventory.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Inventory.SalesPtd)]
        public string SalesPtd { get; set; }
        [FieldName(Inventory.SalesYtd)]
        public string SalesYtd { get; set; }
        [FieldName(Inventory.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(Inventory.SLRsvdInvs)]
        public string SLRsvdInvs { get; set; }
        [FieldName(Inventory.SLSerials)]
        public string SLSerials { get; set; }
        [FieldName(Inventory.TotalQtyReserved)]
        public string TotalQtyReserved { get; set; }
        [FieldName(Inventory.TrnInYtd)]
        public string TrnInYtd { get; set; }
        [FieldName(Inventory.TrnOutYtd)]
        public string TrnOutYtd { get; set; }
        [FieldName(Inventory.UoM)]
        public string UoM { get; set; }
        [FieldName(Inventory.WhseCycleType)]
        public string WhseCycleType { get; set; }
        [FieldName(Inventory.WhseName)]
        public string WhseName { get; set; }
    }





    public class NotesCriteria : IdoCriteria
    {
        public NotesCriteria()
            : base(Notes.IDO_NAME)
        {
        }
        [FieldName(Notes.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(Notes.CreateDate)]
        public DateTime CreateDate { get; set; }
        [FieldName(Notes.CreatedBy)]
        public string CreatedBy { get; set; }
        [FieldName(Notes.DerContent)]
        public string DerContent { get; set; }
        [FieldName(Notes.DerDesc)]
        public string DerDesc { get; set; }
        [FieldName(Notes.DerOrigin)]
        public string DerOrigin { get; set; }
        [FieldName(Notes.DerReusable)]
        public string DerReusable { get; set; }
        [FieldName(Notes.DerSystem)]
        public string DerSystem { get; set; }
        [FieldName(Notes.DerType)]
        public string DerType { get; set; }
        [FieldName(Notes.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(Notes.NhNoteFlag)]
        public string NhNoteFlag { get; set; }
        [FieldName(Notes.NhObjectName)]
        public string NhObjectName { get; set; }
        [FieldName(Notes.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(Notes.NoteHeaderToken)]
        public string NoteHeaderToken { get; set; }
        [FieldName(Notes.NoteType)]
        public string NoteType { get; set; }
        [FieldName(Notes.ObjectNoteToken)]
        public string ObjectNoteToken { get; set; }
        [FieldName(Notes.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(Notes.RefRowPointer)]
        public string RefRowPointer { get; set; }
        [FieldName(Notes.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(Notes.SpcnNoteContent)]
        public string SpcnNoteContent { get; set; }
        [FieldName(Notes.SpcnNoteDesc)]
        public string SpcnNoteDesc { get; set; }
        [FieldName(Notes.SpecificNoteToken)]
        public string SpecificNoteToken { get; set; }
        [FieldName(Notes.SysnNoteContent)]
        public string SysnNoteContent { get; set; }
        [FieldName(Notes.SysnNoteDesc)]
        public string SysnNoteDesc { get; set; }
        [FieldName(Notes.SystemNoteToken)]
        public string SystemNoteToken { get; set; }
        [FieldName(Notes.UBRefRowPointer)]
        public string UBRefRowPointer { get; set; }
        [FieldName(Notes.UBTableName)]
        public string UBTableName { get; set; }
        [FieldName(Notes.UpdatedBy)]
        public string UpdatedBy { get; set; }
        [FieldName(Notes.UserNoteToken)]
        public string UserNoteToken { get; set; }
        [FieldName(Notes.UsrnNoteContent)]
        public string UsrnNoteContent { get; set; }
        [FieldName(Notes.UsrnNoteDesc)]
        public string UsrnNoteDesc { get; set; }
    }


    public class IdoPurchaseOrderLinesCriteria : IdoCriteria
    {
        public IdoPurchaseOrderLinesCriteria()
            : base(IdoPurchaseOrderLines.IDO_NAME)
        {
        }
        [FieldName(IdoPurchaseOrderLines.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(IdoPurchaseOrderLines.CommCode)]
        public string CommCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.ComSupplQtyReq)]
        public string ComSupplQtyReq { get; set; }
        [FieldName(IdoPurchaseOrderLines.ConsNum)]
        public string ConsNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.CostType)]
        public string CostType { get; set; }
        [FieldName(IdoPurchaseOrderLines.CurrAmtTotFormat)]
        public string CurrAmtTotFormat { get; set; }
        [FieldName(IdoPurchaseOrderLines.CurrCode)]
        public string CurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.CurrCodeDesc)]
        public string CurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(IdoPurchaseOrderLines.Delterm)]
        public string Delterm { get; set; }
        [FieldName(IdoPurchaseOrderLines.DeltermDesc)]
        public string DeltermDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerASPSearch)]
        public string DerASPSearch { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerBrokerageCurrCode)]
        public string DerBrokerageCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerBrokerageCurrCodeDesc)]
        public string DerBrokerageCurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerBrokerageRate)]
        public string DerBrokerageRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerDefaultLoc)]
        public string DerDefaultLoc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerDutyCurrCode)]
        public string DerDutyCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerDutyCurrCodeDesc)]
        public string DerDutyCurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerDutyRate)]
        public string DerDutyRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerExtItemCostConv)]
        public string DerExtItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerExtPlanCostConv)]
        public string DerExtPlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerFreightCurrCode)]
        public string DerFreightCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerFreightCurrCodeDesc)]
        public string DerFreightCurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerFreightRate)]
        public string DerFreightRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerGrnLine)]
        public string DerGrnLine { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerGrnLineExists)]
        public string DerGrnLineExists { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerGrnNum)]
        public string DerGrnNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerInsuranceCurrCode)]
        public string DerInsuranceCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerInsuranceCurrCodeDesc)]
        public string DerInsuranceCurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerInsuranceRate)]
        public string DerInsuranceRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerItemExists)]
        public string DerItemExists { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLoc)]
        public string DerLoc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLocFrtCurrCode)]
        public string DerLocFrtCurrCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLocFrtCurrCodeDesc)]
        public string DerLocFrtCurrCodeDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLocFrtRate)]
        public string DerLocFrtRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLUnitBrokerageCost)]
        public string DerLUnitBrokerageCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLUnitDutyCost)]
        public string DerLUnitDutyCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLUnitFreightCost)]
        public string DerLUnitFreightCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLUnitInsuranceCost)]
        public string DerLUnitInsuranceCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerLUnitLocFrtCost)]
        public string DerLUnitLocFrtCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerMessage)]
        public string DerMessage { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerNeedsPostReceiveWIP)]
        public string DerNeedsPostReceiveWIP { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerNewStat)]
        public string DerNewStat { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerPoChangeNum)]
        public string DerPoChangeNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerPOChangeRowPointer)]
        public string DerPOChangeRowPointer { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerPoChangeStat)]
        public string DerPoChangeStat { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerQtyReceivedConv)]
        public string DerQtyReceivedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerQtyRejectedConv)]
        public string DerQtyRejectedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerQtyVoucherConv)]
        public string DerQtyVoucherConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerReadOnlyRecordFlag)]
        public string DerReadOnlyRecordFlag { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerRefDescription)]
        public string DerRefDescription { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerShipToAddr)]
        public string DerShipToAddr { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerStatFormatted)]
        public string DerStatFormatted { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerTotalRcvdCost)]
        public string DerTotalRcvdCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerTotQtyOrderedConv)]
        public string DerTotQtyOrderedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.DerUMDescription)]
        public string DerUMDescription { get; set; }
        [FieldName(IdoPurchaseOrderLines.Description)]
        public string Description { get; set; }
        [FieldName(IdoPurchaseOrderLines.DrawingNbr)]
        public string DrawingNbr { get; set; }
        [FieldName(IdoPurchaseOrderLines.DropSeq)]
        public string DropSeq { get; set; }
        [FieldName(IdoPurchaseOrderLines.DropShipNo)]
        public string DropShipNo { get; set; }
        [FieldName(IdoPurchaseOrderLines.DueDate)]
        public DateTime DueDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.EcCode)]
        public string EcCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.Expedited)]
        public string Expedited { get; set; }
        [FieldName(IdoPurchaseOrderLines.ExportValue)]
        public string ExportValue { get; set; }
        [FieldName(IdoPurchaseOrderLines.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(IdoPurchaseOrderLines.Item)]
        public string Item { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItemCost)]
        public string ItemCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItemCostConv)]
        public string ItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItemPOToleranceOver)]
        public string ItemPOToleranceOver { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItemPOToleranceUnder)]
        public string ItemPOToleranceUnder { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItemType)]
        public string ItemType { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmDescription)]
        public string ItmDescription { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmLotPrefix)]
        public string ItmLotPrefix { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmLotTracked)]
        public string ItmLotTracked { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmSerialPrefix)]
        public string ItmSerialPrefix { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmSerialTracked)]
        public string ItmSerialTracked { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmTaxFreeMatl)]
        public string ItmTaxFreeMatl { get; set; }
        [FieldName(IdoPurchaseOrderLines.ItmUnitBrokerageCost)]
        public string ItmUnitBrokerageCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.LcOverride)]
        public string LcOverride { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAccessUnit1)]
        public string NonInvAccessUnit1 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAccessUnit2)]
        public string NonInvAccessUnit2 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAccessUnit3)]
        public string NonInvAccessUnit3 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAccessUnit4)]
        public string NonInvAccessUnit4 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcct)]
        public string NonInvAcct { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcctDesc)]
        public string NonInvAcctDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcctUnit1)]
        public string NonInvAcctUnit1 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcctUnit2)]
        public string NonInvAcctUnit2 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcctUnit3)]
        public string NonInvAcctUnit3 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NonInvAcctUnit4)]
        public string NonInvAcctUnit4 { get; set; }
        [FieldName(IdoPurchaseOrderLines.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(IdoPurchaseOrderLines.Origin)]
        public string Origin { get; set; }
        [FieldName(IdoPurchaseOrderLines.PlanCost)]
        public string PlanCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.PlanCostConv)]
        public string PlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnBlanketQtyConv)]
        public string PoBlnBlanketQtyConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnDescription)]
        public string PoBlnDescription { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnDrawingNbr)]
        public string PoBlnDrawingNbr { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnEffDate)]
        public DateTime PoBlnEffDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnExpDate)]
        public DateTime PoBlnExpDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnItem)]
        public string PoBlnItem { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnItemCostConv)]
        public string PoBlnItemCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnPlanCostConv)]
        public string PoBlnPlanCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnPoLine)]
        public string PoBlnPoLine { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnRevision)]
        public string PoBlnRevision { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnStat)]
        public string PoBlnStat { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnUM)]
        public string PoBlnUM { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBlnVendItem)]
        public string PoBlnVendItem { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBuilderPoNum)]
        public string PoBuilderPoNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoBuilderPoOrigSite)]
        public string PoBuilderPoOrigSite { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoContainsOnlyTaxFreeMatls)]
        public string PoContainsOnlyTaxFreeMatls { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoExchRate)]
        public string PoExchRate { get; set; }
        [FieldName(IdoPurchaseOrderLines.POIncludeTaxInCost)]
        public string POIncludeTaxInCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoLine)]
        public string PoLine { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoNum)]
        public string PoNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoOrderDate)]
        public DateTime PoOrderDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoRelease)]
        public string PoRelease { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoStat)]
        public string PoStat { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoTaxCode1)]
        public string PoTaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoTaxCode2)]
        public string PoTaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoType)]
        public string PoType { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoVendNum)]
        public string PoVendNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.PoVendorPo)]
        public string PoVendorPo { get; set; }
        [FieldName(IdoPurchaseOrderLines.ProcessInd)]
        public string ProcessInd { get; set; }
        [FieldName(IdoPurchaseOrderLines.PromiseDate)]
        public DateTime PromiseDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyOrdered)]
        public string QtyOrdered { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyOrderedConv)]
        public string QtyOrderedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyReceived)]
        public string QtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyRejected)]
        public string QtyRejected { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyReturned)]
        public string QtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLines.QtyVoucher)]
        public string QtyVoucher { get; set; }
        [FieldName(IdoPurchaseOrderLines.RcvdDate)]
        public DateTime RcvdDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.RecordDate)]
        public DateTime RecordDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.RefLineSuf)]
        public string RefLineSuf { get; set; }
        [FieldName(IdoPurchaseOrderLines.RefNum)]
        public string RefNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.RefRelease)]
        public string RefRelease { get; set; }
        [FieldName(IdoPurchaseOrderLines.RefType)]
        public string RefType { get; set; }
        [FieldName(IdoPurchaseOrderLines.ReleaseDate)]
        public DateTime ReleaseDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.ReqLine)]
        public string ReqLine { get; set; }
        [FieldName(IdoPurchaseOrderLines.ReqNum)]
        public string ReqNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.Revision)]
        public string Revision { get; set; }
        [FieldName(IdoPurchaseOrderLines.RootJob)]
        public string RootJob { get; set; }
        [FieldName(IdoPurchaseOrderLines.RootSuf)]
        public string RootSuf { get; set; }
        [FieldName(IdoPurchaseOrderLines.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(IdoPurchaseOrderLines.ShipAddr)]
        public string ShipAddr { get; set; }
        [FieldName(IdoPurchaseOrderLines.ShowInDropDownList)]
        public string ShowInDropDownList { get; set; }
        [FieldName(IdoPurchaseOrderLines.SLPochanges)]
        public string SLPochanges { get; set; }
        [FieldName(IdoPurchaseOrderLines.SLSerials)]
        public string SLSerials { get; set; }
        [FieldName(IdoPurchaseOrderLines.Stat)]
        public string Stat { get; set; }
        [FieldName(IdoPurchaseOrderLines.SupplQtyConvFactor)]
        public string SupplQtyConvFactor { get; set; }
        [FieldName(IdoPurchaseOrderLines.TaxCode1)]
        public string TaxCode1 { get; set; }
        [FieldName(IdoPurchaseOrderLines.TaxCode1Desc)]
        public string TaxCode1Desc { get; set; }
        [FieldName(IdoPurchaseOrderLines.TaxCode2)]
        public string TaxCode2 { get; set; }
        [FieldName(IdoPurchaseOrderLines.TaxCode2Desc)]
        public string TaxCode2Desc { get; set; }
        [FieldName(IdoPurchaseOrderLines.TransNat)]
        public string TransNat { get; set; }
        [FieldName(IdoPurchaseOrderLines.TransNat2)]
        public string TransNat2 { get; set; }
        [FieldName(IdoPurchaseOrderLines.TransNat2Desc)]
        public string TransNat2Desc { get; set; }
        [FieldName(IdoPurchaseOrderLines.TransNatDesc)]
        public string TransNatDesc { get; set; }
        [FieldName(IdoPurchaseOrderLines.Transport)]
        public string Transport { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbAddProjMatl)]
        public string UbAddProjMatl { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbByCons)]
        public string UbByCons { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbCostCode)]
        public string UbCostCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbCostsChanged)]
        public string UbCostsChanged { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbDispMsg)]
        public string UbDispMsg { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbDispXRefMsg)]
        public string UbDispXRefMsg { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbDRRt)]
        public string UbDRRt { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbErrorStatus)]
        public string UbErrorStatus { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbGrnExists)]
        public string UbGrnExists { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbImportDocId)]
        public string UbImportDocId { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbItemVendAdd)]
        public string UbItemVendAdd { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbItemVendUpdate)]
        public string UbItemVendUpdate { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbLocation)]
        public string UbLocation { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbLot)]
        public string UbLot { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbPackNum)]
        public string UbPackNum { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbPoChangeIup)]
        public string UbPoChangeIup { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbQtyReceived)]
        public string UbQtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbQtyReceivedConv)]
        public string UbQtyReceivedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbQtyReturned)]
        public string UbQtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbQtyReturnedConv)]
        public string UbQtyReturnedConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbReasonCode)]
        public string UbReasonCode { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSelectedReceiving)]
        public string UbSelectedReceiving { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSequence)]
        public string UbSequence { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSerNumGenerateQty)]
        public string UbSerNumGenerateQty { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSerNumRangeQty)]
        public string UbSerNumRangeQty { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSerNumSelected)]
        public string UbSerNumSelected { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSerNumStatLinkBy)]
        public string UbSerNumStatLinkBy { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSImportDocId)]
        public string UbSImportDocId { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSLocation)]
        public string UbSLocation { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbSLot)]
        public string UbSLot { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbTotQtyReceived)]
        public string UbTotQtyReceived { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbTotQtyReturned)]
        public string UbTotQtyReturned { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbTransDate)]
        public DateTime UbTransDate { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbUnReceiveFlag)]
        public string UbUnReceiveFlag { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbUpdateJobMatlUnitCost)]
        public string UbUpdateJobMatlUnitCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UbWorkKey)]
        public string UbWorkKey { get; set; }
        [FieldName(IdoPurchaseOrderLines.UM)]
        public string UM { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitBrokerageCost)]
        public string UnitBrokerageCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitBrokerageCostConv)]
        public string UnitBrokerageCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitDutyCost)]
        public string UnitDutyCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitDutyCostConv)]
        public string UnitDutyCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitFreightCost)]
        public string UnitFreightCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitFreightCostConv)]
        public string UnitFreightCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitInsuranceCost)]
        public string UnitInsuranceCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitInsuranceCostConv)]
        public string UnitInsuranceCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitLocFrtCost)]
        public string UnitLocFrtCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitLocFrtCostConv)]
        public string UnitLocFrtCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitMatCost)]
        public string UnitMatCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitMatCostConv)]
        public string UnitMatCostConv { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnitWeight)]
        public string UnitWeight { get; set; }
        [FieldName(IdoPurchaseOrderLines.UnlinkedXref)]
        public string UnlinkedXref { get; set; }
        [FieldName(IdoPurchaseOrderLines.VenadrName)]
        public string VenadrName { get; set; }
        [FieldName(IdoPurchaseOrderLines.VendItem)]
        public string VendItem { get; set; }
        [FieldName(IdoPurchaseOrderLines.VendorCountry)]
        public string VendorCountry { get; set; }
        [FieldName(IdoPurchaseOrderLines.VendPriceBy)]
        public string VendPriceBy { get; set; }
        [FieldName(IdoPurchaseOrderLines.VoucherCost)]
        public string VoucherCost { get; set; }
        [FieldName(IdoPurchaseOrderLines.Whse)]
        public string Whse { get; set; }
    }


    public class BlanketOrderLineCriteria : IdoCriteria
    {
        public BlanketOrderLineCriteria()
            : base(BlanketOrderLine.IDO_NAME)
        {
        }
        [FieldName(BlanketOrderLine.IDO_NAME)]
        public string IDO_NAME { get; set; }
        [FieldName(BlanketOrderLine.BlanketQty)]
        public string BlanketQty { get; set; }
        [FieldName(BlanketOrderLine.BlanketQtyConv)]
        public string BlanketQtyConv { get; set; }
        [FieldName(BlanketOrderLine.Cadr01CreditHold)]
        public string Cadr01CreditHold { get; set; }
        [FieldName(BlanketOrderLine.Cadr0CorpCred)]
        public string Cadr0CorpCred { get; set; }
        [FieldName(BlanketOrderLine.Cadr0CorpCust)]
        public string Cadr0CorpCust { get; set; }
        [FieldName(BlanketOrderLine.Cadr0CreditHold)]
        public string Cadr0CreditHold { get; set; }
        [FieldName(BlanketOrderLine.CadrCreditHold)]
        public string CadrCreditHold { get; set; }
        [FieldName(BlanketOrderLine.CadrCurrCode)]
        public string CadrCurrCode { get; set; }
        [FieldName(BlanketOrderLine.CadrName)]
        public string CadrName { get; set; }
        [FieldName(BlanketOrderLine.CfgMainConfigGid)]
        public string CfgMainConfigGid { get; set; }
        [FieldName(BlanketOrderLine.CfgMainConfigStatus)]
        public string CfgMainConfigStatus { get; set; }
        [FieldName(BlanketOrderLine.CoCreditHold)]
        public string CoCreditHold { get; set; }
        [FieldName(BlanketOrderLine.CoCustNum)]
        public string CoCustNum { get; set; }
        [FieldName(BlanketOrderLine.CoExchRate)]
        public string CoExchRate { get; set; }
        [FieldName(BlanketOrderLine.CoExportType)]
        public string CoExportType { get; set; }
        [FieldName(BlanketOrderLine.CoLine)]
        public string CoLine { get; set; }
        [FieldName(BlanketOrderLine.ConfigId)]
        public string ConfigId { get; set; }
        [FieldName(BlanketOrderLine.ContPrice)]
        public string ContPrice { get; set; }
        [FieldName(BlanketOrderLine.ContPriceConv)]
        public string ContPriceConv { get; set; }
        [FieldName(BlanketOrderLine.OrderNumber)]
        public string OrderNumber { get; set; }
        [FieldName(BlanketOrderLine.OrderDate)]
        public string OrderDate { get; set; }
        [FieldName(BlanketOrderLine.OrigSite)]
        public string OrigSite { get; set; }
        [FieldName(BlanketOrderLine.CoPricecode)]
        public string CoPricecode { get; set; }
        [FieldName(BlanketOrderLine.Status)]
        public string Status { get; set; }
        [FieldName(BlanketOrderLine.OrderType)]
        public string OrderType { get; set; }
        [FieldName(BlanketOrderLine.CurrCstPrcFormat)]
        public string CurrCstPrcFormat { get; set; }
        [FieldName(BlanketOrderLine.CustItem)]
        public string CustItem { get; set; }
        [FieldName(BlanketOrderLine.DerCadrName)]
        public string DerCadrName { get; set; }
        [FieldName(BlanketOrderLine.DerCanChangeItem)]
        public string DerCanChangeItem { get; set; }
        [FieldName(BlanketOrderLine.DerCanChangeShipSite)]
        public string DerCanChangeShipSite { get; set; }
        [FieldName(BlanketOrderLine.DerHasXRef)]
        public string DerHasXRef { get; set; }
        [FieldName(BlanketOrderLine.DerItemFeatTempl)]
        public string DerItemFeatTempl { get; set; }
        [FieldName(BlanketOrderLine.Description)]
        public string Description { get; set; }
        [FieldName(BlanketOrderLine.EffDate)]
        public string EffDate { get; set; }
        [FieldName(BlanketOrderLine.ExpDate)]
        public string ExpDate { get; set; }
        [FieldName(BlanketOrderLine.FeatStr)]
        public string FeatStr { get; set; }
        [FieldName(BlanketOrderLine.InWorkflow)]
        public string InWorkflow { get; set; }
        [FieldName(BlanketOrderLine.Item)]
        public string Item { get; set; }
        [FieldName(BlanketOrderLine.ItemAutoPost)]
        public string ItemAutoPost { get; set; }
        [FieldName(BlanketOrderLine.ItemCfgModel)]
        public string ItemCfgModel { get; set; }
        [FieldName(BlanketOrderLine.ItemCoPostConfig)]
        public string ItemCoPostConfig { get; set; }
        [FieldName(BlanketOrderLine.ItemDescription)]
        public string ItemDescription { get; set; }
        [FieldName(BlanketOrderLine.ItemKit)]
        public string ItemKit { get; set; }
        [FieldName(BlanketOrderLine.ItemOrderConfigurable)]
        public string ItemOrderConfigurable { get; set; }
        [FieldName(BlanketOrderLine.ItemPlanFlag)]
        public string ItemPlanFlag { get; set; }
        [FieldName(BlanketOrderLine.ItemSerialTracked)]
        public string ItemSerialTracked { get; set; }
        [FieldName(BlanketOrderLine.NoteExistsFlag)]
        public string NoteExistsFlag { get; set; }
        [FieldName(BlanketOrderLine.ParCfgConfigGid)]
        public string ParCfgConfigGid { get; set; }
        [FieldName(BlanketOrderLine.PcoDescription)]
        public string PcoDescription { get; set; }
        [FieldName(BlanketOrderLine.Pricecode)]
        public string Pricecode { get; set; }
        [FieldName(BlanketOrderLine.PrintKitComponents)]
        public string PrintKitComponents { get; set; }
        [FieldName(BlanketOrderLine.PromiseDate)]
        public string PromiseDate { get; set; }
        [FieldName(BlanketOrderLine.RecordDate)]
        public string RecordDate { get; set; }
        [FieldName(BlanketOrderLine.RowPointer)]
        public string RowPointer { get; set; }
        [FieldName(BlanketOrderLine.ShipSite)]
        public string ShipSite { get; set; }
        [FieldName(BlanketOrderLine.LineStatus)]
        public string LineStatus { get; set; }
        [FieldName(BlanketOrderLine.UBDispMsg)]
        public string UBDispMsg { get; set; }
        [FieldName(BlanketOrderLine.UbIncrPrice)]
        public string UbIncrPrice { get; set; }
        [FieldName(BlanketOrderLine.UbItemCustAdd)]
        public string UbItemCustAdd { get; set; }
        [FieldName(BlanketOrderLine.UbItemCustUpdate)]
        public string UbItemCustUpdate { get; set; }
        [FieldName(BlanketOrderLine.UbQtyReleased)]
        public string UbQtyReleased { get; set; }
        [FieldName(BlanketOrderLine.UbQtyReserved)]
        public string UbQtyReserved { get; set; }
        [FieldName(BlanketOrderLine.UbQtyShipped)]
        public string UbQtyShipped { get; set; }
        [FieldName(BlanketOrderLine.UM)]
        public string UM { get; set; }
    }

}
