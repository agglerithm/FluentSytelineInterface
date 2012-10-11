
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Dsl.Queries
{
    
    public class Sites
    {

        public const string IDO_NAME = "SL.SLSites";
        public const string Site = "Site";
        public const string SiteName = "SiteName";
        public const string Description = "Description";
    }

    public class SitesBuilder :
        IdoQueryBuilder<SitesBuilder,SitesFilterExpressionBuilder>
    {
        public SitesBuilder(IExpressionInterpreter ei) : base(Sites.IDO_NAME, ei) { }
        public SitesBuilder Site { get { AddProperty(Sites.Site); return this; } }
        public SitesBuilder SiteName { get { AddProperty(Sites.SiteName); return this; } }

        public SitesBuilder Description
        {
            get { AddProperty(Sites.Description); return this; }  
        }

        public SitesBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (SitesBuilder) base.WithChildren(builders);
        }

        public SitesBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (SitesBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class SitesFilterExpressionBuilder : FilterExpressionBuilder<SitesBuilder>
    {
        public FilterExpression<SitesBuilder, SitesFilterExpressionBuilder> Site
        {
            get { return new FilterExpression<SitesBuilder, SitesFilterExpressionBuilder>(_builder, Sites.Site); }
        }

        public FilterExpression<SitesBuilder, SitesFilterExpressionBuilder> SiteName
        {
            get { return new FilterExpression<SitesBuilder, SitesFilterExpressionBuilder>(_builder, Sites.SiteName); }
        }

        public FilterExpression<SitesBuilder, SitesFilterExpressionBuilder> Description
        {
            get { return new FilterExpression<SitesBuilder, SitesFilterExpressionBuilder>(_builder, Sites.Description); }
        }
    }
}