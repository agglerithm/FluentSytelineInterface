
using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{ 
    public class Inventory : IdoConstants
    {
        public const string IDO_NAME = "SL.SLItemwhses";
        public const string TotalQtyOnHand = "TotalQtyOnHand";
        public const string Warehouse = "Whse";
        public const string Item = "Item";
        public const string AllocTrn = "AllocTrn";
        public const string CntInProc = "CntInProc";
        public const string CycleFlag = "CycleFlag";
        public const string CycleFreq = "CycleFreq";
        public const string CycleType = "CycleType";
        public const string DerCycleTypeD = "DerCycleTypeD";
        public const string DerCycleTypeI = "DerCycleTypeI";
        public const string DerCycleTypeR = "DerCycleTypeR";
        public const string DerCycleTypeZ = "DerCycleTypeZ";
        public const string DerItemAvailQtyAlloc = "DerItemAvailQtyAlloc";
        public const string DerItemAvailQtyAllocjob = "DerItemAvailQtyAllocjob";
        public const string DerItemAvailQtyAvail = "DerItemAvailQtyAvail";
        public const string DerItemAvailQtyOnHand = "DerItemAvailQtyOnHand";
        public const string DerItemAvailReceipts = "DerItemAvailReceipts";
        public const string DerItemAvailTotalQtyOnHand = "DerItemAvailTotalQtyOnHand";
        public const string DerItmRecordDate = "DerItmRecordDate";
        public const string DerQtyMrb = "DerQtyMrb";
        public const string DerQtyOnHand = "DerQtyOnHand";
        public const string DerQtyRsvdCo = "DerQtyRsvdCo";
        public const string DerWhse = "DerWhse";
        public const string InWorkflow = "InWorkflow"; 
        public const string ItemDescription = "ItemDescription";
        public const string ItemLotTracked = "ItemLotTracked";
        public const string ItmAvgFovhdCost = "ItmAvgFovhdCost";
        public const string ItmAvgLbrCost = "ItmAvgLbrCost";
        public const string ItmAvgMatlCost = "ItmAvgMatlCost";
        public const string ItmAvgOutCost = "ItmAvgOutCost";
        public const string ItmAvgUCost = "ItmAvgUCost";
        public const string ItmAvgVovhdCost = "ItmAvgVovhdCost";
        public const string ItmCostMethod = "ItmCostMethod";
        public const string ItmIssueBy = "ItmIssueBy";
        public const string ItmLstUCost = "ItmLstUCost";
        public const string ItmNextConfig = "ItmNextConfig";
        public const string ItmQtyMfgYtd = "ItmQtyMfgYtd";
        public const string ItmQtyUsedYtd = "ItmQtyUsedYtd";
        public const string ItmReservable = "ItmReservable";
        public const string ItmSerialTracked = "ItmSerialTracked";
        public const string LastCycle = "LastCycle";
        public const string Site = "LocSite";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PhyInvDte = "PhyInvDte";
        public const string PhyInvQty = "PhyInvQty";
        public const string QtyAllocated = "QtyAllocCo";
        public const string QtyAllocjob = "QtyAllocjob";
        public const string QtyMrb = "QtyMrb";
        public const string QtyOnHand = "QtyOnHand";
        public const string QtyOrdered = "QtyOrdered";
        public const string QtyPurYtd = "QtyPurYtd";
        public const string QtyReorder = "QtyReorder";
        public const string QtyRsvdCo = "QtyRsvdCo";
        public const string QtySoldYtd = "QtySoldYtd";
        public const string QtyTrans = "QtyTrans";
        public const string QtyWip = "QtyWip";
        public const string RecordDate = "RecordDate";
        public const string ReplenPoNum = "ReplenPoNum";
        public const string ReplenPsNum = "ReplenPsNum";
        public const string ReplenTrnNum = "ReplenTrnNum";
        public const string RowPointer = "RowPointer";
        public const string SalesPtd = "SalesPtd";
        public const string SalesYtd = "SalesYtd";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string SLRsvdInvs = "SLRsvdInvs";
        public const string SLSerials = "SLSerials"; 
        public const string TotalQtyReserved = "TotalQtyReserved";
        public const string TrnInYtd = "TrnInYtd";
        public const string TrnOutYtd = "TrnOutYtd";
        public const string UoM = "UM"; 
        public const string WhseCycleType = "WhseCycleType";
        public const string WhseName = "WhseName";  
        public const string LocSite = "LocSite"; 
        public const string QtyAllocCo = "QtyAllocCo"; 

        
    }

    public class InventoryBuilder :
        IdoQueryBuilder<InventoryBuilder, InventoryFilterExpressionBuilder>
    {
        public InventoryBuilder(IExpressionInterpreter ei) : base(Inventory.IDO_NAME, ei) { }

        public InventoryBuilder TotalQtyOnHand { get { AddProperty(Inventory.TotalQtyOnHand); return this; } }
        public InventoryBuilder Warehouse { get { AddProperty(Inventory.Warehouse); return this; } }
        public InventoryBuilder Item { get { AddProperty(Inventory.Item); return this; } }
        public InventoryBuilder ItemDescription { get { AddProperty(Inventory.ItemDescription); return this; } }
        public InventoryBuilder Site { get { AddProperty(Inventory.Site); return this; } }
        public InventoryBuilder QtyOrdered { get { AddProperty(Inventory.QtyOrdered); return this; } }
        public InventoryBuilder RecordDate { get { AddProperty(Inventory.RecordDate); return this; } }
        public InventoryBuilder QtyAllocated { get { AddProperty(Inventory.QtyAllocated); return this; } }
        public InventoryBuilder QtyReorder { get { AddProperty(Inventory.QtyReorder); return this; } }
        public InventoryBuilder AllocTrn { get { AddProperty(Inventory.AllocTrn); return this; } }
        public InventoryBuilder CntInProc { get { AddProperty(Inventory.CntInProc); return this; } }
        public InventoryBuilder CycleFlag { get { AddProperty(Inventory.CycleFlag); return this; } }
        public InventoryBuilder CycleFreq { get { AddProperty(Inventory.CycleFreq); return this; } }
        public InventoryBuilder CycleType { get { AddProperty(Inventory.CycleType); return this; } }
        public InventoryBuilder DerCycleTypeD { get { AddProperty(Inventory.DerCycleTypeD); return this; } }
        public InventoryBuilder DerCycleTypeI { get { AddProperty(Inventory.DerCycleTypeI); return this; } }
        public InventoryBuilder DerCycleTypeR { get { AddProperty(Inventory.DerCycleTypeR); return this; } }
        public InventoryBuilder DerCycleTypeZ { get { AddProperty(Inventory.DerCycleTypeZ); return this; } }
        public InventoryBuilder DerItemAvailQtyAlloc { get { AddProperty(Inventory.DerItemAvailQtyAlloc); return this; } }
        public InventoryBuilder DerItemAvailQtyAllocjob { get { AddProperty(Inventory.DerItemAvailQtyAllocjob); return this; } }
        public InventoryBuilder DerItemAvailQtyAvail { get { AddProperty(Inventory.DerItemAvailQtyAvail); return this; } }
        public InventoryBuilder DerItemAvailQtyOnHand { get { AddProperty(Inventory.DerItemAvailQtyOnHand); return this; } }
        public InventoryBuilder DerItemAvailReceipts { get { AddProperty(Inventory.DerItemAvailReceipts); return this; } }
        public InventoryBuilder DerItemAvailTotalQtyOnHand { get { AddProperty(Inventory.DerItemAvailTotalQtyOnHand); return this; } }
        public InventoryBuilder DerItmRecordDate { get { AddProperty(Inventory.DerItmRecordDate); return this; } }
        public InventoryBuilder DerQtyMrb { get { AddProperty(Inventory.DerQtyMrb); return this; } }
        public InventoryBuilder DerQtyOnHand { get { AddProperty(Inventory.DerQtyOnHand); return this; } }
        public InventoryBuilder DerQtyRsvdCo { get { AddProperty(Inventory.DerQtyRsvdCo); return this; } }
        public InventoryBuilder DerWhse { get { AddProperty(Inventory.DerWhse); return this; } }
        public InventoryBuilder InWorkflow { get { AddProperty(Inventory.InWorkflow); return this; } } 
        public InventoryBuilder ItemLotTracked { get { AddProperty(Inventory.ItemLotTracked); return this; } }
        public InventoryBuilder ItmAvgFovhdCost { get { AddProperty(Inventory.ItmAvgFovhdCost); return this; } }
        public InventoryBuilder ItmAvgLbrCost { get { AddProperty(Inventory.ItmAvgLbrCost); return this; } }
        public InventoryBuilder ItmAvgMatlCost { get { AddProperty(Inventory.ItmAvgMatlCost); return this; } }
        public InventoryBuilder ItmAvgOutCost { get { AddProperty(Inventory.ItmAvgOutCost); return this; } }
        public InventoryBuilder ItmAvgUCost { get { AddProperty(Inventory.ItmAvgUCost); return this; } }
        public InventoryBuilder ItmAvgVovhdCost { get { AddProperty(Inventory.ItmAvgVovhdCost); return this; } }
        public InventoryBuilder ItmCostMethod { get { AddProperty(Inventory.ItmCostMethod); return this; } }
        public InventoryBuilder ItmIssueBy { get { AddProperty(Inventory.ItmIssueBy); return this; } }
        public InventoryBuilder ItmLstUCost { get { AddProperty(Inventory.ItmLstUCost); return this; } }
        public InventoryBuilder ItmNextConfig { get { AddProperty(Inventory.ItmNextConfig); return this; } }
        public InventoryBuilder ItmQtyMfgYtd { get { AddProperty(Inventory.ItmQtyMfgYtd); return this; } }
        public InventoryBuilder ItmQtyUsedYtd { get { AddProperty(Inventory.ItmQtyUsedYtd); return this; } }
        public InventoryBuilder ItmReservable { get { AddProperty(Inventory.ItmReservable); return this; } }
        public InventoryBuilder ItmSerialTracked { get { AddProperty(Inventory.ItmSerialTracked); return this; } }
        public InventoryBuilder LastCycle { get { AddProperty(Inventory.LastCycle); return this; } }
        public InventoryBuilder LocSite { get { AddProperty(Inventory.LocSite); return this; } }
        public InventoryBuilder NoteExistsFlag { get { AddProperty(Inventory.NoteExistsFlag); return this; } }
        public InventoryBuilder PhyInvDte { get { AddProperty(Inventory.PhyInvDte); return this; } }
        public InventoryBuilder PhyInvQty { get { AddProperty(Inventory.PhyInvQty); return this; } }
        public InventoryBuilder QtyAllocCo { get { AddProperty(Inventory.QtyAllocCo); return this; } }
        public InventoryBuilder QtyAllocjob { get { AddProperty(Inventory.QtyAllocjob); return this; } }
        public InventoryBuilder QtyMrb { get { AddProperty(Inventory.QtyMrb); return this; } }
        public InventoryBuilder QtyOnHand { get { AddProperty(Inventory.QtyOnHand); return this; } } 
        public InventoryBuilder QtyPurYtd { get { AddProperty(Inventory.QtyPurYtd); return this; } } 
        public InventoryBuilder QtyRsvdCo { get { AddProperty(Inventory.QtyRsvdCo); return this; } }
        public InventoryBuilder QtySoldYtd { get { AddProperty(Inventory.QtySoldYtd); return this; } }
        public InventoryBuilder QtyTrans { get { AddProperty(Inventory.QtyTrans); return this; } }
        public InventoryBuilder QtyWip { get { AddProperty(Inventory.QtyWip); return this; } } 
        public InventoryBuilder ReplenPoNum { get { AddProperty(Inventory.ReplenPoNum); return this; } }
        public InventoryBuilder ReplenPsNum { get { AddProperty(Inventory.ReplenPsNum); return this; } }
        public InventoryBuilder ReplenTrnNum { get { AddProperty(Inventory.ReplenTrnNum); return this; } }
        public InventoryBuilder RowPointer { get { AddProperty(Inventory.RowPointer); return this; } }
        public InventoryBuilder SalesPtd { get { AddProperty(Inventory.SalesPtd); return this; } }
        public InventoryBuilder SalesYtd { get { AddProperty(Inventory.SalesYtd); return this; } }
        public InventoryBuilder ShowInDropDownList { get { AddProperty(Inventory.ShowInDropDownList); return this; } }
        public InventoryBuilder SLRsvdInvs { get { AddProperty(Inventory.SLRsvdInvs); return this; } }
        public InventoryBuilder SLSerials { get { AddProperty(Inventory.SLSerials); return this; } } 
        public InventoryBuilder TotalQtyReserved { get { AddProperty(Inventory.TotalQtyReserved); return this; } }
        public InventoryBuilder TrnInYtd { get { AddProperty(Inventory.TrnInYtd); return this; } }
        public InventoryBuilder TrnOutYtd { get { AddProperty(Inventory.TrnOutYtd); return this; } } 
        public InventoryBuilder WhseCycleType { get { AddProperty(Inventory.WhseCycleType); return this; } }
        public InventoryBuilder WhseName { get { AddProperty(Inventory.WhseName); return this; } } 
        public InventoryBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (InventoryBuilder) base.WithChildren(builders);
        }

        public InventoryBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (InventoryBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class InventoryFilterExpressionBuilder  : FilterExpressionBuilder<InventoryBuilder>
    {
        public FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder> TotalQtyOnHand
        {
            get { return new FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder>(_builder, Inventory.TotalQtyOnHand); }
        }
        public FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder> Warehouse
        {
            get { return new FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder>(_builder, Inventory.Warehouse); }
        }
        public FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<InventoryBuilder, InventoryFilterExpressionBuilder>(_builder, Inventory.Item); }
        }



    }
}