using System;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Linq; 

namespace FluentNHibernateClasses
{
    public interface ISytelineRepository
    {
        T[] Query<T>(Expression<Func<T, bool>> where, ISession session);
        T[] GetAll<T>(ISession session); 
    }

    public class SytelineRepository : ISytelineRepository
    {


        public T[] Query<T>(Expression<System.Func<T, bool>> where, ISession session)
        {
            using (session)
            {
                return session.Query<T>().Where(where).ToArray();
            }
        }

        public T[] GetAll<T>(ISession session)
        {
            using ( session )
            {
                return session.Query<T>().ToArray();
            }
        }
         

 
 

 
    }
}