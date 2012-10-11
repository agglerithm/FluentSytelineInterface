using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection; 
using SytelineInterface.Core;
using Expression = System.Linq.Expressions.Expression;

namespace SytelineInterface.Dsl
{
    using Common.Extensions;

    public interface IExpressionResolverList
    {
        IResolveExpressions GetResolverFor(Expression exp, ISytelineExpressionVisitor visitor);
    }
    
    public class ExpressionResolverList : IExpressionResolverList
    { 
        private readonly IList<IResolveExpressions> _expressionList = new List<IResolveExpressions>();

        public ExpressionResolverList(ISytelineExpressionVisitor visitor) 
        { 
            _expressionList.Add(new NullBinaryExpressionResolver());
            _expressionList.Add(new BinaryExpressionResolver());
            _expressionList.Add(new IsNullOrEmptyCallExpressionResolver());
            _expressionList.Add(new ConvertExpressionResolver());
            _expressionList.Add(new ConstantExpressionResolver());
            _expressionList.Add(new ContainsCallExpressionResolver());
            _expressionList.Add(new NegateExpressionResolver());
            _expressionList.Add(new ClassValueVariableMemberExpressionResolver());
            _expressionList.Add(new PropertyMemberExpressionResolver());
            _expressionList.Add(new ParameterMemberExpressionResolver());
            _expressionList.Add(new TrimExpressionResolver());
        }

        public IResolveExpressions GetResolverFor(Expression exp, ISytelineExpressionVisitor visitor)
        {
            return _expressionList.Find(e => e.CanProcess(exp,visitor));
        }
    }

    public interface IResolveExpressions
    {
        bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor);
        string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, 
            ISytelineExpressionVisitor visitor);
    }


    public class NullBinaryExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            if (!exp.IsBinaryExpression()) return false;
            var bin = (BinaryExpression)exp;
            return  ((bin.Left.NodeType == ExpressionType.Constant && ((ConstantExpression)bin.Left).Value == null
                     || bin.Right.NodeType == ExpressionType.Constant && ((ConstantExpression)bin.Right).Value == null));
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, 
            ISytelineExpressionVisitor visitor)
        {
            var bin = (BinaryExpression)exp;
            var openParen = "(";
            if (bin.NodeType == ExpressionType.NotEqual)
                openParen = "(NOT ";
            if (bin.Right.NodeType == ExpressionType.Constant)
                return openParen + evaluateNode(bin.Left) + " IS NULL) ";
            return openParen + evaluateNode(bin.Right) + " IS NULL) ";
        }
    }

  
    public class BinaryExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        { 
            if (!exp.IsBinaryExpression()) return false;
            var bin = (BinaryExpression)exp;
            return !(bin.Left.NodeType == ExpressionType.Constant && ((ConstantExpression) bin.Left).Value == null
                     || bin.Right.NodeType == ExpressionType.Constant && ((ConstantExpression) bin.Right).Value == null);
 
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, 
            ISytelineExpressionVisitor visitor)
        {
            var bin = (BinaryExpression)visitor.Visit(exp);
            var lvalue = evaluateNode(bin.Left);
            var op = evaluateOp(bin.NodeType);
            var rvalue = evaluateNode(bin.Right);
            if (rvalue.Trim() == "NULL" && op.Trim() == "=")
                op = " IS ";
            return "(" + lvalue + op + rvalue + ")";
        }

 
    }

    public class IsNullOrEmptyCallExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            if (exp.NodeType == ExpressionType.Call)
            {
                var method = (MethodCallExpression)exp;
                return method.Method.Name == "IsNullOrEmpty";
            }
            return false;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp,
            ISytelineExpressionVisitor visitor)
        {

            var member = (MethodCallExpression)visitor.Visit(exp);
            var argMember = (MemberExpression)member.Arguments[0]; 
            var parm = argMember.GetAttribute();

            return string.Format(" IsNull({0}, '') = '' ", parm);
        }


    }

    public class ContainsCallExpressionResolver :  IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
           if(exp.NodeType == ExpressionType.Call)
           {
               var method = (MethodCallExpression) exp;
               return method.Method.Name == "Contains";
           }
            return false;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, 
            ISytelineExpressionVisitor visitor)
        {

            return exp.ParseContainsCall("");
        }


    }

    public class TrimExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            if (node.NodeType != ExpressionType.Call) return false;
            var method = (MethodCallExpression)exp;
            return (method.Method.Name == "Trim");
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            return exp.ParseTrimCall();
        }
    }
    public class ConvertExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            return (node.NodeType == ExpressionType.Convert);
 
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var conv = (UnaryExpression) exp;
            var mem = (MemberExpression)conv.Operand;
            return mem.GetValue().FormatValue();

        }
    }

    public class NegateExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            return (node.NodeType == ExpressionType.Not);

        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var conv = (UnaryExpression)exp;
            if (conv.Operand.NodeType == ExpressionType.Call)
            {
                var meth = (MethodCallExpression) conv.Operand;
                return meth.ParseContainsCall(" NOT");
            }
            return "";
        }
    }

    public class ClassValueVariableMemberExpressionResolver : IResolveExpressions
    {

        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            if (node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExp = (MemberExpression)node;
                return (memberExp.Expression != null
                        &&
                        (memberExp.Expression.NodeType == ExpressionType.Constant ||
                         memberExp.Expression.NodeType == ExpressionType.MemberAccess)
                       );
            }
            return false;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var member = (MemberExpression)visitor.Visit(exp);
            return string.Format(" {0} ", member.GetValue().FormatValue());
        }

 

    }


        public class ParameterMemberExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            if (node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExp = (MemberExpression)node;
                return memberExp.Expression != null 
                    && memberExp.Expression.NodeType == ExpressionType.Parameter;

            }
            return false;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var member = (MemberExpression)visitor.Visit(exp);
            return string.Format(" {0} ", member.GetAttribute());
        }
    }

    public class PropertyMemberExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            var node = visitor.Visit(exp);
            if (node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExp = (MemberExpression)node;
                return memberExp.Expression== null;
                 
            }
            return false;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var member = (MemberExpression)visitor.Visit(exp);
            return string.Format(" {0} ", get_value(member));
        }

        private string get_value(MemberExpression member)
        {
            if (member.Expression != null)
            {
                if (member.Expression.NodeType == ExpressionType.Constant)
                {
                    var c = (ConstantExpression)member.Expression;
                    //                    if(c.Type.Name.ToUpper().Contains("C__DISPLAYCLASS"))
                    //                    {
                    var parent = c.Value;
                    object obj = null;
                    var fieldName = member.Member.Name;
                    try
                    {
                        obj = parent.GetType().InvokeMember(fieldName, BindingFlags.GetField, null, parent,
                                                                 null);

                    }
                    catch (MissingFieldException)
                    {
                        var fld = parent.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

                        obj = fld.GetValue(parent);
                    }
                    return obj.FormatValue();


                }
            }
            var prop = (PropertyInfo)member.Member;
            return string.Format("'{0}'", prop.GetValue(member.Member, null));
        }
    }


    public class ConstantExpressionResolver : IResolveExpressions
    {
        public bool CanProcess(Expression exp, ISytelineExpressionVisitor visitor)
        {
            return exp.NodeType == ExpressionType.Constant;
        }

        public string ResolveExpression(Expression exp, Func<Expression, string> evaluateNode, Func<ExpressionType, string> evaluateOp, ISytelineExpressionVisitor visitor)
        {
            var c = (ConstantExpression) exp;
            return string.Format(" {0} ", c.Value.FormatValue());
        }
    }
}