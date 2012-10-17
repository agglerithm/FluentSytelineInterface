namespace SytelineInterface.Dsl.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Mongoose.Core.Common;
    using Mongoose.IDO.Protocol;
    using SytelineInterface.Common.Extensions;

    public interface IIdoQueryBuilder
    {
        string GetProperties();
        string GetFilter();
        string GetIDOName();
        int GetMaxResults();
        IIdoQueryBuilder Add(string[] properties);
        IIdoQueryBuilder AddFilterBuilderFrom(IIdoQueryBuilder filter);
        IIdoQueryBuilder EnsureKey();
        IEnumerable<IIdoQueryBuilder> GetChildren(); 
        IIdoQueryBuilder WithChildren(params IIdoQueryBuilder[] builders);
        IIdoQueryBuilder LinkBy(string parentFieldName, string childFieldName);
        PropertyPair[] GetLinkFields();
        bool HasLinkFields { get;  } 
    }

    public class IdoQueryBuilder<PARAMBUILDER, FILTERBUILDER> : IIdoQueryBuilder
        where FILTERBUILDER : FilterExpressionBuilder<PARAMBUILDER>, new()
        where PARAMBUILDER : IdoQueryBuilder<PARAMBUILDER, FILTERBUILDER>
    {
        protected readonly IList<IFilterExpression> _filterExpressions 
            = new List<IFilterExpression>();
        private readonly IList<string> _properties = new List<string>();
        protected string _idoName;
        private int _maxResults = 0;
        private IList<IIdoQueryBuilder> _children = new List<IIdoQueryBuilder>();
        protected IList<PropertyPair> _linkFields = new List<PropertyPair>();
        private IExpressionInterpreter _expression;
        private string _currentJoiner = "";
        private string _filterString = "";

        public IdoQueryBuilder(string idoName, IExpressionInterpreter expression)
        {
            _idoName = idoName;
            _expression = expression;
        }

        protected void set_child(IIdoQueryBuilder builder)
        {
            _children.Add(builder);   
        }

        public IEnumerable<IIdoQueryBuilder> GetChildren()
        {
            return _children;
        }

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

        public PARAMBUILDER Where<TCriteria>(Expression<Func<TCriteria, bool>> exp) where TCriteria : IdoCriteria
        { 
            _filterString = _expression.GetSytelineWhereClause<TCriteria>(exp);
            return   this as PARAMBUILDER;
        }
 

        public PropertyPair[] GetLinkFields()
        {
            return _linkFields.ToArray();
        }

        public bool HasLinkFields
        {
            get { return _linkFields.Count() > 0; }
        }

        public IIdoQueryBuilder Add(string[] properties)
        {
            properties.ForEach(AddProperty);
            return this;
        }

 
        protected void AddProperty(string property)
        {
            if(_properties.Find(p => p==property) == null)
                _properties.Add(property);
        }

        public int PropertyCount
        {
            get { return _properties.Count; }
        }

        public IIdoQueryBuilder AddFilterBuilderFrom(IIdoQueryBuilder filter)
        {
            var builder = (IdoQueryBuilder<PARAMBUILDER, FILTERBUILDER>) filter;
            builder._filterExpressions.ForEach(e => _filterExpressions.Add(e)); 
            return this;
        }

        public IIdoQueryBuilder EnsureKey()
        {
            return Key;
        }

        private FILTERBUILDER set_joiner(string joiner)
        {
            
                _currentJoiner = joiner;
                var t = new FILTERBUILDER();
                
                t.SetBuilder(this as PARAMBUILDER);
                return t;
        }

 
 
 

 
        public string GetIDOName()
        {
            return _idoName;
        }

        public int GetMaxResults()
        {
            return _maxResults;
        }
        public PARAMBUILDER WithMaxResults(int maxResults)
        {
            _maxResults = maxResults;
            return (PARAMBUILDER)this;
        }

        public string GetProperties()
        {
            string propertiesString = string.Empty;
            const string delimeter = ", ";
            _properties.ToList().ForEach(prop => propertiesString += prop + delimeter);
            return propertiesString.TrimEnd(delimeter.ToCharArray());
        }

        public string GetFilter()
        {
            if(_filterExpressions.Count() > 0)
            {
                _filterString = string.Empty; 
                _filterExpressions.ToList().ForEach(ex => _filterString += ex.GetJoiner() + ex.ToExpressionString() ); 
            }
            return _filterString.TrimEnd(_currentJoiner.ToCharArray());
        }

        public PARAMBUILDER AddNestedFilter(IIdoQueryBuilder nestedBuilder)
        {
            var filter = new FilterExpressionCollection(nestedBuilder);
            AddFilterExpression(filter);
            return (PARAMBUILDER) this;
        }

        public void AddFilterExpression(IFilterExpression filterExpression)
        {
            filterExpression.SetJoiner(_currentJoiner);
            reset_joiner();
            _filterExpressions.Add(filterExpression);
        }

        private void reset_joiner()
        {
            _currentJoiner = "";
        }

        public PARAMBUILDER RowPointer { get { AddProperty(Core.IdoConstants.ROW_POINTER); return (PARAMBUILDER)this; } }

        public PARAMBUILDER Key { get {  AddProperty(Core.IdoConstants.KEY); return (PARAMBUILDER)this; } }

    }

    public class FilterExpressionCollection  : IFilterExpression  
    {
        private string _joiner;

        protected readonly IIdoQueryBuilder _builder;

        public FilterExpressionCollection(IIdoQueryBuilder builder)
        {
            _builder = builder;
        }

        public void SetJoiner(string joiner)
        {
            _joiner = joiner;
        }

        public string GetJoiner()
        {
            return _joiner;
        }

        public string ToExpressionString()
        {
            return _joiner + "(" + _builder.GetFilter() + ") ";
        }
    }

    public class FilterExpression<PARAMBUILDER, FILTERBUILDER> : IFilterExpression
        where PARAMBUILDER : IdoQueryBuilder<PARAMBUILDER, FILTERBUILDER> 
        where FILTERBUILDER : FilterExpressionBuilder<PARAMBUILDER>, new()
    {
        private readonly string _lhs;
        private readonly PARAMBUILDER _builder;
        private string _operand;
        private string _unary;
        private string _rhs;
        private string _joiner = ""; 

        public void SetJoiner(string joiner)
        {
            _joiner = joiner;
        }
        public string GetJoiner()
        {
            return _joiner;
        }
        public FilterExpression(PARAMBUILDER builder, string lhs)
        {
            _builder = builder;
            _lhs = lhs; 
        }

        #region IFilterExpression Members

        public string ToExpressionString()
        {
            return   string.Format("{3}{0}{1}{2}", _lhs, _operand, _rhs, _unary);
        }

        #endregion
 
 

 

    }

    public interface IFilterExpression
    {
        void SetJoiner(string joiner);
        string GetJoiner();
        string ToExpressionString();
    }

    public class FilterExpressionBuilder<PARAMBUILDER>  
    {
        protected PARAMBUILDER _builder; 

 
        public void SetBuilder(PARAMBUILDER builder)
        {
            _builder = builder;
        }
    }
}