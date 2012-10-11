using FluentNHibernate;

namespace FluentNHibernateClasses
{
    public class SytelineSessionSource:  SessionSource
    {
        public SytelineSessionSource(string connectionKey)
            : base(FluentNHibernateConfigurationBuilderForSyteline
                       .GetFluentNHibernateConfiguration(connectionKey)) {
            ConnectionKey = connectionKey; }

        public string ConnectionKey { get; private set; }
    }
}