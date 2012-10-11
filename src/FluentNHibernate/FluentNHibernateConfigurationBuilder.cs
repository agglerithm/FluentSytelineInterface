using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace FluentNHibernateClasses
{
    public static class FluentNHibernateConfigurationBuilder  
    {

        public static FluentConfiguration GetFluentNHibernateConfiguration(string connectionKey)
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration
                              .MsSql2005.ConnectionString(c => c.FromAppSetting(connectionKey)))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("FluentNHibernateClasses")))
                ; 

        }
    }
 
 
}