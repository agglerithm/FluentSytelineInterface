 
using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class ShippedCustomerOrderLineItem : IdoConstants
    {
        public const string IDO_NAME = "SLCoShips";
        public const string CustomerID = "CoCustNum";
        public const string CustomerPo = "CoCustPo";
//        public const string CoCustSeq = "CoCustSeq";
        public const string CustomerPartNumber = "CoiCustItem";
        public const string Description = "CoiDescription";
        public const string ItemID = "CoiItem";
        public const string LineNumber = "CoLine";
        public const string OrderNumber = "CoNum";
        public const string Cost = "Cost";
        public const string CoType = "CoType";
        public const string DoLine = "DoLine";
        public const string DoNum = "DoNum";
        public const string DoSeq = "DoSeq";
        public const string Price = "Price";
        public const string QtyShipped = "QtyShipped";
        public const string ShipDate = "ShipDate";
        public const string ShipperNum = "ShipperNum";

        public static ShippedCustomerOrderLineItemBuilder GetFullProjection()
        {
            return FromSyteline.ShippedCustomerOrderLineItem.ItemDescription.Item.Line.OrderNumber.Cost
                .OrderType.CustomerID.CustomerPartNumber.CustomerPo.BolLine.BolNum.BolSeq.QtyShipped
                .ShipDate.ShipperNum.Price;
        }
    }

    public class ShippedCustomerOrderLineItemBuilder :
        IdoQueryBuilder<ShippedCustomerOrderLineItemBuilder,ShippedCustomerOrderLineItemFilterExpressionBuilder>
    {
        public ShippedCustomerOrderLineItemBuilder(IExpressionInterpreter ei) : base(ShippedCustomerOrderLineItem.IDO_NAME, ei) { }

        public ShippedCustomerOrderLineItemBuilder CustomerID { get { AddProperty(ShippedCustomerOrderLineItem.CustomerID); return this; } }
        public ShippedCustomerOrderLineItemBuilder CustomerPo { get { AddProperty(ShippedCustomerOrderLineItem.CustomerPo); return this; } } 
        public ShippedCustomerOrderLineItemBuilder CustomerPartNumber { get { AddProperty(ShippedCustomerOrderLineItem.CustomerPartNumber); return this; } }
        public ShippedCustomerOrderLineItemBuilder ItemDescription { get { AddProperty(ShippedCustomerOrderLineItem.Description); return this; } }
        public ShippedCustomerOrderLineItemBuilder Item { get { AddProperty(ShippedCustomerOrderLineItem.ItemID); return this; } }
        public ShippedCustomerOrderLineItemBuilder Line { get { AddProperty(ShippedCustomerOrderLineItem.LineNumber); return this; } }
        public ShippedCustomerOrderLineItemBuilder OrderNumber { get { AddProperty(ShippedCustomerOrderLineItem.OrderNumber); return this; } }
        public ShippedCustomerOrderLineItemBuilder Cost { get { AddProperty(ShippedCustomerOrderLineItem.Cost); return this; } }
        public ShippedCustomerOrderLineItemBuilder OrderType { get { AddProperty(ShippedCustomerOrderLineItem.CoType); return this; } }
        public ShippedCustomerOrderLineItemBuilder BolLine { get { AddProperty(ShippedCustomerOrderLineItem.DoLine); return this; } }
        public ShippedCustomerOrderLineItemBuilder BolNum { get { AddProperty(ShippedCustomerOrderLineItem.DoNum); return this; } }
        public ShippedCustomerOrderLineItemBuilder BolSeq { get { AddProperty(ShippedCustomerOrderLineItem.DoSeq); return this; } }
        public ShippedCustomerOrderLineItemBuilder Price { get { AddProperty(ShippedCustomerOrderLineItem.Price); return this; } }
        public ShippedCustomerOrderLineItemBuilder QtyShipped { get { AddProperty(ShippedCustomerOrderLineItem.QtyShipped); return this; } }
        public ShippedCustomerOrderLineItemBuilder ShipDate { get { AddProperty(ShippedCustomerOrderLineItem.ShipDate); return this; } }
        public ShippedCustomerOrderLineItemBuilder ShipperNum { get { AddProperty(ShippedCustomerOrderLineItem.ShipperNum); return this; } }


        public ShippedCustomerOrderLineItemBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ShippedCustomerOrderLineItemBuilder) base.WithChildren(builders);
        }

        public ShippedCustomerOrderLineItemBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ShippedCustomerOrderLineItemBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ShippedCustomerOrderLineItemFilterExpressionBuilder  : FilterExpressionBuilder<ShippedCustomerOrderLineItemBuilder>
    {
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> CustomerNumber { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.CustomerID); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> CustomerPo { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.CustomerPo); } } 
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> CustomerPartNumber { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.CustomerPartNumber); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> ItemDescription { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.Description); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> Item { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.ItemID); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> Cost { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.Cost); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> OrderType { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.CoType); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> DoLine { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.DoLine); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> DoNum { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.DoNum); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> DoSeq { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.DoSeq); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> Price { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.Price); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> QtyShipped { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.QtyShipped); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> ShipDate { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.ShipDate); } }
        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> ShipperNum { get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.ShipperNum); } }

        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> LineNumber
        {
            get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.LineNumber); }
 
        }

        public FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder> OrderNumber
        {
            get { return new FilterExpression<ShippedCustomerOrderLineItemBuilder, ShippedCustomerOrderLineItemFilterExpressionBuilder>(_builder, ShippedCustomerOrderLineItem.OrderNumber); }

        }
    }
}