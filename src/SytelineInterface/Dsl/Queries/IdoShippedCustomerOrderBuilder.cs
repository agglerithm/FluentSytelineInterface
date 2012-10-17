

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class ShippedCustomerOrder : IdoConstants
    {
        public const string IDO_NAME = "SL.SLCoShips";
         public const string OrderRelease = "CoRelease"; 
        //public const string BOL = "Bol";
        //public const string ShipCode = "CoShipCode"; 
        public const string DeliveryOrderNumber = "DoNum";
        //public const string ShipCodeDescription = "ShipCodeDescription";

        public const string CustomerNumber = "CoCustNum";
        public const string OrderDate = "CoOrderDate";
        public const string OrderNumber = "CoNum";  
        //public const string ShipToCode = "CustSeq";
        public const string Status = "CoiStat";
        public const string DateSeq = "DateSeq"; 
        public const string CustSeq = "CoCustSeq";  
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer"; 
        public const string CustomerPo = "CoCustPo"; 
        public const string CustomerPartNumber = "CoiCustItem";
        public const string Description = "CoiDescription";
        public const string ItemID = "CoiItem";
        public const string LineNumber = "CoLine"; 
        public const string Cost = "Cost";
        public const string CoType = "CoType";
        public const string DoLine = "DoLine";
        public const string DoNum = "DoNum";
        public const string DoSeq = "DoSeq";
        public const string Price = "Price";
        public const string QtyShipped = "QtyShipped";
        public const string ShipDate = "ShipDate";
        public const string ShipperNum = "ShipperNum";
        public const string BOL = "PackNum";

        public static ShippedCustomerOrderBuilder GetFullProjection()
        {
            return FromSyteline.ShippedCustomerOrder.CustomerNumber.DeliveryOrderNumber.
                OrderDate.OrderNumber.ItemDescription.Item.Line.OrderNumber.Cost
                        .CustomerPartNumber.CustomerPo.BOL.OrderRelease.
                        Price.QtyShipped.RowPointer.ShipDate.ShipperNum.DateSeq.Status;
        }

    }

    public class ShippedCustomerOrderBuilder :
        IdoQueryBuilder<ShippedCustomerOrderBuilder,ShippedCustomerOrderFilterExpressionBuilder>
    {
        public ShippedCustomerOrderBuilder(IExpressionInterpreter ei) : base(ShippedCustomerOrder.IDO_NAME, ei) { }

        //public ShippedCustomerOrderBuilder Active { get { AddProperty(ShippedCustomerOrder.Active); return this; } }
        //public ShippedCustomerOrderBuilder BatchID { get { AddProperty(ShippedCustomerOrder.BatchId); return this; } }
        //public ShippedCustomerOrderBuilder BOL { get { AddProperty(ShippedCustomerOrder.BOL); return this; } }
        //public ShippedCustomerOrderBuilder ShipCode { get { AddProperty(ShippedCustomerOrder.ShipCode); return this; } } 
        public ShippedCustomerOrderBuilder DeliveryOrderNumber { get { AddProperty(ShippedCustomerOrder.DeliveryOrderNumber); return this; } }
        //public ShippedCustomerOrderBuilder ShipCodeDescription { get { AddProperty(ShippedCustomerOrder.ShipCodeDescription); return this; } } 
        public ShippedCustomerOrderBuilder CustomerPo { get { AddProperty(ShippedCustomerOrder.CustomerPo); return this; } }
        public ShippedCustomerOrderBuilder CustomerPartNumber { get { AddProperty(ShippedCustomerOrder.CustomerPartNumber); return this; } }
        public ShippedCustomerOrderBuilder ItemDescription { get { AddProperty(ShippedCustomerOrder.Description); return this; } }
        public ShippedCustomerOrderBuilder Item { get { AddProperty(ShippedCustomerOrder.ItemID); return this; } }
        public ShippedCustomerOrderBuilder Line { get { AddProperty(ShippedCustomerOrder.LineNumber); return this; } } 
        public ShippedCustomerOrderBuilder Cost { get { AddProperty(ShippedCustomerOrder.Cost); return this; } }  
        public ShippedCustomerOrderBuilder OrderRelease { get { AddProperty(ShippedCustomerOrder.OrderRelease); return this; } }
        public ShippedCustomerOrderBuilder Price { get { AddProperty(ShippedCustomerOrder.Price); return this; } }
        public ShippedCustomerOrderBuilder QtyShipped { get { AddProperty(ShippedCustomerOrder.QtyShipped); return this; } }
        public ShippedCustomerOrderBuilder ShipDate { get { AddProperty(ShippedCustomerOrder.ShipDate); return this; } }
        public ShippedCustomerOrderBuilder DateSeq { get { AddProperty(ShippedCustomerOrder.DateSeq); return this; } }
        public ShippedCustomerOrderBuilder ShipperNum { get { AddProperty(ShippedCustomerOrder.ShipperNum); return this; } }
        public ShippedCustomerOrderBuilder CustomerNumber { get { AddProperty(ShippedCustomerOrder.CustomerNumber); return this; } }
        public ShippedCustomerOrderBuilder OrderDate { get { AddProperty(ShippedCustomerOrder.OrderDate); return this; } }
        public ShippedCustomerOrderBuilder OrderNumber { get { AddProperty(ShippedCustomerOrder.OrderNumber); return this; } } 
        //public ShippedCustomerOrderBuilder ShipToCode { get { AddProperty(ShippedCustomerOrder.ShipToCode); return this; } }
        //public ShippedCustomerOrderBuilder OrderType { get { AddProperty(ShippedCustomerOrder.OrderType); return this; } }

        public ShippedCustomerOrderBuilder Status { get { AddProperty(ShippedCustomerOrder.Status); return this; } }
        //public ShippedCustomerOrderBuilder Invoiced { get { AddProperty(ShippedCustomerOrder.Invoiced); return this; } }
        //public ShippedCustomerOrderBuilder Picked { get { AddProperty(ShippedCustomerOrder.Picked); return this; } }
        //public ShippedCustomerOrderBuilder Shipped { get { AddProperty(ShippedCustomerOrder.Shipped); return this; } }
        //public ShippedCustomerOrderBuilder ShipToName { get { AddProperty(ShippedCustomerOrder.ShipToName); return this; } } 
        //public ShippedCustomerOrderBuilder BatchId { get { AddProperty(ShippedCustomerOrder.BatchId); return this; } } 
        //public ShippedCustomerOrderBuilder BolAcceptDefaults { get { AddProperty(ShippedCustomerOrder.BolAcceptDefaults); return this; } }
        //public ShippedCustomerOrderBuilder Contact { get { AddProperty(ShippedCustomerOrder.Contact); return this; } } 
        //public ShippedCustomerOrderBuilder CoLcrNum { get { AddProperty(ShippedCustomerOrder.CoLcrNum); return this; } } 
        //public ShippedCustomerOrderBuilder CoPhone { get { AddProperty(ShippedCustomerOrder.CoPhone); return this; } } 
        //public ShippedCustomerOrderBuilder CoShipEarly { get { AddProperty(ShippedCustomerOrder.CoShipEarly); return this; } }
        //public ShippedCustomerOrderBuilder CoShipPartial { get { AddProperty(ShippedCustomerOrder.CoShipPartial); return this; } } 
        //public ShippedCustomerOrderBuilder CoUseExchRate { get { AddProperty(ShippedCustomerOrder.CoUseExchRate); return this; } } 
        public ShippedCustomerOrderBuilder CustSeq { get { AddProperty(ShippedCustomerOrder.CustSeq); return this; } } 
        //public ShippedCustomerOrderBuilder InvoiceAcceptDefaults { get { AddProperty(ShippedCustomerOrder.InvoiceAcceptDefaults); return this; } }
        //public ShippedCustomerOrderBuilder InWorkflow { get { AddProperty(ShippedCustomerOrder.InWorkflow); return this; } } 
        //public ShippedCustomerOrderBuilder NoteExistsFlag { get { AddProperty(ShippedCustomerOrder.NoteExistsFlag); return this; } }
        //public ShippedCustomerOrderBuilder PackAcceptDefaults { get { AddProperty(ShippedCustomerOrder.PackAcceptDefaults); return this; } }
        //public ShippedCustomerOrderBuilder PickAcceptDefaults { get { AddProperty(ShippedCustomerOrder.PickAcceptDefaults); return this; } }
        //public ShippedCustomerOrderBuilder ReadyToProcess { get { AddProperty(ShippedCustomerOrder.ReadyToProcess); return this; } }
        public ShippedCustomerOrderBuilder RecordDate { get { AddProperty(ShippedCustomerOrder.RecordDate); return this; } } 
        //public ShippedCustomerOrderBuilder ShipAcceptDefaults { get { AddProperty(ShippedCustomerOrder.ShipAcceptDefaults); return this; } }
        //public ShippedCustomerOrderBuilder CreditAmt { get { AddProperty(ShippedCustomerOrder.CreditAmt); return this; } }
        //public ShippedCustomerOrderBuilder CreditOk { get { AddProperty(ShippedCustomerOrder.CreditOk); return this; } }
        public ShippedCustomerOrderBuilder BOL { get { AddProperty(ShippedCustomerOrder.BOL); return this; } } 

        public ShippedCustomerOrderBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ShippedCustomerOrderBuilder) base.WithChildren(builders);
        }

        public ShippedCustomerOrderBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ShippedCustomerOrderBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ShippedCustomerOrderFilterExpressionBuilder : FilterExpressionBuilder<ShippedCustomerOrderBuilder>
    {
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> OrderNumber
        {
            get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.OrderNumber); }
        }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> CustomerNumber
        {
            get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.CustomerNumber); }
        }
         
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> CustomerPo { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.CustomerPo); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> CustomerPartNumber { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.CustomerPartNumber); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> ItemDescription { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.Description); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> Item { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.ItemID); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> Cost { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.Cost); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> OrderType { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.CoType); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> DoLine { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.DoLine); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> DoNum { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.DoNum); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> DoSeq { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.DoSeq); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> Price { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.Price); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> QtyShipped { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.QtyShipped); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> ShipDate { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.ShipDate); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> ShipperNum { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.ShipperNum); } }
        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> PackNum { get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.BOL); } }

        public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> LineNumber
        {
            get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.LineNumber); }

        }

 

        //public FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder> BOL
        //{
        //    get { return new FilterExpression<ShippedCustomerOrderBuilder, ShippedCustomerOrderFilterExpressionBuilder>(_builder, ShippedCustomerOrder.BOL); }
        //}

    }
}