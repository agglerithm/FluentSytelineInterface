using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl.Commands;

namespace SytelineInterface.Dsl.Queries
{
    public class IdoCommandBuilder : IIdoCommandBuilder
    {

        protected readonly IList<IIdoCommandBuilder> _children = new List<IIdoCommandBuilder>();
        private Dictionary<string, object> _dictionary = new Dictionary<string, object>();
        private IList<PropertyPair> _linkList = new List<PropertyPair>();
        private string _linkProperty;
        protected UpdateAction _updateAction;

        public IdoCommandBuilder(string idoName)
        {
            IdoName = idoName;
        }

//        public bool HasAggregates
//        {
//            get { return _children.Count > 0;  }
//        }

 

        public IIdoCommandBuilder [] GetChildren()
        {
            return _children.ToArray();
        }

        public string IdoName
        {
            get; protected set;
        }


        public IIdoCommandBuilder LinkProperty(string propName)
        {
            _linkProperty = propName;
            return this;
        }

        public Dictionary<string, object> Properties
        {
            get { return _dictionary; }
        }

        protected void AddValue(string name, object value)
        {
            if (value == null)
                value = IDONull.Value;
            if (_dictionary.ContainsKey(name))
                _dictionary[name] = value;
            else
                _dictionary.Add(name, value);
        }

//        public DataSet GetDataSet()
//        {
//            var dt = new DataTable(Guid.NewGuid().ToString());
//            _dictionary.Keys.ToList().ForEach(key => dt.Columns.Add(key, typeof(string)));
//            dt.Columns.Add("_ItemId", typeof (string));
//            dt.Rows.Add(_dictionary.Values.ToArray());
//
//            var ds = new DataSet(IdoName);
//            ds.Tables.Add(dt);
//            return ds;
//        }

        protected string[] get_property_names()
        {
            return _dictionary.Keys.ToArray();
        }



//        public DataTable UpdateTableFrom(DataTable tbl)
//        {
//            var val = "";
//            var dr = tbl.Rows[0];
//            _dictionary.Keys.ToList().ForEach(key =>
//                                                  {
//                                                      if (_dictionary.TryGetValue(key, out val))
//                                                          dr[key] = val;
//                                                  });
//            return tbl;
//        }
//        public DataSet UpdateDatasetFrom(DataSet ds)
//        {
//            var val = "";
//            var dt = ds.Tables[0];
//            var dr = dt.Rows[0];
//            _dictionary.Keys.ToList().ForEach(key =>
//                                                  {
//                                                      if(_dictionary.TryGetValue(key, out val))
//                                                          dr[key] = val;
//                                                  }); 
//            return ds;
//        }

//        public DataTable GetTable()
//        {            
//            var dt = new DataTable(Guid.NewGuid().ToString());
//            _dictionary.Keys.ToList().ForEach(key => dt.Columns.Add(key, typeof(string)));
//            dt.Columns.Add("_ItemId", typeof (string));
//            dt.Rows.Add(_dictionary.Values.ToArray());
//            return dt;
//        }


        private IIdoCommandBuilder SetLink(IIdoCommandBuilder child)
        {
            child.AddLink(new PropertyPair(_linkProperty, child.GetLinkProperty()));
            _children.Add(child);
            return this;
        }

 

        public IIdoCommandBuilder Action(UpdateAction action)
        {
            _updateAction = action;
            return this;
        }

        public void AddLink(PropertyPair link)
        {
            if(!_linkList.Contains(link))
            _linkList.Add(link);
        }

        public IIdoCommandBuilder WithChildren(params Func<IIdoCommandBuilder>[] builders)
        {
            foreach (Func<IIdoCommandBuilder> builder in builders) 
                SetLink(builder());
            return this;
        }

        public string GetLinkProperty()
        {
            return _linkProperty;
        }

        public string GetIDOName()
        {
            return IdoName;
        }

        public   UpdateAction GetUpdateAction()
        {
            return _updateAction;
        }

        public PropertyPair[] GetLinkBy()
        {
            return _linkList.ToArray();
        }

        public virtual IIdoQueryBuilder GetBuilder()
        {
            throw new NotImplementedException();
        }


        protected IdoCommandBuilder LinkBy(string parentField, string childField)
        {
            AddLink(new PropertyPair(parentField, childField));
            return this;
        }
    }
}