 
using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    public class IdoConstantsClass : IdoConstants
    {
        public const string IDO_NAME = "";
        
    }

    public class IdoBuilder :
        IdoBuilder<IdoBuilder, IdoFilterExpressionBuilder>
    {
        protected IdoBuilder() : base(Inventory.IDO_NAME) { }


 

        public IdoBuilder IDOName { get { AddProperty(IdoConstantsClass.IDO_NAME); return this; } } 

    }

    public class IdoFilterExpressionBuilder  : FilterExpressionBuilder<IdoBuilder>
    {
        public FilterExpression<IdoBuilder, IdoFilterExpressionBuilder> IDOName
        {
            get { return new FilterExpression<IdoBuilder, IdoFilterExpressionBuilder>(_builder, IdoConstantsClass.IDO_NAME); }
        }
        

    }
}
 
