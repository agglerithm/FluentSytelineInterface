namespace SytelineInterface.Dsl.Queries
{
    using SytelineInterface.Core;

    public class PoReceipts : IdoConstants
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
        public const string DerPoitemTotalCost = "DerPoitemTotalCost";
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
        public const string PoExchRate = "PoExchRate";
        public const string PohExchRate = "PohExchRate";
        public const string PohOrderDate = "PohOrderDate";
        public const string PohStat = "PohStat";
        public const string PohVendNum = "PohVendNum";
        public const string PoiDescription = "PoiDescription";
        public const string PoihDescription = "PoihDescription";
        public const string PoihItem = "PoihItem";
        public const string PoihItemCostConv = "PoihItemCostConv";
        public const string PoihPlanCostConv = "PoihPlanCostConv";
        public const string PoihQtyOrderedConv = "PoihQtyOrderedConv";
        public const string PoihUM = "PoihUM";
        public const string PoiItemCostConv = "PoiItemCostConv";
        public const string PoiPlanCostConv = "PoiPlanCostConv";
        public const string PoiQtyOrdered = "PoiQtyOrdered";
        public const string PoiQtyOrderedConv = "PoiQtyOrderedConv";
        public const string PoItem = "PoItem";
        public const string PoiUM = "PoiUM";
        public const string PoLine = "PoLine";
        public const string PoNum = "PoNum";
        public const string PoOrderDate = "PoOrderDate";
        public const string PoRelease = "PoRelease";
        public const string PoStat = "PoStat";
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

    public class SLPoRcptsBuilder
        : IdoQueryBuilder<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>
    {
        public SLPoRcptsBuilder(IExpressionInterpreter interpreter) : base(PoReceipts.IDO_NAME, interpreter) { }

        public SLPoRcptsBuilder ByCons { get { AddProperty(PoReceipts.ByCons); return this; } }
        public SLPoRcptsBuilder CurrAmtTotFormat { get { AddProperty(PoReceipts.CurrAmtTotFormat); return this; } }
        public SLPoRcptsBuilder CurrCstPrcFormat { get { AddProperty(PoReceipts.CurrCstPrcFormat); return this; } }
        public SLPoRcptsBuilder CurrDescription { get { AddProperty(PoReceipts.CurrDescription); return this; } }
        public SLPoRcptsBuilder CurrhAmtTotFormat { get { AddProperty(PoReceipts.CurrhAmtTotFormat); return this; } }
        public SLPoRcptsBuilder CurrhCstPrcFormat { get { AddProperty(PoReceipts.CurrhCstPrcFormat); return this; } }
        public SLPoRcptsBuilder CurrhDescription { get { AddProperty(PoReceipts.CurrhDescription); return this; } }
        public SLPoRcptsBuilder DateSeq { get { AddProperty(PoReceipts.DateSeq); return this; } }
        public SLPoRcptsBuilder DerHItemCostConv { get { AddProperty(PoReceipts.DerHItemCostConv); return this; } }
        public SLPoRcptsBuilder DerHPoitemTotalCost { get { AddProperty(PoReceipts.DerHPoitemTotalCost); return this; } }
        public SLPoRcptsBuilder DerHQtyReceivedConv { get { AddProperty(PoReceipts.DerHQtyReceivedConv); return this; } }
        public SLPoRcptsBuilder DerHQtyReturnedConv { get { AddProperty(PoReceipts.DerHQtyReturnedConv); return this; } }
        public SLPoRcptsBuilder DerHTotalCostConv { get { AddProperty(PoReceipts.DerHTotalCostConv); return this; } }
        public SLPoRcptsBuilder DerItemCostConv { get { AddProperty(PoReceipts.DerItemCostConv); return this; } }
        public SLPoRcptsBuilder DerPoitemTotalCost { get { AddProperty(PoReceipts.DerPoitemTotalCost); return this; } }
        public SLPoRcptsBuilder DerQtyReceivedConv { get { AddProperty(PoReceipts.DerQtyReceivedConv); return this; } }
        public SLPoRcptsBuilder DerQtyReturnedConv { get { AddProperty(PoReceipts.DerQtyReturnedConv); return this; } }
        public SLPoRcptsBuilder DerTotalCostConv { get { AddProperty(PoReceipts.DerTotalCostConv); return this; } }
        public SLPoRcptsBuilder ExchRate { get { AddProperty(PoReceipts.ExchRate); return this; } }
        public SLPoRcptsBuilder GrnLine { get { AddProperty(PoReceipts.GrnLine); return this; } }
        public SLPoRcptsBuilder GrnNum { get { AddProperty(PoReceipts.GrnNum); return this; } }
        public SLPoRcptsBuilder InWorkflow { get { AddProperty(PoReceipts.InWorkflow); return this; } }
        public SLPoRcptsBuilder ItemCost { get { AddProperty(PoReceipts.ItemCost); return this; } }
        public SLPoRcptsBuilder NoteExistsFlag { get { AddProperty(PoReceipts.NoteExistsFlag); return this; } }
        public SLPoRcptsBuilder PackNum { get { AddProperty(PoReceipts.PackNum); return this; } }
        public SLPoRcptsBuilder PoExchRate { get { AddProperty(PoReceipts.PoExchRate); return this; } }
        public SLPoRcptsBuilder PohExchRate { get { AddProperty(PoReceipts.PohExchRate); return this; } }
        public SLPoRcptsBuilder PohOrderDate { get { AddProperty(PoReceipts.PohOrderDate); return this; } }
        public SLPoRcptsBuilder PohStat { get { AddProperty(PoReceipts.PohStat); return this; } }
        public SLPoRcptsBuilder PohVendNum { get { AddProperty(PoReceipts.PohVendNum); return this; } }
        public SLPoRcptsBuilder PoiDescription { get { AddProperty(PoReceipts.PoiDescription); return this; } }
        public SLPoRcptsBuilder PoihDescription { get { AddProperty(PoReceipts.PoihDescription); return this; } }
        public SLPoRcptsBuilder PoihItem { get { AddProperty(PoReceipts.PoihItem); return this; } }
        public SLPoRcptsBuilder PoihItemCostConv { get { AddProperty(PoReceipts.PoihItemCostConv); return this; } }
        public SLPoRcptsBuilder PoihPlanCostConv { get { AddProperty(PoReceipts.PoihPlanCostConv); return this; } }
        public SLPoRcptsBuilder PoihQtyOrderedConv { get { AddProperty(PoReceipts.PoihQtyOrderedConv); return this; } }
        public SLPoRcptsBuilder PoihUM { get { AddProperty(PoReceipts.PoihUM); return this; } }
        public SLPoRcptsBuilder PoiItemCostConv { get { AddProperty(PoReceipts.PoiItemCostConv); return this; } }
        public SLPoRcptsBuilder PoiPlanCostConv { get { AddProperty(PoReceipts.PoiPlanCostConv); return this; } }
        public SLPoRcptsBuilder PoiQtyOrdered { get { AddProperty(PoReceipts.PoiQtyOrdered); return this; } }
        public SLPoRcptsBuilder PoiQtyOrderedConv { get { AddProperty(PoReceipts.PoiQtyOrderedConv); return this; } }
        public SLPoRcptsBuilder PoItem { get { AddProperty(PoReceipts.PoItem); return this; } }
        public SLPoRcptsBuilder PoiUM { get { AddProperty(PoReceipts.PoiUM); return this; } }
        public SLPoRcptsBuilder PoLine { get { AddProperty(PoReceipts.PoLine); return this; } }
        public SLPoRcptsBuilder PoNum { get { AddProperty(PoReceipts.PoNum); return this; } }
        public SLPoRcptsBuilder PoOrderDate { get { AddProperty(PoReceipts.PoOrderDate); return this; } }
        public SLPoRcptsBuilder PoRelease { get { AddProperty(PoReceipts.PoRelease); return this; } }
        public SLPoRcptsBuilder PoStat { get { AddProperty(PoReceipts.PoStat); return this; } }
        public SLPoRcptsBuilder PoVendNum { get { AddProperty(PoReceipts.PoVendNum); return this; } }
        public SLPoRcptsBuilder QtyReceived { get { AddProperty(PoReceipts.QtyReceived); return this; } }
        public SLPoRcptsBuilder QtyReturned { get { AddProperty(PoReceipts.QtyReturned); return this; } }
        public SLPoRcptsBuilder QtyVouchered { get { AddProperty(PoReceipts.QtyVouchered); return this; } }
        public SLPoRcptsBuilder RcvdDate { get { AddProperty(PoReceipts.RcvdDate); return this; } }
        public SLPoRcptsBuilder RecordDate { get { AddProperty(PoReceipts.RecordDate); return this; } }
        public SLPoRcptsBuilder RowPointer { get { AddProperty(PoReceipts.RowPointer); return this; } }
        public SLPoRcptsBuilder SupplQty { get { AddProperty(PoReceipts.SupplQty); return this; } }
        public SLPoRcptsBuilder UbSelectedGrn { get { AddProperty(PoReceipts.UbSelectedGrn); return this; } }
        public SLPoRcptsBuilder UnitBrokerageCost { get { AddProperty(PoReceipts.UnitBrokerageCost); return this; } }
        public SLPoRcptsBuilder UnitDutyCost { get { AddProperty(PoReceipts.UnitDutyCost); return this; } }
        public SLPoRcptsBuilder UnitFreightCost { get { AddProperty(PoReceipts.UnitFreightCost); return this; } }
        public SLPoRcptsBuilder UnitMatCost { get { AddProperty(PoReceipts.UnitMatCost); return this; } }
        public SLPoRcptsBuilder UnitWeight { get { AddProperty(PoReceipts.UnitWeight); return this; } }
        public SLPoRcptsBuilder VenaddhName { get { AddProperty(PoReceipts.VenaddhName); return this; } }
        public SLPoRcptsBuilder VenaddName { get { AddProperty(PoReceipts.VenaddName); return this; } }
        public SLPoRcptsBuilder VendCurrCode { get { AddProperty(PoReceipts.VendCurrCode); return this; } }
        public SLPoRcptsBuilder VendhCurrCode { get { AddProperty(PoReceipts.VendhCurrCode); return this; } }
        public SLPoRcptsBuilder VendNum { get { AddProperty(PoReceipts.VendNum); return this; } }


    }

    public class SLPoRcptsFilterExpressionBuilder
        : FilterExpressionBuilder<SLPoRcptsBuilder>
    {
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> ByCons
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.ByCons); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrAmtTotFormat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrCstPrcFormat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrCstPrcFormat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrDescription
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrDescription); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhAmtTotFormat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrhAmtTotFormat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhCstPrcFormat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrhCstPrcFormat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> CurrhDescription
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.CurrhDescription); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DateSeq
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DateSeq); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHItemCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerHItemCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHPoitemTotalCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerHPoitemTotalCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHQtyReceivedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerHQtyReceivedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHQtyReturnedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerHQtyReturnedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerHTotalCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerHTotalCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerItemCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerItemCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerPoitemTotalCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerPoitemTotalCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerQtyReceivedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerQtyReceivedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerQtyReturnedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerQtyReturnedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> DerTotalCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.DerTotalCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> ExchRate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.ExchRate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> GrnLine
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.GrnLine); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> GrnNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.GrnNum); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.InWorkflow); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> ItemCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.ItemCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.NoteExistsFlag); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PackNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PackNum); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoExchRate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoExchRate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PohExchRate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PohExchRate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PohOrderDate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PohOrderDate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PohStat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PohStat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PohVendNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PohVendNum); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiDescription
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiDescription); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihDescription
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihDescription); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihItem
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihItem); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihItemCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihItemCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihPlanCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihPlanCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihQtyOrderedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihQtyOrderedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoihUM
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoihUM); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiItemCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiItemCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiPlanCostConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiPlanCostConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiQtyOrdered
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiQtyOrdered); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiQtyOrderedConv
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiQtyOrderedConv); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoItem
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoItem); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoiUM
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoiUM); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoLine
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoLine); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoNum); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoOrderDate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoOrderDate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoRelease
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoRelease); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoStat
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoStat); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> PoVendNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.PoVendNum); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyReceived
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.QtyReceived); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyReturned
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.QtyReturned); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> QtyVouchered
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.QtyVouchered); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> RcvdDate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.RcvdDate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.RecordDate); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.RowPointer); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> SupplQty
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.SupplQty); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UbSelectedGrn
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UbSelectedGrn); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitBrokerageCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UnitBrokerageCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitDutyCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UnitDutyCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitFreightCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UnitFreightCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitMatCost
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UnitMatCost); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> UnitWeight
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.UnitWeight); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> VenaddhName
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.VenaddhName); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> VenaddName
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.VenaddName); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> VendCurrCode
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.VendCurrCode); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> VendhCurrCode
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.VendhCurrCode); }
        }
        public FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<SLPoRcptsBuilder, SLPoRcptsFilterExpressionBuilder>(_builder, PoReceipts.VendNum); }
        }


    }


}
