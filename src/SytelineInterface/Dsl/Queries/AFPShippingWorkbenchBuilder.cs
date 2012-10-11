using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class AFPShippingWorkbench : IdoConstants
    {
        public const string IDO_NAME = "AFPShippingWorkbenchs";
        public const string Accountrep = "Accountrep";
        public const string BillToName = "BillToName";
        public const string OrderNumber = "CoNum";
        public const string CreateDate = "CreateDate";
        public const string CreatedBy = "CreatedBy";
        //public const string CustNum = "DerCustNum";
        public const string CustPo = "CustPo";
        public const string CutoffDate = "CutoffDate";
        public const string Ats = "DerAts";
        public const string FirstDueDate = "DerFirstDueDate";
        public const string KitPresent = "DerKitPresent";
        public const string OldPickStatus = "DerOldPickStatus";
        public const string OldTrailerLoc = "DerOldTrailerLoc";
        public const string PickStatusRank = "DerPickStatusRank";
        public const string InWorkflow = "InWorkflow";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OrderDate = "DerOrderDate";
        public const string PickStatus = "DerPickStatus";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string ShipEarly = "ShipEarly";
        public const string ShipToName = "ShipToName";
        public const string ShipZone = "ShipZone";
        public const string Slsman = "Slsman";
        public const string TrailerLoc = "TrailerLoc";
        public const string Selected = "UbSelected";
        public const string Whse = "Whse";
    }

    public class AFPShippingWorkbenchBuilder
    : IdoQueryBuilder<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder>
    {
        public AFPShippingWorkbenchBuilder(IExpressionInterpreter expression)
            : base(AFPShippingWorkbench.IDO_NAME, expression)
        {
        }

        public AFPShippingWorkbenchBuilder OrderNumber { get { AddProperty(AFPShippingWorkbench.OrderNumber); return this; } }
        public AFPShippingWorkbenchBuilder OrderDate { get { AddProperty(AFPShippingWorkbench.OrderDate); return this; } }
        //public AFPShippingWorkbenchBuilder CustNum { get { AddProperty(AFPShippingWorkbench.CustNum); return this; } }
        public AFPShippingWorkbenchBuilder PickStatus { get { AddProperty(AFPShippingWorkbench.PickStatus); return this; } }
    }

    public class AFPShippingWorkbenchFilterExpressionBuilder : FilterExpressionBuilder<AFPShippingWorkbenchBuilder>
    {

        public FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder> OrderNumber
        {
            get { return new FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder>(_builder, AFPShippingWorkbench.OrderNumber); }
        }
        public FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder> OrderDate
        {
            get { return new FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder>(_builder, AFPShippingWorkbench.OrderDate); }
        }
        public FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder> PickStatus
        {
            get { return new FilterExpression<AFPShippingWorkbenchBuilder, AFPShippingWorkbenchFilterExpressionBuilder>(_builder, AFPShippingWorkbench.PickStatus); }
        }
 

    }
}