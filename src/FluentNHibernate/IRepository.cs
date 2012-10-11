using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AFPST.Common.Services.Logging;
using FluentNHibernate;
using FluentNHibernate.Data;
using FluentNHibernate.Utils;
using NHibernate.Criterion;
using NHibernate.Linq; 

namespace FluentNHibernateClasses
{
    public interface IRepository
    {
        T Find<T>(long id) where T : Entity; 
        T[] Query<T>(Expression<Func<T, bool>> where);
        T FindBy<T, U>(Expression<Func<T, U>> expression, U search) where T : class;
        T FindBy<T>(Expression<Func<T, bool>> where);
        void Save<T>(T target) where T : Entity;
        T[] GetAll<T>();
        void DeleteAll<T>();
    }

    public class Repository : IRepository
    { 
        private readonly ISessionSource _source;


        public Repository(ISessionSource source)
        { 
            _source = source;
        }

        #region IRepository Members

 

        public T Find<T>(long id) where T : Entity
        {
            using(var uow = NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Get<T>(id);
            }
        }

        private static void Delete<T>(T target, INHibernateUnitOfWork uow)
        { 
             uow.CurrentSession.Delete(target);  
        }

        public T[] Query<T>(Expression<System.Func<T, bool>> where)
        {
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Linq<T>().Where(where).ToArray();
            }
        }

        public T[] GetAll<T>()
        {
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Linq<T>().ToArray();
            }
        }

        #endregion

        public void Save<T>(T target) where T : Entity
        {
//            var ent = (Entity) target;
//            var logMsg = ent.GetLogMessage();
//            Logger.Debug(this, "Saving: " + logMsg);
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                uow.CurrentSession.Flush();
                try
                {
                    try
                    {
                        uow.CurrentSession.SaveOrUpdate(target);
                        uow.Commit(); 
                    }
                    catch (NHibernate.NonUniqueObjectException)
                    {
                        merge(uow, target);
                        uow.Commit(); 
                    }

                }
                catch (NHibernate.TransactionException trxEx)
                {
                    Logger.Error(this,string.Format("Transaction failed saving: {0}"),trxEx); 
                }
                catch(NHibernate.Exceptions.GenericADOException adoEx)
                {
                    Logger.Error(this, string.Format("ADO failure saving: {0}"), adoEx);
                }
            }

        }

        private void merge<T>(INHibernateUnitOfWork uow, T target)
        {
            try
            {
                uow.CurrentSession.Merge(target);

            }
            catch (Exception)
            {
                uow.CurrentSession.Transaction.Rollback();
                throw;
            }
        }

        public T FindBy<T, U>(Expression<System.Func<T, U>> expression, U search) where T : class
        {
            string propertyName = ReflectionHelper.GetProperty(expression).Name;

            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                var criteria = uow.CurrentSession.CreateCriteria(typeof (T)).Add(Restrictions.Eq(propertyName, search));
                return criteria.UniqueResult() as T;
            }
        }

        public T FindBy<T>(Expression<System.Func<T, bool>> where)
        {
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                return uow.CurrentSession.Linq<T>().First(where);
            }
        }

        public void DeleteWhere<T>(Expression<System.Func<T, bool>> where)
        {
            var lst = Query(where);
            delete_list(lst.ToList());
        }

   
        public void DeleteAll<T>()
        {
            var lst = GetAll<T>().ToList();
            delete_list(lst);
        }

        private void delete_list<T>(List<T> lst)
        {
            using (var uow = NHibernateUnitOfWork.Start(_source))
            {
                try
                { 
                    lst.ForEach(obj => Delete(obj, uow));
                }
                catch (Exception)
                {
                    uow.Rollback();
                    throw;
                }

                uow.Commit();
            }
        }
    }
}