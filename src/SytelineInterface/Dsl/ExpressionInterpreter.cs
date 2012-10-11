using System;
using System.Data;
using System.Linq.Expressions;
using NCommon.Expressions;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl
{
    public interface IResolveOperators
    {
        bool CanProcess(ExpressionType expressionType);
        string GetOperator();
    }

    public interface IExpressionInterpreter 
    {
        string GetSytelineWhereClause<TCriteria>(Expression<Func<TCriteria, bool>> exp) where TCriteria : IdoCriteria; 
    }

    public class ExpressionInterpreter  : IExpressionInterpreter 
    { 
        private readonly IOperatorResolverList _opList;
        private readonly IExpressionResolverList _expList;
        private readonly ISytelineExpressionVisitor _visitor;

        public static ExpressionInterpreter Build()
        {
            var visitor = new SytelineExpressionVisitor();
            var expressionInterpreter = new ExpressionInterpreter(new OperatorResolverList(visitor),
                                                                     new ExpressionResolverList(visitor),
                                                                        visitor);
            return expressionInterpreter;
        }


        private ExpressionInterpreter(IOperatorResolverList opList, IExpressionResolverList expList, ISytelineExpressionVisitor visitor)
        {
            _opList = opList;
            _expList = expList;
            _visitor = visitor;
        }

        public string GetSytelineWhereClause<TCriteria>(Expression<Func<TCriteria, bool>> exp) where TCriteria : IdoCriteria 
        {
            return build_condition(exp);
        }

        private string build_condition<TCriteria>(Expression<Func<TCriteria, bool>> exp)
        {
            var expr = exp.Body;
 
            return evaluate_node(expr); 
        }

        private string evaluate_op(ExpressionType nodeType)
        {
            return _opList.GetOperatorFor(nodeType).GetOperator();
        }

        private string evaluate_node(Expression exp)
        {
            var resolver = _expList.GetResolverFor(exp,_visitor);
            if (resolver == null) throw new InvalidExpressionException("No resolver found for this expression");
            return resolver.ResolveExpression(exp, evaluate_node, evaluate_op, _visitor);
        }
    }
}