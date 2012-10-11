

using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ShippedCustomerOrderLineItemValues : IdoCommandBuilder
    {
        public ShippedCustomerOrderLineItemValues()
            : base(ShippedCustomerOrderLineItem.IDO_NAME)
        {
        }

        public ShippedCustomerOrderLineItemValues CustomerID(string value) { AddValue(ShippedCustomerOrderLineItem.CustomerID, value); return this; }
        public ShippedCustomerOrderLineItemValues CustomerPo(string value) { AddValue(ShippedCustomerOrderLineItem.CustomerPo, value); return this; } 
        public ShippedCustomerOrderLineItemValues CustomerPartNumber(string value) { AddValue(ShippedCustomerOrderLineItem.CustomerPartNumber, value); return this; }
        public ShippedCustomerOrderLineItemValues CoiDescription(string value) { AddValue(ShippedCustomerOrderLineItem.Description, value); return this; }
        public ShippedCustomerOrderLineItemValues ItemID(string value) { AddValue(ShippedCustomerOrderLineItem.ItemID, value); return this; }
        public ShippedCustomerOrderLineItemValues LineNumber(string value) { AddValue(ShippedCustomerOrderLineItem.LineNumber, value); return this; }
        public ShippedCustomerOrderLineItemValues OrderNumber(string value) { AddValue(ShippedCustomerOrderLineItem.OrderNumber, value); return this; }
        public ShippedCustomerOrderLineItemValues Cost(string value) { AddValue(ShippedCustomerOrderLineItem.Cost, value); return this; }
        public ShippedCustomerOrderLineItemValues CoType(string value) { AddValue(ShippedCustomerOrderLineItem.CoType, value); return this; }
        public ShippedCustomerOrderLineItemValues DoLine(string value) { AddValue(ShippedCustomerOrderLineItem.DoLine, value); return this; }
        public ShippedCustomerOrderLineItemValues DoNum(string value) { AddValue(ShippedCustomerOrderLineItem.DoNum, value); return this; }
        public ShippedCustomerOrderLineItemValues DoSeq(string value) { AddValue(ShippedCustomerOrderLineItem.DoSeq, value); return this; }
        public ShippedCustomerOrderLineItemValues Price(string value) { AddValue(ShippedCustomerOrderLineItem.Price, value); return this; }
        public ShippedCustomerOrderLineItemValues QtyShipped(string value) { AddValue(ShippedCustomerOrderLineItem.QtyShipped, value); return this; }
        public ShippedCustomerOrderLineItemValues ShipDate(string value) { AddValue(ShippedCustomerOrderLineItem.ShipDate, value); return this; }
        public ShippedCustomerOrderLineItemValues ShipperNum(string value) { AddValue(ShippedCustomerOrderLineItem.ShipperNum, value); return this; }
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.ShippedCustomerOrderLineItem.Add(get_property_names());
        }
    }
}