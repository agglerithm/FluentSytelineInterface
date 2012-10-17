

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class CustomerPartNumbers : IdoConstants
    {
        public const string IDO_NAME = "SL.SLItemCusts";
        public const string Item = "Item";
        public const string CustomerNumber = "CustNum";
        public const string CustomerPartNumber = "CustItem"; 

        public static CustomerPartNumberBuilder GetFullProjection()
        {
            return FromSyteline.CustomerPartNumbers.CustomerNumber.CustomerPartNumber.Item;
        }
    }

    public class CustomerPartNumberBuilder :
        IdoQueryBuilder<CustomerPartNumberBuilder, CustomerPartNumberFilterExpressionBuilder>
    {
        public CustomerPartNumberBuilder(IExpressionInterpreter ei) : base(CustomerPartNumbers.IDO_NAME, ei) { }

        public CustomerPartNumberBuilder Item { get { AddProperty(CustomerPartNumbers.Item); return this; } }

        public CustomerPartNumberBuilder CustomerNumber { get { AddProperty(CustomerPartNumbers.CustomerNumber); return this; } }

        public CustomerPartNumberBuilder CustomerPartNumber { get { AddProperty(CustomerPartNumbers.CustomerPartNumber); return this; } } 

        public CustomerPartNumberBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (CustomerPartNumberBuilder) base.WithChildren(builders);
        }

        public CustomerPartNumberBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (CustomerPartNumberBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class CustomerPartNumberFilterExpressionBuilder : FilterExpressionBuilder<CustomerPartNumberBuilder>
    {
        public FilterExpression<CustomerPartNumberBuilder, CustomerPartNumberFilterExpressionBuilder> CustomerPartNumber
        {
            get { return new FilterExpression<CustomerPartNumberBuilder, CustomerPartNumberFilterExpressionBuilder>(_builder, CustomerPartNumbers.CustomerPartNumber); }
        }
        public FilterExpression<CustomerPartNumberBuilder, CustomerPartNumberFilterExpressionBuilder> CustomerNumber
        {
            get { return new FilterExpression<CustomerPartNumberBuilder, CustomerPartNumberFilterExpressionBuilder>(_builder, CustomerPartNumbers.CustomerNumber); }
        }
 

    }
}