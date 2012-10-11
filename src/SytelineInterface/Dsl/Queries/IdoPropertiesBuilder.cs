using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    
    public class IDOCollections : IdoConstants
    {
        public const string CollectionName = "CollectionName";
        public const string IDO_NAME = "IdoCollections";

    }

    
    public class IDOProperties : IdoConstants
    {
        public const string CollectionName = "CollectionName";
        public const string IDO_NAME = "IdoProperties";
        public const string PropertyName = "PropertyName";
    }

    public class IdoPropertiesBuilder :
        IdoQueryBuilder<IdoPropertiesBuilder, IdoPropertiesFilterExpressionBuilder>
    {
        public IdoPropertiesBuilder(IExpressionInterpreter ei) : base(IDOProperties.IDO_NAME, ei) { }
        public IdoPropertiesBuilder CollectionName { get { AddProperty(IDOProperties.CollectionName); return this; } }
        public IdoPropertiesBuilder PropertyName { get { AddProperty(IDOProperties.PropertyName); return this; } }

        public IdoPropertiesBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (IdoPropertiesBuilder) base.WithChildren(builders);
        }

        public IdoPropertiesBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (IdoPropertiesBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class IdoPropertiesFilterExpressionBuilder : FilterExpressionBuilder<IdoPropertiesBuilder>
    {
        public FilterExpression<IdoPropertiesBuilder, IdoPropertiesFilterExpressionBuilder> PropertyName
        {
            get { return new FilterExpression<IdoPropertiesBuilder, IdoPropertiesFilterExpressionBuilder>(_builder, IDOProperties.PropertyName); }
        }

        public FilterExpression<IdoPropertiesBuilder, IdoPropertiesFilterExpressionBuilder> CollectionName
        {
            get { return new FilterExpression<IdoPropertiesBuilder, IdoPropertiesFilterExpressionBuilder>(_builder, IDOProperties.CollectionName); }
        }
    }

    public class IdoCollectionsBuilder :
        IdoQueryBuilder<IdoCollectionsBuilder, IdoCollectionsFilterExpressionBuilder>
    {
        public IdoCollectionsBuilder(IExpressionInterpreter ei) : base(IDOCollections.IDO_NAME, ei) { }
        public IdoCollectionsBuilder CollectionName { get { AddProperty(IDOCollections.CollectionName); return this; } }

        public IIdoQueryBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            foreach (IIdoQueryBuilder builder in builders)
                set_child(builder);
            return this;
        }

        public IIdoQueryBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            _linkFields.Add(new PropertyPair(parentFieldName, childFieldName));
            return this;
        }
    }

    public class IdoCollectionsFilterExpressionBuilder : FilterExpressionBuilder<IdoCollectionsBuilder>
    {
  
        public FilterExpression<IdoCollectionsBuilder, IdoCollectionsFilterExpressionBuilder> CollectionName
        {
            get { return new FilterExpression<IdoCollectionsBuilder, IdoCollectionsFilterExpressionBuilder>(_builder, IDOCollections.CollectionName); }
        }
    }

    
    public class IDOMethods : IdoConstants
    {
        public const string CollectionName = "CollectionName";
        public const string IDO_NAME = "IdoMethods";
        public const string MethodName = "MethodName";
        public const string MethodDescription = "MethodDesc";
    }

    public class IdoMethodsBuilder :
        IdoQueryBuilder<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder>
    {
        public IdoMethodsBuilder(IExpressionInterpreter ei) : base(IDOMethods.IDO_NAME, ei) { }
        public IdoMethodsBuilder CollectionName { get { AddProperty(IDOMethods.CollectionName); return this; } }
        public IdoMethodsBuilder MethodName { get { AddProperty(IDOMethods.MethodName); return this; } }
        public IdoMethodsBuilder MethodDescription { get { AddProperty(IDOMethods.MethodDescription); return this; } }

        public IdoMethodsBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (IdoMethodsBuilder)base.WithChildren(builders);
        }

        public IdoMethodsBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (IdoMethodsBuilder)base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class IdoMethodsFilterExpressionBuilder : FilterExpressionBuilder<IdoMethodsBuilder>
    {
        public FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder> MethodName
        {
            get { return new FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder>(_builder, IDOMethods.MethodName); }
        }

        public FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder> MethodDescription
        {
            get { return new FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder>(_builder, IDOMethods.MethodDescription); }
        }

        public FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder> CollectionName
        {
            get { return new FilterExpression<IdoMethodsBuilder, IdoMethodsFilterExpressionBuilder>(_builder, IDOMethods.CollectionName); }
        }
    }

    
    public class IDOMethodParameters
    {
        public const string CollectionName = "CollectionName";
        public const string IDO_NAME = "IdoMethodParameters";
        public const string MethodName = "MethodName";
        public const string ParameterName = "ParameterName";
        public const string Sequence = "Sequence";
    }

    public class IdoMethodParametersBuilder:
        IdoQueryBuilder<IdoMethodParametersBuilder, IdoMethodParametersFilterExpressionBuilder>
    {
        public IdoMethodParametersBuilder(IExpressionInterpreter ei) : base(IDOMethodParameters.IDO_NAME, ei) { }
        public IdoMethodParametersBuilder CollectionName { get { AddProperty(IDOMethodParameters.CollectionName); return this; } }
        public IdoMethodParametersBuilder MethodName { get { AddProperty(IDOMethodParameters.MethodName); return this; } }
        public IdoMethodParametersBuilder ParameterName { get { AddProperty(IDOMethodParameters.ParameterName); return this; } }
        public IdoMethodParametersBuilder Sequence { get { AddProperty(IDOMethodParameters.Sequence); return this; } }

        public IdoMethodParametersBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (IdoMethodParametersBuilder)base.WithChildren(builders);
        }

        public IdoMethodParametersBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (IdoMethodParametersBuilder)base.LinkBy(parentFieldName, childFieldName);
        }
    
    }

    public class IdoMethodParametersFilterExpressionBuilder : FilterExpressionBuilder<IdoMethodParametersBuilder>
    {
        public FilterExpression<IdoMethodParametersBuilder, IdoMethodParametersFilterExpressionBuilder> MethodName
        {
            get { return new FilterExpression<IdoMethodParametersBuilder, IdoMethodParametersFilterExpressionBuilder>(_builder, IDOMethodParameters.MethodName); }
        }

 
        public FilterExpression<IdoMethodParametersBuilder, IdoMethodParametersFilterExpressionBuilder> CollectionName
        {
            get { return new FilterExpression<IdoMethodParametersBuilder, IdoMethodParametersFilterExpressionBuilder>(_builder, IDOMethodParameters.CollectionName); }
        }
    }
}