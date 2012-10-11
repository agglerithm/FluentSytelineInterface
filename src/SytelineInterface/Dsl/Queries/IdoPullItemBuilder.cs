 

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    
    public class PullItem : IdoConstants
    {
        public const string IDO_NAME = "PullItems";    
        public const string Item  = "Item ";
        public const string TriggerPoint  = "trigger_point ";
        public const string Warehouse = "whse";

        
    }

    public class  PullItemBuilder :
        IdoQueryBuilder<PullItemBuilder,PullItemFilterExpressionBuilder>
    {
        public PullItemBuilder(IExpressionInterpreter ei) : base(PullItem.IDO_NAME, ei) { }

        public PullItemBuilder Item { get { AddProperty(PullItem.Item); return this; } }
        public PullItemBuilder TriggerPoint { get { AddProperty(PullItem.TriggerPoint); return this; } }
        public PullItemBuilder Warehouse { get { AddProperty(PullItem.Warehouse); return this; } }


        public PullItemBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (PullItemBuilder) base.WithChildren(builders);
        }

        public PullItemBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (PullItemBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class PullItemFilterExpressionBuilder  : FilterExpressionBuilder<PullItemBuilder>
    {
        public FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder> Item { get { return new FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder>(_builder, PullItem.Item); } }
        public FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder> TriggerPoint { get { return new FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder>(_builder, PullItem.TriggerPoint); } }
        public FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder> Warehouse { get { return new FilterExpression<PullItemBuilder, PullItemFilterExpressionBuilder>(_builder, PullItem.Warehouse); } } 
 
    }
}