using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class  InvoicedOrders : IdoConstants 
    {
        public const string IDO_NAME = "SLInvHdrs";
        public const string OrderNumber = "CoNum";
        public const string DeliveryNumber = "DoNum";  
        public const string CustomerPo = "CustPo";  
        public const string BillType = "BillType"; 
        public const string CustomerID = "CustNum";  
        public const string InvDate = "InvDate";  
        public const string Slsman = "Slsman"; 
        public const string InvNum = "InvNum";
        public const string InvSeq = "InvSeq";  
        public const string RecordDate = "RecordDate";
//        public const string ShipCode = "ShipCode"; 
        public const string RowPointer = "RowPointer";
        public const string ShipDate = "ShipDate";
        public const string Freight = "Freight";
        public const string TermsCode = "TermsCode";
  //      public const string Discount = "Disc";
        public const string Amount = "Price";
        public const string Cost = "Cost";

        public static InvoicedOrdersBuilder GetFullProjection()
        {
            return FromSyteline.InvoicedOrders.Amount.BillType.CustomerID.CustPo.InvDate
                .InvNum.InvSeq.OrderNumber.RecordDate.RowPointer.Slsman.DeliveryNumber.Freight.Terms.Cost.ShipDate;
        }

        public static InvoicedOrdersBuilder GetFullProjectionWithLineItems()
        {
            return
                GetFullProjection().WithChildren(InvoiceLineItemAlls.GetFullProjection().LinkBy(InvoicedOrders.InvNum,
                                                                                                InvoiceLineItemAlls.
                                                                                                    InvoiceNumber));
        }

    }

    public class InvoicedOrdersBuilder :
        IdoQueryBuilder<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>
    {
        public InvoicedOrdersBuilder(IExpressionInterpreter ei)
            : base(InvoicedOrders.IDO_NAME, ei)
        {
        }
 
        public InvoicedOrdersBuilder OrderNumber { get { AddProperty(InvoicedOrders.OrderNumber); return this; } }  
        public InvoicedOrdersBuilder CustomerID { get { AddProperty(InvoicedOrders.CustomerID); return this; } }
        public InvoicedOrdersBuilder CustPo { get { AddProperty(InvoicedOrders.CustomerPo); return this; } }  
        public InvoicedOrdersBuilder BillType { get { AddProperty(InvoicedOrders.BillType); return this; } }  
        public InvoicedOrdersBuilder InvDate { get { AddProperty(InvoicedOrders.InvDate); return this; } } 
        public InvoicedOrdersBuilder Slsman { get { AddProperty(InvoicedOrders.Slsman); return this; } } 
        public InvoicedOrdersBuilder InvNum { get { AddProperty(InvoicedOrders.InvNum); return this; } }
        public InvoicedOrdersBuilder InvSeq { get { AddProperty(InvoicedOrders.InvSeq); return this; } }
        public InvoicedOrdersBuilder Amount { get { AddProperty(InvoicedOrders.Amount); return this; } }
        public InvoicedOrdersBuilder Cost { get { AddProperty(InvoicedOrders.Cost); return this; } }
        public InvoicedOrdersBuilder Freight { get { AddProperty(InvoicedOrders.Freight); return this; } }
        public InvoicedOrdersBuilder RecordDate { get { AddProperty(InvoicedOrders.RecordDate); return this; } }
        public InvoicedOrdersBuilder DeliveryNumber { get { AddProperty(InvoicedOrders.DeliveryNumber); return this; } }
        public new InvoicedOrdersBuilder RowPointer { get { AddProperty(InvoicedOrders.RowPointer); return this; } }
        public InvoicedOrdersBuilder ShipDate { get { AddProperty(InvoicedOrders.ShipDate); return this; } }

        public InvoicedOrdersBuilder Terms
        {
            get { AddProperty(InvoicedOrders.TermsCode); return this; }
        }

        public InvoicedOrdersBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (InvoicedOrdersBuilder) base.WithChildren(builders);
        }

        public InvoicedOrdersBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (InvoicedOrdersBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class InvoicedOrdersFilterExpressionBuilder : FilterExpressionBuilder<InvoicedOrdersBuilder>
    { 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> OrderNumber { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.OrderNumber); } } 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> CustPo { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.CustomerPo); } }  
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> InvDate { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.InvDate); } } 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> BillType { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.BillType); } }
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> CustomerID { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.CustomerID); } } 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> Slsman { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.Slsman); } } 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> InvNum { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.InvNum); } }
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> InvSeq { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.InvSeq); } } 
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> Amount { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.Amount); } }  
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> RecordDate { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.RecordDate); } }
        public FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder> RowPointer { get { return new FilterExpression<InvoicedOrdersBuilder, InvoicedOrdersFilterExpressionBuilder>(_builder, InvoicedOrders.RowPointer); } } 

    }
}