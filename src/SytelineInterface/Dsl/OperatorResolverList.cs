using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SytelineInterface.Dsl
{
    using Common.Extensions;

    public interface IOperatorResolverList
    {
        IResolveOperators GetOperatorFor(ExpressionType expType);
    }

    public class OperatorResolverList : IOperatorResolverList
    {
        private readonly ISytelineExpressionVisitor _visitor;
        private IList<IResolveOperators> _opResolvers= new List<IResolveOperators>();
        public OperatorResolverList(ISytelineExpressionVisitor visitor)
        {
            _visitor = visitor;
            _opResolvers.Add(new GreaterThanResolver());
            _opResolvers.Add(new LessThanResolver());
            _opResolvers.Add(new EqualsResolver());
            _opResolvers.Add(new InequalityResolver());
            _opResolvers.Add(new AndResolver());
            _opResolvers.Add(new OrResolver());
            _opResolvers.Add(new GreaterThanOrEqualResolver());
            _opResolvers.Add(new LessThanOrEqualResolver());
        }

        public IResolveOperators GetOperatorFor(ExpressionType expType)
        {
            return _opResolvers.Find(r => r.CanProcess(expType));
        }
    }

    public class InequalityResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.NotEqual;
        }

        public string GetOperator()
        {
            return " <> ";
        }
    }

    public class EqualsResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.Equal;
        }

        public string GetOperator()
        {
            return " = ";
        }
    }

    public class LessThanResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.LessThan;
        }

        public string GetOperator()
        {
            return " < ";
        }
    }

    public class GreaterThanResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.GreaterThan;
        }

        public string GetOperator()
        {
            return " > ";
        }
    }

    public class GreaterThanOrEqualResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.GreaterThanOrEqual;
        }

        public string GetOperator()
        {
            return " >= ";
        }
    }

    public class LessThanOrEqualResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.LessThanOrEqual;
        }

        public string GetOperator()
        {
            return " <= ";
        }
    }

    public class AndResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.AndAlso;
        }

        public string GetOperator()
        {
            return " AND ";
        }
    }

    public class OrResolver : IResolveOperators
    {
        public bool CanProcess(ExpressionType expressionType)
        {
            return expressionType == ExpressionType.OrElse;
        }

        public string GetOperator()
        {
            return " OR ";
        }
    }
}