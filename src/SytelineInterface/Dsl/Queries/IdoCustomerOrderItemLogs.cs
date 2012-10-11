using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    public class IdoCustomerOrderItemLogs : IdoConstants
    {
        public const string IDO_NAME = "SLCoitemLogs";
        public const string ActivityDate = "ActivityDate";
        public const string ActivitySeq = "ActivitySeq";
        public const string CoDiscChg = "CoDiscChg";
        public const string CoLine = "CoLine";
        public const string CoNum = "CoNum";
        public const string CoRelease = "CoRelease";
        public const string DerCoDiscChg = "DerCoDiscChg";
        public const string DerDiscChg = "DerDiscChg";
        public const string DerNetValue = "DerNetValue";
        public const string DerPriceAdj = "DerPriceAdj";
        public const string DerPriceChg = "DerPriceChg";
        public const string DerPriceChgConv = "DerPriceChgConv";
        public const string DerQtyChg = "DerQtyChg";
        public const string DerQtyChgConv = "DerQtyChgConv";
        public const string DiscChg = "DiscChg";
        public const string DueDate = "DueDate";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PriceChg = "PriceChg";
        public const string PriceChgConv = "PriceChgConv";
        public const string ProjectedDate = "ProjectedDate";
        public const string QtyChg = "QtyChg";
        public const string QtyChgConv = "QtyChgConv";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string TransAmt = "TransAmt";
        public const string TransDisc = "TransDisc";
        public const string UM = "UM";


    }

    public class IdoCustomerOrderItemLogsBuilder
        : IdoQueryBuilder<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>
    {
        public IdoCustomerOrderItemLogsBuilder(IExpressionInterpreter interpreter) : base(IdoCustomerOrderItemLogs.IDO_NAME, interpreter) { }

        public IdoCustomerOrderItemLogsBuilder ActivityDate { get { AddProperty(IdoCustomerOrderItemLogs.ActivityDate); return this; } }
        public IdoCustomerOrderItemLogsBuilder ActivitySeq { get { AddProperty(IdoCustomerOrderItemLogs.ActivitySeq); return this; } }
        public IdoCustomerOrderItemLogsBuilder CoDiscChg { get { AddProperty(IdoCustomerOrderItemLogs.CoDiscChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder CoLine { get { AddProperty(IdoCustomerOrderItemLogs.CoLine); return this; } }
        public IdoCustomerOrderItemLogsBuilder CoNum { get { AddProperty(IdoCustomerOrderItemLogs.CoNum); return this; } }
        public IdoCustomerOrderItemLogsBuilder CoRelease { get { AddProperty(IdoCustomerOrderItemLogs.CoRelease); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerCoDiscChg { get { AddProperty(IdoCustomerOrderItemLogs.DerCoDiscChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerDiscChg { get { AddProperty(IdoCustomerOrderItemLogs.DerDiscChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerNetValue { get { AddProperty(IdoCustomerOrderItemLogs.DerNetValue); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerPriceAdj { get { AddProperty(IdoCustomerOrderItemLogs.DerPriceAdj); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerPriceChg { get { AddProperty(IdoCustomerOrderItemLogs.DerPriceChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerPriceChgConv { get { AddProperty(IdoCustomerOrderItemLogs.DerPriceChgConv); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerQtyChg { get { AddProperty(IdoCustomerOrderItemLogs.DerQtyChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder DerQtyChgConv { get { AddProperty(IdoCustomerOrderItemLogs.DerQtyChgConv); return this; } }
        public IdoCustomerOrderItemLogsBuilder DiscChg { get { AddProperty(IdoCustomerOrderItemLogs.DiscChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder DueDate { get { AddProperty(IdoCustomerOrderItemLogs.DueDate); return this; } }
        public IdoCustomerOrderItemLogsBuilder InWorkflow { get { AddProperty(IdoCustomerOrderItemLogs.InWorkflow); return this; } }
        public IdoCustomerOrderItemLogsBuilder Item { get { AddProperty(IdoCustomerOrderItemLogs.Item); return this; } }
        public IdoCustomerOrderItemLogsBuilder NoteExistsFlag { get { AddProperty(IdoCustomerOrderItemLogs.NoteExistsFlag); return this; } }
        public IdoCustomerOrderItemLogsBuilder PriceChg { get { AddProperty(IdoCustomerOrderItemLogs.PriceChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder PriceChgConv { get { AddProperty(IdoCustomerOrderItemLogs.PriceChgConv); return this; } }
        public IdoCustomerOrderItemLogsBuilder ProjectedDate { get { AddProperty(IdoCustomerOrderItemLogs.ProjectedDate); return this; } }
        public IdoCustomerOrderItemLogsBuilder QtyChg { get { AddProperty(IdoCustomerOrderItemLogs.QtyChg); return this; } }
        public IdoCustomerOrderItemLogsBuilder QtyChgConv { get { AddProperty(IdoCustomerOrderItemLogs.QtyChgConv); return this; } }
        public IdoCustomerOrderItemLogsBuilder RecordDate { get { AddProperty(IdoCustomerOrderItemLogs.RecordDate); return this; } }
        public IdoCustomerOrderItemLogsBuilder RowPointer { get { AddProperty(IdoCustomerOrderItemLogs.RowPointer); return this; } }
        public IdoCustomerOrderItemLogsBuilder TransAmt { get { AddProperty(IdoCustomerOrderItemLogs.TransAmt); return this; } }
        public IdoCustomerOrderItemLogsBuilder TransDisc { get { AddProperty(IdoCustomerOrderItemLogs.TransDisc); return this; } }
        public IdoCustomerOrderItemLogsBuilder UM { get { AddProperty(IdoCustomerOrderItemLogs.UM); return this; } }


    }

    public class SLCoitemLogsFilterExpressionBuilder
        : FilterExpressionBuilder<IdoCustomerOrderItemLogsBuilder>
    {
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ActivityDate
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.ActivityDate); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ActivitySeq
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.ActivitySeq); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoDiscChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.CoDiscChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoLine
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.CoLine); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoNum
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.CoNum); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoRelease
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.CoRelease); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerCoDiscChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerCoDiscChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerDiscChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerDiscChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerNetValue
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerNetValue); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceAdj
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerPriceAdj); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerPriceChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceChgConv
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerPriceChgConv); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerQtyChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerQtyChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerQtyChgConv
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DerQtyChgConv); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DiscChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DiscChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DueDate
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.DueDate); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.InWorkflow); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.Item); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.NoteExistsFlag); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> PriceChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.PriceChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> PriceChgConv
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.PriceChgConv); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ProjectedDate
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.ProjectedDate); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> QtyChg
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.QtyChg); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> QtyChgConv
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.QtyChgConv); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.RecordDate); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.RowPointer); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> TransAmt
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.TransAmt); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> TransDisc
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.TransDisc); }
        }
        public FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> UM
        {
            get { return new FilterExpression<IdoCustomerOrderItemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, IdoCustomerOrderItemLogs.UM); }
        }


    }

}