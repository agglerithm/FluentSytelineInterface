using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    public class IdoItemLocs : IdoConstants
    {
        public const string IDO_NAME = "SLItemLocs";
        public const string DerASPSearch = "DerASPSearch";
        public const string DerIWhseQtyOnHand = "DerIWhseQtyOnHand";
        public const string DerIWhseTotalNonNetStock = "DerIWhseTotalNonNetStock";
        public const string DerIWhseTotalRsvdCO = "DerIWhseTotalRsvdCO";
        public const string DerTotalCost = "DerTotalCost";
        public const string DerUM = "DerUM";
        public const string FovaccAccessUnit1 = "FovaccAccessUnit1";
        public const string FovaccAccessUnit2 = "FovaccAccessUnit2";
        public const string FovaccAccessUnit3 = "FovaccAccessUnit3";
        public const string FovaccAccessUnit4 = "FovaccAccessUnit4";
        public const string FovaccDescription = "FovaccDescription";
        public const string FovhdAcct = "FovhdAcct";
        public const string FovhdAcctUnit1 = "FovhdAcctUnit1";
        public const string FovhdAcctUnit2 = "FovhdAcctUnit2";
        public const string FovhdAcctUnit3 = "FovhdAcctUnit3";
        public const string FovhdAcctUnit4 = "FovhdAcctUnit4";
        public const string FovhdCost = "FovhdCost";
        public const string InvaccAccessUnit1 = "InvaccAccessUnit1";
        public const string InvaccAccessUnit2 = "InvaccAccessUnit2";
        public const string InvaccAccessUnit3 = "InvaccAccessUnit3";
        public const string InvaccAccessUnit4 = "InvaccAccessUnit4";
        public const string InvaccDescription = "InvaccDescription";
        public const string InvAcct = "InvAcct";
        public const string InvAcctUnit1 = "InvAcctUnit1";
        public const string InvAcctUnit2 = "InvAcctUnit2";
        public const string InvAcctUnit3 = "InvAcctUnit3";
        public const string InvAcctUnit4 = "InvAcctUnit4";
        public const string InvpBflushLoc = "InvpBflushLoc";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItmBflushLoc = "ItmBflushLoc";
        public const string ItmCostMethod = "ItmCostMethod";
        public const string ItmCostType = "ItmCostType";
        public const string ItmDescription = "ItmDescription";
        public const string ItmIssueBy = "ItmIssueBy";
        public const string ItmItem = "ItmItem";
        public const string ItmLotTracked = "ItmLotTracked";
        public const string ItmSerialTracked = "ItmSerialTracked";
        public const string ItmUM = "ItmUM";
        public const string ItmwhseQtyOnHand = "ItmwhseQtyOnHand";
        public const string JmatlJob = "JmatlJob";
        public const string LbraccAccessUnit1 = "LbraccAccessUnit1";
        public const string LbraccAccessUnit2 = "LbraccAccessUnit2";
        public const string LbraccAccessUnit3 = "LbraccAccessUnit3";
        public const string LbraccAccessUnit4 = "LbraccAccessUnit4";
        public const string LbraccDescription = "LbraccDescription";
        public const string LbrAcct = "LbrAcct";
        public const string LbrAcctUnit1 = "LbrAcctUnit1";
        public const string LbrAcctUnit2 = "LbrAcctUnit2";
        public const string LbrAcctUnit3 = "LbrAcctUnit3";
        public const string LbrAcctUnit4 = "LbrAcctUnit4";
        public const string LbrCost = "LbrCost";
        public const string Loc = "Loc";
        public const string LocDescription = "LocDescription";
        public const string LocLoc = "LocLoc";
        public const string LocType = "LocType";
        public const string LocWc = "LocWc";
        public const string MatlCost = "MatlCost";
        public const string MrbFlag = "MrbFlag";
        public const string NewRank = "NewRank";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OutaccAccessUnit1 = "OutaccAccessUnit1";
        public const string OutaccAccessUnit2 = "OutaccAccessUnit2";
        public const string OutaccAccessUnit3 = "OutaccAccessUnit3";
        public const string OutaccAccessUnit4 = "OutaccAccessUnit4";
        public const string OutaccDescription = "OutaccDescription";
        public const string OutAcct = "OutAcct";
        public const string OutAcctUnit1 = "OutAcctUnit1";
        public const string OutAcctUnit2 = "OutAcctUnit2";
        public const string OutAcctUnit3 = "OutAcctUnit3";
        public const string OutAcctUnit4 = "OutAcctUnit4";
        public const string OutCost = "OutCost";
        public const string PermFlag = "PermFlag";
        public const string QtyOnHand = "QtyOnHand";
        public const string QtyRsvd = "QtyRsvd";
        public const string Rank = "Rank";
        public const string RecordDate = "RecordDate";
        public const string RecordState = "RecordState";
        public const string RowPointer = "RowPointer";
        public const string SLSerials = "SLSerials";
        public const string UbToLoc = "UbToLoc";
        public const string UBTrnDate = "UBTrnDate";
        public const string UBTrnDesc = "UBTrnDesc";
        public const string UBTrnReasonCode = "UBTrnReasonCode";
        public const string UBTrnType = "UBTrnType";
        public const string UnitCost = "UnitCost";
        public const string VovacctAccessUnit1 = "VovacctAccessUnit1";
        public const string VovacctAccessUnit2 = "VovacctAccessUnit2";
        public const string VovacctAccessUnit3 = "VovacctAccessUnit3";
        public const string VovacctAccessUnit4 = "VovacctAccessUnit4";
        public const string VovacctDescription = "VovacctDescription";
        public const string VovhdAcct = "VovhdAcct";
        public const string VovhdAcctUnit1 = "VovhdAcctUnit1";
        public const string VovhdAcctUnit2 = "VovhdAcctUnit2";
        public const string VovhdAcctUnit3 = "VovhdAcctUnit3";
        public const string VovhdAcctUnit4 = "VovhdAcctUnit4";
        public const string VovhdCost = "VovhdCost";
        public const string Wc = "Wc";
        public const string Whse = "Whse";
        public const string WhsName = "WhsName";
        public const string WhsWhse = "WhsWhse";


    }

    public class IdoItemLocsBuilder
        : IdoQueryBuilder<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>
    {
        public IdoItemLocsBuilder(IExpressionInterpreter interpreter) : base(IdoItemLocs.IDO_NAME, interpreter) { }

        public IdoItemLocsBuilder DerASPSearch { get { AddProperty(IdoItemLocs.DerASPSearch); return this; } }
        public IdoItemLocsBuilder DerIWhseQtyOnHand { get { AddProperty(IdoItemLocs.DerIWhseQtyOnHand); return this; } }
        public IdoItemLocsBuilder DerIWhseTotalNonNetStock { get { AddProperty(IdoItemLocs.DerIWhseTotalNonNetStock); return this; } }
        public IdoItemLocsBuilder DerIWhseTotalRsvdCO { get { AddProperty(IdoItemLocs.DerIWhseTotalRsvdCO); return this; } }
        public IdoItemLocsBuilder DerTotalCost { get { AddProperty(IdoItemLocs.DerTotalCost); return this; } }
        public IdoItemLocsBuilder DerUM { get { AddProperty(IdoItemLocs.DerUM); return this; } }
        public IdoItemLocsBuilder FovaccAccessUnit1 { get { AddProperty(IdoItemLocs.FovaccAccessUnit1); return this; } }
        public IdoItemLocsBuilder FovaccAccessUnit2 { get { AddProperty(IdoItemLocs.FovaccAccessUnit2); return this; } }
        public IdoItemLocsBuilder FovaccAccessUnit3 { get { AddProperty(IdoItemLocs.FovaccAccessUnit3); return this; } }
        public IdoItemLocsBuilder FovaccAccessUnit4 { get { AddProperty(IdoItemLocs.FovaccAccessUnit4); return this; } }
        public IdoItemLocsBuilder FovaccDescription { get { AddProperty(IdoItemLocs.FovaccDescription); return this; } }
        public IdoItemLocsBuilder FovhdAcct { get { AddProperty(IdoItemLocs.FovhdAcct); return this; } }
        public IdoItemLocsBuilder FovhdAcctUnit1 { get { AddProperty(IdoItemLocs.FovhdAcctUnit1); return this; } }
        public IdoItemLocsBuilder FovhdAcctUnit2 { get { AddProperty(IdoItemLocs.FovhdAcctUnit2); return this; } }
        public IdoItemLocsBuilder FovhdAcctUnit3 { get { AddProperty(IdoItemLocs.FovhdAcctUnit3); return this; } }
        public IdoItemLocsBuilder FovhdAcctUnit4 { get { AddProperty(IdoItemLocs.FovhdAcctUnit4); return this; } }
        public IdoItemLocsBuilder FovhdCost { get { AddProperty(IdoItemLocs.FovhdCost); return this; } }
        public IdoItemLocsBuilder InvaccAccessUnit1 { get { AddProperty(IdoItemLocs.InvaccAccessUnit1); return this; } }
        public IdoItemLocsBuilder InvaccAccessUnit2 { get { AddProperty(IdoItemLocs.InvaccAccessUnit2); return this; } }
        public IdoItemLocsBuilder InvaccAccessUnit3 { get { AddProperty(IdoItemLocs.InvaccAccessUnit3); return this; } }
        public IdoItemLocsBuilder InvaccAccessUnit4 { get { AddProperty(IdoItemLocs.InvaccAccessUnit4); return this; } }
        public IdoItemLocsBuilder InvaccDescription { get { AddProperty(IdoItemLocs.InvaccDescription); return this; } }
        public IdoItemLocsBuilder InvAcct { get { AddProperty(IdoItemLocs.InvAcct); return this; } }
        public IdoItemLocsBuilder InvAcctUnit1 { get { AddProperty(IdoItemLocs.InvAcctUnit1); return this; } }
        public IdoItemLocsBuilder InvAcctUnit2 { get { AddProperty(IdoItemLocs.InvAcctUnit2); return this; } }
        public IdoItemLocsBuilder InvAcctUnit3 { get { AddProperty(IdoItemLocs.InvAcctUnit3); return this; } }
        public IdoItemLocsBuilder InvAcctUnit4 { get { AddProperty(IdoItemLocs.InvAcctUnit4); return this; } }
        public IdoItemLocsBuilder InvpBflushLoc { get { AddProperty(IdoItemLocs.InvpBflushLoc); return this; } }
        public IdoItemLocsBuilder InWorkflow { get { AddProperty(IdoItemLocs.InWorkflow); return this; } }
        public IdoItemLocsBuilder Item { get { AddProperty(IdoItemLocs.Item); return this; } }
        public IdoItemLocsBuilder ItmBflushLoc { get { AddProperty(IdoItemLocs.ItmBflushLoc); return this; } }
        public IdoItemLocsBuilder ItmCostMethod { get { AddProperty(IdoItemLocs.ItmCostMethod); return this; } }
        public IdoItemLocsBuilder ItmCostType { get { AddProperty(IdoItemLocs.ItmCostType); return this; } }
        public IdoItemLocsBuilder ItmDescription { get { AddProperty(IdoItemLocs.ItmDescription); return this; } }
        public IdoItemLocsBuilder ItmIssueBy { get { AddProperty(IdoItemLocs.ItmIssueBy); return this; } }
        public IdoItemLocsBuilder ItmItem { get { AddProperty(IdoItemLocs.ItmItem); return this; } }
        public IdoItemLocsBuilder ItmLotTracked { get { AddProperty(IdoItemLocs.ItmLotTracked); return this; } }
        public IdoItemLocsBuilder ItmSerialTracked { get { AddProperty(IdoItemLocs.ItmSerialTracked); return this; } }
        public IdoItemLocsBuilder ItmUM { get { AddProperty(IdoItemLocs.ItmUM); return this; } }
        public IdoItemLocsBuilder ItmwhseQtyOnHand { get { AddProperty(IdoItemLocs.ItmwhseQtyOnHand); return this; } }
        public IdoItemLocsBuilder JmatlJob { get { AddProperty(IdoItemLocs.JmatlJob); return this; } }
        public IdoItemLocsBuilder LbraccAccessUnit1 { get { AddProperty(IdoItemLocs.LbraccAccessUnit1); return this; } }
        public IdoItemLocsBuilder LbraccAccessUnit2 { get { AddProperty(IdoItemLocs.LbraccAccessUnit2); return this; } }
        public IdoItemLocsBuilder LbraccAccessUnit3 { get { AddProperty(IdoItemLocs.LbraccAccessUnit3); return this; } }
        public IdoItemLocsBuilder LbraccAccessUnit4 { get { AddProperty(IdoItemLocs.LbraccAccessUnit4); return this; } }
        public IdoItemLocsBuilder LbraccDescription { get { AddProperty(IdoItemLocs.LbraccDescription); return this; } }
        public IdoItemLocsBuilder LbrAcct { get { AddProperty(IdoItemLocs.LbrAcct); return this; } }
        public IdoItemLocsBuilder LbrAcctUnit1 { get { AddProperty(IdoItemLocs.LbrAcctUnit1); return this; } }
        public IdoItemLocsBuilder LbrAcctUnit2 { get { AddProperty(IdoItemLocs.LbrAcctUnit2); return this; } }
        public IdoItemLocsBuilder LbrAcctUnit3 { get { AddProperty(IdoItemLocs.LbrAcctUnit3); return this; } }
        public IdoItemLocsBuilder LbrAcctUnit4 { get { AddProperty(IdoItemLocs.LbrAcctUnit4); return this; } }
        public IdoItemLocsBuilder LbrCost { get { AddProperty(IdoItemLocs.LbrCost); return this; } }
        public IdoItemLocsBuilder Loc { get { AddProperty(IdoItemLocs.Loc); return this; } }
        public IdoItemLocsBuilder LocDescription { get { AddProperty(IdoItemLocs.LocDescription); return this; } }
        public IdoItemLocsBuilder LocLoc { get { AddProperty(IdoItemLocs.LocLoc); return this; } }
        public IdoItemLocsBuilder LocType { get { AddProperty(IdoItemLocs.LocType); return this; } }
        public IdoItemLocsBuilder LocWc { get { AddProperty(IdoItemLocs.LocWc); return this; } }
        public IdoItemLocsBuilder MatlCost { get { AddProperty(IdoItemLocs.MatlCost); return this; } }
        public IdoItemLocsBuilder MrbFlag { get { AddProperty(IdoItemLocs.MrbFlag); return this; } }
        public IdoItemLocsBuilder NewRank { get { AddProperty(IdoItemLocs.NewRank); return this; } }
        public IdoItemLocsBuilder NoteExistsFlag { get { AddProperty(IdoItemLocs.NoteExistsFlag); return this; } }
        public IdoItemLocsBuilder OutaccAccessUnit1 { get { AddProperty(IdoItemLocs.OutaccAccessUnit1); return this; } }
        public IdoItemLocsBuilder OutaccAccessUnit2 { get { AddProperty(IdoItemLocs.OutaccAccessUnit2); return this; } }
        public IdoItemLocsBuilder OutaccAccessUnit3 { get { AddProperty(IdoItemLocs.OutaccAccessUnit3); return this; } }
        public IdoItemLocsBuilder OutaccAccessUnit4 { get { AddProperty(IdoItemLocs.OutaccAccessUnit4); return this; } }
        public IdoItemLocsBuilder OutaccDescription { get { AddProperty(IdoItemLocs.OutaccDescription); return this; } }
        public IdoItemLocsBuilder OutAcct { get { AddProperty(IdoItemLocs.OutAcct); return this; } }
        public IdoItemLocsBuilder OutAcctUnit1 { get { AddProperty(IdoItemLocs.OutAcctUnit1); return this; } }
        public IdoItemLocsBuilder OutAcctUnit2 { get { AddProperty(IdoItemLocs.OutAcctUnit2); return this; } }
        public IdoItemLocsBuilder OutAcctUnit3 { get { AddProperty(IdoItemLocs.OutAcctUnit3); return this; } }
        public IdoItemLocsBuilder OutAcctUnit4 { get { AddProperty(IdoItemLocs.OutAcctUnit4); return this; } }
        public IdoItemLocsBuilder OutCost { get { AddProperty(IdoItemLocs.OutCost); return this; } }
        public IdoItemLocsBuilder PermFlag { get { AddProperty(IdoItemLocs.PermFlag); return this; } }
        public IdoItemLocsBuilder QtyOnHand { get { AddProperty(IdoItemLocs.QtyOnHand); return this; } }
        public IdoItemLocsBuilder QtyRsvd { get { AddProperty(IdoItemLocs.QtyRsvd); return this; } }
        public IdoItemLocsBuilder Rank { get { AddProperty(IdoItemLocs.Rank); return this; } }
        public IdoItemLocsBuilder RecordDate { get { AddProperty(IdoItemLocs.RecordDate); return this; } }
        public IdoItemLocsBuilder RecordState { get { AddProperty(IdoItemLocs.RecordState); return this; } }
        public IdoItemLocsBuilder RowPointer { get { AddProperty(IdoItemLocs.RowPointer); return this; } }
        public IdoItemLocsBuilder SLSerials { get { AddProperty(IdoItemLocs.SLSerials); return this; } }
        public IdoItemLocsBuilder UbToLoc { get { AddProperty(IdoItemLocs.UbToLoc); return this; } }
        public IdoItemLocsBuilder UBTrnDate { get { AddProperty(IdoItemLocs.UBTrnDate); return this; } }
        public IdoItemLocsBuilder UBTrnDesc { get { AddProperty(IdoItemLocs.UBTrnDesc); return this; } }
        public IdoItemLocsBuilder UBTrnReasonCode { get { AddProperty(IdoItemLocs.UBTrnReasonCode); return this; } }
        public IdoItemLocsBuilder UBTrnType { get { AddProperty(IdoItemLocs.UBTrnType); return this; } }
        public IdoItemLocsBuilder UnitCost { get { AddProperty(IdoItemLocs.UnitCost); return this; } }
        public IdoItemLocsBuilder VovacctAccessUnit1 { get { AddProperty(IdoItemLocs.VovacctAccessUnit1); return this; } }
        public IdoItemLocsBuilder VovacctAccessUnit2 { get { AddProperty(IdoItemLocs.VovacctAccessUnit2); return this; } }
        public IdoItemLocsBuilder VovacctAccessUnit3 { get { AddProperty(IdoItemLocs.VovacctAccessUnit3); return this; } }
        public IdoItemLocsBuilder VovacctAccessUnit4 { get { AddProperty(IdoItemLocs.VovacctAccessUnit4); return this; } }
        public IdoItemLocsBuilder VovacctDescription { get { AddProperty(IdoItemLocs.VovacctDescription); return this; } }
        public IdoItemLocsBuilder VovhdAcct { get { AddProperty(IdoItemLocs.VovhdAcct); return this; } }
        public IdoItemLocsBuilder VovhdAcctUnit1 { get { AddProperty(IdoItemLocs.VovhdAcctUnit1); return this; } }
        public IdoItemLocsBuilder VovhdAcctUnit2 { get { AddProperty(IdoItemLocs.VovhdAcctUnit2); return this; } }
        public IdoItemLocsBuilder VovhdAcctUnit3 { get { AddProperty(IdoItemLocs.VovhdAcctUnit3); return this; } }
        public IdoItemLocsBuilder VovhdAcctUnit4 { get { AddProperty(IdoItemLocs.VovhdAcctUnit4); return this; } }
        public IdoItemLocsBuilder VovhdCost { get { AddProperty(IdoItemLocs.VovhdCost); return this; } }
        public IdoItemLocsBuilder Wc { get { AddProperty(IdoItemLocs.Wc); return this; } }
        public IdoItemLocsBuilder Whse { get { AddProperty(IdoItemLocs.Whse); return this; } }
        public IdoItemLocsBuilder WhsName { get { AddProperty(IdoItemLocs.WhsName); return this; } }
        public IdoItemLocsBuilder WhsWhse { get { AddProperty(IdoItemLocs.WhsWhse); return this; } }


    }

    public class SLItemLocsFilterExpressionBuilder
        : FilterExpressionBuilder<IdoItemLocsBuilder>
    {
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerASPSearch
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerASPSearch); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseQtyOnHand
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerIWhseQtyOnHand); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseTotalNonNetStock
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerIWhseTotalNonNetStock); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseTotalRsvdCO
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerIWhseTotalRsvdCO); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerTotalCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerTotalCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerUM
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.DerUM); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovaccAccessUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovaccAccessUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovaccAccessUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovaccAccessUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovaccDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcct
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdAcct); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdAcctUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdAcctUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdAcctUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdAcctUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.FovhdCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvaccAccessUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvaccAccessUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvaccAccessUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvaccAccessUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvaccDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcct
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvAcct); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvAcctUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvAcctUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvAcctUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvAcctUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvpBflushLoc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InvpBflushLoc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.InWorkflow); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.Item); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmBflushLoc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmBflushLoc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmCostMethod
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmCostMethod); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmCostType
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmCostType); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmIssueBy
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmIssueBy); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmItem
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmItem); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmLotTracked
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmLotTracked); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmSerialTracked
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmSerialTracked); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmUM
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmUM); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmwhseQtyOnHand
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.ItmwhseQtyOnHand); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> JmatlJob
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.JmatlJob); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbraccAccessUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbraccAccessUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbraccAccessUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbraccAccessUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbraccDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcct
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrAcct); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrAcctUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrAcctUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrAcctUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrAcctUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LbrCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Loc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.Loc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LocDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocLoc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LocLoc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocType
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LocType); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocWc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.LocWc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> MatlCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.MatlCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> MrbFlag
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.MrbFlag); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> NewRank
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.NewRank); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.NoteExistsFlag); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutaccAccessUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutaccAccessUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutaccAccessUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutaccAccessUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutaccDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcct
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutAcct); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutAcctUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutAcctUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutAcctUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutAcctUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.OutCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> PermFlag
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.PermFlag); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> QtyOnHand
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.QtyOnHand); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> QtyRsvd
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.QtyRsvd); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Rank
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.Rank); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.RecordDate); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RecordState
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.RecordState); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.RowPointer); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> SLSerials
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.SLSerials); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UbToLoc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UbToLoc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnDate
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UBTrnDate); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnDesc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UBTrnDesc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnReasonCode
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UBTrnReasonCode); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnType
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UBTrnType); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UnitCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.UnitCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovacctAccessUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovacctAccessUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovacctAccessUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovacctAccessUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctDescription
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovacctDescription); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcct
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdAcct); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit1
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdAcctUnit1); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit2
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdAcctUnit2); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit3
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdAcctUnit3); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit4
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdAcctUnit4); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdCost
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.VovhdCost); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Wc
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.Wc); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.Whse); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> WhsName
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.WhsName); }
        }
        public FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder> WhsWhse
        {
            get { return new FilterExpression<IdoItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, IdoItemLocs.WhsWhse); }
        }


    }

}