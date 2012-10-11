

using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ItemWarehouseValues : IdoCommandBuilder
    {
        public ItemWarehouseValues()
            : base(ItemWarehouse.IDO_NAME)
        {
        }
        public ItemWarehouseValues Item(string value) { AddValue(ItemWarehouse.Item, value); return this; }
        public ItemWarehouseValues ItemDescription(string value) { AddValue(ItemWarehouse.ItemDescription, value); return this; }
        public ItemWarehouseValues QtyMrb(string value) { AddValue(ItemWarehouse.QtyMrb, value); return this; }
        public ItemWarehouseValues QtyOnHand(string value) { AddValue(ItemWarehouse.QtyOnHand, value); return this; }
        public ItemWarehouseValues QtyOrdered(string value) { AddValue(ItemWarehouse.QtyOrdered, value); return this; } 
        public ItemWarehouseValues QtyReorder(string value) { AddValue(ItemWarehouse.QtyReorder, value); return this; } 
        public ItemWarehouseValues QtySoldYtd(string value) { AddValue(ItemWarehouse.QtySoldYtd, value); return this; } 
        public ItemWarehouseValues QtyWip(string value) { AddValue(ItemWarehouse.QtyWip, value); return this; }
        public ItemWarehouseValues RecordDate(string value) { AddValue(ItemWarehouse.RecordDate, value); return this; }
        public ItemWarehouseValues RowPointer(string value) { AddValue(ItemWarehouse.RowPointer, value); return this; }
        public ItemWarehouseValues SalesPtd(string value) { AddValue(ItemWarehouse.SalesPtd, value); return this; }
        public ItemWarehouseValues SalesYtd(string value) { AddValue(ItemWarehouse.SalesYtd, value); return this; }
        public ItemWarehouseValues TotalQtyOnHand(string value) { AddValue(ItemWarehouse.TotalQtyOnHand, value); return this; }
        public ItemWarehouseValues TotalQtyReserved(string value) { AddValue(ItemWarehouse.TotalQtyReserved, value); return this; }
        public ItemWarehouseValues UM(string value) { AddValue(ItemWarehouse.UM, value); return this; }
        public ItemWarehouseValues Whse(string value) { AddValue(ItemWarehouse.Whse, value); return this; }
        public ItemWarehouseValues WhseName(string value) { AddValue(ItemWarehouse.WhseName, value); return this; }
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.ItemWarehouse.Add(get_property_names());
        }
    }
}