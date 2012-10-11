using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ShippedCustomerOrderValues : IdoCommandBuilder
    {
        public ShippedCustomerOrderValues( ) : base(ShippedCustomerOrder.IDO_NAME)
        {
        }

        //public ShippedCustomerOrderValues Active(string value)
        //{
        //    AddValue(ShippedCustomerOrder.Active, value); return this;
        //}
        //public ShippedCustomerOrderValues BatchID(string value)
        //{
        //    AddValue(ShippedCustomerOrder.BatchId, value); return this;
        //}
        //public ShippedCustomerOrderValues BOL(string value)
        //{
        //    AddValue(ShippedCustomerOrder.BOL, value); return this;
        //}
        //public ShippedCustomerOrderValues ShipCode(string value)
        //{
        //    AddValue(ShippedCustomerOrder.ShipCode, value); return this;
        //}
        public ShippedCustomerOrderValues LineNumber(string value)
        {
            AddValue(ShippedCustomerOrder.LineNumber, value); return this;
        }
        public ShippedCustomerOrderValues DeliveryOrderNumber(string value)
        {
            AddValue(ShippedCustomerOrder.DeliveryOrderNumber, value); return this;
        }
        //public ShippedCustomerOrderValues ShipCodeDescription(string value)
        //{
        //    AddValue(ShippedCustomerOrder.ShipCodeDescription, value); return this;
        //}
 
        public ShippedCustomerOrderValues CustomerNumber(string value)
        {
            AddValue(ShippedCustomerOrder.CustomerNumber, value); return this;
        }
        public ShippedCustomerOrderValues OrderDate(string value)
        {
            AddValue(ShippedCustomerOrder.OrderDate, value); return this;
        }
        public ShippedCustomerOrderValues OrderNumber(string value)
        {
            AddValue(ShippedCustomerOrder.OrderNumber, value); return this;
        }
        //public ShippedCustomerOrderValues ShipToCode(string value)
        //{
        //    AddValue(ShippedCustomerOrder.ShipToCode, value); return this;
        //}
        //public ShippedCustomerOrderValues OrderType(string value)
        //{
        //    AddValue(ShippedCustomerOrder.OrderType, value); return this;
        //}

        public ShippedCustomerOrderValues Status(string value)
        {
            AddValue(ShippedCustomerOrder.Status, value); return this;
        }
        //public ShippedCustomerOrderValues Invoiced(string value)
        //{
        //    AddValue(ShippedCustomerOrder.Invoiced, value); return this;
        //}
        //public ShippedCustomerOrderValues Picked(string value)
        //{
        //    AddValue(ShippedCustomerOrder.Picked, value); return this;
        //}
        //public ShippedCustomerOrderValues Shipped(string value)
        //{
        //    AddValue(ShippedCustomerOrder.Shipped, value); return this;
        //}
        //public ShippedCustomerOrderValues ShipToName(string value)
        //{
        //    AddValue(ShippedCustomerOrder.ShipToName, value); return this;
        //}
         
        public ShippedCustomerOrderValues CustomerPo(string value) { AddValue(ShippedCustomerOrder.CustomerPo, value); return this; }
        public ShippedCustomerOrderValues CustomerPartNumber(string value) { AddValue(ShippedCustomerOrder.CustomerPartNumber, value); return this; }
        public ShippedCustomerOrderValues CoiDescription(string value) { AddValue(ShippedCustomerOrder.Description, value); return this; }
        public ShippedCustomerOrderValues ItemID(string value) { AddValue(ShippedCustomerOrder.ItemID, value); return this; } 
        public ShippedCustomerOrderValues Cost(string value) { AddValue(ShippedCustomerOrder.Cost, value); return this; }
        public ShippedCustomerOrderValues CoType(string value) { AddValue(ShippedCustomerOrder.CoType, value); return this; }
        public ShippedCustomerOrderValues DoLine(string value) { AddValue(ShippedCustomerOrder.DoLine, value); return this; }
        public ShippedCustomerOrderValues DoNum(string value) { AddValue(ShippedCustomerOrder.DoNum, value); return this; }
        public ShippedCustomerOrderValues DoSeq(string value) { AddValue(ShippedCustomerOrder.DoSeq, value); return this; }
        public ShippedCustomerOrderValues Price(string value) { AddValue(ShippedCustomerOrder.Price, value); return this; }
        public ShippedCustomerOrderValues QtyShipped(string value) { AddValue(ShippedCustomerOrder.QtyShipped, value); return this; }
        public ShippedCustomerOrderValues ShipDate(string value) { AddValue(ShippedCustomerOrder.ShipDate, value); return this; }
        public ShippedCustomerOrderValues ShipperNum(string value) { AddValue(ShippedCustomerOrder.ShipperNum, value); return this; }

        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.ShippedCustomerOrder.Add(get_property_names());
        }

    }
}