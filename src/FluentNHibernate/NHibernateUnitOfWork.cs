using System;
using FluentNHibernate;
using NHibernate;

namespace FluentNHibernateClasses
{
    public class NHibernateUnitOfWork : INHibernateUnitOfWork 
    { 
        private bool _isDisposed;
        private readonly ISessionSource _source;
        private bool _isInitialized;

        public NHibernateUnitOfWork(ISessionSource source)
        {
            _source = source;
        }

        public static INHibernateUnitOfWork Start(ISessionSource source)
        {
            var uow = new NHibernateUnitOfWork(source);
            uow.Start();
            return uow;
        }

        public void Start()
        {
            should_not_currently_be_disposed();

            CurrentSession = _source.CreateSession(); 

            _isInitialized = true;
             
        }
        public ISession CurrentSession { get; private set; }

        public void Commit()
        {
            should_not_currently_be_disposed();
            should_be_initialized_first();
             
        }

 

 

        private void should_not_currently_be_disposed()
        {
            if (_isDisposed) throw new ObjectDisposedException(GetType().Name);
        }

        private void should_be_initialized_first()
        {
            if (!_isInitialized) throw new InvalidOperationException("Must initialize (call Start()) on NHibernateUnitOfWork before committing or rolling back");
        }

        public void Dispose()
        {
            if (_isDisposed || !_isInitialized) return;

            _transaction.Dispose();
            CurrentSession.Dispose();

            _isDisposed = true;
        }
    }
}