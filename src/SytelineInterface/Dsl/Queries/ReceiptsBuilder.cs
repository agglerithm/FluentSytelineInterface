
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class Receipts : IdoConstants
    {
        public const string IDO_NAME = "SLPoRcpts";
        public const string ByCons = "ByCons";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string CurrDescription = "CurrDescription";
        public const string CurrhAmtTotFormat = "CurrhAmtTotFormat";
        public const string CurrhCstPrcFormat = "CurrhCstPrcFormat";
        public const string CurrhDescription = "CurrhDescription";
        public const string DateSeq = "DateSeq";
        public const string DerHItemCostConv = "DerHItemCostConv";
        public const string DerHPoitemTotalCost = "DerHPoitemTotalCost";
        public const string DerHQtyReceivedConv = "DerHQtyReceivedConv";
        public const string DerHQtyReturnedConv = "DerHQtyReturnedConv";
        public const string DerHTotalCostConv = "DerHTotalCostConv";
        public const string DerItemCostConv = "DerItemCostConv";
        public const string PoitemTotalCost = "DerPoitemTotalCost";
        public const string DerQtyReceivedConv = "DerQtyReceivedConv";
        public const string DerQtyReturnedConv = "DerQtyReturnedConv";
        public const string DerTotalCostConv = "DerTotalCostConv";
        public const string ExchRate = "ExchRate";
        public const string GrnLine = "GrnLine";
        public const string GrnNum = "GrnNum";
        public const string InWorkflow = "InWorkflow";
        public const string ItemCost = "ItemCost";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PackNum = "PackNum"; 
        public const string PohExchRate = "PohExchRate"; 
        public const string ItemDescription = "PoiDescription";
        public const string PoihDescription = "PoihDescription";
        public const string PoihItem = "PoihItem";
        public const string PoihItemCostConv = "PoihItemCostConv";
        public const string PoihPlanCostConv = "PoihPlanCostConv";
        public const string PoihQtyOrderedConv = "PoihQtyOrderedConv"; 
        public const string PoiItemCostConv = "PoiItemCostConv";
        public const string PoiPlanCostConv = "PoiPlanCostConv";
        public const string PoiQtyOrdered = "PoiQtyOrdered";
        public const string PoiQtyOrderedConv = "PoiQtyOrderedConv";
        public const string Item = "PoItem";
        public const string UM = "PoiUM";
        public const string PoLine = "PoLine";
        public const string PoNum = "PoNum";
        public const string PoOrderDate = "PoOrderDate";
        public const string PoRelease = "PoRelease";
        public const string Status = "PoStat";
        public const string PoVendNum = "PoVendNum";
        public const string QtyReceived = "QtyReceived";
        public const string QtyReturned = "QtyReturned";
        public const string QtyVouchered = "QtyVouchered";
        public const string RcvdDate = "RcvdDate";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string SupplQty = "SupplQty";
        public const string UbSelectedGrn = "UbSelectedGrn";
        public const string UnitBrokerageCost = "UnitBrokerageCost";
        public const string UnitDutyCost = "UnitDutyCost";
        public const string UnitFreightCost = "UnitFreightCost";
        public const string UnitMatCost = "UnitMatCost";
        public const string UnitWeight = "UnitWeight";
        public const string VenaddhName = "VenaddhName";
        public const string VenaddName = "VenaddName";
        public const string VendCurrCode = "VendCurrCode";
        public const string VendhCurrCode = "VendhCurrCode";
        public const string VendNum = "VendNum";


    }

    public class ReceiptsBuilder
        : IdoQueryBuilder<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>
    {
        public ReceiptsBuilder(IExpressionInterpreter interpreter) : base(Receipts.IDO_NAME, interpreter) { }

        public ReceiptsBuilder ByCons { get { AddProperty(Receipts.ByCons); return this; } }
        public ReceiptsBuilder CurrAmtTotFormat { get { AddProperty(Receipts.CurrAmtTotFormat); return this; } }
        public ReceiptsBuilder CurrCstPrcFormat { get { AddProperty(Receipts.CurrCstPrcFormat); return this; } }
        public ReceiptsBuilder CurrDescription { get { AddProperty(Receipts.CurrDescription); return this; } }
        public ReceiptsBuilder CurrhAmtTotFormat { get { AddProperty(Receipts.CurrhAmtTotFormat); return this; } }
        public ReceiptsBuilder CurrhCstPrcFormat { get { AddProperty(Receipts.CurrhCstPrcFormat); return this; } }
        public ReceiptsBuilder CurrhDescription { get { AddProperty(Receipts.CurrhDescription); return this; } }
        public ReceiptsBuilder DateSeq { get { AddProperty(Receipts.DateSeq); return this; } }
        public ReceiptsBuilder DerHItemCostConv { get { AddProperty(Receipts.DerHItemCostConv); return this; } }
        public ReceiptsBuilder DerHPoitemTotalCost { get { AddProperty(Receipts.DerHPoitemTotalCost); return this; } }
        public ReceiptsBuilder DerHQtyReceivedConv { get { AddProperty(Receipts.DerHQtyReceivedConv); return this; } }
        public ReceiptsBuilder DerHQtyReturnedConv { get { AddProperty(Receipts.DerHQtyReturnedConv); return this; } }
        public ReceiptsBuilder DerHTotalCostConv { get { AddProperty(Receipts.DerHTotalCostConv); return this; } }
        public ReceiptsBuilder DerItemCostConv { get { AddProperty(Receipts.DerItemCostConv); return this; } }
        public ReceiptsBuilder DerPoitemTotalCost { get { AddProperty(Receipts.PoitemTotalCost); return this; } }
        public ReceiptsBuilder DerQtyReceivedConv { get { AddProperty(Receipts.DerQtyReceivedConv); return this; } }
        public ReceiptsBuilder DerQtyReturnedConv { get { AddProperty(Receipts.DerQtyReturnedConv); return this; } }
        public ReceiptsBuilder DerTotalCostConv { get { AddProperty(Receipts.DerTotalCostConv); return this; } }
        public ReceiptsBuilder ExchRate { get { AddProperty(Receipts.ExchRate); return this; } }
        public ReceiptsBuilder GrnLine { get { AddProperty(Receipts.GrnLine); return this; } }
        public ReceiptsBuilder GrnNum { get { AddProperty(Receipts.GrnNum); return this; } }
        public ReceiptsBuilder InWorkflow { get { AddProperty(Receipts.InWorkflow); return this; } }
        public ReceiptsBuilder ItemCost { get { AddProperty(Receipts.ItemCost); return this; } }
        public ReceiptsBuilder NoteExistsFlag { get { AddProperty(Receipts.NoteExistsFlag); return this; } }
        public ReceiptsBuilder PackNum { get { AddProperty(Receipts.PackNum); return this; } } 
        public ReceiptsBuilder PohExchRate { get { AddProperty(Receipts.PohExchRate); return this; } }   
        public ReceiptsBuilder ItemDescription { get { AddProperty(Receipts.ItemDescription); return this; } }
        public ReceiptsBuilder PoihDescription { get { AddProperty(Receipts.PoihDescription); return this; } }
        public ReceiptsBuilder PoihItem { get { AddProperty(Receipts.PoihItem); return this; } }
        public ReceiptsBuilder PoihItemCostConv { get { AddProperty(Receipts.PoihItemCostConv); return this; } }
        public ReceiptsBuilder PoihPlanCostConv { get { AddProperty(Receipts.PoihPlanCostConv); return this; } }
        public ReceiptsBuilder PoihQtyOrderedConv { get { AddProperty(Receipts.PoihQtyOrderedConv); return this; } }
        public ReceiptsBuilder UM { get { AddProperty(Receipts.UM); return this; } }
        public ReceiptsBuilder PoiItemCostConv { get { AddProperty(Receipts.PoiItemCostConv); return this; } }
        public ReceiptsBuilder PoiPlanCostConv { get { AddProperty(Receipts.PoiPlanCostConv); return this; } }
        public ReceiptsBuilder PoiQtyOrdered { get { AddProperty(Receipts.PoiQtyOrdered); return this; } }
        public ReceiptsBuilder PoiQtyOrderedConv { get { AddProperty(Receipts.PoiQtyOrderedConv); return this; } }
        public ReceiptsBuilder Item { get { AddProperty(Receipts.Item); return this; } } 
        public ReceiptsBuilder PoLine { get { AddProperty(Receipts.PoLine); return this; } }
        public ReceiptsBuilder PoNum { get { AddProperty(Receipts.PoNum); return this; } }
        public ReceiptsBuilder PoOrderDate { get { AddProperty(Receipts.PoOrderDate); return this; } }
        public ReceiptsBuilder PoRelease { get { AddProperty(Receipts.PoRelease); return this; } }
        public ReceiptsBuilder Status { get { AddProperty(Receipts.Status); return this; } }
        public ReceiptsBuilder PoVendNum { get { AddProperty(Receipts.PoVendNum); return this; } }
        public ReceiptsBuilder QtyReceived { get { AddProperty(Receipts.QtyReceived); return this; } }
        public ReceiptsBuilder QtyReturned { get { AddProperty(Receipts.QtyReturned); return this; } }
        public ReceiptsBuilder QtyVouchered { get { AddProperty(Receipts.QtyVouchered); return this; } }
        public ReceiptsBuilder RcvdDate { get { AddProperty(Receipts.RcvdDate); return this; } }
        public ReceiptsBuilder RecordDate { get { AddProperty(Receipts.RecordDate); return this; } } 
        public ReceiptsBuilder SupplQty { get { AddProperty(Receipts.SupplQty); return this; } }
        public ReceiptsBuilder UbSelectedGrn { get { AddProperty(Receipts.UbSelectedGrn); return this; } }
        public ReceiptsBuilder UnitBrokerageCost { get { AddProperty(Receipts.UnitBrokerageCost); return this; } }
        public ReceiptsBuilder UnitDutyCost { get { AddProperty(Receipts.UnitDutyCost); return this; } }
        public ReceiptsBuilder UnitFreightCost { get { AddProperty(Receipts.UnitFreightCost); return this; } }
        public ReceiptsBuilder UnitMatCost { get { AddProperty(Receipts.UnitMatCost); return this; } }
        public ReceiptsBuilder UnitWeight { get { AddProperty(Receipts.UnitWeight); return this; } }
        public ReceiptsBuilder VenaddhName { get { AddProperty(Receipts.VenaddhName); return this; } }
        public ReceiptsBuilder VenaddName { get { AddProperty(Receipts.VenaddName); return this; } }
        public ReceiptsBuilder VendCurrCode { get { AddProperty(Receipts.VendCurrCode); return this; } }
        public ReceiptsBuilder VendhCurrCode { get { AddProperty(Receipts.VendhCurrCode); return this; } }
        public ReceiptsBuilder VendNum { get { AddProperty(Receipts.VendNum); return this; } }


    }

    public class SLPoRcptsFilterExpressionBuilder
        : FilterExpressionBuilder<ReceiptsBuilder>
    {
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> ByCons
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.ByCons); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrAmtTotFormat); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrCstPrcFormat
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrCstPrcFormat); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrDescription
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrDescription); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhAmtTotFormat
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrhAmtTotFormat); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhCstPrcFormat
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrhCstPrcFormat); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhDescription
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.CurrhDescription); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DateSeq
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DateSeq); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHItemCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerHItemCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHPoitemTotalCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerHPoitemTotalCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHQtyReceivedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerHQtyReceivedConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHQtyReturnedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerHQtyReturnedConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHTotalCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerHTotalCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerItemCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerItemCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerPoitemTotalCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoitemTotalCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerQtyReceivedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerQtyReceivedConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerQtyReturnedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerQtyReturnedConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> DerTotalCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.DerTotalCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> ExchRate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.ExchRate); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> GrnLine
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.GrnLine); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> GrnNum
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.GrnNum); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.InWorkflow); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> ItemCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.ItemCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.NoteExistsFlag); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PackNum
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PackNum); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoExchRate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.ExchRate); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PohExchRate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PohExchRate); }
        }
   
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihDescription
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoihDescription); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihItem
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoihItem); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihItemCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoihItemCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihPlanCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoihPlanCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihQtyOrderedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoihQtyOrderedConv); }
        } 
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiItemCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoiItemCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiPlanCostConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoiPlanCostConv); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiQtyOrdered
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoiQtyOrdered); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiQtyOrderedConv
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoiQtyOrderedConv); }
        }
 
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiUM
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UM); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoLine
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoLine); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoNum); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoOrderDate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoOrderDate); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoRelease
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoRelease); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoStat
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.Status); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> PoVendNum
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.PoVendNum); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyReceived
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.QtyReceived); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyReturned
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.QtyReturned); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyVouchered
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.QtyVouchered); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> RcvdDate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.RcvdDate); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.RecordDate); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.RowPointer); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> SupplQty
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.SupplQty); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UbSelectedGrn
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UbSelectedGrn); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitBrokerageCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UnitBrokerageCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitDutyCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UnitDutyCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitFreightCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UnitFreightCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitMatCost
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UnitMatCost); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitWeight
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.UnitWeight); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> VenaddhName
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.VenaddhName); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> VenaddName
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.VenaddName); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> VendCurrCode
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.VendCurrCode); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> VendhCurrCode
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.VendhCurrCode); }
        }
        public FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<ReceiptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, Receipts.VendNum); }
        }


    }
}
