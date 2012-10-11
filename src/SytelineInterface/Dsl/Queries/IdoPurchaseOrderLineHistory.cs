using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    public class IdoPurchaseOrderLineHistory : IdoConstants 
                { 
                           public const string IDO_NAME = "SLPitemhs";
       public const string CommCode = "CommCode";
       public const string ComSupplQtyReq = "ComSupplQtyReq";
       public const string ConsNum = "ConsNum";
       public const string CostType = "CostType";
       public const string CurrAmtFormat = "CurrAmtFormat";
       public const string CurrAmtTotFormat = "CurrAmtTotFormat";
       public const string CurrCodeDesc = "CurrCodeDesc";
       public const string CurrCstPrcFormat = "CurrCstPrcFormat";
       public const string Delterm = "Delterm";
       public const string DeltermDesc = "DeltermDesc";
       public const string DerExtItemCostConv = "DerExtItemCostConv";
       public const string DerExtPlanCostConv = "DerExtPlanCostConv";
       public const string DerGrnLineExists = "DerGrnLineExists";
       public const string DerHistoryTrue = "DerHistoryTrue";
       public const string DerItemExists = "DerItemExists";
       public const string DerLoc = "DerLoc";
       public const string DerMessage = "DerMessage";
       public const string DerNewStat = "DerNewStat";
       public const string DerPoChangeNum = "DerPoChangeNum";
       public const string DerPoChangeStat = "DerPoChangeStat";
       public const string DerQtyReceivedConv = "DerQtyReceivedConv";
       public const string DerQtyRejectedConv = "DerQtyRejectedConv";
       public const string DerQtyVoucherConv = "DerQtyVoucherConv";
       public const string DerReadOnlyRecord = "DerReadOnlyRecord";
       public const string DerRefDescription = "DerRefDescription";
       public const string DerShipToAddr = "DerShipToAddr";
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
       public const string GrnlnGrnLine = "GrnlnGrnLine";
       public const string GrnlnGrnNum = "GrnlnGrnNum";
       public const string InWorkflow = "InWorkflow";
       public const string Item = "Item";
       public const string ItemCost = "ItemCost";
       public const string ItemCostConv = "ItemCostConv";
       public const string ItemType = "ItemType";
       public const string ItmDescription = "ItmDescription";
       public const string ItmLotPrefix = "ItmLotPrefix";
       public const string ItmLotTracked = "ItmLotTracked";
       public const string ItmSerialPrefix = "ItmSerialPrefix";
       public const string ItmSerialTracked = "ItmSerialTracked";
       public const string ItmUnitBrokerageCost = "ItmUnitBrokerageCost";
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
       public const string PoExchRate = "PoExchRate";
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
       public const string SLPochanges = "SLPochanges";
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
       public const string UbErrorStatus = "UbErrorStatus";
       public const string UbGrnExists = "UbGrnExists";
       public const string UbItemVendAdd = "UbItemVendAdd";
       public const string UbItemVendUpdate = "UbItemVendUpdate";
       public const string UbLocation = "UbLocation";
       public const string UbLot = "UbLot";
       public const string UbPoChangeIup = "UbPoChangeIup";
       public const string UbQtyReceived = "UbQtyReceived";
       public const string UbQtyReturned = "UbQtyReturned";
       public const string UbReasonCode = "UbReasonCode";
       public const string UbSLocation = "UbSLocation";
       public const string UbSLot = "UbSLot";
       public const string UbTotQtyReceived = "UbTotQtyReceived";
       public const string UbTotQtyReturned = "UbTotQtyReturned";
       public const string UbTransDate = "UbTransDate";
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
       public const string VenadrName = "VenadrName";
       public const string VenCurrCode = "VenCurrCode";
       public const string VendItem = "VendItem";
       public const string VenPriceBy = "VenPriceBy";
       public const string VoucherCost = "VoucherCost";
       public const string Whse = "Whse";


                }

            public class IdoPurchaseOrderLineHistoryBuilder  
                :   IdoQueryBuilder<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>
                {
                        public IdoPurchaseOrderLineHistoryBuilder(IExpressionInterpreter interpreter) : base(IdoPurchaseOrderLineHistory.IDO_NAME, interpreter) { }

                      public IdoPurchaseOrderLineHistoryBuilder CommCode { get {  AddProperty(IdoPurchaseOrderLineHistory.CommCode); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ComSupplQtyReq { get {  AddProperty(IdoPurchaseOrderLineHistory.ComSupplQtyReq); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ConsNum { get {  AddProperty(IdoPurchaseOrderLineHistory.ConsNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder CostType { get {  AddProperty(IdoPurchaseOrderLineHistory.CostType); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder CurrAmtFormat { get {  AddProperty(IdoPurchaseOrderLineHistory.CurrAmtFormat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder CurrAmtTotFormat { get {  AddProperty(IdoPurchaseOrderLineHistory.CurrAmtTotFormat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder CurrCodeDesc { get {  AddProperty(IdoPurchaseOrderLineHistory.CurrCodeDesc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder CurrCstPrcFormat { get {  AddProperty(IdoPurchaseOrderLineHistory.CurrCstPrcFormat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Delterm { get {  AddProperty(IdoPurchaseOrderLineHistory.Delterm); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DeltermDesc { get {  AddProperty(IdoPurchaseOrderLineHistory.DeltermDesc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerExtItemCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerExtItemCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerExtPlanCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerExtPlanCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerGrnLineExists { get {  AddProperty(IdoPurchaseOrderLineHistory.DerGrnLineExists); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerHistoryTrue { get {  AddProperty(IdoPurchaseOrderLineHistory.DerHistoryTrue); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerItemExists { get {  AddProperty(IdoPurchaseOrderLineHistory.DerItemExists); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerLoc { get {  AddProperty(IdoPurchaseOrderLineHistory.DerLoc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerMessage { get {  AddProperty(IdoPurchaseOrderLineHistory.DerMessage); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerNewStat { get {  AddProperty(IdoPurchaseOrderLineHistory.DerNewStat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerPoChangeNum { get {  AddProperty(IdoPurchaseOrderLineHistory.DerPoChangeNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerPoChangeStat { get {  AddProperty(IdoPurchaseOrderLineHistory.DerPoChangeStat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerQtyReceivedConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerQtyReceivedConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerQtyRejectedConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerQtyRejectedConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerQtyVoucherConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerQtyVoucherConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerReadOnlyRecord { get {  AddProperty(IdoPurchaseOrderLineHistory.DerReadOnlyRecord); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerRefDescription { get {  AddProperty(IdoPurchaseOrderLineHistory.DerRefDescription); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerShipToAddr { get {  AddProperty(IdoPurchaseOrderLineHistory.DerShipToAddr); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerTotalRcvdCost { get {  AddProperty(IdoPurchaseOrderLineHistory.DerTotalRcvdCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerTotQtyOrderedConv { get {  AddProperty(IdoPurchaseOrderLineHistory.DerTotQtyOrderedConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DerUMDescription { get {  AddProperty(IdoPurchaseOrderLineHistory.DerUMDescription); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Description { get {  AddProperty(IdoPurchaseOrderLineHistory.Description); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DrawingNbr { get {  AddProperty(IdoPurchaseOrderLineHistory.DrawingNbr); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DropSeq { get {  AddProperty(IdoPurchaseOrderLineHistory.DropSeq); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DropShipNo { get {  AddProperty(IdoPurchaseOrderLineHistory.DropShipNo); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder DueDate { get {  AddProperty(IdoPurchaseOrderLineHistory.DueDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder EcCode { get {  AddProperty(IdoPurchaseOrderLineHistory.EcCode); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Expedited { get {  AddProperty(IdoPurchaseOrderLineHistory.Expedited); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ExportValue { get {  AddProperty(IdoPurchaseOrderLineHistory.ExportValue); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder GrnlnGrnLine { get {  AddProperty(IdoPurchaseOrderLineHistory.GrnlnGrnLine); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder GrnlnGrnNum { get {  AddProperty(IdoPurchaseOrderLineHistory.GrnlnGrnNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder InWorkflow { get {  AddProperty(IdoPurchaseOrderLineHistory.InWorkflow); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Item { get {  AddProperty(IdoPurchaseOrderLineHistory.Item); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItemCost { get {  AddProperty(IdoPurchaseOrderLineHistory.ItemCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItemCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.ItemCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItemType { get {  AddProperty(IdoPurchaseOrderLineHistory.ItemType); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmDescription { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmDescription); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmLotPrefix { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmLotPrefix); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmLotTracked { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmLotTracked); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmSerialPrefix { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmSerialPrefix); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmSerialTracked { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmSerialTracked); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ItmUnitBrokerageCost { get {  AddProperty(IdoPurchaseOrderLineHistory.ItmUnitBrokerageCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAccessUnit1 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAccessUnit1); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAccessUnit2 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAccessUnit2); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAccessUnit3 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAccessUnit3); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAccessUnit4 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAccessUnit4); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcct { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcct); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcctDesc { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcctDesc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcctUnit1 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcctUnit1); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcctUnit2 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcctUnit2); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcctUnit3 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcctUnit3); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NonInvAcctUnit4 { get {  AddProperty(IdoPurchaseOrderLineHistory.NonInvAcctUnit4); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder NoteExistsFlag { get {  AddProperty(IdoPurchaseOrderLineHistory.NoteExistsFlag); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Origin { get {  AddProperty(IdoPurchaseOrderLineHistory.Origin); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PlanCost { get {  AddProperty(IdoPurchaseOrderLineHistory.PlanCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PlanCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.PlanCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnBlanketQtyConv { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnBlanketQtyConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnDescription { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnDescription); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnDrawingNbr { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnDrawingNbr); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnEffDate { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnEffDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnExpDate { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnExpDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnItem { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnItem); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnItemCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnItemCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnPlanCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnPlanCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnPoLine { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnPoLine); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnRevision { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnRevision); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnStat { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnStat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnUM { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnUM); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoBlnVendItem { get {  AddProperty(IdoPurchaseOrderLineHistory.PoBlnVendItem); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoExchRate { get {  AddProperty(IdoPurchaseOrderLineHistory.PoExchRate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoLine { get {  AddProperty(IdoPurchaseOrderLineHistory.PoLine); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoNum { get {  AddProperty(IdoPurchaseOrderLineHistory.PoNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoOrderDate { get {  AddProperty(IdoPurchaseOrderLineHistory.PoOrderDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoRelease { get {  AddProperty(IdoPurchaseOrderLineHistory.PoRelease); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoStat { get {  AddProperty(IdoPurchaseOrderLineHistory.PoStat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoTaxCode1 { get {  AddProperty(IdoPurchaseOrderLineHistory.PoTaxCode1); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoTaxCode2 { get {  AddProperty(IdoPurchaseOrderLineHistory.PoTaxCode2); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoType { get {  AddProperty(IdoPurchaseOrderLineHistory.PoType); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoVendNum { get {  AddProperty(IdoPurchaseOrderLineHistory.PoVendNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PoVendorPo { get {  AddProperty(IdoPurchaseOrderLineHistory.PoVendorPo); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ProcessInd { get {  AddProperty(IdoPurchaseOrderLineHistory.ProcessInd); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder PromiseDate { get {  AddProperty(IdoPurchaseOrderLineHistory.PromiseDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyOrdered { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyOrdered); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyOrderedConv { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyOrderedConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyReceived { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyReceived); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyRejected { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyRejected); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyReturned { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyReturned); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder QtyVoucher { get {  AddProperty(IdoPurchaseOrderLineHistory.QtyVoucher); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RcvdDate { get {  AddProperty(IdoPurchaseOrderLineHistory.RcvdDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RecordDate { get {  AddProperty(IdoPurchaseOrderLineHistory.RecordDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RefLineSuf { get {  AddProperty(IdoPurchaseOrderLineHistory.RefLineSuf); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RefNum { get {  AddProperty(IdoPurchaseOrderLineHistory.RefNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RefRelease { get {  AddProperty(IdoPurchaseOrderLineHistory.RefRelease); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RefType { get {  AddProperty(IdoPurchaseOrderLineHistory.RefType); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ReleaseDate { get {  AddProperty(IdoPurchaseOrderLineHistory.ReleaseDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ReqLine { get {  AddProperty(IdoPurchaseOrderLineHistory.ReqLine); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ReqNum { get {  AddProperty(IdoPurchaseOrderLineHistory.ReqNum); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Revision { get {  AddProperty(IdoPurchaseOrderLineHistory.Revision); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RootJob { get {  AddProperty(IdoPurchaseOrderLineHistory.RootJob); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RootSuf { get {  AddProperty(IdoPurchaseOrderLineHistory.RootSuf); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder RowPointer { get {  AddProperty(IdoPurchaseOrderLineHistory.RowPointer); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder ShipAddr { get {  AddProperty(IdoPurchaseOrderLineHistory.ShipAddr); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder SLPochanges { get {  AddProperty(IdoPurchaseOrderLineHistory.SLPochanges); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Stat { get {  AddProperty(IdoPurchaseOrderLineHistory.Stat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder SupplQtyConvFactor { get {  AddProperty(IdoPurchaseOrderLineHistory.SupplQtyConvFactor); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TaxCode1 { get {  AddProperty(IdoPurchaseOrderLineHistory.TaxCode1); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TaxCode1Desc { get {  AddProperty(IdoPurchaseOrderLineHistory.TaxCode1Desc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TaxCode2 { get {  AddProperty(IdoPurchaseOrderLineHistory.TaxCode2); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TaxCode2Desc { get {  AddProperty(IdoPurchaseOrderLineHistory.TaxCode2Desc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TransNat { get {  AddProperty(IdoPurchaseOrderLineHistory.TransNat); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TransNat2 { get {  AddProperty(IdoPurchaseOrderLineHistory.TransNat2); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TransNat2Desc { get {  AddProperty(IdoPurchaseOrderLineHistory.TransNat2Desc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder TransNatDesc { get {  AddProperty(IdoPurchaseOrderLineHistory.TransNatDesc); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Transport { get {  AddProperty(IdoPurchaseOrderLineHistory.Transport); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbAddProjMatl { get {  AddProperty(IdoPurchaseOrderLineHistory.UbAddProjMatl); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbByCons { get {  AddProperty(IdoPurchaseOrderLineHistory.UbByCons); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbCostCode { get {  AddProperty(IdoPurchaseOrderLineHistory.UbCostCode); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbErrorStatus { get {  AddProperty(IdoPurchaseOrderLineHistory.UbErrorStatus); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbGrnExists { get {  AddProperty(IdoPurchaseOrderLineHistory.UbGrnExists); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbItemVendAdd { get {  AddProperty(IdoPurchaseOrderLineHistory.UbItemVendAdd); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbItemVendUpdate { get {  AddProperty(IdoPurchaseOrderLineHistory.UbItemVendUpdate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbLocation { get {  AddProperty(IdoPurchaseOrderLineHistory.UbLocation); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbLot { get {  AddProperty(IdoPurchaseOrderLineHistory.UbLot); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbPoChangeIup { get {  AddProperty(IdoPurchaseOrderLineHistory.UbPoChangeIup); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbQtyReceived { get {  AddProperty(IdoPurchaseOrderLineHistory.UbQtyReceived); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbQtyReturned { get {  AddProperty(IdoPurchaseOrderLineHistory.UbQtyReturned); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbReasonCode { get {  AddProperty(IdoPurchaseOrderLineHistory.UbReasonCode); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbSLocation { get {  AddProperty(IdoPurchaseOrderLineHistory.UbSLocation); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbSLot { get {  AddProperty(IdoPurchaseOrderLineHistory.UbSLot); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbTotQtyReceived { get {  AddProperty(IdoPurchaseOrderLineHistory.UbTotQtyReceived); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbTotQtyReturned { get {  AddProperty(IdoPurchaseOrderLineHistory.UbTotQtyReturned); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbTransDate { get {  AddProperty(IdoPurchaseOrderLineHistory.UbTransDate); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbUpdateJobMatlUnitCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UbUpdateJobMatlUnitCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UbWorkKey { get {  AddProperty(IdoPurchaseOrderLineHistory.UbWorkKey); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UM { get {  AddProperty(IdoPurchaseOrderLineHistory.UM); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitBrokerageCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitBrokerageCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitBrokerageCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitBrokerageCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitDutyCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitDutyCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitDutyCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitDutyCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitFreightCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitFreightCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitFreightCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitFreightCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitInsuranceCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitInsuranceCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitInsuranceCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitInsuranceCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitLocFrtCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitLocFrtCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitLocFrtCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitLocFrtCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitMatCost { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitMatCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitMatCostConv { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitMatCostConv); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder UnitWeight { get {  AddProperty(IdoPurchaseOrderLineHistory.UnitWeight); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder VenadrName { get {  AddProperty(IdoPurchaseOrderLineHistory.VenadrName); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder VenCurrCode { get {  AddProperty(IdoPurchaseOrderLineHistory.VenCurrCode); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder VendItem { get {  AddProperty(IdoPurchaseOrderLineHistory.VendItem); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder VenPriceBy { get {  AddProperty(IdoPurchaseOrderLineHistory.VenPriceBy); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder VoucherCost { get {  AddProperty(IdoPurchaseOrderLineHistory.VoucherCost); return this; }  } 
                          public IdoPurchaseOrderLineHistoryBuilder Whse { get {  AddProperty(IdoPurchaseOrderLineHistory.Whse); return this; }  } 
                    

                }

            public class SLPitemhsFilterExpressionBuilder  
                :   FilterExpressionBuilder<IdoPurchaseOrderLineHistoryBuilder>
                {
                        public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CommCode
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CommCode); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ComSupplQtyReq
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ComSupplQtyReq); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ConsNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ConsNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CostType
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CostType); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CurrAmtFormat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CurrAmtTotFormat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CurrAmtTotFormat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CurrCodeDesc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CurrCodeDesc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> CurrCstPrcFormat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.CurrCstPrcFormat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Delterm
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Delterm); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DeltermDesc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DeltermDesc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerExtItemCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerExtItemCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerExtPlanCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerExtPlanCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerGrnLineExists
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerGrnLineExists); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerHistoryTrue
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerHistoryTrue); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerItemExists
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerItemExists); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerLoc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerLoc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerMessage
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerMessage); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerNewStat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerNewStat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerPoChangeNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerPoChangeNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerPoChangeStat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerPoChangeStat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerQtyReceivedConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerQtyReceivedConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerQtyRejectedConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerQtyRejectedConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerQtyVoucherConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerQtyVoucherConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerReadOnlyRecord
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerReadOnlyRecord); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerRefDescription
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerRefDescription); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerShipToAddr
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerShipToAddr); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerTotalRcvdCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerTotalRcvdCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerTotQtyOrderedConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerTotQtyOrderedConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DerUMDescription
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DerUMDescription); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Description); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DrawingNbr
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DrawingNbr); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DropSeq
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DropSeq); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DropShipNo
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DropShipNo); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> DueDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.DueDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> EcCode
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.EcCode); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Expedited
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Expedited); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ExportValue
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ExportValue); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> GrnlnGrnLine
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.GrnlnGrnLine); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> GrnlnGrnNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.GrnlnGrnNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.InWorkflow); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Item); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItemCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItemCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItemCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItemCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItemType
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItemType); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmDescription
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmDescription); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmLotPrefix
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmLotPrefix); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmLotTracked
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmLotTracked); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmSerialPrefix
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmSerialPrefix); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmSerialTracked
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmSerialTracked); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ItmUnitBrokerageCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ItmUnitBrokerageCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAccessUnit1
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAccessUnit1); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAccessUnit2
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAccessUnit2); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAccessUnit3
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAccessUnit3); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAccessUnit4
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAccessUnit4); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcct
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcct); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcctDesc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcctDesc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcctUnit1
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcctUnit1); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcctUnit2
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcctUnit2); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcctUnit3
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcctUnit3); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NonInvAcctUnit4
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NonInvAcctUnit4); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.NoteExistsFlag); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Origin
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Origin); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PlanCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PlanCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PlanCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PlanCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnBlanketQtyConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnBlanketQtyConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnDescription
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnDescription); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnDrawingNbr
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnDrawingNbr); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnEffDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnEffDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnExpDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnExpDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnItem
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnItem); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnItemCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnItemCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnPlanCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnPlanCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnPoLine
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnPoLine); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnRevision
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnRevision); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnStat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnStat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnUM
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnUM); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoBlnVendItem
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoBlnVendItem); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoExchRate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoExchRate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoLine
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoLine); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoOrderDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoOrderDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoRelease
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoRelease); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoStat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoStat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoTaxCode1
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoTaxCode1); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoTaxCode2
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoTaxCode2); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoType
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoType); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoVendNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoVendNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PoVendorPo
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PoVendorPo); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ProcessInd
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ProcessInd); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> PromiseDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.PromiseDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyOrdered
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyOrdered); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyOrderedConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyOrderedConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyReceived
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyReceived); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyRejected
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyRejected); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyReturned
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyReturned); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> QtyVoucher
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.QtyVoucher); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RcvdDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RcvdDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RecordDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RefLineSuf
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RefLineSuf); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RefNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RefNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RefRelease
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RefRelease); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RefType
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RefType); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ReleaseDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ReleaseDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ReqLine
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ReqLine); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ReqNum
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ReqNum); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Revision
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Revision); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RootJob
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RootJob); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RootSuf
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RootSuf); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.RowPointer); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> ShipAddr
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.ShipAddr); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> SLPochanges
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.SLPochanges); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Stat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Stat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> SupplQtyConvFactor
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.SupplQtyConvFactor); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TaxCode1); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TaxCode1Desc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TaxCode1Desc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TaxCode2); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TaxCode2Desc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TaxCode2Desc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TransNat
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TransNat); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TransNat2
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TransNat2); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TransNat2Desc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TransNat2Desc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> TransNatDesc
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.TransNatDesc); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Transport
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Transport); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbAddProjMatl
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbAddProjMatl); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbByCons
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbByCons); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbCostCode
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbCostCode); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbErrorStatus
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbErrorStatus); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbGrnExists
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbGrnExists); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbItemVendAdd
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbItemVendAdd); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbItemVendUpdate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbItemVendUpdate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbLocation
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbLocation); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbLot
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbLot); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbPoChangeIup
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbPoChangeIup); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbQtyReceived
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbQtyReceived); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbQtyReturned
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbQtyReturned); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbReasonCode
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbReasonCode); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbSLocation
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbSLocation); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbSLot
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbSLot); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbTotQtyReceived
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbTotQtyReceived); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbTotQtyReturned
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbTotQtyReturned); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbTransDate
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbTransDate); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbUpdateJobMatlUnitCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbUpdateJobMatlUnitCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UbWorkKey
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UbWorkKey); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UM
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UM); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitBrokerageCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitBrokerageCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitBrokerageCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitBrokerageCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitDutyCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitDutyCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitDutyCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitDutyCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitFreightCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitFreightCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitFreightCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitFreightCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitInsuranceCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitInsuranceCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitInsuranceCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitInsuranceCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitLocFrtCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitLocFrtCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitLocFrtCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitLocFrtCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitMatCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitMatCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitMatCostConv
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitMatCostConv); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> UnitWeight
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.UnitWeight); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> VenadrName
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.VenadrName); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> VenCurrCode
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.VenCurrCode); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> VendItem
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.VendItem); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> VenPriceBy
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.VenPriceBy); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> VoucherCost
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.VoucherCost); }
                    }
                            public FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<IdoPurchaseOrderLineHistoryBuilder, SLPitemhsFilterExpressionBuilder>(_builder, IdoPurchaseOrderLineHistory.Whse); }
                    }
                    

                }

}