using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class CustomerOrderLineItemValues : IdoCommandBuilder
    {
        public CustomerOrderLineItemValues() : base(CustomerOrderLineItem.IDO_NAME) { }

        public CustomerOrderLineItemValues LinkBy(string parentField, string childField)
        {
            return (CustomerOrderLineItemValues)base.LinkBy(parentField, childField); 
        }

        public CustomerOrderLineItemValues CustomerNumber(string value)
        {
            AddValue(CustomerOrderLineItem.CustomerNumber, value);
            return this;
        }
        public CustomerOrderLineItemValues Item(string value)
        {
            AddValue(CustomerOrderLineItem.Item, value);
            return this;
        }
        public CustomerOrderLineItemValues LineNumber(string value)
        {
            AddValue(CustomerOrderLineItem.LineNumber, value);
            return this;
        }
        public CustomerOrderLineItemValues CustomerPartNumber(string value)
        {
            AddValue(CustomerOrderLineItem.CustomerPartNumber, value);
            return this;
        }

        public CustomerOrderLineItemValues QtyOrdered(string value)
        {
            AddValue(CustomerOrderLineItem.QtyOrdered, value);
            return this;
        }

        public CustomerOrderLineItemValues OrderNumber(string value)
        {
            AddValue(CustomerOrderLineItem.OrderNumber, value);
            return this;
        }

        public CustomerOrderLineItemValues ReleaseNumber(string value)
        {
            AddValue(CustomerOrderLineItem.ReleaseNumber, value);
            return this;
        }
        public CustomerOrderLineItemValues Status (string value)
        {
            AddValue(CustomerOrderLineItem.Status, value);
            return this;
        }
        public CustomerOrderLineItemValues Description(string value)
        {
            AddValue(CustomerOrderLineItem.Description, value);
            return this;
        }
        public CustomerOrderLineItemValues UnitOfMeasure(string value)
        {
            AddValue(CustomerOrderLineItem.UnitOfMeasure, value);
            return this;
        }
 
        public CustomerOrderLineItemValues Price(string value)
        {
            AddValue(CustomerOrderLineItem.Price, value);
            return this;
        }

        //public CustomerOrderLineItemValues ConvertedPrice(string value)
        //{
        //    AddValue(CustomerOrderLineItem.ConvertedPrice, value);
        //    return this;
        //}
        public CustomerOrderLineItemValues DueDate(string value)
        {
            AddValue(CustomerOrderLineItem.DueDate, value);
            return this;
        }
//        public CustomerOrderLineItemValues ReferenceType(string value)
//        {
//            AddValue(CustomerOrderLineItem.ReferenceType, value);
//            return this;
//        }
        public CustomerOrderLineItemValues ShipSite(string value)
        {
            AddValue(CustomerOrderLineItem.ShipSite, value);
            return this;
        }
        public CustomerOrderLineItemValues Warehouse(string value)
        {
            AddValue(CustomerOrderLineItem.Warehouse, value);
            return this;
        }
        public CustomerOrderLineItemValues InventoryFrequency(string value)
        {
            AddValue(CustomerOrderLineItem.InventoryFrequency, value);
            return this;
        }

        public CustomerOrderLineItemValues RequestedDate(string value)
        {
            // This is what syteline lables this under the covers
            AddValue(CustomerOrderLineItem.PromiseDate, value);
            return this;
        }
//        public CustomerOrderLineItemValues Discount(string value)
//        {
//            AddValue(CustomerOrderLineItem.Discount, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues CoCustNum(string value)
//        {
//            AddValue(CustomerOrderLineItem.CoCustNum, value);
//            return this;
//        }

//        public CustomerOrderLineItemValues Address1(string value)
//        {
//            AddValue(CustomerOrderLineItem.Address1, value);
//            return this;
//        }
//
//        public CustomerOrderLineItemValues Address2(string value)
//        {
//            AddValue(CustomerOrderLineItem.Address2, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues Address3(string value)
//        {
//            AddValue(CustomerOrderLineItem.Address3, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues Address4(string value)
//        {
//            AddValue(CustomerOrderLineItem.Address4, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressCity(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressCity, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressCountry(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressCountry, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressFaxNum(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressFaxNum, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressName(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressName, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressState(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressState, value);
//            return this;
//        }
//        public CustomerOrderLineItemValues AddressZip(string value)
//        {
//            AddValue(CustomerOrderLineItem.AddressZip, value);
//            return this;
//        }
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.CustomerOrderLineItems.Add(get_property_names());
        }

//        public CustomerOrderLineItemValues CustomerSequence(string value)
//        {
//            AddValue(CustomerOrderLineItem.CustomerSequence, value);
//            return this;
//        }
 

   
    }
}