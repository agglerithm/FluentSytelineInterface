namespace SytelineInterface.Dsl.Queries
{
    using Commands;
    using Core;

    
    public class PackHeader : IdoConstants
    {
        public const string IDO_NAME = "SLPckHdrs";
        public const string PackNumber = "PackNum";
        public const string OrderNumber = "CoNum";
        public const string PackDate = "PackDate";
        public const string Warehouse = "Whse";

    }

    public class PackHeaderBuilder :
        IdoQueryBuilder<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder>
    {
        public PackHeaderBuilder(IExpressionInterpreter ei) : base(PackHeader.IDO_NAME, ei) { }

        public PackHeaderBuilder PackNumber { get { AddProperty(PackHeader.PackNumber); return this; } }
        public PackHeaderBuilder OrderNumber { get { AddProperty(PackHeader.OrderNumber); return this; } }
        public PackHeaderBuilder PackDate { get { AddProperty(PackHeader.PackDate); return this; } }
        public PackHeaderBuilder Warehouse { get { AddProperty(PackHeader.Warehouse); return this; } }

        public PackHeaderBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (PackHeaderBuilder)base.WithChildren(builders);
        }

        public PackHeaderBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (PackHeaderBuilder)base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class IdoPackHeaderBuilderExpressionBuilder : FilterExpressionBuilder<PackHeaderBuilder>
    {
        public FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder> PackNumber { get { return new FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder>(_builder, PackHeader.PackNumber); } }
        public FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder> OrderNumber { get { return new FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder>(_builder, PackHeader.OrderNumber); } }
        public FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder> PackDate { get { return new FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder>(_builder, PackHeader.PackDate); } }
        public FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder> Warehouse { get { return new FilterExpression<PackHeaderBuilder, IdoPackHeaderBuilderExpressionBuilder>(_builder, PackHeader.Warehouse); } }
    }
}