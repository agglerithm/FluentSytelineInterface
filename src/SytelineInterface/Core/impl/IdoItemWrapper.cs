using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mongoose.IDO.Protocol;
using NCommon.Extensions;

namespace SytelineInterface.Core.impl
{

    public class IdoItemWrapper
    {
        private readonly Dictionary<string, object> _valueList;

        public IdoItemWrapper(Dictionary<string, object> valueList, ICollection linkedIdos, string idoName)
        {
            IdoName = idoName;
            _valueList = valueList;
            Records = get_entry_from(linkedIdos);
        }

        public object this[string ndx]
        {
          get{return
          GetValue(ndx );}  
        }

        public object GetValue (string key)
        {
            return _valueList[key];
        }

        public DataTable AddRecordTo(DataTable input)
        {
            if(input == null)
            {
                input = new DataTable();
                _valueList.Keys.ForEach(k => input.Columns.Add(k));
            }
            input.Rows.Add(_valueList.Values);
            return input;
        }

        public IEnumerable<IdoItemWrapper> Records { get; private set; }

        public string IdoName { get; private set; }


        private static IEnumerable<IdoItemWrapper> get_entry_from(ICollection linkedIdos)
        {
            var lst = new List<IdoItemWrapper>();

            foreach(LoadCollectionResponseData linkedIdo in linkedIdos)
            {
                lst.AddRange(linkedIdo.BuildChildResponseWrappers());
            }

            return lst;
        }

    }
}
