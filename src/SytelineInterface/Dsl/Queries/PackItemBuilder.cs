namespace SytelineInterface.Dsl.Queries
{
    using Commands;
    using Core;

    
    public class PackItem : IdoConstants
    {
        public const string IDO_NAME = "SLPckitems";
        public const string PackNum = "PackNum";
        public const string InvNum = "InvNum";
        public const string CoNum = "CoNum";
        public const string CoLine = "CoLine";
        public const string CoRelease = "CoRelease";
        public const string CreateDate = "CreateDate";
        public const string QtyOrdered = "QtyOrdered";
        public const string QtyPacked = "QtyPacked";
        public const string Item = "Item";

    }

    public class PackItemBuilder :
        IdoQueryBuilder<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>
    {
        public PackItemBuilder(IExpressionInterpreter ei) : base(PackItem.IDO_NAME, ei) { }

        public PackItemBuilder PackNum { get { AddProperty(PackItem.PackNum); return this; } }
        public PackItemBuilder InvNum { get { AddProperty(PackItem.InvNum); return this; } }
        public PackItemBuilder CoNum { get { AddProperty(PackItem.CoNum); return this; } }
        public PackItemBuilder CoLine { get { AddProperty(PackItem.CoLine); return this; } }
        public PackItemBuilder CoRelease { get { AddProperty(PackItem.CoRelease); return this; } }
        public PackItemBuilder CreateDate { get { AddProperty(PackItem.CreateDate); return this; } }
        public PackItemBuilder QtyOrdered { get { AddProperty(PackItem.QtyOrdered); return this; } }
        public PackItemBuilder QtyPacked { get { AddProperty(PackItem.QtyPacked); return this; } }
        public PackItemBuilder Item { get { AddProperty(PackItem.Item); return this; } }

        public PackItemBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (PackItemBuilder)base.WithChildren(builders);
        }

        public PackItemBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (PackItemBuilder)base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class IdoPackItemBuilderExpressionBuilder : FilterExpressionBuilder<PackItemBuilder>
    {
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> PackNum { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.PackNum); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> InvNum { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.InvNum); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> CoNum { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.CoNum); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> CoLine { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.CoLine); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> CoRelease { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.CoRelease); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> CreateDate { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.CreateDate); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> QtyOrdered { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.QtyOrdered); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> QtyPacked { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.QtyPacked); } }
        public FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder> Item { get { return new FilterExpression<PackItemBuilder, IdoPackItemBuilderExpressionBuilder>(_builder, PackItem.Item); } }
    }
}