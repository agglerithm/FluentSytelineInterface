using System.Linq.Expressions;
using FluentNHibernate;
using NHibernate;

namespace SytelineInterface.Core.impl
{
    public interface ISytelineQuery
    {
        T[] Query<T>(Expression<System.Func<T, bool>> where, ISession source);
    }
}