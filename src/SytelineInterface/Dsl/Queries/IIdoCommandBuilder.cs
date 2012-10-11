using System;
using System.Collections.Generic;
using System.Data;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Dsl.Queries
{
    public interface IIdoCommandBuilder
    {
        //DataSet GetDataSet();
        //bool HasAggregates { get; }
        IIdoCommandBuilder LinkProperty(string propName);
        Dictionary<string, object> Properties { get; }
        IIdoCommandBuilder[] GetChildren();
        string IdoName { get;}
        //DataSet UpdateDatasetFrom(DataSet ds);
        //DataTable GetTable();
        //DataTable UpdateTableFrom(DataTable tbl); 
        PropertyPair[] GetLinkBy();
        IIdoQueryBuilder GetBuilder();
        //IIdoCommandBuilder SetLink(IIdoCommandBuilder builder); 
        string GetLinkProperty();
        string GetIDOName();
        UpdateAction GetUpdateAction();
        IIdoCommandBuilder Action(UpdateAction action);
        void AddLink(PropertyPair pair);
        IIdoCommandBuilder WithChildren(params Func<IIdoCommandBuilder>[] builders);
    }
}