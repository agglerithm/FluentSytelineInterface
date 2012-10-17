 
using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class ItemWarehouse : IdoConstants
    {
        public const string IDO_NAME = "SLItemwhses";
        public const string Item = "Item";
        public const string ItemDescription = "ItemDescription";
        public const string QtyMrb = "QtyMrb";
        public const string QtyOnHand = "QtyOnHand";
        public const string QtyOrdered = "QtyOrdered";
        public const string QtyPurchasedYtd = "QtyPurYtd";
        public const string QtyReorder = "QtyReorder"; 
        public const string QtySoldYtd = "QtySoldYtd"; 
        public const string QtyWip = "QtyWip";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string SalesPtd = "SalesPtd";
        public const string SalesYtd = "SalesYtd";
        public const string TotalQtyOnHand = "TotalQtyOnHand";
        public const string TotalQtyReserved = "TotalQtyReserved";
        public const string UM = "UM";
        public const string Whse = "Whse";
        public const string WhseName = "WhseName";
        public const string ItemSuffix = "Suffix";
        public const string AvgCost = "AvgUCost";
        public const string FreezeDate = "FrzFreezeDate";
        public const string QtyAllocatedOrders = "QtyAllocCo";
        public const string QtyAllocatedJobs = "QtyAllocjob";
        public const string UnitCost = "UnitCost";
        public const string FreezeCost = "FrzCompMatl";
        public const string LeadTime = "LeadTime";




        public static ItemWarehouseBuilder GetFullProjection()
        {
            return FromSyteline.ItemWarehouse.Item.ItemDescription.QtyMrb.QtyOnHand.QtyOrdered.QtyReorder.QtySoldYtd
                .QtyWip.RecordDate.RowPointer.SalesPtd.SalesYtd.TotalQtyOnHand.TotalQtyReserved.UM.Whse.WhseName.QtyPurchasedYtd
                .ItemSuffix.AvgCost.UnitCost.FreezeCost.FreezeDate.LeadTime.QtyAllocatedJobs.QtyAllocatedOrders;
        }
    }

    public class  ItemWarehouseBuilder :
        IdoQueryBuilder<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>
    {
        public ItemWarehouseBuilder(IExpressionInterpreter ei) : base(ItemWarehouse.IDO_NAME, ei) { }
        public ItemWarehouseBuilder AvgCost { get { AddProperty(ItemWarehouse.AvgCost); return this; } }
        public ItemWarehouseBuilder UnitCost { get { AddProperty(ItemWarehouse.UnitCost); return this; } }
        public ItemWarehouseBuilder FreezeDate { get { AddProperty(ItemWarehouse.FreezeDate); return this; } }
        public ItemWarehouseBuilder FreezeCost { get { AddProperty(ItemWarehouse.FreezeCost); return this; } }
        public ItemWarehouseBuilder QtyAllocatedOrders { get { AddProperty(ItemWarehouse.QtyAllocatedOrders); return this; } }
        public ItemWarehouseBuilder QtyAllocatedJobs { get { AddProperty(ItemWarehouse.QtyAllocatedJobs); return this; } }
        public ItemWarehouseBuilder LeadTime { get { AddProperty(ItemWarehouse.LeadTime); return this; } }
        public ItemWarehouseBuilder Item { get { AddProperty(ItemWarehouse.Item); return this; } }
        public ItemWarehouseBuilder ItemDescription { get { AddProperty(ItemWarehouse.ItemDescription); return this; } }
        public ItemWarehouseBuilder QtyMrb { get { AddProperty(ItemWarehouse.QtyMrb); return this; } }
        public ItemWarehouseBuilder QtyOnHand { get { AddProperty(ItemWarehouse.QtyOnHand); return this; } }
        public ItemWarehouseBuilder QtyOrdered { get { AddProperty(ItemWarehouse.QtyOrdered); return this; } }
        public ItemWarehouseBuilder QtyPurchasedYtd { get { AddProperty(ItemWarehouse.QtyPurchasedYtd); return this; } } 
        public ItemWarehouseBuilder QtyReorder { get { AddProperty(ItemWarehouse.QtyReorder); return this; } } 
        public ItemWarehouseBuilder QtySoldYtd { get { AddProperty(ItemWarehouse.QtySoldYtd); return this; } } 
        public ItemWarehouseBuilder QtyWip { get { AddProperty(ItemWarehouse.QtyWip); return this; } }
        public ItemWarehouseBuilder RecordDate { get { AddProperty(ItemWarehouse.RecordDate); return this; } }
        public new ItemWarehouseBuilder RowPointer { get { AddProperty(ItemWarehouse.RowPointer); return this; } }
        public ItemWarehouseBuilder SalesPtd { get { AddProperty(ItemWarehouse.SalesPtd); return this; } }
        public ItemWarehouseBuilder SalesYtd { get { AddProperty(ItemWarehouse.SalesYtd); return this; } }
        public ItemWarehouseBuilder TotalQtyOnHand { get { AddProperty(ItemWarehouse.TotalQtyOnHand); return this; } }
        public ItemWarehouseBuilder TotalQtyReserved { get { AddProperty(ItemWarehouse.TotalQtyReserved); return this; } }
        public ItemWarehouseBuilder UM { get { AddProperty(ItemWarehouse.UM); return this; } }
        public ItemWarehouseBuilder Whse { get { AddProperty(ItemWarehouse.Whse); return this; } }
        public ItemWarehouseBuilder WhseName { get { AddProperty(ItemWarehouse.WhseName); return this; } }


        public ItemWarehouseBuilder ItemSuffix { get { AddProperty(ItemWarehouse.ItemSuffix); return this; } }


        public ItemWarehouseBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ItemWarehouseBuilder) base.WithChildren(builders);
        }

        public ItemWarehouseBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ItemWarehouseBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ItemWarehouseFilterExpressionBuilder  : FilterExpressionBuilder<ItemWarehouseBuilder>
    {
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> Item{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.Item);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> ItemDescription{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.ItemDescription);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtyMrb{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtyMrb);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtyOnHand{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtyOnHand);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtyOrdered{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtyOrdered);  }  }  
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtyReorder{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtyReorder);  }  }  
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtySoldYtd{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtySoldYtd);  }  }  
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> QtyWip{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.QtyWip);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> RecordDate{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.RecordDate);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> RowPointer{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.RowPointer);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> SalesPtd{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.SalesPtd);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> SalesYtd{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.SalesYtd);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> TotalQtyOnHand{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.TotalQtyOnHand);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> TotalQtyReserved{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.TotalQtyReserved);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> UM{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.UM);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> Whse{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.Whse);  }  } 
        public FilterExpression<ItemWarehouseBuilder, ItemWarehouseFilterExpressionBuilder> WhseName{ get { return new FilterExpression<ItemWarehouseBuilder,ItemWarehouseFilterExpressionBuilder>(_builder, ItemWarehouse.WhseName);  }  } 

        

    }
}