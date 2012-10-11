using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    
    public class Warehouses : IdoConstants
    {
        public const string Site = "SiteRef";
        public const string IDO_NAME = "SL.SLWhses";
        public const string Warehouse = "Whse";
        public const string Name = "Name";
        public const string City = "City";
        public const string State = "State";
        public const string Addr1 = "Addr_1";
        public const string Addr2 = "Addr_2";
        public const string Addr3 = "Addr_3";
        public const string Zip = "Zip";
    }

    public class WarehouseBuilder : IdoQueryBuilder<WarehouseBuilder,WarehouseFilterExpressionBuilder>
    {
        public WarehouseBuilder(IExpressionInterpreter ei) : base(Warehouses.IDO_NAME, ei) { }

        public WarehouseBuilder Warehouse { get { AddProperty(Warehouses.Warehouse); return this; } }

        public WarehouseBuilder Name { get { AddProperty(Warehouses.Name); return this; } }

        public WarehouseBuilder City { get { AddProperty(Warehouses.City); return this; } }

        public WarehouseBuilder State { get { AddProperty(Warehouses.State); return this; } }

        public WarehouseBuilder Address1 { get { AddProperty(Warehouses.Addr1); return this; } }
 
        public WarehouseBuilder Address2 { get { AddProperty(Warehouses.Addr2); return this; } }

        public WarehouseBuilder Address3 { get { AddProperty(Warehouses.Addr3); return this; } }

        public WarehouseBuilder Zip { get { AddProperty(Warehouses.Zip); return this; } }

        public WarehouseBuilder Site
        {
            get { AddProperty(Warehouses.Site); return this; }
        }

        public WarehouseBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (WarehouseBuilder) base.WithChildren(builders);
        }

        public WarehouseBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (WarehouseBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class WarehouseFilterExpressionBuilder : FilterExpressionBuilder<WarehouseBuilder>
    {
        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Warehouse
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Warehouse); }
        }

        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Site
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Site); }
        }
        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> State
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.State); }
        }

        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Zip
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Zip); }
        }
        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Address1
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Addr1); }
        }

        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Address2
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Addr2); }
        }

        public FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder> Address3
        {
            get { return new FilterExpression<WarehouseBuilder, WarehouseFilterExpressionBuilder>(_builder, Warehouses.Addr3); }
        }
    }
}