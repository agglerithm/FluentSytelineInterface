using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;

namespace SytelineInterface.Core
{
    public static class SytelineExtensions
    {


        public static string ToSytelineDate(this DateTime dte)
        {
            return dte.ToString("yyyy/MM/dd");
        }

        public static DateTime FromSytelineDateTime(this string sytelineDate)
        {
            DateTime sytelineDateTime = DateTime.Now;
            try
            {
                sytelineDateTime = DateTime.ParseExact(sytelineDate, "yyyyMMdd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return sytelineDateTime;
        }

        public static DateTime FromSytelineDateTime(this object sytelineDate)
        {
            return sytelineDate.ToString().FromSytelineDateTime();
        }

        public static object[] GetLinkedIdoValues(this IDOItem idoItem)
        {
            var vals = new List<string> { idoItem.ItemID };
            idoItem.PropertyValues.Where(v => v.Value != idoItem.ItemID).ToList().ForEach(v => vals.Add(v.Value));
            return vals.ToArray();
        }

        public static IEnumerable<IdoItemWrapper> BuildChildResponseWrappers(this LoadCollectionResponseData linkedIdo)
        {
            foreach (var idoItem in linkedIdo.Items)
            {
                var valueList = new Dictionary<string, object>();

                var values = idoItem.GetLinkedIdoValues();

                var keys = new List<string> {IdoConstants.KEY};
                    
                  keys.AddRange(linkedIdo.PropertyList.List.Where(s => s != IdoConstants.KEY));  

                if(keys.Count != values.Length)
                    throw new Exception("Property names and values are incompatible!");
                for (var i = 0; i < keys.Count; i++)
                {
                    valueList.Add(keys[i], values[i]);
                }

                yield return new IdoItemWrapper(valueList, idoItem.NestedResponses, linkedIdo.IDOName);
            }
        }

        public static bool IsBinaryExpression(this Expression exp)
        {
            return exp.NodeType == ExpressionType.And
                   || exp.NodeType == ExpressionType.AndAlso
                   || exp.NodeType == ExpressionType.Or
                   || exp.NodeType == ExpressionType.OrElse
                   || exp.NodeType == ExpressionType.Equal
                   || exp.NodeType == ExpressionType.GreaterThanOrEqual
                   || exp.NodeType == ExpressionType.GreaterThan
                   || exp.NodeType == ExpressionType.NotEqual
                   || exp.NodeType == ExpressionType.LessThan
                   || exp.NodeType == ExpressionType.LessThanOrEqual
                   || exp.NodeType == ExpressionType.ExclusiveOr;
        }


        public static string GetAttribute(this MemberExpression member)
        {
            var attrs = member.Member.GetCustomAttributes(typeof (FieldName), false);
            if (attrs.Length == 0)
            {
                throw new InvalidExpressionException(
                    "Parameters for the SytelineInterface expression resolver must have the 'FieldName' attribute!");
            }
            return attrs[0].ToString();

        }
        
        public static string GetParam(ParameterExpression parm)
        {
             Expression c;
            if (parm.CanReduce)
                c = parm.Reduce();
            else
            {
                c = parm;
            }
            return "";
        }

        public static string GetProperty(MemberExpression member)
        {
            var c = member;
            //                    if(c.Type.Name.ToUpper().Contains("C__DISPLAYCLASS"))
            //                    {
            var parent = c.Expression;
            object obj = null;
            var fieldName = member.Member.Name;

            obj = parent.Type.InvokeMember(fieldName, BindingFlags.GetProperty, null, parent,
                                                     null);


            return obj.ToString();
        }
        
        public static object GetValue(this   object parent, string fieldName)
        {
            object obj = null;
            try
            {
                obj = parent.GetType().InvokeMember(fieldName, BindingFlags.GetField | BindingFlags.GetProperty, null, parent,
                                                    null);

            }
            catch (MissingFieldException)
            {
                var fld = parent.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

                obj = fld.GetValue(parent);
            }
            catch (MissingMethodException)
            {
                var fld = parent.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);

                obj = fld.GetValue(parent);
            }
            return  obj;
        }

        public static string FormatValue(this object obj)
        {
            if (obj == null) return " NULL ";
            return obj.GetType() == typeof(string) || obj.GetType() == typeof(DateTime)
                       ? string.Format("'{0}'", obj)
                       : obj.ToString();
        }

        public static object GetValue(this MemberExpression member)
        {
            if (member.Expression.NodeType == ExpressionType.Parameter)
                return GetProperty(member);

            var parentMember = member.GetNextLevelUpObject();
            var parent = parentMember.parent;
            var fieldName = parentMember.memberName;
            return parent.GetValue(fieldName);

        }

        public static string ParseTrimCall(this Expression exp)
        {
            var member = (MethodCallExpression)exp; 
            var attr = (MemberExpression)member.Object;
            return  getTrimValue(attr);
             
        }

        private static string getTrimValue(MemberExpression attr)
        {
            return attr.Expression.NodeType == ExpressionType.Parameter ? string.Format(" ltrim(rtrim({0})) ", GetAttribute(attr)) : string.Format(" ltrim(rtrim('{0}')) ", GetValue(attr));
        }

        public static string ParseContainsCall(this Expression exp, string negation)
        {
            var member = (MethodCallExpression)exp;
            var argMember = (MemberExpression)member.Arguments[0];
            var attr = (MemberExpression)member.Object;
            var val = argMember.GetValue();
            var parm = attr.GetAttribute();

            return string.Format(" {0}{2} LIKE '%{1}%' ", parm, val, negation);
        }

        public static Member GetNextLevelUpObject(this MemberExpression member)
        {
            var stack = addLevels(member, new Stack<Member>());
            return stack.Peek();
            
        }

        private static Stack<Member> addLevels(MemberExpression member, Stack<Member> stack)
        { 
            if(member.Expression.NodeType == ExpressionType.Constant)
            {
                stack.Push(new Member(((ConstantExpression)member.Expression).Value, member.Member));
                return stack;
            }

            stack = addLevels((MemberExpression) member.Expression, stack);
            var p = stack.Peek();

            object obj = null;
            try
            {
                    obj = p.parent.GetType().InvokeMember(p.memberName, BindingFlags.GetField | BindingFlags.GetProperty, null, p.parent,
                                                         null);
            }
            catch (MissingFieldException)
            {
                var fld = p.parent.GetType().GetField(p.memberName, BindingFlags.NonPublic | BindingFlags.Instance);

                obj = fld.GetValue(p.parent);
            }
            catch (MissingMethodException)
            {
                var fld = p.parent.GetType().GetField(p.memberName, BindingFlags.NonPublic | BindingFlags.Instance);

                obj = fld.GetValue(p.parent);
            }
            stack.Push(new Member(obj, member.Member));
            return stack;
        }

    }
}