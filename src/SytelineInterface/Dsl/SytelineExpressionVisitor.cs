using System.Linq.Expressions;
using ExpressionVisitor = NCommon.Expressions.ExpressionVisitor;

namespace SytelineInterface.Dsl
{
    public interface ISytelineExpressionVisitor
    {
        Expression Visit(Expression exp);

    }
    
    public class SytelineExpressionVisitor : ExpressionVisitor, ISytelineExpressionVisitor
    {
    }
}
