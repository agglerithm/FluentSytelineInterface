using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class InvoicedOrdersValues : IdoCommandBuilder
    {
        public InvoicedOrdersValues() : base(InvoicedOrders.IDO_NAME)
        {
        }
 
        public InvoicedOrdersValues OrderNumber(string value) { AddValue(InvoicedOrders.OrderNumber, value); return this; } 
        public InvoicedOrdersValues CustomerID(string value) { AddValue(InvoicedOrders.CustomerID, value); return this; }
        public InvoicedOrdersValues CustomerPo(string value) { AddValue(InvoicedOrders.CustomerPo, value); return this; }  
        public InvoicedOrdersValues InvoiceDate(string value) { AddValue(InvoicedOrders.InvDate, value); return this; } 
        public InvoicedOrdersValues BillType(string value) { AddValue(InvoicedOrders.BillType, value); return this; }      
        public InvoicedOrdersValues Slsman(string value) { AddValue(InvoicedOrders.Slsman, value); return this; } 
        public InvoicedOrdersValues InvNum(string value) { AddValue(InvoicedOrders.InvNum, value); return this; }
        public InvoicedOrdersValues InvSeq(string value) { AddValue(InvoicedOrders.InvSeq, value); return this; } 
        public InvoicedOrdersValues Amount(string value) { AddValue(InvoicedOrders.Amount, value); return this; }  
        public InvoicedOrdersValues RecordDate(string value) { AddValue(InvoicedOrders.RecordDate, value); return this; }
        public InvoicedOrdersValues RowPointer(string value) { AddValue(InvoicedOrders.RowPointer, value); return this; }
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.InvoicedOrders.Add(get_property_names());
        }
    }
}