using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Core.impl
{

    public class UpdateCollectionResponseWrapper
    {
        private readonly IDOUpdateItems _items;
        private readonly IDictionary<DataRow, IEnumerable<UpdateCollectionResponseWrapper>> _children =
    new Dictionary<DataRow, IEnumerable<UpdateCollectionResponseWrapper>>();

        private readonly DataTable _tbl;

        public UpdateCollectionResponseWrapper(UpdateCollectionResponseData data)
        { 
            _tbl = build_table_from(data);
            _items = data.Items;
            _items.ForEach(add_item);
        }

        private static DataTable build_table_from(UpdateCollectionResponseData data)
        {
            return data.Items.Count == 0 ? get_empty_table(data.IDOName) : build_table(data.Items[0].Properties, data.IDOName);
        }

        private static DataTable get_empty_table(string idoname)
        {
            var tbl = new DataTable(idoname);
            tbl.Columns.Add(IdoConstants.KEY);
            tbl.Columns.Add("Modified");
            return tbl;
        }

        public string IDOName { get { return _tbl.TableName;  } }

        public IEnumerable<UpdateCollectionResponseWrapper> GetChildren(DataRow row)
        {
            return _children[row];
        }

        public DataRowCollection Rows
        {
            get { return _tbl.Rows; }
        }

        public IEnumerable<T> ReturnListOf<T>(Func<DataRow, IEnumerable<UpdateCollectionResponseWrapper>, T> mapping)
        {
            foreach(DataRow row in Rows)
            {
                yield return mapping(row,_children[row]);
            }
        }

        public Guid GetItemId(int rowIndex)
        {
            var idFromSyteline = _tbl.Rows[rowIndex]["_ItemId"].ToString();
            
            var split = idFromSyteline.Split('=');
            var idString = split[split.Length - 1].TrimEnd(']').TrimStart('[');

            return new Guid(idString);
        }
 

        private void add_item(IDOUpdateItem item)
        {
            var row = _tbl.Rows.Add(get_row(item.Properties, item.ItemID));
            _children.Add(row, get_entry_from(item.NestedUpdates));
        }

        private static object[] get_row(IDOUpdatePropertyList values, string itemId)
        {
            bool modified = get_is_modified(values);
            var vals = new List<string> { itemId, modified.ToString() };
            values.ForEach(v => vals.Add(v.Value));
            return vals.ToArray();
        }

        private static bool get_is_modified(IDOUpdatePropertyList values)
        {
            foreach(IDOUpdateProperty value in values)
                if(value.Modified) return true;
            return false;
        }

        private static IEnumerable<UpdateCollectionResponseWrapper> get_entry_from(IList<UpdateCollectionDataBase> children)
        {
            var lst = new List<UpdateCollectionResponseWrapper>();
            foreach (UpdateCollectionResponseData child in children)
            {
                lst.Add(new UpdateCollectionResponseWrapper(child));
            }
            return lst;
        }


        private static DataTable build_table(IDOUpdatePropertyList props, string idoname)
        {
            var tbl = get_empty_table(idoname);
            foreach (IDOUpdateProperty prop in props.ToList())
                tbl.Columns.Add(prop.Name);
            return tbl;

        }
    }
}
