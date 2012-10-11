using System;
using NHibernate;

namespace FluentNHibernateClasses
{
    public interface INHibernateUnitOfWork : IDisposable
    {
        ISession CurrentSession { get; }
        void Start(); 
    }
}